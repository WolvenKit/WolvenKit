using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Save;

/// <summary>
/// Read/write access to the patch 2.5 stats layout (<see cref="gameStatsStateMapStructure.ValuesOptimized"/>).
/// <para>
/// In 2.5 an entity's record ID, inactive stats and modifiers are stored as indices into tables shared by all
/// entities. Modifiers live in <c>sharedDataBuffer</c>, an arena of serialized modifier entries (same format as
/// the pre-2.5 <c>modifiersBuffer</c>), addressed through <c>sharedBufferSlices</c>
/// (<c>offset</c>, <c>combined</c> = byte length | <see cref="ForcedSliceFlag"/>). A flagged slice holds what used to be
/// <c>forcedModifiersBuffer</c> (e.g. the player's attributes, skills and level), an unflagged one <c>modifiersBuffer</c>.
/// Identical slices are shared between entities.
/// </para>
/// <para>
/// <see cref="Get"/> materializes an entity as a pre-2.5 <see cref="gameSavedStatsData"/> that can be edited as before;
/// <see cref="Commit"/> writes changed entities back. Shared slices are never modified in place: a changed modifier list
/// reuses an identical existing slice or is appended to the arena (copy-on-write). Unchanged entities are left untouched,
/// so a save that was not edited is written back byte for byte.
/// </para>
/// </summary>
public class OptimizedStatsStore
{
    public const uint ForcedSliceFlag = 0x40000000;
    public const uint SliceSizeMask = 0x3FFFFFFF;
    private const int ArenaGrowth = 0x8000;

    private readonly gameStatsStateMapStructure _map;
    private readonly Dictionary<(gameStatIDType, ulong), Materialized> _materialized = new();

    /// <summary>State of one modifier list (normal or forced) of a materialized entity.</summary>
    private sealed class ModifierList
    {
        public required uint Flag { get; init; }
        public byte[] Baseline { get; set; } = Array.Empty<byte>();

        /// <summary>False if the original slices could not be decoded; the list is then left untouched.</summary>
        public bool Editable { get; set; } = true;
    }

    private sealed class Materialized
    {
        public required gameSavedStatsData Data { get; init; }

        /// <summary>The optimized entry, or null for an entity created with <see cref="Create"/>.</summary>
        public gameSavedStatsDataOptimized? Source { get; set; }
        public required gameStatIDType IdType { get; init; }
        public required ulong EntityHash { get; init; }

        public ModifierList Normal { get; } = new() { Flag = 0 };
        public ModifierList Forced { get; } = new() { Flag = ForcedSliceFlag };
        public List<gamedataStatType> BaselineInactive { get; set; } = new();
        public TweakDBID BaselineRecordId { get; set; }
        public uint BaselineSeed { get; set; }
    }

    public OptimizedStatsStore(gameStatsStateMapStructure map) => _map = map;

    /// <summary>True when the stats container uses the patch 2.5 layout.</summary>
    public bool IsOptimized => _map.ValuesOptimized.Count > 0;

    public gameSavedStatsData? Get(gameStatIDType idType, ulong entityHash)
    {
        if (_materialized.TryGetValue((idType, entityHash), out var existing))
        {
            return existing.Data;
        }

        var source = _map.ValuesOptimized.FirstOrDefault(x => x.EntityHash == entityHash && x.IdType == idType);
        if (source == null)
        {
            return null;
        }

        var data = new gameSavedStatsData
        {
            StatModifiers = source.StatModifiers,
            Seed = source.Seed,
            RecordID = source.RecordIDIndex < _map.SharedRecordId.Count ? _map.SharedRecordId[source.RecordIDIndex] : default,
            ModifiersBuffer = new DataBuffer { Data = new ModifiersBuffer() },
            ForcedModifiersBuffer = new DataBuffer { Data = new ModifiersBuffer() }
        };
        foreach (var index in source.InactiveStatsIndices)
        {
            data.InactiveStats.Add(_map.SharedInactiveStats[index]);
        }

        var entry = new Materialized { Data = data, Source = source, IdType = idType, EntityHash = entityHash };

        var arena = GetArena();
        foreach (var sliceIndex in source.BufferSliceIndices)
        {
            var slice = _map.SharedBufferSlices[sliceIndex];
            var forced = (slice.Combined & ForcedSliceFlag) != 0;
            var list = forced ? entry.Forced : entry.Normal;
            var buffer = forced ? data.ForcedModifiersBuffer : data.ModifiersBuffer;

            var parsed = ReadModifiers(arena.AsSpan((int)(uint)slice.Offset, (int)(slice.Combined & SliceSizeMask)).ToArray());
            if (!parsed.IsParsed || ((ModifiersBuffer)buffer.Data!).Entries.Count > 0)
            {
                // Undecodable, or a second slice of the same kind (not seen in saves): leave this list as it is
                list.Editable = false;
                continue;
            }
            buffer.Data = parsed;
        }

        foreach (var (list, buffer) in new[] { (entry.Normal, data.ModifiersBuffer), (entry.Forced, data.ForcedModifiersBuffer) })
        {
            if (list.Editable)
            {
                list.Baseline = WriteModifiers((ModifiersBuffer)buffer.Data!);
            }
        }
        entry.BaselineInactive = data.InactiveStats.Select(x => (gamedataStatType)x).ToList();
        entry.BaselineRecordId = data.RecordID;
        entry.BaselineSeed = data.Seed;

        _materialized.Add((idType, entityHash), entry);
        return data;
    }

    /// <summary>Creates stats for an entity that has none. The entry is added to the save on <see cref="Commit"/>.</summary>
    public gameSavedStatsData Create(gameStatIDType idType, ulong entityHash, gameSavedStatsData data)
    {
        if (Get(idType, entityHash) != null)
        {
            throw new InvalidOperationException($"Stats for {idType} {entityHash} already exist");
        }

        data.ModifiersBuffer ??= new DataBuffer();
        data.ModifiersBuffer.Data ??= new ModifiersBuffer();
        data.ForcedModifiersBuffer ??= new DataBuffer();
        data.ForcedModifiersBuffer.Data ??= new ModifiersBuffer();
        _materialized.Add((idType, entityHash), new Materialized
        {
            Data = data,
            IdType = idType,
            EntityHash = entityHash
        });
        return data;
    }

    /// <summary>Returns whether any materialized entity has changes that <see cref="Commit"/> would write.</summary>
    public bool HasChanges => _materialized.Values.Any(x => x.Source == null || IsDirty(x));

    /// <summary>Writes all changed entities back into the optimized tables.</summary>
    public void Commit()
    {
        foreach (var entry in _materialized.Values)
        {
            if (entry.Source != null && !IsDirty(entry))
            {
                continue;
            }

            var isNew = entry.Source == null;
            var target = entry.Source;
            if (target == null)
            {
                target = new gameSavedStatsDataOptimized
                {
                    EntityHash = entry.EntityHash,
                    IdType = entry.IdType,
                    StatModifiers = entry.Data.StatModifiers
                };
                _map.ValuesOptimized.Add(target);
                entry.Source = target;
            }

            var data = entry.Data;

            if (isNew || entry.BaselineSeed != data.Seed)
            {
                target.Seed = data.Seed;
            }

            if (isNew || !entry.BaselineRecordId.Equals(data.RecordID))
            {
                target.RecordIDIndex = (ushort)IndexOfOrAdd(_map.SharedRecordId, data.RecordID);
            }

            var inactive = data.InactiveStats.Select(x => (gamedataStatType)x).ToList();
            if (isNew || !inactive.SequenceEqual(entry.BaselineInactive))
            {
                target.InactiveStatsIndices.Clear();
                foreach (var stat in inactive)
                {
                    target.InactiveStatsIndices.Add((ushort)IndexOfOrAdd(_map.SharedInactiveStats, (CEnum<gamedataStatType>)stat));
                }
            }

            CommitList(target, entry.Normal, data.ModifiersBuffer);
            CommitList(target, entry.Forced, data.ForcedModifiersBuffer);

            entry.BaselineInactive = inactive;
            entry.BaselineRecordId = data.RecordID;
            entry.BaselineSeed = data.Seed;
        }
    }

    private void CommitList(gameSavedStatsDataOptimized target, ModifierList list, DataBuffer buffer)
    {
        if (!list.Editable || buffer.Data is not ModifiersBuffer modifiers)
        {
            return;
        }

        var bytes = WriteModifiers(modifiers);
        if (bytes.AsSpan().SequenceEqual(list.Baseline))
        {
            return;
        }

        // Replace this kind's slice in place to keep the original order; append if the entity had none.
        var position = -1;
        for (var i = 0; i < target.BufferSliceIndices.Count; i++)
        {
            if ((_map.SharedBufferSlices[target.BufferSliceIndices[i]].Combined & ForcedSliceFlag) == list.Flag)
            {
                position = i;
                break;
            }
        }

        if (bytes.Length == 0)
        {
            if (position >= 0)
            {
                target.BufferSliceIndices.RemoveAt(position);
            }
        }
        else
        {
            var sliceIndex = (ushort)FindOrAppendSlice(bytes, list.Flag);
            if (position >= 0)
            {
                target.BufferSliceIndices[position] = sliceIndex;
            }
            else
            {
                target.BufferSliceIndices.Add(sliceIndex);
            }
        }

        list.Baseline = bytes;
    }

    private bool IsDirty(Materialized entry)
    {
        var data = entry.Data;
        if (entry.BaselineSeed != data.Seed || !entry.BaselineRecordId.Equals(data.RecordID))
        {
            return true;
        }
        if (!data.InactiveStats.Select(x => (gamedataStatType)x).SequenceEqual(entry.BaselineInactive))
        {
            return true;
        }
        return IsListDirty(entry.Normal, data.ModifiersBuffer) || IsListDirty(entry.Forced, data.ForcedModifiersBuffer);
    }

    private static bool IsListDirty(ModifierList list, DataBuffer buffer) =>
        list.Editable && buffer.Data is ModifiersBuffer modifiers && !WriteModifiers(modifiers).AsSpan().SequenceEqual(list.Baseline);

    private static int IndexOfOrAdd<T>(CArray<T> array, T value) where T : IRedType
    {
        for (var i = 0; i < array.Count; i++)
        {
            if (Equals(array[i], value))
            {
                return i;
            }
        }
        array.Add(value);
        return array.Count - 1;
    }

    // sharedDataBuffer is only set for maps read from a save
    private byte[] GetArena() => _map.SharedDataBuffer?.Buffer.GetBytes() ?? Array.Empty<byte>();

    private int FindOrAppendSlice(byte[] bytes, uint flag)
    {
        var arena = GetArena();

        // Reuse an identical slice (the game deduplicates them as well)
        for (var i = 0; i < _map.SharedBufferSlices.Count; i++)
        {
            var slice = _map.SharedBufferSlices[i];
            if ((slice.Combined & SliceSizeMask) == bytes.Length && (slice.Combined & ForcedSliceFlag) == flag &&
                arena.AsSpan((int)(uint)slice.Offset, bytes.Length).SequenceEqual(bytes))
            {
                return i;
            }
        }

        var used = _map.SharedBufferSlices.Count == 0 ? 0 : _map.SharedBufferSlices.Max(x => (int)((uint)x.Offset + (x.Combined & SliceSizeMask)));
        if (used + bytes.Length > arena.Length)
        {
            var newLength = (used + bytes.Length + ArenaGrowth - 1) / ArenaGrowth * ArenaGrowth;
            Array.Resize(ref arena, newLength);
        }
        else
        {
            arena = (byte[])arena.Clone();
        }
        bytes.CopyTo(arena, used);
        _map.SharedDataBuffer ??= new DataBuffer();
        _map.SharedDataBuffer.Buffer.SetBytes(arena);

        _map.SharedBufferSlices.Add(new gameBufferSlice { Offset = (uint)used, Combined = (uint)bytes.Length | flag });
        return _map.SharedBufferSlices.Count - 1;
    }

    private static ModifiersBuffer ReadModifiers(byte[] bytes)
    {
        var buffer = new RedBuffer();
        using var reader = new ModifiersBufferReader(new MemoryStream(bytes));
        reader.ReadBuffer(buffer);
        return (ModifiersBuffer)buffer.Data!;
    }

    private static byte[] WriteModifiers(ModifiersBuffer buffer)
    {
        using var ms = new MemoryStream();
        using (var writer = new ModifiersBufferWriter(ms))
        {
            writer.WriteBuffer(buffer);
        }
        return ms.ToArray();
    }
}

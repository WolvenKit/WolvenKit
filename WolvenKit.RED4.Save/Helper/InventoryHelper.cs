using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class InventoryHelper
{
    [Flags]
    public enum ItemFlag : byte
    {
        IsQuestItem = 1,
        IsNotUnequippable = 2
    }

    public interface IItemData
    {
        
    }

    public class SubInventory
    {
        public ulong InventoryId { get; set; }
        public List<ItemData> Items { get; set; } = new();
    }

    // TODO [WolvenKit.RED4.Save]: Probably gameItemID, will check later
    public class HeaderThing : IEquatable<HeaderThing>
    {
        public uint Seed { get; set; }
        public byte UnknownByte1 { get; set; }
        public ushort UnknownBytes2 { get; set; }
        public byte UnknownByte3 { get; set; }

        public byte Kind =>
            UnknownByte1 switch
            {
                1 => 2,
                2 => 1,
                3 => 0,
                _ => (byte)(Seed != 2 ? 2 : 1)
            };

        public bool Equals(HeaderThing? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Seed == other.Seed && UnknownByte1 == other.UnknownByte1 && UnknownBytes2 == other.UnknownBytes2 && UnknownByte3 == other.UnknownByte3;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((HeaderThing)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int)Seed;
                hashCode = (hashCode * 397) ^ UnknownByte1.GetHashCode();
                hashCode = (hashCode * 397) ^ UnknownBytes2.GetHashCode();
                hashCode = (hashCode * 397) ^ UnknownByte3.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(HeaderThing? left, HeaderThing? right) => Equals(left, right);

        public static bool operator !=(HeaderThing? left, HeaderThing? right) => !Equals(left, right);
    }

    public class NextItemEntry : IEquatable<NextItemEntry>
    {
        public TweakDBID ItemTdbId { get; set; }
        public HeaderThing Header { get; set; }

        public bool Equals(NextItemEntry? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return ItemTdbId.Equals(other.ItemTdbId) && Header.Equals(other.Header);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((NextItemEntry)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (ItemTdbId.GetHashCode() * 397) ^ Header.GetHashCode();
            }
        }

        public static bool operator ==(NextItemEntry? left, NextItemEntry? right) => Equals(left, right);

        public static bool operator !=(NextItemEntry? left, NextItemEntry? right) => !Equals(left, right);
    }

    public class ItemData : NextItemEntry, INodeData
    {
        public ItemFlag Flags { get; set; }
        public uint CreationTime { get; set; }
        public IItemData Data { get; set; }
    }

    public class SimpleItemData : IItemData
    {
        public uint Quantity { get; set; }

        public override string ToString()
        {
            return $"{Quantity}x";
        }
    }

    public class ModableItemData : IItemData
    {
        public TweakDBID TdbId1 { get; set; }
        public uint Unknown2 { get; set; }
        public float Unknown3 { get; set; }
        public ItemModData RootNode { get; set; }
    }

    public class ItemModData
    {
        public TweakDBID ItemTdbId { get; set; }
        public HeaderThing Header { get; set; }
        public string UnknownString { get; set; }
        public TweakDBID AttachmentSlotTdbId { get; set; }
        public List<ItemModData> Children { get; set; } = new();
        public uint Unknown2 { get; set; }
        public TweakDBID TdbId2 { get; set; }
        public uint Unknown3 { get; set; }
        public float Unknown4 { get; set; }
    }

    public class ModableItemWithQuantityData : ModableItemData
    {
        public uint Quantity { get; set; }
    }

    public static HeaderThing ReadHeaderThing(BinaryReader reader) =>
        new()
        {
            Seed = reader.ReadUInt32(),
            UnknownByte1 = reader.ReadByte(),
            UnknownBytes2 = reader.ReadUInt16(),
            UnknownByte3 = reader.ReadByte()
        };

    private static void WriteHeaderThing(BinaryWriter writer, HeaderThing itemHeader)
    {
        writer.Write(itemHeader.Seed);
        writer.Write(itemHeader.UnknownByte1);
        writer.Write(itemHeader.UnknownBytes2);
        writer.Write(itemHeader.UnknownByte3);
    }

    public static NextItemEntry ReadNextItemEntry(byte[] bytes)
    {
        using var ms = new MemoryStream(bytes);
        using var br = new BinaryReader(ms);

        return ReadNextItemEntry(br);
    }

    public static NextItemEntry ReadNextItemEntry(BinaryReader reader) =>
        new() {
            ItemTdbId = reader.ReadUInt64(),
            Header = ReadHeaderThing(reader)
        };

    public static void WriteNextItemEntry(NodeWriter writer, NextItemEntry item)
    {
        writer.Write((ulong)item.ItemTdbId);
        WriteHeaderThing(writer, item.Header);
    }

    public static byte[] GetNextItemEntryBytes(NextItemEntry item)
    {
        using var ms = new MemoryStream();
        using var writer = new BinaryWriter(ms);

        writer.Write((ulong)item.ItemTdbId);
        WriteHeaderThing(writer, item.Header);

        return ms.ToArray();
    }

    public static ItemData ReadItemData(BinaryReader reader)
    {
        var result = new ItemData();

        result.ItemTdbId = reader.ReadUInt64();
        result.Header = ReadHeaderThing(reader);
        result.Flags = (ItemFlag)reader.ReadByte();
        result.CreationTime = reader.ReadUInt32();

        switch (result.Header.Kind)
        {
            case 0:
                result.Data = ReadModableItemWithQuantityData(reader);
                break;
            case 1:
                result.Data = ReadSimpleItemData(reader);
                break;
            case 2:
                result.Data = ReadModableItemData(reader);
                break;
        }

        return result;
    }

    public static void WriteItemData(BinaryWriter writer, ItemData item)
    {
        writer.Write((ulong)item.ItemTdbId);
        WriteHeaderThing(writer, item.Header);
        writer.Write((byte)item.Flags);
        writer.Write(item.CreationTime);

        if (item.Data is ModableItemWithQuantityData modq)
        {
            WriteModableItemWithQuantityData(writer, modq);
        }
        else if (item.Data is ModableItemData mod)
        {
            WriteModableItemData(writer, mod);
        }
        else if (item.Data is SimpleItemData simp)
        {
            WriteSimpleItemData(writer, simp);
        }
    }

    public static SimpleItemData ReadSimpleItemData(BinaryReader reader) =>
        new()
        {
            Quantity = reader.ReadUInt32()
        };

    private static void WriteSimpleItemData(BinaryWriter writer, SimpleItemData simp)
    {
        writer.Write(simp.Quantity);
    }

    public static ModableItemWithQuantityData ReadModableItemWithQuantityData(BinaryReader reader)
    {
        var result = new ModableItemWithQuantityData();

        result.Quantity = reader.ReadUInt32();
        var modItem = ReadModableItemData(reader);
        result.TdbId1 = modItem.TdbId1;
        result.Unknown2 = modItem.Unknown2;
        result.Unknown3 = modItem.Unknown3;
        result.RootNode = modItem.RootNode;

        return result;
    }

    private static void WriteModableItemWithQuantityData(BinaryWriter writer, ModableItemWithQuantityData modq)
    {
        writer.Write(modq.Quantity);
        writer.Write((ulong)modq.TdbId1);
        writer.Write(modq.Unknown2);
        writer.Write(modq.Unknown3);
        WriteKind2DataNode(writer, modq.RootNode);
    }

    public static ModableItemData ReadModableItemData(BinaryReader reader)
    {
        var result = new ModableItemData();

        result.TdbId1 = reader.ReadUInt64();
        result.Unknown2 = reader.ReadUInt32();
        result.Unknown3 = reader.ReadSingle();
        result.RootNode = ReadKind2DataNode(reader);

        return result;
    }

    private static void WriteModableItemData(BinaryWriter writer, ModableItemData mod)
    {
        writer.Write((ulong)mod.TdbId1);
        writer.Write(mod.Unknown2);
        writer.Write(mod.Unknown3);
        WriteKind2DataNode(writer, mod.RootNode);
    }

    public static ItemModData ReadKind2DataNode(BinaryReader reader)
    {
        var result = new ItemModData();

        result.ItemTdbId = reader.ReadUInt64();
        result.Header = ReadHeaderThing(reader);
        result.UnknownString = reader.ReadLengthPrefixedString();
        result.AttachmentSlotTdbId = reader.ReadUInt64();
        var count = reader.ReadVLQInt32();
        for (var i = 0; i < count; ++i)
        {
            result.Children.Add(ReadKind2DataNode(reader));
        }

        result.Unknown2 = reader.ReadUInt32();
        result.TdbId2 = reader.ReadUInt64();
        result.Unknown3 = reader.ReadUInt32();
        result.Unknown4 = reader.ReadSingle();

        return result;
    }

    private static void WriteKind2DataNode(BinaryWriter writer, ItemModData mod)
    {
        writer.Write((ulong)mod.ItemTdbId);
        WriteHeaderThing(writer, mod.Header);
        writer.WriteLengthPrefixedString(mod.UnknownString);
        writer.Write((ulong)mod.AttachmentSlotTdbId);
        writer.WriteVLQInt32(mod.Children.Count);
        foreach (var child in mod.Children)
        {
            WriteKind2DataNode(writer, child);
        }
        writer.Write(mod.Unknown2);
        writer.Write((ulong)mod.TdbId2);
        writer.Write(mod.Unknown3);
        writer.Write(mod.Unknown4);
    }

    public static ulong GetItemIdHash(TweakDBID tweakDbId, uint seed, ushort unk1 = 0)
    {
        var c = 0xC6A4A7935BD1E995;

        ulong tmp;

        if (unk1 == 0)
        {
            tmp = seed * c;
            tmp = (tmp >> 0x2F) ^ tmp;
        }
        else
        {
            tmp = unk1 * c;
            tmp = ((((tmp >> 0x2F) ^ tmp) * c) ^ seed) * 0x35A98F4D286A90B9;
            tmp = (tmp >> 0x2F) ^ tmp;
        }

        return ((tmp * c) ^ tweakDbId) * c;
    }
}

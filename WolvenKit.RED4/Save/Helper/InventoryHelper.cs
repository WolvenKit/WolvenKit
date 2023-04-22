using WolvenKit.Core.Extensions;
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

    public class gameItemIdWrapper : IEquatable<gameItemIdWrapper>
    {
        public gameItemID ItemId { get; set; }
        public Enums.gamedataItemStructure ItemStructure { get; set; }

        public byte Kind =>
            (byte)ItemStructure switch
            {
                1 => 2,
                2 => 1,
                3 => 0,
                _ => (byte)(ItemId.RngSeed != 2 ? 2 : 1)
            };

        public bool Equals(gameItemIdWrapper? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return ItemId.Equals(other.ItemId) && ItemStructure == other.ItemStructure;
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

            return Equals((gameItemIdWrapper)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = ItemId.GetHashCode();
                hashCode = (hashCode * 397) ^ ItemStructure.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(gameItemIdWrapper? left, gameItemIdWrapper? right) => Equals(left, right);

        public static bool operator !=(gameItemIdWrapper? left, gameItemIdWrapper? right) => !Equals(left, right);
    }

    public class ModHeaderThing : IEquatable<ModHeaderThing>
    {
        public TweakDBID LootItemId { get; set; }
        public uint Unknown2 { get; set; }
        public float Unknown3 { get; set; }

        public bool Equals(ModHeaderThing? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return LootItemId.Equals(other.LootItemId) && Unknown2 == other.Unknown2 && Unknown3.Equals(other.Unknown3);
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

            return Equals((ModHeaderThing)obj);
        }

        public override int GetHashCode() => HashCode.Combine(LootItemId, Unknown2, Unknown3);
    }

    public class ItemData : INodeData
    {
        public gameItemIdWrapper Header { get; set; }
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
        public ModHeaderThing ModHeaderThing { get; set; }
        public ItemModData RootNode { get; set; }
    }

    public class ItemModData
    {
        public gameItemIdWrapper Header { get; set; }
        public string AppearanceName { get; set; }
        public TweakDBID AttachmentSlotTdbId { get; set; }
        public List<ItemModData> Children { get; set; } = new();
        public uint Unknown2 { get; set; }
        public ModHeaderThing ModHeaderThing { get; set; }
    }

    public class ModableItemWithQuantityData : ModableItemData
    {
        public uint Quantity { get; set; }
    }

    public static gameItemIdWrapper ReadHeaderThing(BinaryReader reader)
    {
        var id = reader.ReadUInt64();
        var seed = reader.ReadUInt32();
        var itemStructure = reader.ReadByte();
        var uniqueCounter = reader.ReadUInt16();
        var flags = reader.ReadByte();

        return new gameItemIdWrapper
        {
            ItemId = new gameItemID
            {
                Id = id,
                RngSeed = seed,
                UniqueCounter = uniqueCounter,
                Flags = flags
            },
            ItemStructure = (Enums.gamedataItemStructure)itemStructure
        };
    }

    public static void WriteHeaderThing(BinaryWriter writer, gameItemIdWrapper itemHeader)
    {
        writer.Write((ulong)itemHeader.ItemId.Id);
        writer.Write(itemHeader.ItemId.RngSeed);
        writer.Write((byte)itemHeader.ItemStructure);
        writer.Write(itemHeader.ItemId.UniqueCounter);
        writer.Write(itemHeader.ItemId.Flags);
    }

    public static ItemData ReadItemData(BinaryReader reader)
    {
        var result = new ItemData();

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
        result.ModHeaderThing = ReadModHeaderThing(reader);
        result.RootNode = ReadKind2DataNode(reader);

        return result;
    }

    private static void WriteModableItemWithQuantityData(BinaryWriter writer, ModableItemWithQuantityData modq)
    {
        writer.Write(modq.Quantity);
        writer.Write((ulong)modq.ModHeaderThing.LootItemId);
        writer.Write(modq.ModHeaderThing.Unknown2);
        writer.Write(modq.ModHeaderThing.Unknown3);
        WriteKind2DataNode(writer, modq.RootNode);
    }

    public static ModHeaderThing ReadModHeaderThing(BinaryReader reader)
    {
        var result = new ModHeaderThing();

        result.LootItemId = reader.ReadUInt64();
        result.Unknown2 = reader.ReadUInt32();
        result.Unknown3 = reader.ReadSingle();

        return result;
    }

    public static void WriteModHeaderThing(BinaryWriter writer, ModHeaderThing modHeaderThing)
    {
        writer.Write((ulong)modHeaderThing.LootItemId);
        writer.Write(modHeaderThing.Unknown2);
        writer.Write(modHeaderThing.Unknown3);
    }

    public static ModableItemData ReadModableItemData(BinaryReader reader)
    {
        var result = new ModableItemData();

        result.ModHeaderThing = ReadModHeaderThing(reader);
        result.RootNode = ReadKind2DataNode(reader);

        return result;
    }

    private static void WriteModableItemData(BinaryWriter writer, ModableItemData mod)
    {
        WriteModHeaderThing(writer, mod.ModHeaderThing);
        WriteKind2DataNode(writer, mod.RootNode);
    }

    public static ItemModData ReadKind2DataNode(BinaryReader reader)
    {
        var result = new ItemModData();

        result.Header = ReadHeaderThing(reader);
        result.AppearanceName = reader.ReadLengthPrefixedString();
        result.AttachmentSlotTdbId = reader.ReadUInt64();
        var count = reader.ReadVLQInt32();
        for (var i = 0; i < count; ++i)
        {
            result.Children.Add(ReadKind2DataNode(reader));
        }

        result.Unknown2 = reader.ReadUInt32();

        // Always the same as in the parent ModableItem
        result.ModHeaderThing = ReadModHeaderThing(reader);

        return result;
    }

    private static void WriteKind2DataNode(BinaryWriter writer, ItemModData mod)
    {
        WriteHeaderThing(writer, mod.Header);
        writer.WriteLengthPrefixedString(mod.AppearanceName);
        writer.Write((ulong)mod.AttachmentSlotTdbId);
        writer.WriteVLQInt32(mod.Children.Count);
        foreach (var child in mod.Children)
        {
            WriteKind2DataNode(writer, child);
        }
        writer.Write(mod.Unknown2);
        WriteModHeaderThing(writer, mod.ModHeaderThing);
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

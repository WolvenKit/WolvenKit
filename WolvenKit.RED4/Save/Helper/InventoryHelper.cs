using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.Classes;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class InventoryHelper
{
    public static ItemInfo ReadItemInfo(BinaryReader reader)
    {
        var id = reader.ReadUInt64();
        var seed = reader.ReadUInt32();
        var itemStructure = reader.ReadByte();
        var uniqueCounter = reader.ReadUInt16();
        var flags = reader.ReadByte();

        return new ItemInfo
        {
            ItemId = new gameItemID
            {
                Id = id,
                RngSeed = seed,
                UniqueCounter = uniqueCounter,
                Flags = flags
            },
            ItemStructure = (ItemStructure)itemStructure
        };
    }

    public static void WriteItemInfo(BinaryWriter writer, ItemInfo itemHeader)
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

        result.ItemInfo = ReadItemInfo(reader);
        result.Flags = (ItemFlag)reader.ReadByte();
        result.CreationTime = reader.ReadUInt32();

        if (result.HasQuantity())
        {
            result.Quantity = reader.ReadUInt32();
        }

        if (result.HasExtendedData())
        {
            result.ItemAdditionalInfo = ReadItemAdditionalInfo(reader);
            result.ItemSlotPart = ReadItemSlotPart(reader);
        }

        return result;
    }

    public static void WriteItemData(BinaryWriter writer, ItemData item)
    {
        WriteItemInfo(writer, item.ItemInfo);
        writer.Write((byte)item.Flags);
        writer.Write(item.CreationTime);

        if (item.HasQuantity())
        {
            writer.Write(item.Quantity);
        }

        if (item.HasExtendedData())
        {
            if (item.ItemAdditionalInfo == null || item.ItemSlotPart == null)
            {
                throw new Exception();
            }

            WriteItemAdditionalInfo(writer, item.ItemAdditionalInfo);
            WriteItemSlotPart(writer, item.ItemSlotPart);
        }
    }

    public static ItemAdditionalInfo ReadItemAdditionalInfo(BinaryReader reader)
    {
        var result = new ItemAdditionalInfo();

        result.LootItemPoolId = reader.ReadUInt64();
        result.Unknown2 = reader.ReadUInt32();
        result.RequiredLevel = reader.ReadSingle();

        return result;
    }

    public static void WriteItemAdditionalInfo(BinaryWriter writer, ItemAdditionalInfo modHeaderThing)
    {
        writer.Write((ulong)modHeaderThing.LootItemPoolId);
        writer.Write(modHeaderThing.Unknown2);
        writer.Write(modHeaderThing.RequiredLevel);
    }

    public static ItemSlotPart ReadItemSlotPart(BinaryReader reader)
    {
        var result = new ItemSlotPart();

        result.ItemInfo = ReadItemInfo(reader);
        result.AppearanceName = reader.ReadLengthPrefixedString();
        result.AttachmentSlotTdbId = reader.ReadUInt64();
        var count = reader.ReadVLQInt32();
        for (var i = 0; i < count; ++i)
        {
            result.Children.Add(ReadItemSlotPart(reader));
        }
        result.Unknown2 = reader.ReadUInt32();
        result.ItemAdditionalInfo = ReadItemAdditionalInfo(reader);

        return result;
    }

    public static void WriteItemSlotPart(BinaryWriter writer, ItemSlotPart itemSlotPart)
    {
        WriteItemInfo(writer, itemSlotPart.ItemInfo);
        writer.WriteLengthPrefixedString(itemSlotPart.AppearanceName);
        writer.Write((ulong)itemSlotPart.AttachmentSlotTdbId);

        writer.WriteVLQInt32(itemSlotPart.Children.Count);
        foreach (var subSlotPart in itemSlotPart.Children)
        {
            WriteItemSlotPart(writer, subSlotPart);
        }

        writer.Write(itemSlotPart.Unknown2);
        WriteItemAdditionalInfo(writer, itemSlotPart.ItemAdditionalInfo);
    }

    public static ulong GetItemIdHash(gameItemID gameItemId) => GetItemIdHash(gameItemId.Id, gameItemId.RngSeed, gameItemId.UniqueCounter);

    public static ulong GetItemIdHash(ulong tweakDbId, uint seed, ushort unk1 = 0)
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

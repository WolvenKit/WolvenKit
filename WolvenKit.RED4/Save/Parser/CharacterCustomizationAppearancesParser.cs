using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class gameuiCharacterCustomizationPresetWrapper : INodeData
{
    public CBool DataExists { get; set; }
    public CUInt32 Unknown1 { get; set; }
    public CBool IsBrainGenderMale { get; set; }
    public gameuiCharacterCustomizationPreset Preset { get; set; } = new();
}

public class CharacterCustomizationAppearancesParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.CHARACTER_CUSTOMIZATION_APPEARANCES_NODE;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new gameuiCharacterCustomizationPresetWrapper();
        data.DataExists = reader.ReadBoolean();
        data.Unknown1 = reader.ReadUInt32(); // Could be CookingPlatform

        if (!data.DataExists)
        {
            node.Value = data;
            return;
        }

        data.Preset.Version = reader.ReadUInt32();
        data.Preset.IsMale = reader.ReadBoolean();

        data.IsBrainGenderMale = reader.ReadBoolean();

        data.Preset.HeadGroups = ReadCustomizationGroups(reader);
        data.Preset.ArmsGroups = ReadCustomizationGroups(reader);
        data.Preset.BodyGroups = ReadCustomizationGroups(reader);

        var count = reader.ReadUInt32();
        for (var i = 0; i < count; ++i)
        {
            data.Preset.PerspectiveInfo.Add(ReadPerspectiveInfo(reader));
        }

        var scount = reader.ReadVLQInt32();
        for (var i = 0; i < scount; ++i)
        {
            data.Preset.Tags.Tags.Add(reader.ReadLengthPrefixedString());
        }

        node.Value = data;
    }

    private CArray<gameuiCustomizationGroup> ReadCustomizationGroups(BinaryReader reader)
    {
        var result = new CArray<gameuiCustomizationGroup>();

        var count = reader.ReadUInt32();
        for (uint i = 0; i < count; ++i)
        {
            result.Add(ReadCustomizationGroup(reader));
        }

        return result;
    }

    private gameuiCustomizationGroup ReadCustomizationGroup(BinaryReader reader)
    {
        var result = new gameuiCustomizationGroup();

        result.Name = reader.ReadLengthPrefixedString();

        var count = reader.ReadInt32();
        for (int i = 0; i < count; i++)
        {
            result.Customization.Add(ReadCustomizationAppearance(reader));
        }

        count = reader.ReadInt32();
        for (int i = 0; i < count; i++)
        {
            result.Morphs.Add(ReadCustomizationMorph(reader));
        }

        return result;
    }

    private gameuiCustomizationAppearance ReadCustomizationAppearance(BinaryReader reader)
    {
        var result = new gameuiCustomizationAppearance();

        result.Resource = new CResourceAsyncReference<appearanceAppearanceResource>(reader.ReadUInt64(), InternalEnums.EImportFlags.Soft);
        result.Definition = reader.ReadLengthPrefixedString();
        result.Name = reader.ReadLengthPrefixedString();

        result.CensorFlag = (Enums.CensorshipFlags)reader.ReadUInt32();
        result.CensorFlagAction = (Enums.gameuiCharacterCustomizationActionType)reader.ReadUInt32();

        return result;
    }

    private gameuiCustomizationMorph ReadCustomizationMorph(BinaryReader reader)
    {
        var result = new gameuiCustomizationMorph();

        result.RegionName = reader.ReadLengthPrefixedString();
        result.TargetName = reader.ReadLengthPrefixedString();

        result.CensorFlag = (Enums.CensorshipFlags)reader.ReadUInt32();
        result.CensorFlagAction = (Enums.gameuiCharacterCustomizationActionType)reader.ReadUInt32();

        return result;
    }

    private gameuiPerspectiveInfo ReadPerspectiveInfo(BinaryReader reader)
    {
        return new gameuiPerspectiveInfo
        {
            Name = reader.ReadLengthPrefixedString(),
            Fpp = reader.ReadLengthPrefixedString(),
            Tpp = reader.ReadLengthPrefixedString()
        };
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (gameuiCharacterCustomizationPresetWrapper)node.Value;

        writer.Write((bool)data.DataExists);
        writer.Write(data.Unknown1);
        if (data.DataExists)
        {
            writer.Write(data.Preset.Version);
            writer.Write((bool)data.Preset.IsMale);
            writer.Write((bool)data.IsBrainGenderMale);

            WriteCustomizationGroups(writer, data.Preset.HeadGroups);
            WriteCustomizationGroups(writer, data.Preset.ArmsGroups);
            WriteCustomizationGroups(writer, data.Preset.BodyGroups);

            writer.Write(data.Preset.PerspectiveInfo.Count);
            foreach (var perspectiveInfo in data.Preset.PerspectiveInfo)
            {
                WritePerspectiveInfo(writer, perspectiveInfo);
            }

            writer.WriteVLQInt32(data.Preset.Tags.Tags.Count);
            foreach (var tag in data.Preset.Tags.Tags)
            {
                writer.WriteLengthPrefixedString(tag);
            }
        }
    }

    private void WriteCustomizationGroups(NodeWriter writer, CArray<gameuiCustomizationGroup> groupArray)
    {
        writer.Write(groupArray.Count);
        foreach (var customizationGroup in groupArray)
        {
            WriteCustomizationGroup(writer, customizationGroup);
        }
    }

    private void WriteCustomizationGroup(NodeWriter writer, gameuiCustomizationGroup customizationGroup)
    {
        writer.WriteLengthPrefixedString(customizationGroup.Name);

        writer.Write(customizationGroup.Customization.Count);
        foreach (var appearance in customizationGroup.Customization)
        {
            WriteCustomizationAppearance(writer, appearance);
        }

        writer.Write(customizationGroup.Morphs.Count);
        foreach (var morph in customizationGroup.Morphs)
        {
            WriteCustomizationMorph(writer, morph);
        }
    }

    private void WriteCustomizationAppearance(NodeWriter writer, gameuiCustomizationAppearance appearance)
    {
        writer.Write((ulong)appearance.Resource.DepotPath);
        writer.WriteLengthPrefixedString(appearance.Definition);
        writer.WriteLengthPrefixedString(appearance.Name);
        writer.Write((uint)Convert.ChangeType((Enums.CensorshipFlags)appearance.CensorFlag, TypeCode.UInt32));
        writer.Write((uint)Convert.ChangeType((Enums.gameuiCharacterCustomizationActionType)appearance.CensorFlagAction, TypeCode.UInt32));
    }

    private void WriteCustomizationMorph(NodeWriter writer, gameuiCustomizationMorph morph)
    {
        writer.WriteLengthPrefixedString(morph.RegionName);
        writer.WriteLengthPrefixedString(morph.TargetName);
        writer.Write((uint)Convert.ChangeType((Enums.CensorshipFlags)morph.CensorFlag, TypeCode.UInt32));
        writer.Write((uint)Convert.ChangeType((Enums.gameuiCharacterCustomizationActionType)morph.CensorFlagAction, TypeCode.UInt32));
    }

    private void WritePerspectiveInfo(NodeWriter writer, gameuiPerspectiveInfo perspectiveInfo)
    {
        writer.WriteLengthPrefixedString(perspectiveInfo.Name);
        writer.WriteLengthPrefixedString(perspectiveInfo.Fpp);
        writer.WriteLengthPrefixedString(perspectiveInfo.Tpp);
    }
}
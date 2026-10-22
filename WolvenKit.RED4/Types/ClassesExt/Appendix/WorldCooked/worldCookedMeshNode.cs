using WolvenKit.RED4.IO;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types;

public partial class worldCookedMeshNode
{
    protected void ReadEntry(Red4Reader br, in worldCookedMeshNode_Class1 entry)
    {
        entry.Unknown1 = new CResourceAsyncReference<CMesh>(br.BaseReader.ReadUInt64());
        entry.Unknown2 = br.BaseReader.ReadUInt64();

        entry.Unknown3 = br.ReadCFloat();
        entry.Unknown4 = br.ReadCUInt32();

        entry.Unknown5 = (visWorldOccluderType)br.BaseReader.ReadByte();
        entry.Unknown6 = br.ReadCUInt8();
        entry.Unknown7 = (RenderSceneLayerMask)br.BaseReader.ReadByte();

        entry.Unknown8 = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
        entry.Unknown9 = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
        entry.Unknown10 = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
        entry.Unknown11 = (shadowsShadowCastingMode)br.BaseReader.ReadByte();

        entry.Unknown12 = br.ReadCBool();
        entry.Unknown13 = br.ReadCBool();
    }

    protected void WriteEntry(Red4Writer bw, worldCookedMeshNode_Class1 entry)
    {
        bw.BaseWriter.Write((ulong)entry.Unknown1.DepotPath);
        bw.BaseWriter.Write((ulong)entry.Unknown2);

        bw.Write(entry.Unknown3);
        bw.Write(entry.Unknown4);

        bw.BaseWriter.Write((byte)(visWorldOccluderType)entry.Unknown5);
        bw.Write(entry.Unknown6);
        bw.BaseWriter.Write((byte)(RenderSceneLayerMask)entry.Unknown7);

        bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.Unknown8);
        bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.Unknown9);
        bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.Unknown10);
        bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.Unknown11);

        bw.Write(entry.Unknown12);
        bw.Write(entry.Unknown13);
    }
}

public class worldCookedMeshNode_Class1 : RedBaseClass
{
    [RED("unknown1")]
    [REDProperty(IsIgnored = true)]
    public CResourceAsyncReference<CMesh> Unknown1
    {
        get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
        set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
    }

    [RED("unknown2")]
    [REDProperty(IsIgnored = true)]
    public CName Unknown2
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("unknown3")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unknown3
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unknown4")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unknown4
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unknown5")]
    [REDProperty(IsIgnored = true)]
    public CEnum<visWorldOccluderType> Unknown5
    {
        get => GetPropertyValue<CEnum<visWorldOccluderType>>();
        set => SetPropertyValue<CEnum<visWorldOccluderType>>(value);
    }

    [RED("unknown6")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 Unknown6
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [RED("unknown7")]
    [REDProperty(IsIgnored = true)]
    public CBitField<RenderSceneLayerMask> Unknown7
    {
        get => GetPropertyValue<CBitField<RenderSceneLayerMask>>();
        set => SetPropertyValue<CBitField<RenderSceneLayerMask>>(value);
    }

    [RED("unknown8")]
    [REDProperty(IsIgnored = true)]
    public CEnum<shadowsShadowCastingMode> Unknown8
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [RED("unknown9")]
    [REDProperty(IsIgnored = true)]
    public CEnum<shadowsShadowCastingMode> Unknown9
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [RED("unknown10")]
    [REDProperty(IsIgnored = true)]
    public CEnum<shadowsShadowCastingMode> Unknown10
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [RED("unknown11")]
    [REDProperty(IsIgnored = true)]
    public CEnum<shadowsShadowCastingMode> Unknown11
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [RED("unknown12")]
    [REDProperty(IsIgnored = true)]
    public CBool Unknown12
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [RED("unknown13")]
    [REDProperty(IsIgnored = true)]
    public CBool Unknown13
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}

using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types;

public partial class worldInstancedMeshNode
{
    public override ProcessTime GetProcessTime() => ProcessTime.OnAccess;

    public override void LoadData(RedBaseClass cls)
    {
        var result = new worldInstancedMeshNode_Buffer();

        //var relatedNodes = GetRelatedNodes(wss);

        using var ms = new MemoryStream(Buffer.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        br.BaseReader.ReadByte(); // Unknown byte

        var count1 = br.BaseReader.ReadVLQInt32(); // relatedNodes.Count
        for (var i = 0; i < count1; i++)
        {
            var entry = new worldInstancedMeshNode_Class1();

            entry.Unknown1.Min.X = br.ReadCFloat();
            entry.Unknown1.Min.Y = br.ReadCFloat();
            entry.Unknown1.Min.Z = br.ReadCFloat();
            entry.Unknown1.Min.W = br.ReadCFloat();

            entry.Unknown1.Max.X = br.ReadCFloat();
            entry.Unknown1.Max.Y = br.ReadCFloat();
            entry.Unknown1.Max.Z = br.ReadCFloat();
            entry.Unknown1.Max.W = br.ReadCFloat();

            entry.Unknown2 = new CResourceAsyncReference<CMesh>(br.BaseReader.ReadUInt64());
            entry.Unknown3 = br.BaseReader.ReadUInt64();
            entry.Unknown4 = br.ReadCFloat();
            entry.Unknown5 = br.ReadCUInt32();

            entry.Unknown6 = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
            entry.Unknown7 = (shadowsShadowCastingMode)br.BaseReader.ReadByte();

            entry.Unknown8 = (RenderSceneLayerMask)br.BaseReader.ReadByte();
            entry.Unknown9 = (visWorldOccluderType)br.BaseReader.ReadByte();
            entry.Unknown10 = br.ReadCUInt8();
            entry.Unknown11 = br.ReadCBool();

            br.BaseReader.ReadBytes(2); // unused

            result.Unknown1.Add(entry);
        }

        var count2 = br.BaseReader.ReadVLQInt32(); // relatedNodes.Count
        for (var i = 0; i < count2; i++)
        {
            var entry = new worldInstancedMeshNode_Class2();

            entry.Unknown1 = br.ReadCUInt16();
            entry.Unknown2 = br.ReadCUInt16();

            result.Unknown2.Add(entry);
        }

        Buffer.Data = result;
    }

    public override void StoreData()
    {
        if (Buffer.Data is not worldInstancedMeshNode_Buffer data)
        {
            throw new Exception();
        }

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        bw.BaseWriter.Write((byte)0); // Unknown byte

        bw.BaseWriter.WriteVLQInt32(data.Unknown1.Count);
        foreach (var entry in data.Unknown1)
        {
            bw.Write(entry.Unknown1.Min.X);
            bw.Write(entry.Unknown1.Min.Y);
            bw.Write(entry.Unknown1.Min.Z);
            bw.Write(entry.Unknown1.Min.W);

            bw.Write(entry.Unknown1.Max.X);
            bw.Write(entry.Unknown1.Max.Y);
            bw.Write(entry.Unknown1.Max.Z);
            bw.Write(entry.Unknown1.Max.W);

            bw.BaseWriter.Write((ulong)entry.Unknown2.DepotPath);
            bw.BaseWriter.Write((ulong)entry.Unknown3);
            bw.Write(entry.Unknown4);
            bw.Write(entry.Unknown5);

            bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.Unknown6);
            bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.Unknown7);

            bw.BaseWriter.Write((byte)(RenderSceneLayerMask)entry.Unknown8);
            bw.BaseWriter.Write((byte)(visWorldOccluderType)entry.Unknown9);
            bw.Write(entry.Unknown10);
            bw.Write(entry.Unknown11);

            bw.BaseWriter.Write(new byte[2]); // unused
        }

        bw.BaseWriter.WriteVLQInt32(data.Unknown2.Count);
        foreach (var entry in data.Unknown2)
        {
            bw.Write(entry.Unknown1);
            bw.Write(entry.Unknown2);
        }

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldInstancedMeshNode_Buffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldInstancedMeshNode_Class1> Unknown1 { get; set; } = new();
    public CArray<worldInstancedMeshNode_Class2> Unknown2 { get; set; } = new();
}

public class worldInstancedMeshNode_Class1 : RedBaseClass
{
    [RED("unknown1")]
    [REDProperty(IsIgnored = true)]
    public Box Unknown1
    {
        get => GetPropertyValue<Box>();
        set => SetPropertyValue<Box>(value);
    }

    [RED("unknown2")]
    [REDProperty(IsIgnored = true)]
    public CResourceAsyncReference<CMesh> Unknown2
    {
        get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
        set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
    }

    [RED("unknown3")]
    [REDProperty(IsIgnored = true)]
    public CName Unknown3
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("unknown4")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unknown4
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unknown5")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unknown5
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unknown6")]
    [REDProperty(IsIgnored = true)]
    public CEnum<shadowsShadowCastingMode> Unknown6
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [RED("unknown7")]
    [REDProperty(IsIgnored = true)]
    public CEnum<shadowsShadowCastingMode> Unknown7
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [RED("unknown8")]
    public CBitField<RenderSceneLayerMask> Unknown8
    {
        get => GetPropertyValue<CBitField<RenderSceneLayerMask>>();
        set => SetPropertyValue<CBitField<RenderSceneLayerMask>>(value);
    }

    [Ordinal(8)]
    [RED("unknown9")]
    public CEnum<visWorldOccluderType> Unknown9
    {
        get => GetPropertyValue<CEnum<visWorldOccluderType>>();
        set => SetPropertyValue<CEnum<visWorldOccluderType>>(value);
    }

    [RED("unknown10")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 Unknown10
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [RED("unknown11")]
    [REDProperty(IsIgnored = true)]
    public CBool Unknown11
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    public worldInstancedMeshNode_Class1()
    {
        Unknown1 = new Box();
    }
}

public class worldInstancedMeshNode_Class2 : RedBaseClass
{
    [RED("transformIndex")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown1
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("transformCount")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown2
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }
}

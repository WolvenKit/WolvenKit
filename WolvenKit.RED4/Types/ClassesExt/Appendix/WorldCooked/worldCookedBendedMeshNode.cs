using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types;

public partial class worldCookedBendedMeshNode
{
    public override void LoadData(RedBaseClass cls)
    {
        if (cls is not worldStreamingSector wss)
        {
            throw new Exception();
        }

        var result = new worldCookedBendedMeshNode_Buffer();

        //var relatedNodes = GetRelatedNodes(wss);

        using var ms = new MemoryStream(Buffer.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var size = br.BaseReader.ReadVLQInt32();

        var count1 = size / 30;
        for (var i = 0; i < count1; i++)
        {
            var entry = new worldCookedBendedMeshNode_Class1();

            entry.Unknown1 = new CResourceAsyncReference<CMesh>(br.BaseReader.ReadUInt64());
            entry.Unknown2 = br.BaseReader.ReadUInt64();
            entry.Unknown3 = br.ReadCUInt32();
            entry.Unknown4 = br.ReadCUInt32();
            entry.Unknown5 = br.ReadCUInt16();
            entry.Unknown6 = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
            entry.Unknown7 = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
            entry.Unknown8 = br.ReadCBool();
            entry.Unknown9 = br.ReadCBool();

            result.Unknown1.Add(entry);
        }

        var count2 = br.BaseReader.ReadVLQInt32();
        for (var i = 0; i < count2; i++)
        {
            var entry = new CMatrix();

            entry.X.X = br.ReadCFloat();
            entry.X.Y = br.ReadCFloat();
            entry.X.Z = br.ReadCFloat();
            entry.X.W = br.ReadCFloat();

            entry.Y.X = br.ReadCFloat();
            entry.Y.Y = br.ReadCFloat();
            entry.Y.Z = br.ReadCFloat();
            entry.Y.W = br.ReadCFloat();

            entry.Z.X = br.ReadCFloat();
            entry.Z.Y = br.ReadCFloat();
            entry.Z.Z = br.ReadCFloat();
            entry.Z.W = br.ReadCFloat();

            entry.W.X = br.ReadCFloat();
            entry.W.Y = br.ReadCFloat();
            entry.W.Z = br.ReadCFloat();
            entry.W.W = br.ReadCFloat();

            result.Unknown2.Add(entry);
        }

        var count3 = br.BaseReader.ReadVLQInt32();
        for (var i = 0; i < count3; i++)
        {
            var entry = new Box();

            entry.Min.X = br.ReadCFloat();
            entry.Min.Y = br.ReadCFloat();
            entry.Min.Z = br.ReadCFloat();
            entry.Min.W = br.ReadCFloat();

            entry.Max.X = br.ReadCFloat();
            entry.Max.Y = br.ReadCFloat();
            entry.Max.Z = br.ReadCFloat();
            entry.Max.W = br.ReadCFloat();

            result.Unknown3.Add(entry);
        }

        Buffer.Data = result;
    }

    public override void StoreData()
    {
        if (Buffer.Data is not worldCookedBendedMeshNode_Buffer data)
        {
            throw new Exception();
        }

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        bw.BaseWriter.WriteVLQInt32(data.Unknown1.Count * 30);
        foreach (var entry in data.Unknown1)
        {
            bw.BaseWriter.Write((ulong)entry.Unknown1.DepotPath);
            bw.BaseWriter.Write((ulong)entry.Unknown2);
            bw.Write(entry.Unknown3);
            bw.Write(entry.Unknown4);
            bw.Write(entry.Unknown5);
            bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.Unknown6);
            bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.Unknown7);
            bw.Write(entry.Unknown8);
            bw.Write(entry.Unknown9);
        }

        bw.BaseWriter.WriteVLQInt32(data.Unknown2.Count);
        foreach (var entry in data.Unknown2)
        {
            bw.Write(entry.X.X);
            bw.Write(entry.X.Y);
            bw.Write(entry.X.Z);
            bw.Write(entry.X.W);

            bw.Write(entry.Y.X);
            bw.Write(entry.Y.Y);
            bw.Write(entry.Y.Z);
            bw.Write(entry.Y.W);

            bw.Write(entry.Z.X);
            bw.Write(entry.Z.Y);
            bw.Write(entry.Z.Z);
            bw.Write(entry.Z.W);

            bw.Write(entry.W.X);
            bw.Write(entry.W.Y);
            bw.Write(entry.W.Z);
            bw.Write(entry.W.W);
        }

        bw.BaseWriter.WriteVLQInt32(data.Unknown3.Count);
        foreach (var entry in data.Unknown3)
        {
            bw.Write(entry.Min.X);
            bw.Write(entry.Min.Y);
            bw.Write(entry.Min.Z);
            bw.Write(entry.Min.W);

            bw.Write(entry.Max.X);
            bw.Write(entry.Max.Y);
            bw.Write(entry.Max.Z);
            bw.Write(entry.Max.W);
        }

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldCookedBendedMeshNode_Buffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedBendedMeshNode_Class1> Unknown1 { get; set; } = new();
    public CArray<CMatrix> Unknown2 { get; set; } = new();
    public CArray<Box> Unknown3 { get; set; } = new();
}

public class worldCookedBendedMeshNode_Class1 : RedBaseClass
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
    public CUInt32 Unknown3
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
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
    public CUInt16 Unknown5
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
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
    [REDProperty(IsIgnored = true)]
    public CBool Unknown8
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [RED("unknown9")]
    [REDProperty(IsIgnored = true)]
    public CBool Unknown9   
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}

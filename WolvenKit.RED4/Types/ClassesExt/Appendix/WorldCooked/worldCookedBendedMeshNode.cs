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
            var entry = new worldCookedBendedMeshNodeInner();

            entry.Mesh = new CResourceAsyncReference<CMesh>(br.BaseReader.ReadUInt64());
            entry.MeshAppearance = br.BaseReader.ReadUInt64();
            entry.DeformationDataStartIndex = br.ReadCUInt32();
            entry.DeformationDataCount = br.ReadCUInt32();
            entry.Index = br.ReadCUInt16();
            entry.CastShadows = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
            entry.CastLocalShadows = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
            entry.RemoveFromRainMap = br.ReadCBool();
            entry.IsBendedRoad = br.ReadCBool();

            result.InnerNodes.Add(entry);
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

            result.DeformationData.Add(entry);
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

            result.DeformedBoxes.Add(entry);
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

        bw.BaseWriter.WriteVLQInt32(data.InnerNodes.Count * 30);
        foreach (var entry in data.InnerNodes)
        {
            bw.BaseWriter.Write((ulong)entry.Mesh.DepotPath);
            bw.BaseWriter.Write((ulong)entry.MeshAppearance);
            bw.Write(entry.DeformationDataStartIndex);
            bw.Write(entry.DeformationDataCount);
            bw.Write(entry.Index);
            bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.CastShadows);
            bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.CastLocalShadows);
            bw.Write(entry.RemoveFromRainMap);
            bw.Write(entry.IsBendedRoad);
        }

        bw.BaseWriter.WriteVLQInt32(data.DeformationData.Count);
        foreach (var entry in data.DeformationData)
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

        bw.BaseWriter.WriteVLQInt32(data.DeformedBoxes.Count);
        foreach (var entry in data.DeformedBoxes)
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

    public CArray<worldCookedBendedMeshNodeInner> InnerNodes { get; set; } = new();
    public CArray<CMatrix> DeformationData { get; set; } = new();
    public CArray<Box> DeformedBoxes { get; set; } = new();
}

public class worldCookedBendedMeshNodeInner : RedBaseClass
{
    [RED("mesh")]
    [REDProperty(IsIgnored = true)]
    public CResourceAsyncReference<CMesh> Mesh
    {
        get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
        set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
    }

    [RED("meshAppearance")]
    [REDProperty(IsIgnored = true)]
    public CName MeshAppearance
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("deformationDataStartIndex")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 DeformationDataStartIndex
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("deformationDataCount")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 DeformationDataCount
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("index")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Index
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("castShadows")]
    [REDProperty(IsIgnored = true)]
    public CEnum<shadowsShadowCastingMode> CastShadows
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [RED("castLocalShadows")]
    [REDProperty(IsIgnored = true)]
    public CEnum<shadowsShadowCastingMode> CastLocalShadows
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [RED("removeFromRainMap")]
    [REDProperty(IsIgnored = true)]
    public CBool RemoveFromRainMap
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [RED("isBendedRoad")]
    [REDProperty(IsIgnored = true)]
    public CBool IsBendedRoad
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}

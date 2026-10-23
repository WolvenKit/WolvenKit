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
            var entry = new worldInstancedMeshNodeInner();

            entry.GroupWorldBoundingBox.Min.X = br.ReadCFloat();
            entry.GroupWorldBoundingBox.Min.Y = br.ReadCFloat();
            entry.GroupWorldBoundingBox.Min.Z = br.ReadCFloat();
            entry.GroupWorldBoundingBox.Min.W = br.ReadCFloat();

            entry.GroupWorldBoundingBox.Max.X = br.ReadCFloat();
            entry.GroupWorldBoundingBox.Max.Y = br.ReadCFloat();
            entry.GroupWorldBoundingBox.Max.Z = br.ReadCFloat();
            entry.GroupWorldBoundingBox.Max.W = br.ReadCFloat();

            entry.Mesh = new CResourceAsyncReference<CMesh>(br.BaseReader.ReadUInt64());
            entry.MeshAppearance = br.BaseReader.ReadUInt64();
            entry.ForcedAutoHideDistance = br.ReadCFloat();
            entry.LodLevelScales = br.ReadCUInt32();

            entry.CastShadows = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
            entry.CastLocalShadows = (shadowsShadowCastingMode)br.BaseReader.ReadByte();

            entry.RenderSceneLayerMask = (RenderSceneLayerMask)br.BaseReader.ReadByte();
            entry.OccluderType = (visWorldOccluderType)br.BaseReader.ReadByte();
            entry.OccluderAutohideDistanceScale = br.ReadCUInt8();
            entry.RemoveFromRainMap = br.ReadCBool();

            br.BaseReader.ReadBytes(2); // unused

            result.InnerNodes.Add(entry);
        }

        var count2 = br.BaseReader.ReadVLQInt32(); // relatedNodes.Count
        for (var i = 0; i < count2; i++)
        {
            var entry = new TransformRange();

            entry.TransformIndex = br.ReadCUInt16();
            entry.TransformCount = br.ReadCUInt16();

            result.TransformRanges.Add(entry);
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

        bw.BaseWriter.WriteVLQInt32(data.InnerNodes.Count);
        foreach (var entry in data.InnerNodes)
        {
            bw.Write(entry.GroupWorldBoundingBox.Min.X);
            bw.Write(entry.GroupWorldBoundingBox.Min.Y);
            bw.Write(entry.GroupWorldBoundingBox.Min.Z);
            bw.Write(entry.GroupWorldBoundingBox.Min.W);

            bw.Write(entry.GroupWorldBoundingBox.Max.X);
            bw.Write(entry.GroupWorldBoundingBox.Max.Y);
            bw.Write(entry.GroupWorldBoundingBox.Max.Z);
            bw.Write(entry.GroupWorldBoundingBox.Max.W);

            bw.BaseWriter.Write((ulong)entry.Mesh.DepotPath);
            bw.BaseWriter.Write((ulong)entry.MeshAppearance);
            bw.Write(entry.ForcedAutoHideDistance);
            bw.Write(entry.LodLevelScales);

            bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.CastShadows);
            bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.CastLocalShadows);

            bw.BaseWriter.Write((byte)(RenderSceneLayerMask)entry.RenderSceneLayerMask);
            bw.BaseWriter.Write((byte)(visWorldOccluderType)entry.OccluderType);
            bw.Write(entry.OccluderAutohideDistanceScale);
            bw.Write(entry.RemoveFromRainMap);

            bw.BaseWriter.Write(new byte[2]); // unused
        }

        bw.BaseWriter.WriteVLQInt32(data.TransformRanges.Count);
        foreach (var entry in data.TransformRanges)
        {
            bw.Write(entry.TransformIndex);
            bw.Write(entry.TransformCount);
        }

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldInstancedMeshNode_Buffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldInstancedMeshNodeInner> InnerNodes { get; set; } = new();
    public CArray<TransformRange> TransformRanges { get; set; } = new();
}

public class worldInstancedMeshNodeInner : RedBaseClass
{
    [RED("groupWorldBoundingBox")]
    [REDProperty(IsIgnored = true)]
    public Box GroupWorldBoundingBox
    {
        get => GetPropertyValue<Box>();
        set => SetPropertyValue<Box>(value);
    }

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

    [RED("forcedAutoHideDistance")]
    [REDProperty(IsIgnored = true)]
    public CFloat ForcedAutoHideDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("lodLevelScales")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 LodLevelScales
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
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

    [RED("renderSceneLayerMask")]
    public CBitField<RenderSceneLayerMask> RenderSceneLayerMask
    {
        get => GetPropertyValue<CBitField<RenderSceneLayerMask>>();
        set => SetPropertyValue<CBitField<RenderSceneLayerMask>>(value);
    }

    [Ordinal(8)]
    [RED("occluderType")]
    public CEnum<visWorldOccluderType> OccluderType
    {
        get => GetPropertyValue<CEnum<visWorldOccluderType>>();
        set => SetPropertyValue<CEnum<visWorldOccluderType>>(value);
    }

    [RED("occluderAutohideDistanceScale")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 OccluderAutohideDistanceScale
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [RED("removeFromRainMap")]
    [REDProperty(IsIgnored = true)]
    public CBool RemoveFromRainMap
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    public worldInstancedMeshNodeInner()
    {
        GroupWorldBoundingBox = new Box();
    }
}

public class TransformRange : RedBaseClass
{
    [RED("transformIndex")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 TransformIndex
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("transformCount")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 TransformCount
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }
}

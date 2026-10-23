using WolvenKit.RED4.IO;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types;

public partial class worldCookedMeshNode
{
    protected void ReadEntry(Red4Reader br, in worldCookedMeshNodeInner entry)
    {
        entry.Mesh = new CResourceAsyncReference<CMesh>(br.BaseReader.ReadUInt64());
        entry.MeshAppearance = br.BaseReader.ReadUInt64();

        entry.ForcedAutoHideDistance = br.ReadCFloat();
        entry.LodLevelScales = br.ReadCUInt32();

        entry.OccluderType = (visWorldOccluderType)br.BaseReader.ReadByte();
        entry.OccluderAutohideDistanceScale = br.ReadCUInt8();
        entry.RenderSceneLayerMask = (RenderSceneLayerMask)br.BaseReader.ReadByte();

        entry.CastShadows = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
        entry.CastLocalShadows = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
        entry.CastRayTracedGlobalShadows = (shadowsShadowCastingMode)br.BaseReader.ReadByte();
        entry.CastRayTracedLocalShadows = (shadowsShadowCastingMode)br.BaseReader.ReadByte();

        entry.WindImpulseEnabled = br.ReadCBool();
        entry.RemoveFromRainMap = br.ReadCBool();
    }

    protected void WriteEntry(Red4Writer bw, worldCookedMeshNodeInner entry)
    {
        bw.BaseWriter.Write((ulong)entry.Mesh.DepotPath);
        bw.BaseWriter.Write((ulong)entry.MeshAppearance);

        bw.Write(entry.ForcedAutoHideDistance);
        bw.Write(entry.LodLevelScales);

        bw.BaseWriter.Write((byte)(visWorldOccluderType)entry.OccluderType);
        bw.Write(entry.OccluderAutohideDistanceScale);
        bw.BaseWriter.Write((byte)(RenderSceneLayerMask)entry.RenderSceneLayerMask);

        bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.CastShadows);
        bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.CastLocalShadows);
        bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.CastRayTracedGlobalShadows);
        bw.BaseWriter.Write((byte)(shadowsShadowCastingMode)entry.CastRayTracedLocalShadows);

        bw.Write(entry.WindImpulseEnabled);
        bw.Write(entry.RemoveFromRainMap);
    }
}

public class worldCookedMeshNodeInner : RedBaseClass
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

    [RED("occluderType")]
    [REDProperty(IsIgnored = true)]
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

    [RED("renderSceneLayerMask")]
    [REDProperty(IsIgnored = true)]
    public CBitField<RenderSceneLayerMask> RenderSceneLayerMask
    {
        get => GetPropertyValue<CBitField<RenderSceneLayerMask>>();
        set => SetPropertyValue<CBitField<RenderSceneLayerMask>>(value);
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

    [RED("castRayTracedGlobalShadows")]
    [REDProperty(IsIgnored = true)]
    public CEnum<shadowsShadowCastingMode> CastRayTracedGlobalShadows
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [RED("castRayTracedLocalShadows")]
    [REDProperty(IsIgnored = true)]
    public CEnum<shadowsShadowCastingMode> CastRayTracedLocalShadows
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [RED("windImpulseEnabled")]
    [REDProperty(IsIgnored = true)]
    public CBool WindImpulseEnabled
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [RED("removeFromRainMap")]
    [REDProperty(IsIgnored = true)]
    public CBool RemoveFromRainMap
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}

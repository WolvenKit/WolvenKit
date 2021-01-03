using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CMesh : resStreamedResource
	{
		[Ordinal(0)]  [RED("appearances")] public CArray<CHandle<meshMeshAppearance>> Appearances { get; set; }
		[Ordinal(1)]  [RED("boneNames")] public CArray<CName> BoneNames { get; set; }
		[Ordinal(2)]  [RED("boneRigMatrices")] public CArray<CMatrix> BoneRigMatrices { get; set; }
		[Ordinal(3)]  [RED("boneVertexEpsilons")] public CArray<CFloat> BoneVertexEpsilons { get; set; }
		[Ordinal(4)]  [RED("boundingBox")] public Box BoundingBox { get; set; }
		[Ordinal(5)]  [RED("castGlobalShadowsCachedInCook")] public CBool CastGlobalShadowsCachedInCook { get; set; }
		[Ordinal(6)]  [RED("castLocalShadowsCachedInCook")] public CBool CastLocalShadowsCachedInCook { get; set; }
		[Ordinal(7)]  [RED("constrainAutoHideDistanceToTerrainHeightMap")] public CBool ConstrainAutoHideDistanceToTerrainHeightMap { get; set; }
		[Ordinal(8)]  [RED("externalMaterials")] public CArray<raRef<IMaterial>> ExternalMaterials { get; set; }
		[Ordinal(9)]  [RED("floatTrackNames")] public CArray<CName> FloatTrackNames { get; set; }
		[Ordinal(10)]  [RED("forceLoadAllAppearances")] public CBool ForceLoadAllAppearances { get; set; }
		[Ordinal(11)]  [RED("localMaterialBuffer")] public meshMeshMaterialBuffer LocalMaterialBuffer { get; set; }
		[Ordinal(12)]  [RED("localMaterialInstances")] public CArray<CHandle<CMaterialInstance>> LocalMaterialInstances { get; set; }
		[Ordinal(13)]  [RED("lodBoneMask")] public CArray<CUInt8> LodBoneMask { get; set; }
		[Ordinal(14)]  [RED("lodLevelInfo")] public CArray<CFloat> LodLevelInfo { get; set; }
		[Ordinal(15)]  [RED("materialEntries")] public CArray<CMeshMaterialEntry> MaterialEntries { get; set; }
		[Ordinal(16)]  [RED("objectType")] public CEnum<ERenderObjectType> ObjectType { get; set; }
		[Ordinal(17)]  [RED("parameters")] public CArray<CHandle<meshMeshParameter>> Parameters { get; set; }
		[Ordinal(18)]  [RED("preloadExternalMaterials")] public CArray<rRef<IMaterial>> PreloadExternalMaterials { get; set; }
		[Ordinal(19)]  [RED("preloadLocalMaterialInstances")] public CArray<CHandle<IMaterial>> PreloadLocalMaterialInstances { get; set; }
		[Ordinal(20)]  [RED("renderResourceBlob")] public CHandle<IRenderResourceBlob> RenderResourceBlob { get; set; }
		[Ordinal(21)]  [RED("surfaceAreaPerAxis")] public Vector3 SurfaceAreaPerAxis { get; set; }

		public CMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

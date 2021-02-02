using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldProxyMeshBuildParams : CVariable
	{
		[Ordinal(0)]  [RED("buildProxy")] public CBool BuildProxy { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<worldProxyMeshBuildType> Type { get; set; }
		[Ordinal(2)]  [RED("usedMesh")] public CEnum<worldProxyMeshOutputType> UsedMesh { get; set; }
		[Ordinal(3)]  [RED("polycount")] public CUInt32 Polycount { get; set; }
		[Ordinal(4)]  [RED("polycountPercentage")] public CFloat PolycountPercentage { get; set; }
		[Ordinal(5)]  [RED("resolution")] public CUInt32 Resolution { get; set; }
		[Ordinal(6)]  [RED("coreAxis")] public CEnum<worldProxyCoreAxis> CoreAxis { get; set; }
		[Ordinal(7)]  [RED("groupingNormals")] public CEnum<worldProxyGroupingNormals> GroupingNormals { get; set; }
		[Ordinal(8)]  [RED("forceSurfaceFlattening")] public CBool ForceSurfaceFlattening { get; set; }
		[Ordinal(9)]  [RED("forceSeamlessModule")] public CBool ForceSeamlessModule { get; set; }
		[Ordinal(10)]  [RED("enableAlphaMask")] public CBool EnableAlphaMask { get; set; }
		[Ordinal(11)]  [RED("windows")] public worldProxyWindowsParams Windows { get; set; }
		[Ordinal(12)]  [RED("textures")] public worldProxyTextureParams Textures { get; set; }
		[Ordinal(13)]  [RED("customGeometry")] public worldProxyCustomGeometryParams CustomGeometry { get; set; }
		[Ordinal(14)]  [RED("advancedParams")] public worldProxyMeshAdvancedBuildParams AdvancedParams { get; set; }

		public worldProxyMeshBuildParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

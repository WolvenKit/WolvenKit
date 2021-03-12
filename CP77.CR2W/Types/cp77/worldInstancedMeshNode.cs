using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldInstancedMeshNode : worldNode
	{
		[Ordinal(4)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(5)] [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(6)] [RED("castShadows")] public CBool CastShadows { get; set; }
		[Ordinal(7)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
		[Ordinal(8)] [RED("occluderType")] public CEnum<visWorldOccluderType> OccluderType { get; set; }
		[Ordinal(9)] [RED("meshLODScales")] public CUInt32 MeshLODScales { get; set; }
		[Ordinal(10)] [RED("occluderAutohideDistanceScale")] public CUInt8 OccluderAutohideDistanceScale { get; set; }
		[Ordinal(11)] [RED("worldTransformsBuffer")] public worldRenderProxyTransformBuffer WorldTransformsBuffer { get; set; }

		public worldInstancedMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

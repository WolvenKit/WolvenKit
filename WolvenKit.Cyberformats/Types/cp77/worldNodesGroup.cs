using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldNodesGroup : ISerializable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("id")] public CUInt64 Id { get; set; }
		[Ordinal(2)] [RED("groupUniqueId")] public CRUID GroupUniqueId { get; set; }
		[Ordinal(3)] [RED("nodes")] public CArray<CHandle<worldNode>> Nodes { get; set; }
		[Ordinal(4)] [RED("subGroups")] public CArray<CHandle<worldNodesGroup>> SubGroups { get; set; }
		[Ordinal(5)] [RED("type")] public CEnum<worldNodeGroupType> Type { get; set; }
		[Ordinal(6)] [RED("keepPosition")] public CBool KeepPosition { get; set; }
		[Ordinal(7)] [RED("transform")] public Transform Transform { get; set; }
		[Ordinal(8)] [RED("transformCalculated")] public CBool TransformCalculated { get; set; }
		[Ordinal(9)] [RED("customPivotOffset")] public Transform CustomPivotOffset { get; set; }
		[Ordinal(10)] [RED("proxyMeshGroupBuildParams")] public worldProxyMeshGroupBuildParams ProxyMeshGroupBuildParams { get; set; }
		[Ordinal(11)] [RED("proxyMesh")] public raRef<CMesh> ProxyMesh { get; set; }
		[Ordinal(12)] [RED("proxyDistanceFactor")] public CFloat ProxyDistanceFactor { get; set; }
		[Ordinal(13)] [RED("metadataArray")] public CArray<CHandle<worldPrefabMetadata>> MetadataArray { get; set; }

		public worldNodesGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

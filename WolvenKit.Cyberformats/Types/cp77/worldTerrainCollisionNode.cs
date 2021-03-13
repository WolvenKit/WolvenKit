using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTerrainCollisionNode : worldNode
	{
		[Ordinal(4)] [RED("materials")] public CArray<CName> Materials { get; set; }
		[Ordinal(5)] [RED("materialIndices")] public CArray<CUInt8> MaterialIndices { get; set; }
		[Ordinal(6)] [RED("heightfieldGeometry")] public serializationDeferredDataBuffer HeightfieldGeometry { get; set; }
		[Ordinal(7)] [RED("actorTransform")] public WorldTransform ActorTransform { get; set; }
		[Ordinal(8)] [RED("extents")] public Vector4 Extents { get; set; }
		[Ordinal(9)] [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
		[Ordinal(10)] [RED("rowScale")] public CFloat RowScale { get; set; }
		[Ordinal(11)] [RED("columnScale")] public CFloat ColumnScale { get; set; }
		[Ordinal(12)] [RED("heightScale")] public CFloat HeightScale { get; set; }
		[Ordinal(13)] [RED("increaseStreamingDistance")] public CBool IncreaseStreamingDistance { get; set; }

		public worldTerrainCollisionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

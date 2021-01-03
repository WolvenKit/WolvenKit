using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTerrainCollisionNode : worldNode
	{
		[Ordinal(0)]  [RED("actorTransform")] public WorldTransform ActorTransform { get; set; }
		[Ordinal(1)]  [RED("columnScale")] public CFloat ColumnScale { get; set; }
		[Ordinal(2)]  [RED("extents")] public Vector4 Extents { get; set; }
		[Ordinal(3)]  [RED("heightScale")] public CFloat HeightScale { get; set; }
		[Ordinal(4)]  [RED("heightfieldGeometry")] public serializationDeferredDataBuffer HeightfieldGeometry { get; set; }
		[Ordinal(5)]  [RED("increaseStreamingDistance")] public CBool IncreaseStreamingDistance { get; set; }
		[Ordinal(6)]  [RED("materialIndices")] public CArray<CUInt8> MaterialIndices { get; set; }
		[Ordinal(7)]  [RED("materials")] public CArray<CName> Materials { get; set; }
		[Ordinal(8)]  [RED("rowScale")] public CFloat RowScale { get; set; }
		[Ordinal(9)]  [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }

		public worldTerrainCollisionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

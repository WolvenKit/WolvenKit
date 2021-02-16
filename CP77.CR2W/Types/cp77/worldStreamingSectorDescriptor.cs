using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStreamingSectorDescriptor : CVariable
	{
		[Ordinal(0)] [RED("data")] public raRef<worldStreamingSector> Data { get; set; }
		[Ordinal(1)] [RED("streamingBox")] public Box StreamingBox { get; set; }
		[Ordinal(2)] [RED("questPrefabNodeRef")] public NodeRef QuestPrefabNodeRef { get; set; }
		[Ordinal(3)] [RED("numNodeRanges")] public CUInt32 NumNodeRanges { get; set; }
		[Ordinal(4)] [RED("variants")] public CArray<worldStreamingSectorVariant> Variants { get; set; }
		[Ordinal(5)] [RED("sectorIndex")] public CUInt32 SectorIndex { get; set; }
		[Ordinal(6)] [RED("level")] public CUInt32 Level { get; set; }

		public worldStreamingSectorDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

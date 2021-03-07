using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldFoliageDestructionNode : worldCollisionNode
	{
		[Ordinal(18)] [RED("populationIndex")] public CArray<CUInt32> PopulationIndex { get; set; }
		[Ordinal(19)] [RED("foliageResourceHash")] public CUInt64 FoliageResourceHash { get; set; }
		[Ordinal(20)] [RED("dataVersion")] public CUInt32 DataVersion { get; set; }

		public worldFoliageDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

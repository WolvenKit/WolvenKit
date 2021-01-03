using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldFoliageDestructionNode : worldCollisionNode
	{
		[Ordinal(0)]  [RED("dataVersion")] public CUInt32 DataVersion { get; set; }
		[Ordinal(1)]  [RED("foliageResourceHash")] public CUInt64 FoliageResourceHash { get; set; }
		[Ordinal(2)]  [RED("populationIndex")] public CArray<CUInt32> PopulationIndex { get; set; }

		public worldFoliageDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

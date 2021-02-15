using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsDestructionLevelData : CVariable
	{
		[Ordinal(0)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(1)] [RED("fracturingEffect")] public raRef<worldEffect> FracturingEffect { get; set; }

		public physicsDestructionLevelData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldFoliagePopulationSpanInfo : CVariable
	{
		[Ordinal(0)]  [RED("stancesBegin")] public CUInt32 StancesBegin { get; set; }
		[Ordinal(1)]  [RED("cketBegin")] public CUInt32 CketBegin { get; set; }
		[Ordinal(2)]  [RED("stancesCount")] public CUInt32 StancesCount { get; set; }
		[Ordinal(3)]  [RED("cketCount")] public CUInt32 CketCount { get; set; }

		public worldFoliagePopulationSpanInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

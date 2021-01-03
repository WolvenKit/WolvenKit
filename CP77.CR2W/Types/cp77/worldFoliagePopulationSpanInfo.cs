using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldFoliagePopulationSpanInfo : CVariable
	{
		[Ordinal(0)]  [RED("cketBegin")] public CUInt32 CketBegin { get; set; }
		[Ordinal(1)]  [RED("cketCount")] public CUInt32 CketCount { get; set; }
		[Ordinal(2)]  [RED("stancesBegin")] public CUInt32 StancesBegin { get; set; }
		[Ordinal(3)]  [RED("stancesCount")] public CUInt32 StancesCount { get; set; }

		public worldFoliagePopulationSpanInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

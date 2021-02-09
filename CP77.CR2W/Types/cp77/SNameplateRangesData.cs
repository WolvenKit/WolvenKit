using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SNameplateRangesData : CVariable
	{
		[Ordinal(0)]  [RED("c_DisplayRange")] public CFloat C_DisplayRange { get; set; }
		[Ordinal(1)]  [RED("c_MaxDisplayRange")] public CFloat C_MaxDisplayRange { get; set; }
		[Ordinal(2)]  [RED("c_MaxDisplayRangeNotAggressive")] public CFloat C_MaxDisplayRangeNotAggressive { get; set; }
		[Ordinal(3)]  [RED("c_DisplayRangeNotAggressive")] public CFloat C_DisplayRangeNotAggressive { get; set; }

		public SNameplateRangesData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

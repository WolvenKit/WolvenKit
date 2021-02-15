using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSmoothFloatClamp : CVariable
	{
		[Ordinal(0)] [RED("min")] public CFloat Min { get; set; }
		[Ordinal(1)] [RED("max")] public CFloat Max { get; set; }
		[Ordinal(2)] [RED("marginEaseOutCurve")] public curveData<CFloat> MarginEaseOutCurve { get; set; }

		public animSmoothFloatClamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

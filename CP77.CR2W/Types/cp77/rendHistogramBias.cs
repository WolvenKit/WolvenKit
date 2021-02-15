using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendHistogramBias : CVariable
	{
		[Ordinal(0)] [RED("mulCoef")] public Vector3 MulCoef { get; set; }
		[Ordinal(1)] [RED("addCoef")] public Vector3 AddCoef { get; set; }

		public rendHistogramBias(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

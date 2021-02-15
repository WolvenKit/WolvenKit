using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimPaddingInterpolator : inkanimInterpolator
	{
		[Ordinal(7)] [RED("startValue")] public inkMargin StartValue { get; set; }
		[Ordinal(8)] [RED("endValue")] public inkMargin EndValue { get; set; }

		public inkanimPaddingInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

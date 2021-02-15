using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimRotationInterpolator : inkanimInterpolator
	{
		[Ordinal(7)] [RED("startValue")] public CFloat StartValue { get; set; }
		[Ordinal(8)] [RED("endValue")] public CFloat EndValue { get; set; }
		[Ordinal(9)] [RED("goShortPath")] public CBool GoShortPath { get; set; }

		public inkanimRotationInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

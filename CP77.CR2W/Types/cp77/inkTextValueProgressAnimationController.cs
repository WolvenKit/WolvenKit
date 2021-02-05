using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkTextValueProgressAnimationController : inkTextAnimationController
	{
		[Ordinal(0)]  [RED("baseValue")] public CFloat BaseValue { get; set; }
		[Ordinal(1)]  [RED("targetValue")] public CFloat TargetValue { get; set; }
		[Ordinal(2)]  [RED("numbersAfterDot")] public CInt32 NumbersAfterDot { get; set; }
		[Ordinal(3)]  [RED("stepValue")] public CFloat StepValue { get; set; }
		[Ordinal(4)]  [RED("suffix")] public CString Suffix { get; set; }

		public inkTextValueProgressAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

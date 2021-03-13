using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextValueProgressAnimationController : inkTextAnimationController
	{
		[Ordinal(8)] [RED("baseValue")] public CFloat BaseValue { get; set; }
		[Ordinal(9)] [RED("targetValue")] public CFloat TargetValue { get; set; }
		[Ordinal(10)] [RED("numbersAfterDot")] public CInt32 NumbersAfterDot { get; set; }
		[Ordinal(11)] [RED("stepValue")] public CFloat StepValue { get; set; }
		[Ordinal(12)] [RED("suffix")] public CString Suffix { get; set; }

		public inkTextValueProgressAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EasingFunction : CVariable
	{
		[Ordinal(0)]  [RED("transitionType")] public CEnum<ETransitionType> TransitionType { get; set; }
		[Ordinal(1)]  [RED("easingType")] public CEnum<EEasingType> EasingType { get; set; }

		public EasingFunction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

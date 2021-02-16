using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionInterpolator_Blend_ : animIAnimStateTransitionInterpolator
	{
		[Ordinal(0)] [RED("interpolationType")] public CEnum<animAnimStateInterpolationType> InterpolationType { get; set; }

		public animAnimStateTransitionInterpolator_Blend_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

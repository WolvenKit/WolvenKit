using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_HasAnimation : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] [RED("animationName")] public CName AnimationName { get; set; }

		public animAnimStateTransitionCondition_HasAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

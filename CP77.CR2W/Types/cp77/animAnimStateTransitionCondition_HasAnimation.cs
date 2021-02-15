using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_HasAnimation : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] [RED("animationName")] public CName AnimationName { get; set; }

		public animAnimStateTransitionCondition_HasAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_HasAnimation : animIAnimStateTransitionCondition
	{
		[Ordinal(0)]  [RED("animationName")] public CName AnimationName { get; set; }

		public animAnimStateTransitionCondition_HasAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

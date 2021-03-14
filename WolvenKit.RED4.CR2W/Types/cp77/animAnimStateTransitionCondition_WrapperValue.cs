using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_WrapperValue : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] [RED("wrapperName")] public CName WrapperName { get; set; }
		[Ordinal(1)] [RED("checkIfWrapperIsSet")] public CBool CheckIfWrapperIsSet { get; set; }

		public animAnimStateTransitionCondition_WrapperValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

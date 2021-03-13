using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateMachineConditionalEntry : ISerializable
	{
		[Ordinal(0)] [RED("targetStateIndex")] public CUInt32 TargetStateIndex { get; set; }
		[Ordinal(1)] [RED("condition")] public CHandle<animIAnimStateTransitionCondition> Condition { get; set; }
		[Ordinal(2)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)] [RED("priority")] public CInt32 Priority { get; set; }
		[Ordinal(4)] [RED("isForcedToTrue")] public CBool IsForcedToTrue { get; set; }

		public animAnimStateMachineConditionalEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

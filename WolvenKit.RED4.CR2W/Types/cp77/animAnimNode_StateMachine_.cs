using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StateMachine_ : animAnimNode_Base
	{
		[Ordinal(11)] [RED("states")] public CArray<CHandle<animAnimNode_State>> States { get; set; }
		[Ordinal(12)] [RED("frozenState")] public CHandle<animAnimNode_StateFrozen> FrozenState { get; set; }
		[Ordinal(13)] [RED("transitions")] public CArray<CHandle<animAnimStateTransitionDescription>> Transitions { get; set; }
		[Ordinal(14)] [RED("conditionalEntries")] public CArray<CHandle<animAnimStateMachineConditionalEntry>> ConditionalEntries { get; set; }
		[Ordinal(15)] [RED("globalTransitions")] public CArray<CHandle<animAnimStateTransitionDescription>> GlobalTransitions { get; set; }
		[Ordinal(16)] [RED("anyStateInterpolator")] public CHandle<animIAnimStateTransitionInterpolator> AnyStateInterpolator { get; set; }
		[Ordinal(17)] [RED("defaultStateIndex")] public CUInt32 DefaultStateIndex { get; set; }
		[Ordinal(18)] [RED("notifyOnEnterState")] public CBool NotifyOnEnterState { get; set; }

		public animAnimNode_StateMachine_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

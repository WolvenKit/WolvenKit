using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StateMachine : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("anyStateInterpolator")] public CHandle<animIAnimStateTransitionInterpolator> AnyStateInterpolator { get; set; }
		[Ordinal(1)]  [RED("conditionalEntries")] public CArray<CHandle<animAnimStateMachineConditionalEntry>> ConditionalEntries { get; set; }
		[Ordinal(2)]  [RED("defaultStateIndex")] public CUInt32 DefaultStateIndex { get; set; }
		[Ordinal(3)]  [RED("frozenState")] public CHandle<animAnimNode_StateFrozen> FrozenState { get; set; }
		[Ordinal(4)]  [RED("globalTransitions")] public CArray<CHandle<animAnimStateTransitionDescription>> GlobalTransitions { get; set; }
		[Ordinal(5)]  [RED("notifyOnEnterState")] public CBool NotifyOnEnterState { get; set; }
		[Ordinal(6)]  [RED("states")] public CArray<CHandle<animAnimNode_State>> States { get; set; }
		[Ordinal(7)]  [RED("transitions")] public CArray<CHandle<animAnimStateTransitionDescription>> Transitions { get; set; }

        [Ordinal(999)] [RED("debugFlag")] public CBool debugFlag { get; set; }

		public animAnimNode_StateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

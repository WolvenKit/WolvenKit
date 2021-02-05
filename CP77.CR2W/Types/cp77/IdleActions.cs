using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IdleActions : TweakAIActionSmartComposite
	{
		[Ordinal(0)]  [RED("actionDebugName")] public CString ActionDebugName { get; set; }
		[Ordinal(1)]  [RED("actionRecord")] public wCHandle<gamedataAIAction_Record> ActionRecord { get; set; }
		[Ordinal(2)]  [RED("actionActivationTimeStamp")] public CFloat ActionActivationTimeStamp { get; set; }
		[Ordinal(3)]  [RED("startActionTimeStamp")] public CFloat StartActionTimeStamp { get; set; }
		[Ordinal(4)]  [RED("actionPhase")] public CEnum<EAIActionPhase> ActionPhase { get; set; }
		[Ordinal(5)]  [RED("phaseRecord")] public wCHandle<gamedataAIActionPhase_Record> PhaseRecord { get; set; }
		[Ordinal(6)]  [RED("nextPhaseConditionCount")] public CInt32 NextPhaseConditionCount { get; set; }
		[Ordinal(7)]  [RED("repeatPhaseConditionCount")] public CInt32 RepeatPhaseConditionCount { get; set; }
		[Ordinal(8)]  [RED("phaseActivationTimeStamp")] public CFloat PhaseActivationTimeStamp { get; set; }
		[Ordinal(9)]  [RED("phaseConditionSuccessfulCheckTimeStamp")] public CFloat PhaseConditionSuccessfulCheckTimeStamp { get; set; }
		[Ordinal(10)]  [RED("phaseConditionCheckTimeStamp")] public CFloat PhaseConditionCheckTimeStamp { get; set; }
		[Ordinal(11)]  [RED("phaseConditionCheckRandomizedInterval")] public CFloat PhaseConditionCheckRandomizedInterval { get; set; }
		[Ordinal(12)]  [RED("phaseIteration")] public CUInt32 PhaseIteration { get; set; }
		[Ordinal(13)]  [RED("phaseDuration")] public CFloat PhaseDuration { get; set; }
		[Ordinal(14)]  [RED("phaseAnimationDuration")] public CFloat PhaseAnimationDuration { get; set; }
		[Ordinal(15)]  [RED("lookatEvents")] public CArray<CHandle<entLookAtAddEvent>> LookatEvents { get; set; }
		[Ordinal(16)]  [RED("movePolicy")] public CHandle<movePolicies> MovePolicy { get; set; }
		[Ordinal(17)]  [RED("generalSubActionsResults", 8)] public CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> GeneralSubActionsResults { get; set; }
		[Ordinal(18)]  [RED("phaseSubActionsResults", 8)] public CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> PhaseSubActionsResults { get; set; }
		[Ordinal(19)]  [RED("lookatActivated")] public CBool LookatActivated { get; set; }
		[Ordinal(20)]  [RED("ticketsCommited")] public CBool TicketsCommited { get; set; }
		[Ordinal(21)]  [RED("ticketsAcknowledged")] public CBool TicketsAcknowledged { get; set; }
		[Ordinal(22)]  [RED("failureStatus")] public CBool FailureStatus { get; set; }
		[Ordinal(23)]  [RED("animationLoaded")] public CBool AnimationLoaded { get; set; }
		[Ordinal(24)]  [RED("gracefullyInterrupted")] public CBool GracefullyInterrupted { get; set; }
		[Ordinal(25)]  [RED("initializedAfterActivation")] public CBool InitializedAfterActivation { get; set; }
		[Ordinal(26)]  [RED("shouldCallGetActionRecordAgain")] public CBool ShouldCallGetActionRecordAgain { get; set; }
		[Ordinal(27)]  [RED("smartComposite")] public TweakDBID SmartComposite { get; set; }
		[Ordinal(28)]  [RED("smartCompositeRecord")] public wCHandle<gamedataAIActionSmartComposite_Record> SmartCompositeRecord { get; set; }
		[Ordinal(29)]  [RED("interruptionRequested")] public CBool InterruptionRequested { get; set; }
		[Ordinal(30)]  [RED("conditionSuccessfulCheckTimeStamp")] public CFloat ConditionSuccessfulCheckTimeStamp { get; set; }
		[Ordinal(31)]  [RED("conditionCheckTimeStamp")] public CFloat ConditionCheckTimeStamp { get; set; }
		[Ordinal(32)]  [RED("conditionCheckRandomizedInterval")] public CFloat ConditionCheckRandomizedInterval { get; set; }
		[Ordinal(33)]  [RED("iteration")] public CUInt32 Iteration { get; set; }
		[Ordinal(34)]  [RED("nodeIterator")] public CInt32 NodeIterator { get; set; }
		[Ordinal(35)]  [RED("currentNodeIterator")] public CInt32 CurrentNodeIterator { get; set; }
		[Ordinal(36)]  [RED("currentNodeType")] public CEnum<ETweakAINodeType> CurrentNodeType { get; set; }
		[Ordinal(37)]  [RED("currentNode")] public wCHandle<gamedataAINode_Record> CurrentNode { get; set; }

		public IdleActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

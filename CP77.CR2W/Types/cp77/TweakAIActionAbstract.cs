using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionAbstract : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("actionActivationTimeStamp")] public CFloat ActionActivationTimeStamp { get; set; }
		[Ordinal(1)]  [RED("actionDebugName")] public CString ActionDebugName { get; set; }
		[Ordinal(2)]  [RED("actionPhase")] public CEnum<EAIActionPhase> ActionPhase { get; set; }
		[Ordinal(3)]  [RED("actionRecord")] public wCHandle<gamedataAIAction_Record> ActionRecord { get; set; }
		[Ordinal(4)]  [RED("animationLoaded")] public CBool AnimationLoaded { get; set; }
		[Ordinal(5)]  [RED("failureStatus")] public CBool FailureStatus { get; set; }
		[Ordinal(6)]  [RED("generalSubActionsResults")] public [8]AIbehaviorUpdateOutcome GeneralSubActionsResults { get; set; }
		[Ordinal(7)]  [RED("gracefullyInterrupted")] public CBool GracefullyInterrupted { get; set; }
		[Ordinal(8)]  [RED("initializedAfterActivation")] public CBool InitializedAfterActivation { get; set; }
		[Ordinal(9)]  [RED("lookatActivated")] public CBool LookatActivated { get; set; }
		[Ordinal(10)]  [RED("lookatEvents")] public CArray<CHandle<entLookAtAddEvent>> LookatEvents { get; set; }
		[Ordinal(11)]  [RED("movePolicy")] public CHandle<movePolicies> MovePolicy { get; set; }
		[Ordinal(12)]  [RED("nextPhaseConditionCount")] public CInt32 NextPhaseConditionCount { get; set; }
		[Ordinal(13)]  [RED("phaseActivationTimeStamp")] public CFloat PhaseActivationTimeStamp { get; set; }
		[Ordinal(14)]  [RED("phaseAnimationDuration")] public CFloat PhaseAnimationDuration { get; set; }
		[Ordinal(15)]  [RED("phaseConditionCheckRandomizedInterval")] public CFloat PhaseConditionCheckRandomizedInterval { get; set; }
		[Ordinal(16)]  [RED("phaseConditionCheckTimeStamp")] public CFloat PhaseConditionCheckTimeStamp { get; set; }
		[Ordinal(17)]  [RED("phaseConditionSuccessfulCheckTimeStamp")] public CFloat PhaseConditionSuccessfulCheckTimeStamp { get; set; }
		[Ordinal(18)]  [RED("phaseDuration")] public CFloat PhaseDuration { get; set; }
		[Ordinal(19)]  [RED("phaseIteration")] public CUInt32 PhaseIteration { get; set; }
		[Ordinal(20)]  [RED("phaseRecord")] public wCHandle<gamedataAIActionPhase_Record> PhaseRecord { get; set; }
		[Ordinal(21)]  [RED("phaseSubActionsResults")] public [8]AIbehaviorUpdateOutcome PhaseSubActionsResults { get; set; }
		[Ordinal(22)]  [RED("repeatPhaseConditionCount")] public CInt32 RepeatPhaseConditionCount { get; set; }
		[Ordinal(23)]  [RED("shouldCallGetActionRecordAgain")] public CBool ShouldCallGetActionRecordAgain { get; set; }
		[Ordinal(24)]  [RED("startActionTimeStamp")] public CFloat StartActionTimeStamp { get; set; }
		[Ordinal(25)]  [RED("ticketsAcknowledged")] public CBool TicketsAcknowledged { get; set; }
		[Ordinal(26)]  [RED("ticketsCommited")] public CBool TicketsCommited { get; set; }

		public TweakAIActionAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

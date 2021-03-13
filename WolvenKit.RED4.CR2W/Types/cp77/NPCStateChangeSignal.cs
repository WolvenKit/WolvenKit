using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCStateChangeSignal : gameTaggedSignalUserData
	{
		[Ordinal(1)] [RED("highLevelState")] public CEnum<gamedataNPCHighLevelState> HighLevelState { get; set; }
		[Ordinal(2)] [RED("highLevelStateValid")] public CBool HighLevelStateValid { get; set; }
		[Ordinal(3)] [RED("upperBodyState")] public CEnum<gamedataNPCUpperBodyState> UpperBodyState { get; set; }
		[Ordinal(4)] [RED("upperBodyStateValid")] public CBool UpperBodyStateValid { get; set; }
		[Ordinal(5)] [RED("stanceState")] public CEnum<gamedataNPCStanceState> StanceState { get; set; }
		[Ordinal(6)] [RED("stanceStateValid")] public CBool StanceStateValid { get; set; }
		[Ordinal(7)] [RED("hitReactionModeState")] public CEnum<EHitReactionMode> HitReactionModeState { get; set; }
		[Ordinal(8)] [RED("hitReactionModeStateValid")] public CBool HitReactionModeStateValid { get; set; }
		[Ordinal(9)] [RED("defenseMode")] public CEnum<gamedataDefenseMode> DefenseMode { get; set; }
		[Ordinal(10)] [RED("defenseModeValid")] public CBool DefenseModeValid { get; set; }
		[Ordinal(11)] [RED("locomotionMode")] public CEnum<gamedataLocomotionMode> LocomotionMode { get; set; }
		[Ordinal(12)] [RED("locomotionModeValid")] public CBool LocomotionModeValid { get; set; }
		[Ordinal(13)] [RED("behaviorState")] public CEnum<gamedataNPCBehaviorState> BehaviorState { get; set; }
		[Ordinal(14)] [RED("behaviorStateValid")] public CBool BehaviorStateValid { get; set; }
		[Ordinal(15)] [RED("phaseState")] public CEnum<ENPCPhaseState> PhaseState { get; set; }
		[Ordinal(16)] [RED("phaseStateValid")] public CBool PhaseStateValid { get; set; }

		public NPCStateChangeSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

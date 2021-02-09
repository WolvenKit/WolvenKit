using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCStatesComponent : gameAINetStateComponent
	{
		[Ordinal(0)]  [RED("aimingLookatEvent")] public CHandle<entLookAtAddEvent> AimingLookatEvent { get; set; }
		[Ordinal(1)]  [RED("highLevelAnimFeatureName")] public CName HighLevelAnimFeatureName { get; set; }
		[Ordinal(2)]  [RED("upperBodyAnimFeatureName")] public CName UpperBodyAnimFeatureName { get; set; }
		[Ordinal(3)]  [RED("stanceAnimFeatureName")] public CName StanceAnimFeatureName { get; set; }
		[Ordinal(4)]  [RED("statFlagDefensiveState")] public CHandle<gameStatModifierData> StatFlagDefensiveState { get; set; }
		[Ordinal(5)]  [RED("prevNPCStanceState")] public CEnum<gamedataNPCStanceState> PrevNPCStanceState { get; set; }
		[Ordinal(6)]  [RED("previousHighLevelState")] public CEnum<gamedataNPCHighLevelState> PreviousHighLevelState { get; set; }
		[Ordinal(7)]  [RED("prevHitReactionMode")] public CEnum<EHitReactionMode> PrevHitReactionMode { get; set; }
		[Ordinal(8)]  [RED("bulkyStaggerMinRecordID")] public TweakDBID BulkyStaggerMinRecordID { get; set; }
		[Ordinal(9)]  [RED("staggerMinRecordID")] public TweakDBID StaggerMinRecordID { get; set; }
		[Ordinal(10)]  [RED("unstoppableRecordID")] public TweakDBID UnstoppableRecordID { get; set; }
		[Ordinal(11)]  [RED("unstoppableTwitchMinRecordID")] public TweakDBID UnstoppableTwitchMinRecordID { get; set; }
		[Ordinal(12)]  [RED("unstoppableTwitchNoneRecordID")] public TweakDBID UnstoppableTwitchNoneRecordID { get; set; }
		[Ordinal(13)]  [RED("forceImpactRecordID")] public TweakDBID ForceImpactRecordID { get; set; }
		[Ordinal(14)]  [RED("forceStaggerRecordID")] public TweakDBID ForceStaggerRecordID { get; set; }
		[Ordinal(15)]  [RED("forceKnockdownRecordID")] public TweakDBID ForceKnockdownRecordID { get; set; }
		[Ordinal(16)]  [RED("fragileRecordID")] public TweakDBID FragileRecordID { get; set; }
		[Ordinal(17)]  [RED("weakRecordID")] public TweakDBID WeakRecordID { get; set; }
		[Ordinal(18)]  [RED("toughRecordID")] public TweakDBID ToughRecordID { get; set; }
		[Ordinal(19)]  [RED("bulkyRecordID")] public TweakDBID BulkyRecordID { get; set; }
		[Ordinal(20)]  [RED("regularRecordID")] public TweakDBID RegularRecordID { get; set; }
		[Ordinal(21)]  [RED("inCombat")] public CBool InCombat { get; set; }

		public NPCStatesComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

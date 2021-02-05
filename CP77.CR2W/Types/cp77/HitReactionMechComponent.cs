using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitReactionMechComponent : HitReactionComponent
	{
		[Ordinal(0)]  [RED("impactDamageDuration")] public CFloat ImpactDamageDuration { get; set; }
		[Ordinal(1)]  [RED("staggerDamageDuration")] public CFloat StaggerDamageDuration { get; set; }
		[Ordinal(2)]  [RED("impactDamageDurationMelee")] public CFloat ImpactDamageDurationMelee { get; set; }
		[Ordinal(3)]  [RED("staggerDamageDurationMelee")] public CFloat StaggerDamageDurationMelee { get; set; }
		[Ordinal(4)]  [RED("knockdownDamageDuration")] public CFloat KnockdownDamageDuration { get; set; }
		[Ordinal(5)]  [RED("defeatedMinDuration")] public CFloat DefeatedMinDuration { get; set; }
		[Ordinal(6)]  [RED("previousHitTime")] public CFloat PreviousHitTime { get; set; }
		[Ordinal(7)]  [RED("reactionType")] public CEnum<animHitReactionType> ReactionType { get; set; }
		[Ordinal(8)]  [RED("animHitReaction")] public CHandle<animAnimFeature_HitReactionsData> AnimHitReaction { get; set; }
		[Ordinal(9)]  [RED("lastAnimHitReaction")] public CHandle<animAnimFeature_HitReactionsData> LastAnimHitReaction { get; set; }
		[Ordinal(10)]  [RED("hitReactionAction")] public CHandle<ActionHitReactionScriptProxy> HitReactionAction { get; set; }
		[Ordinal(11)]  [RED("previousAnimHitReactionArray")] public CArray<ScriptHitData> PreviousAnimHitReactionArray { get; set; }
		[Ordinal(12)]  [RED("lastHitReactionPlayed")] public CEnum<EAILastHitReactionPlayed> LastHitReactionPlayed { get; set; }
		[Ordinal(13)]  [RED("hitShapeData")] public gameShapeData HitShapeData { get; set; }
		[Ordinal(14)]  [RED("animVariation")] public CInt32 AnimVariation { get; set; }
		[Ordinal(15)]  [RED("specificHitTimeout")] public CFloat SpecificHitTimeout { get; set; }
		[Ordinal(16)]  [RED("quickMeleeCooldown")] public CFloat QuickMeleeCooldown { get; set; }
		[Ordinal(17)]  [RED("dismembermentBodyPartDamageThreshold")] public CArray<CFloat> DismembermentBodyPartDamageThreshold { get; set; }
		[Ordinal(18)]  [RED("woundedBodyPartDamageThreshold")] public CArray<CFloat> WoundedBodyPartDamageThreshold { get; set; }
		[Ordinal(19)]  [RED("defeatedBodyPartDamageThreshold")] public CArray<CFloat> DefeatedBodyPartDamageThreshold { get; set; }
		[Ordinal(20)]  [RED("impactDamageThreshold")] public CFloat ImpactDamageThreshold { get; set; }
		[Ordinal(21)]  [RED("staggerDamageThreshold")] public CFloat StaggerDamageThreshold { get; set; }
		[Ordinal(22)]  [RED("knockdownDamageThreshold")] public CFloat KnockdownDamageThreshold { get; set; }
		[Ordinal(23)]  [RED("knockdownImpulseThreshold")] public CFloat KnockdownImpulseThreshold { get; set; }
		[Ordinal(24)]  [RED("immuneToKnockDown")] public CBool ImmuneToKnockDown { get; set; }
		[Ordinal(25)]  [RED("hitComboReset")] public CFloat HitComboReset { get; set; }
		[Ordinal(26)]  [RED("physicalImpulseReset")] public CFloat PhysicalImpulseReset { get; set; }
		[Ordinal(27)]  [RED("cumulatedDamages")] public CFloat CumulatedDamages { get; set; }
		[Ordinal(28)]  [RED("bodyPartWoundCumulatedDamages")] public CArray<CFloat> BodyPartWoundCumulatedDamages { get; set; }
		[Ordinal(29)]  [RED("bodyPartDismemberCumulatedDamages")] public CArray<CFloat> BodyPartDismemberCumulatedDamages { get; set; }
		[Ordinal(30)]  [RED("overrideHitReactionImpulse")] public CFloat OverrideHitReactionImpulse { get; set; }
		[Ordinal(31)]  [RED("cumulatedPhysicalImpulse")] public CFloat CumulatedPhysicalImpulse { get; set; }
		[Ordinal(32)]  [RED("comboResetTime")] public CFloat ComboResetTime { get; set; }
		[Ordinal(33)]  [RED("ragdollImpulse")] public CFloat RagdollImpulse { get; set; }
		[Ordinal(34)]  [RED("hitIntensity")] public CEnum<EAIHitIntensity> HitIntensity { get; set; }
		[Ordinal(35)]  [RED("previousMeleeHitTimeStamp")] public CFloat PreviousMeleeHitTimeStamp { get; set; }
		[Ordinal(36)]  [RED("previousRangedHitTimeStamp")] public CFloat PreviousRangedHitTimeStamp { get; set; }
		[Ordinal(37)]  [RED("previousBlockTimeStamp")] public CFloat PreviousBlockTimeStamp { get; set; }
		[Ordinal(38)]  [RED("previousParryTimeStamp")] public CFloat PreviousParryTimeStamp { get; set; }
		[Ordinal(39)]  [RED("previousDodgeTimeStamp")] public CFloat PreviousDodgeTimeStamp { get; set; }
		[Ordinal(40)]  [RED("blockCount")] public CInt32 BlockCount { get; set; }
		[Ordinal(41)]  [RED("parryCount")] public CInt32 ParryCount { get; set; }
		[Ordinal(42)]  [RED("dodgeCount")] public CInt32 DodgeCount { get; set; }
		[Ordinal(43)]  [RED("hitCount")] public CUInt32 HitCount { get; set; }
		[Ordinal(44)]  [RED("defeatedHasBeenPlayed")] public CBool DefeatedHasBeenPlayed { get; set; }
		[Ordinal(45)]  [RED("deathHasBeenPlayed")] public CBool DeathHasBeenPlayed { get; set; }
		[Ordinal(46)]  [RED("deathRegisteredTime")] public CFloat DeathRegisteredTime { get; set; }
		[Ordinal(47)]  [RED("extendedDeathRegisteredTime")] public CFloat ExtendedDeathRegisteredTime { get; set; }
		[Ordinal(48)]  [RED("extendedDeathDelayRegisteredTime")] public CFloat ExtendedDeathDelayRegisteredTime { get; set; }
		[Ordinal(49)]  [RED("disableDismembermentAfterDeathDelay")] public CFloat DisableDismembermentAfterDeathDelay { get; set; }
		[Ordinal(50)]  [RED("extendedHitReactionRegisteredTime")] public CFloat ExtendedHitReactionRegisteredTime { get; set; }
		[Ordinal(51)]  [RED("extendedHitReactionDelayRegisteredTime")] public CFloat ExtendedHitReactionDelayRegisteredTime { get; set; }
		[Ordinal(52)]  [RED("scatteredGuts")] public CBool ScatteredGuts { get; set; }
		[Ordinal(53)]  [RED("cumulativeDamageUpdateInterval")] public CFloat CumulativeDamageUpdateInterval { get; set; }
		[Ordinal(54)]  [RED("cumulativeDamageUpdateRequested")] public CBool CumulativeDamageUpdateRequested { get; set; }
		[Ordinal(55)]  [RED("currentStimId")] public CUInt32 CurrentStimId { get; set; }
		[Ordinal(56)]  [RED("attackData")] public CHandle<gamedamageAttackData> AttackData { get; set; }
		[Ordinal(57)]  [RED("hitPosition")] public Vector4 HitPosition { get; set; }
		[Ordinal(58)]  [RED("hitDirection")] public Vector4 HitDirection { get; set; }
		[Ordinal(59)]  [RED("lastHitReactionBehaviorData")] public CHandle<HitReactionBehaviorData> LastHitReactionBehaviorData { get; set; }
		[Ordinal(60)]  [RED("lastStimName")] public CName LastStimName { get; set; }
		[Ordinal(61)]  [RED("deathStimName")] public CName DeathStimName { get; set; }
		[Ordinal(62)]  [RED("meleeHitCount")] public CInt32 MeleeHitCount { get; set; }
		[Ordinal(63)]  [RED("strongMeleeHitCount")] public CInt32 StrongMeleeHitCount { get; set; }
		[Ordinal(64)]  [RED("maxHitChain")] public CInt32 MaxHitChain { get; set; }
		[Ordinal(65)]  [RED("isAlive")] public CBool IsAlive { get; set; }
		[Ordinal(66)]  [RED("frameDamageHealthFactor")] public CFloat FrameDamageHealthFactor { get; set; }
		[Ordinal(67)]  [RED("hitCountData", 100)] public CArrayFixedSize<CFloat> HitCountData { get; set; }
		[Ordinal(68)]  [RED("hitCountArrayEnd")] public CInt32 HitCountArrayEnd { get; set; }
		[Ordinal(69)]  [RED("hitCountArrayCurrent")] public CInt32 HitCountArrayCurrent { get; set; }
		[Ordinal(70)]  [RED("indicatorEnabledBlackboardId")] public CUInt32 IndicatorEnabledBlackboardId { get; set; }
		[Ordinal(71)]  [RED("hitIndicatorEnabled")] public CBool HitIndicatorEnabled { get; set; }
		[Ordinal(72)]  [RED("hasBeenWounded")] public CBool HasBeenWounded { get; set; }
		[Ordinal(73)]  [RED("hitReactionData")] public CHandle<animAnimFeature_HitReactionsData> HitReactionData { get; set; }

		public HitReactionMechComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

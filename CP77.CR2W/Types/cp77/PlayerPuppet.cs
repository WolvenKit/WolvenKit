using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerPuppet : ScriptedPuppet
	{
		[Ordinal(96)] [RED("quickSlotsManager")] public CHandle<QuickSlotsManager> QuickSlotsManager { get; set; }
		[Ordinal(97)] [RED("inspectionComponent")] public CHandle<InspectionComponent> InspectionComponent { get; set; }
		[Ordinal(98)] [RED("Phone")] public CHandle<PlayerPhone> Phone { get; set; }
		[Ordinal(99)] [RED("fppCameraComponent")] public CHandle<gameFPPCameraComponent> FppCameraComponent { get; set; }
		[Ordinal(100)] [RED("primaryTargetingComponent")] public CHandle<gameTargetingComponent> PrimaryTargetingComponent { get; set; }
		[Ordinal(101)] [RED("DEBUG_Visualizer")] public CHandle<DEBUG_VisualizerComponent> DEBUG_Visualizer { get; set; }
		[Ordinal(102)] [RED("Debug_DamageInputRec")] public CHandle<DEBUG_DamageInputReceiver> Debug_DamageInputRec { get; set; }
		[Ordinal(103)] [RED("highDamageThreshold")] public CFloat HighDamageThreshold { get; set; }
		[Ordinal(104)] [RED("medDamageThreshold")] public CFloat MedDamageThreshold { get; set; }
		[Ordinal(105)] [RED("lowDamageThreshold")] public CFloat LowDamageThreshold { get; set; }
		[Ordinal(106)] [RED("meleeHighDamageThreshold")] public CFloat MeleeHighDamageThreshold { get; set; }
		[Ordinal(107)] [RED("meleeMedDamageThreshold")] public CFloat MeleeMedDamageThreshold { get; set; }
		[Ordinal(108)] [RED("meleeLowDamageThreshold")] public CFloat MeleeLowDamageThreshold { get; set; }
		[Ordinal(109)] [RED("explosionHighDamageThreshold")] public CFloat ExplosionHighDamageThreshold { get; set; }
		[Ordinal(110)] [RED("explosionMedDamageThreshold")] public CFloat ExplosionMedDamageThreshold { get; set; }
		[Ordinal(111)] [RED("explosionLowDamageThreshold")] public CFloat ExplosionLowDamageThreshold { get; set; }
		[Ordinal(112)] [RED("effectTimeStamp")] public CFloat EffectTimeStamp { get; set; }
		[Ordinal(113)] [RED("curInventoryWeight")] public CFloat CurInventoryWeight { get; set; }
		[Ordinal(114)] [RED("healthVfxBlackboard")] public CHandle<worldEffectBlackboard> HealthVfxBlackboard { get; set; }
		[Ordinal(115)] [RED("laserTargettingVfxBlackboard")] public CHandle<worldEffectBlackboard> LaserTargettingVfxBlackboard { get; set; }
		[Ordinal(116)] [RED("itemLogBlackboard")] public CHandle<gameIBlackboard> ItemLogBlackboard { get; set; }
		[Ordinal(117)] [RED("lastScanTarget")] public wCHandle<gameObject> LastScanTarget { get; set; }
		[Ordinal(118)] [RED("meleeSelectInputProcessed")] public CBool MeleeSelectInputProcessed { get; set; }
		[Ordinal(119)] [RED("waitingForDelayEvent")] public CBool WaitingForDelayEvent { get; set; }
		[Ordinal(120)] [RED("randomizedTime")] public CFloat RandomizedTime { get; set; }
		[Ordinal(121)] [RED("isResetting")] public CBool IsResetting { get; set; }
		[Ordinal(122)] [RED("delayEventID")] public gameDelayID DelayEventID { get; set; }
		[Ordinal(123)] [RED("resetTickID")] public gameDelayID ResetTickID { get; set; }
		[Ordinal(124)] [RED("katanaAnimProgression")] public CFloat KatanaAnimProgression { get; set; }
		[Ordinal(125)] [RED("coverModifierActive")] public CBool CoverModifierActive { get; set; }
		[Ordinal(126)] [RED("workspotDamageReductionActive")] public CBool WorkspotDamageReductionActive { get; set; }
		[Ordinal(127)] [RED("workspotVisibilityReductionActive")] public CBool WorkspotVisibilityReductionActive { get; set; }
		[Ordinal(128)] [RED("currentPlayerWorkspotTags")] public CArray<CName> CurrentPlayerWorkspotTags { get; set; }
		[Ordinal(129)] [RED("incapacitated")] public CBool Incapacitated { get; set; }
		[Ordinal(130)] [RED("remoteMappinId")] public gameNewMappinID RemoteMappinId { get; set; }
		[Ordinal(131)] [RED("CPOMissionDataState")] public CHandle<CPOMissionDataState> CPOMissionDataState { get; set; }
		[Ordinal(132)] [RED("CPOMissionDataBbId")] public CUInt32 CPOMissionDataBbId { get; set; }
		[Ordinal(133)] [RED("armorStatListener")] public CHandle<ArmorStatListener> ArmorStatListener { get; set; }
		[Ordinal(134)] [RED("healthStatListener")] public CHandle<HealthStatListener> HealthStatListener { get; set; }
		[Ordinal(135)] [RED("oxygenStatListener")] public CHandle<OxygenStatListener> OxygenStatListener { get; set; }
		[Ordinal(136)] [RED("aimAssistListener")] public CHandle<AimAssistSettingsListener> AimAssistListener { get; set; }
		[Ordinal(137)] [RED("autoRevealListener")] public CHandle<AutoRevealStatListener> AutoRevealListener { get; set; }
		[Ordinal(138)] [RED("isTalkingOnPhone")] public CBool IsTalkingOnPhone { get; set; }
		[Ordinal(139)] [RED("DataDamageUpdateID")] public gameDelayID DataDamageUpdateID { get; set; }
		[Ordinal(140)] [RED("playerAttachedCallbackID")] public CUInt32 PlayerAttachedCallbackID { get; set; }
		[Ordinal(141)] [RED("playerDetachedCallbackID")] public CUInt32 PlayerDetachedCallbackID { get; set; }
		[Ordinal(142)] [RED("combatStateListener")] public CUInt32 CombatStateListener { get; set; }
		[Ordinal(143)] [RED("LocomotionStateListener")] public CUInt32 LocomotionStateListener { get; set; }
		[Ordinal(144)] [RED("numberOfCombatantsListenerID")] public CUInt32 NumberOfCombatantsListenerID { get; set; }
		[Ordinal(145)] [RED("numberOfCombatants")] public CInt32 NumberOfCombatants { get; set; }
		[Ordinal(146)] [RED("zoneChangeListener")] public CUInt32 ZoneChangeListener { get; set; }
		[Ordinal(147)] [RED("coverVisibilityPerkBlocked")] public CBool CoverVisibilityPerkBlocked { get; set; }
		[Ordinal(148)] [RED("behindCover")] public CBool BehindCover { get; set; }
		[Ordinal(149)] [RED("inCombat")] public CBool InCombat { get; set; }
		[Ordinal(150)] [RED("hasBeenDetected")] public CBool HasBeenDetected { get; set; }
		[Ordinal(151)] [RED("inCrouch")] public CBool InCrouch { get; set; }
		[Ordinal(152)] [RED("gunshotRange")] public CFloat GunshotRange { get; set; }
		[Ordinal(153)] [RED("explosionRange")] public CFloat ExplosionRange { get; set; }
		[Ordinal(154)] [RED("nextBufferModifier")] public CInt32 NextBufferModifier { get; set; }
		[Ordinal(155)] [RED("attackingNetrunnerID")] public entEntityID AttackingNetrunnerID { get; set; }
		[Ordinal(156)] [RED("NPCDeathInstigator")] public wCHandle<NPCPuppet> NPCDeathInstigator { get; set; }
		[Ordinal(157)] [RED("bestTargettingWeapon")] public wCHandle<gameweaponObject> BestTargettingWeapon { get; set; }
		[Ordinal(158)] [RED("bestTargettingDot")] public CFloat BestTargettingDot { get; set; }
		[Ordinal(159)] [RED("targettingEnemies")] public CInt32 TargettingEnemies { get; set; }
		[Ordinal(160)] [RED("coverRecordID")] public TweakDBID CoverRecordID { get; set; }
		[Ordinal(161)] [RED("damageReductionRecordID")] public TweakDBID DamageReductionRecordID { get; set; }
		[Ordinal(162)] [RED("visReductionRecordID")] public TweakDBID VisReductionRecordID { get; set; }
		[Ordinal(163)] [RED("lastDmgInflicted")] public EngineTime LastDmgInflicted { get; set; }
		[Ordinal(164)] [RED("lowHealthNextRumbleTime")] public CFloat LowHealthNextRumbleTime { get; set; }
		[Ordinal(165)] [RED("securityAreaTypeE3HACK")] public CEnum<ESecurityAreaType> SecurityAreaTypeE3HACK { get; set; }
		[Ordinal(166)] [RED("overlappedSecurityZones")] public CArray<gamePersistentID> OverlappedSecurityZones { get; set; }
		[Ordinal(167)] [RED("interestingFacts")] public InterestingFacts InterestingFacts { get; set; }
		[Ordinal(168)] [RED("interestingFactsListenersIds")] public InterestingFactsListenersIds InterestingFactsListenersIds { get; set; }
		[Ordinal(169)] [RED("interestingFactsListenersFunctions")] public InterestingFactsListenersFunctions InterestingFactsListenersFunctions { get; set; }
		[Ordinal(170)] [RED("visionModeController")] public CHandle<PlayerVisionModeController> VisionModeController { get; set; }
		[Ordinal(171)] [RED("cachedGameplayRestrictions")] public CArray<TweakDBID> CachedGameplayRestrictions { get; set; }
		[Ordinal(172)] [RED("delayEndGracePeriodAfterSpawnEventID")] public gameDelayID DelayEndGracePeriodAfterSpawnEventID { get; set; }
		[Ordinal(173)] [RED("bossThatTargetsPlayer")] public entEntityID BossThatTargetsPlayer { get; set; }
		[Ordinal(174)] [RED("choiceTokenTextLayerId")] public CUInt32 ChoiceTokenTextLayerId { get; set; }
		[Ordinal(175)] [RED("choiceTokenTextDrawn")] public CBool ChoiceTokenTextDrawn { get; set; }

		public PlayerPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

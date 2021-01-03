using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerPuppet : ScriptedPuppet
	{
		[Ordinal(0)]  [RED("CPOMissionDataBbId")] public CUInt32 CPOMissionDataBbId { get; set; }
		[Ordinal(1)]  [RED("CPOMissionDataState")] public CHandle<CPOMissionDataState> CPOMissionDataState { get; set; }
		[Ordinal(2)]  [RED("DEBUG_Visualizer")] public CHandle<DEBUG_VisualizerComponent> DEBUG_Visualizer { get; set; }
		[Ordinal(3)]  [RED("DataDamageUpdateID")] public gameDelayID DataDamageUpdateID { get; set; }
		[Ordinal(4)]  [RED("Debug_DamageInputRec")] public CHandle<DEBUG_DamageInputReceiver> Debug_DamageInputRec { get; set; }
		[Ordinal(5)]  [RED("LocomotionStateListener")] public CUInt32 LocomotionStateListener { get; set; }
		[Ordinal(6)]  [RED("NPCDeathInstigator")] public wCHandle<NPCPuppet> NPCDeathInstigator { get; set; }
		[Ordinal(7)]  [RED("Phone")] public CHandle<PlayerPhone> Phone { get; set; }
		[Ordinal(8)]  [RED("aimAssistListener")] public CHandle<AimAssistSettingsListener> AimAssistListener { get; set; }
		[Ordinal(9)]  [RED("armorStatListener")] public CHandle<ArmorStatListener> ArmorStatListener { get; set; }
		[Ordinal(10)]  [RED("attackingNetrunnerID")] public entEntityID AttackingNetrunnerID { get; set; }
		[Ordinal(11)]  [RED("autoRevealListener")] public CHandle<AutoRevealStatListener> AutoRevealListener { get; set; }
		[Ordinal(12)]  [RED("behindCover")] public CBool BehindCover { get; set; }
		[Ordinal(13)]  [RED("bestTargettingDot")] public CFloat BestTargettingDot { get; set; }
		[Ordinal(14)]  [RED("bestTargettingWeapon")] public wCHandle<gameweaponObject> BestTargettingWeapon { get; set; }
		[Ordinal(15)]  [RED("bossThatTargetsPlayer")] public entEntityID BossThatTargetsPlayer { get; set; }
		[Ordinal(16)]  [RED("cachedGameplayRestrictions")] public CArray<TweakDBID> CachedGameplayRestrictions { get; set; }
		[Ordinal(17)]  [RED("choiceTokenTextDrawn")] public CBool ChoiceTokenTextDrawn { get; set; }
		[Ordinal(18)]  [RED("choiceTokenTextLayerId")] public CUInt32 ChoiceTokenTextLayerId { get; set; }
		[Ordinal(19)]  [RED("combatStateListener")] public CUInt32 CombatStateListener { get; set; }
		[Ordinal(20)]  [RED("coverModifierActive")] public CBool CoverModifierActive { get; set; }
		[Ordinal(21)]  [RED("coverRecordID")] public TweakDBID CoverRecordID { get; set; }
		[Ordinal(22)]  [RED("coverVisibilityPerkBlocked")] public CBool CoverVisibilityPerkBlocked { get; set; }
		[Ordinal(23)]  [RED("curInventoryWeight")] public CFloat CurInventoryWeight { get; set; }
		[Ordinal(24)]  [RED("currentPlayerWorkspotTags")] public CArray<CName> CurrentPlayerWorkspotTags { get; set; }
		[Ordinal(25)]  [RED("damageReductionRecordID")] public TweakDBID DamageReductionRecordID { get; set; }
		[Ordinal(26)]  [RED("delayEndGracePeriodAfterSpawnEventID")] public gameDelayID DelayEndGracePeriodAfterSpawnEventID { get; set; }
		[Ordinal(27)]  [RED("delayEventID")] public gameDelayID DelayEventID { get; set; }
		[Ordinal(28)]  [RED("effectTimeStamp")] public CFloat EffectTimeStamp { get; set; }
		[Ordinal(29)]  [RED("explosionHighDamageThreshold")] public CFloat ExplosionHighDamageThreshold { get; set; }
		[Ordinal(30)]  [RED("explosionLowDamageThreshold")] public CFloat ExplosionLowDamageThreshold { get; set; }
		[Ordinal(31)]  [RED("explosionMedDamageThreshold")] public CFloat ExplosionMedDamageThreshold { get; set; }
		[Ordinal(32)]  [RED("explosionRange")] public CFloat ExplosionRange { get; set; }
		[Ordinal(33)]  [RED("fppCameraComponent")] public CHandle<gameFPPCameraComponent> FppCameraComponent { get; set; }
		[Ordinal(34)]  [RED("gunshotRange")] public CFloat GunshotRange { get; set; }
		[Ordinal(35)]  [RED("hasBeenDetected")] public CBool HasBeenDetected { get; set; }
		[Ordinal(36)]  [RED("healthStatListener")] public CHandle<HealthStatListener> HealthStatListener { get; set; }
		[Ordinal(37)]  [RED("healthVfxBlackboard")] public CHandle<worldEffectBlackboard> HealthVfxBlackboard { get; set; }
		[Ordinal(38)]  [RED("highDamageThreshold")] public CFloat HighDamageThreshold { get; set; }
		[Ordinal(39)]  [RED("inCombat")] public CBool InCombat { get; set; }
		[Ordinal(40)]  [RED("inCrouch")] public CBool InCrouch { get; set; }
		[Ordinal(41)]  [RED("incapacitated")] public CBool Incapacitated { get; set; }
		[Ordinal(42)]  [RED("inspectionComponent")] public CHandle<InspectionComponent> InspectionComponent { get; set; }
		[Ordinal(43)]  [RED("interestingFacts")] public InterestingFacts InterestingFacts { get; set; }
		[Ordinal(44)]  [RED("interestingFactsListenersFunctions")] public InterestingFactsListenersFunctions InterestingFactsListenersFunctions { get; set; }
		[Ordinal(45)]  [RED("interestingFactsListenersIds")] public InterestingFactsListenersIds InterestingFactsListenersIds { get; set; }
		[Ordinal(46)]  [RED("isResetting")] public CBool IsResetting { get; set; }
		[Ordinal(47)]  [RED("isTalkingOnPhone")] public CBool IsTalkingOnPhone { get; set; }
		[Ordinal(48)]  [RED("itemLogBlackboard")] public CHandle<gameIBlackboard> ItemLogBlackboard { get; set; }
		[Ordinal(49)]  [RED("katanaAnimProgression")] public CFloat KatanaAnimProgression { get; set; }
		[Ordinal(50)]  [RED("laserTargettingVfxBlackboard")] public CHandle<worldEffectBlackboard> LaserTargettingVfxBlackboard { get; set; }
		[Ordinal(51)]  [RED("lastDmgInflicted")] public EngineTime LastDmgInflicted { get; set; }
		[Ordinal(52)]  [RED("lastScanTarget")] public wCHandle<gameObject> LastScanTarget { get; set; }
		[Ordinal(53)]  [RED("lowDamageThreshold")] public CFloat LowDamageThreshold { get; set; }
		[Ordinal(54)]  [RED("lowHealthNextRumbleTime")] public CFloat LowHealthNextRumbleTime { get; set; }
		[Ordinal(55)]  [RED("medDamageThreshold")] public CFloat MedDamageThreshold { get; set; }
		[Ordinal(56)]  [RED("meleeHighDamageThreshold")] public CFloat MeleeHighDamageThreshold { get; set; }
		[Ordinal(57)]  [RED("meleeLowDamageThreshold")] public CFloat MeleeLowDamageThreshold { get; set; }
		[Ordinal(58)]  [RED("meleeMedDamageThreshold")] public CFloat MeleeMedDamageThreshold { get; set; }
		[Ordinal(59)]  [RED("meleeSelectInputProcessed")] public CBool MeleeSelectInputProcessed { get; set; }
		[Ordinal(60)]  [RED("nextBufferModifier")] public CInt32 NextBufferModifier { get; set; }
		[Ordinal(61)]  [RED("numberOfCombatants")] public CInt32 NumberOfCombatants { get; set; }
		[Ordinal(62)]  [RED("numberOfCombatantsListenerID")] public CUInt32 NumberOfCombatantsListenerID { get; set; }
		[Ordinal(63)]  [RED("overlappedSecurityZones")] public CArray<gamePersistentID> OverlappedSecurityZones { get; set; }
		[Ordinal(64)]  [RED("oxygenStatListener")] public CHandle<OxygenStatListener> OxygenStatListener { get; set; }
		[Ordinal(65)]  [RED("playerAttachedCallbackID")] public CUInt32 PlayerAttachedCallbackID { get; set; }
		[Ordinal(66)]  [RED("playerDetachedCallbackID")] public CUInt32 PlayerDetachedCallbackID { get; set; }
		[Ordinal(67)]  [RED("primaryTargetingComponent")] public CHandle<gameTargetingComponent> PrimaryTargetingComponent { get; set; }
		[Ordinal(68)]  [RED("quickSlotsManager")] public CHandle<QuickSlotsManager> QuickSlotsManager { get; set; }
		[Ordinal(69)]  [RED("randomizedTime")] public CFloat RandomizedTime { get; set; }
		[Ordinal(70)]  [RED("remoteMappinId")] public gameNewMappinID RemoteMappinId { get; set; }
		[Ordinal(71)]  [RED("resetTickID")] public gameDelayID ResetTickID { get; set; }
		[Ordinal(72)]  [RED("securityAreaTypeE3HACK")] public CEnum<ESecurityAreaType> SecurityAreaTypeE3HACK { get; set; }
		[Ordinal(73)]  [RED("targettingEnemies")] public CInt32 TargettingEnemies { get; set; }
		[Ordinal(74)]  [RED("visReductionRecordID")] public TweakDBID VisReductionRecordID { get; set; }
		[Ordinal(75)]  [RED("visionModeController")] public CHandle<PlayerVisionModeController> VisionModeController { get; set; }
		[Ordinal(76)]  [RED("waitingForDelayEvent")] public CBool WaitingForDelayEvent { get; set; }
		[Ordinal(77)]  [RED("workspotDamageReductionActive")] public CBool WorkspotDamageReductionActive { get; set; }
		[Ordinal(78)]  [RED("workspotVisibilityReductionActive")] public CBool WorkspotVisibilityReductionActive { get; set; }
		[Ordinal(79)]  [RED("zoneChangeListener")] public CUInt32 ZoneChangeListener { get; set; }

		public PlayerPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

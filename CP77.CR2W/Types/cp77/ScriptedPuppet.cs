using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScriptedPuppet : gamePuppet
	{
		[Ordinal(31)]  [RED("aiController")] public CHandle<AIHumanComponent> AiController { get; set; }
		[Ordinal(32)]  [RED("movePolicies")] public CHandle<movePoliciesComponent> MovePolicies { get; set; }
		[Ordinal(33)]  [RED("aiStateHandlerComponent")] public CHandle<AIPhaseStateEventHandlerComponent> AiStateHandlerComponent { get; set; }
		[Ordinal(34)]  [RED("hitReactionComponent")] public CHandle<HitReactionComponent> HitReactionComponent { get; set; }
		[Ordinal(35)]  [RED("signalHandlerComponent")] public CHandle<AISignalHandlerComponent> SignalHandlerComponent { get; set; }
		[Ordinal(36)]  [RED("reactionComponent")] public CHandle<ReactionManagerComponent> ReactionComponent { get; set; }
		[Ordinal(37)]  [RED("dismembermentComponent")] public CHandle<gameDismembermentComponent> DismembermentComponent { get; set; }
		[Ordinal(38)]  [RED("hitRepresantation")] public CHandle<entSlotComponent> HitRepresantation { get; set; }
		[Ordinal(39)]  [RED("interactionComponent")] public CHandle<gameinteractionsComponent> InteractionComponent { get; set; }
		[Ordinal(40)]  [RED("slotComponent")] public CHandle<entSlotComponent> SlotComponent { get; set; }
		[Ordinal(41)]  [RED("sensesComponent")] public CHandle<senseComponent> SensesComponent { get; set; }
		[Ordinal(42)]  [RED("visibleObjectComponent")] public CHandle<senseVisibleObjectComponent> VisibleObjectComponent { get; set; }
		[Ordinal(43)]  [RED("sensorObjectComponent")] public CHandle<senseSensorObjectComponent> SensorObjectComponent { get; set; }
		[Ordinal(44)]  [RED("targetTrackerComponent")] public CHandle<AITargetTrackerComponent> TargetTrackerComponent { get; set; }
		[Ordinal(45)]  [RED("targetingComponentsArray")] public CArray<CHandle<gameTargetingComponent>> TargetingComponentsArray { get; set; }
		[Ordinal(46)]  [RED("statesComponent")] public CHandle<NPCStatesComponent> StatesComponent { get; set; }
		[Ordinal(47)]  [RED("fxResourceMapper")] public CHandle<FxResourceMapperComponent> FxResourceMapper { get; set; }
		[Ordinal(48)]  [RED("linkedStatusEffect")] public LinkedStatusEffect LinkedStatusEffect { get; set; }
		[Ordinal(49)]  [RED("resourceLibraryComponent")] public CHandle<ResourceLibraryComponent> ResourceLibraryComponent { get; set; }
		[Ordinal(50)]  [RED("crowdMemberComponent")] public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent { get; set; }
		[Ordinal(51)]  [RED("inventoryComponent")] public CHandle<gameInventory> InventoryComponent { get; set; }
		[Ordinal(52)]  [RED("objectSelectionComponent")] public CHandle<AIObjectSelectionComponent> ObjectSelectionComponent { get; set; }
		[Ordinal(53)]  [RED("transformHistoryComponent")] public CHandle<entTransformHistoryComponent> TransformHistoryComponent { get; set; }
		[Ordinal(54)]  [RED("animationControllerComponent")] public CHandle<entAnimationControllerComponent> AnimationControllerComponent { get; set; }
		[Ordinal(55)]  [RED("bumpComponent")] public CHandle<gameinfluenceBumpComponent> BumpComponent { get; set; }
		[Ordinal(56)]  [RED("isCrowd")] public CBool IsCrowd { get; set; }
		[Ordinal(57)]  [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(58)]  [RED("combatHUDManager")] public CHandle<CombatHUDManager> CombatHUDManager { get; set; }
		[Ordinal(59)]  [RED("exposePosition")] public CBool ExposePosition { get; set; }
		[Ordinal(60)]  [RED("puppetStateBlackboard")] public CHandle<gameIBlackboard> PuppetStateBlackboard { get; set; }
		[Ordinal(61)]  [RED("customBlackboard")] public CHandle<gameIBlackboard> CustomBlackboard { get; set; }
		[Ordinal(62)]  [RED("securityAreaCallbackID")] public CUInt32 SecurityAreaCallbackID { get; set; }
		[Ordinal(63)]  [RED("customAIComponents")] public CArray<CHandle<AICustomComponents>> CustomAIComponents { get; set; }
		[Ordinal(64)]  [RED("listeners")] public CArray<CHandle<PuppetListener>> Listeners { get; set; }
		[Ordinal(65)]  [RED("securitySupportListener")] public CHandle<SecuritySupportListener> SecuritySupportListener { get; set; }
		[Ordinal(66)]  [RED("shouldBeRevealedStorage")] public CHandle<RevealRequestsStorage> ShouldBeRevealedStorage { get; set; }
		[Ordinal(67)]  [RED("inputProcessed")] public CBool InputProcessed { get; set; }
		[Ordinal(68)]  [RED("targetedBlackBoard")] public CHandle<gameIBlackboard> TargetedBlackBoard { get; set; }
		[Ordinal(69)]  [RED("shouldSpawnBloodPuddle")] public CBool ShouldSpawnBloodPuddle { get; set; }
		[Ordinal(70)]  [RED("bloodPuddleSpawned")] public CBool BloodPuddleSpawned { get; set; }
		[Ordinal(71)]  [RED("skipDeathAnimation")] public CBool SkipDeathAnimation { get; set; }
		[Ordinal(72)]  [RED("hitHistory")] public CHandle<HitHistory> HitHistory { get; set; }
		[Ordinal(73)]  [RED("currentWorkspotTags")] public CArray<CName> CurrentWorkspotTags { get; set; }
		[Ordinal(74)]  [RED("lootQuality")] public CEnum<gamedataQuality> LootQuality { get; set; }
		[Ordinal(75)]  [RED("hasQuestItems")] public CBool HasQuestItems { get; set; }
		[Ordinal(76)]  [RED("activeQualityRangeInteraction")] public CName ActiveQualityRangeInteraction { get; set; }
		[Ordinal(77)]  [RED("weakspotComponent")] public CHandle<gameWeakspotComponent> WeakspotComponent { get; set; }
		[Ordinal(78)]  [RED("highlightData")] public CHandle<FocusForcedHighlightData> HighlightData { get; set; }
		[Ordinal(79)]  [RED("killer")] public wCHandle<entEntity> Killer { get; set; }
		[Ordinal(80)]  [RED("objectActionsCallbackCtrl")] public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl { get; set; }
		[Ordinal(81)]  [RED("isActiveCached")] public AIUtilsCachedBoolValue IsActiveCached { get; set; }
		[Ordinal(82)]  [RED("isCyberpsycho")] public CBool IsCyberpsycho { get; set; }
		[Ordinal(83)]  [RED("isCivilian")] public CBool IsCivilian { get; set; }
		[Ordinal(84)]  [RED("isPolice")] public CBool IsPolice { get; set; }
		[Ordinal(85)]  [RED("isGanger")] public CBool IsGanger { get; set; }
		[Ordinal(86)]  [RED("attemptedShards")] public CArray<gameItemID> AttemptedShards { get; set; }

		public ScriptedPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

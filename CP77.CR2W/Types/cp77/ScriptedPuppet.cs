using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScriptedPuppet : gamePuppet
	{
		[Ordinal(40)] [RED("aiController")] public CHandle<AIHumanComponent> AiController { get; set; }
		[Ordinal(41)] [RED("movePolicies")] public CHandle<movePoliciesComponent> MovePolicies { get; set; }
		[Ordinal(42)] [RED("aiStateHandlerComponent")] public CHandle<AIPhaseStateEventHandlerComponent> AiStateHandlerComponent { get; set; }
		[Ordinal(43)] [RED("hitReactionComponent")] public CHandle<HitReactionComponent> HitReactionComponent { get; set; }
		[Ordinal(44)] [RED("signalHandlerComponent")] public CHandle<AISignalHandlerComponent> SignalHandlerComponent { get; set; }
		[Ordinal(45)] [RED("reactionComponent")] public CHandle<ReactionManagerComponent> ReactionComponent { get; set; }
		[Ordinal(46)] [RED("dismembermentComponent")] public CHandle<gameDismembermentComponent> DismembermentComponent { get; set; }
		[Ordinal(47)] [RED("hitRepresantation")] public CHandle<entSlotComponent> HitRepresantation { get; set; }
		[Ordinal(48)] [RED("interactionComponent")] public CHandle<gameinteractionsComponent> InteractionComponent { get; set; }
		[Ordinal(49)] [RED("slotComponent")] public CHandle<entSlotComponent> SlotComponent { get; set; }
		[Ordinal(50)] [RED("sensesComponent")] public CHandle<senseComponent> SensesComponent { get; set; }
		[Ordinal(51)] [RED("visibleObjectComponent")] public CHandle<senseVisibleObjectComponent> VisibleObjectComponent { get; set; }
		[Ordinal(52)] [RED("sensorObjectComponent")] public CHandle<senseSensorObjectComponent> SensorObjectComponent { get; set; }
		[Ordinal(53)] [RED("targetTrackerComponent")] public CHandle<AITargetTrackerComponent> TargetTrackerComponent { get; set; }
		[Ordinal(54)] [RED("targetingComponentsArray")] public CArray<CHandle<gameTargetingComponent>> TargetingComponentsArray { get; set; }
		[Ordinal(55)] [RED("statesComponent")] public CHandle<NPCStatesComponent> StatesComponent { get; set; }
		[Ordinal(56)] [RED("fxResourceMapper")] public CHandle<FxResourceMapperComponent> FxResourceMapper { get; set; }
		[Ordinal(57)] [RED("linkedStatusEffect")] public LinkedStatusEffect LinkedStatusEffect { get; set; }
		[Ordinal(58)] [RED("resourceLibraryComponent")] public CHandle<ResourceLibraryComponent> ResourceLibraryComponent { get; set; }
		[Ordinal(59)] [RED("crowdMemberComponent")] public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent { get; set; }
		[Ordinal(60)] [RED("inventoryComponent")] public CHandle<gameInventory> InventoryComponent { get; set; }
		[Ordinal(61)] [RED("objectSelectionComponent")] public CHandle<AIObjectSelectionComponent> ObjectSelectionComponent { get; set; }
		[Ordinal(62)] [RED("transformHistoryComponent")] public CHandle<entTransformHistoryComponent> TransformHistoryComponent { get; set; }
		[Ordinal(63)] [RED("animationControllerComponent")] public CHandle<entAnimationControllerComponent> AnimationControllerComponent { get; set; }
		[Ordinal(64)] [RED("bumpComponent")] public CHandle<gameinfluenceBumpComponent> BumpComponent { get; set; }
		[Ordinal(65)] [RED("isCrowd")] public CBool IsCrowd { get; set; }
		[Ordinal(66)] [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(67)] [RED("combatHUDManager")] public CHandle<CombatHUDManager> CombatHUDManager { get; set; }
		[Ordinal(68)] [RED("exposePosition")] public CBool ExposePosition { get; set; }
		[Ordinal(69)] [RED("puppetStateBlackboard")] public CHandle<gameIBlackboard> PuppetStateBlackboard { get; set; }
		[Ordinal(70)] [RED("customBlackboard")] public CHandle<gameIBlackboard> CustomBlackboard { get; set; }
		[Ordinal(71)] [RED("securityAreaCallbackID")] public CUInt32 SecurityAreaCallbackID { get; set; }
		[Ordinal(72)] [RED("customAIComponents")] public CArray<CHandle<AICustomComponents>> CustomAIComponents { get; set; }
		[Ordinal(73)] [RED("listeners")] public CArray<CHandle<PuppetListener>> Listeners { get; set; }
		[Ordinal(74)] [RED("securitySupportListener")] public CHandle<SecuritySupportListener> SecuritySupportListener { get; set; }
		[Ordinal(75)] [RED("shouldBeRevealedStorage")] public CHandle<RevealRequestsStorage> ShouldBeRevealedStorage { get; set; }
		[Ordinal(76)] [RED("inputProcessed")] public CBool InputProcessed { get; set; }
		[Ordinal(77)] [RED("targetedBlackBoard")] public CHandle<gameIBlackboard> TargetedBlackBoard { get; set; }
		[Ordinal(78)] [RED("shouldSpawnBloodPuddle")] public CBool ShouldSpawnBloodPuddle { get; set; }
		[Ordinal(79)] [RED("bloodPuddleSpawned")] public CBool BloodPuddleSpawned { get; set; }
		[Ordinal(80)] [RED("skipDeathAnimation")] public CBool SkipDeathAnimation { get; set; }
		[Ordinal(81)] [RED("hitHistory")] public CHandle<HitHistory> HitHistory { get; set; }
		[Ordinal(82)] [RED("currentWorkspotTags")] public CArray<CName> CurrentWorkspotTags { get; set; }
		[Ordinal(83)] [RED("lootQuality")] public CEnum<gamedataQuality> LootQuality { get; set; }
		[Ordinal(84)] [RED("hasQuestItems")] public CBool HasQuestItems { get; set; }
		[Ordinal(85)] [RED("activeQualityRangeInteraction")] public CName ActiveQualityRangeInteraction { get; set; }
		[Ordinal(86)] [RED("weakspotComponent")] public CHandle<gameWeakspotComponent> WeakspotComponent { get; set; }
		[Ordinal(87)] [RED("highlightData")] public CHandle<FocusForcedHighlightData> HighlightData { get; set; }
		[Ordinal(88)] [RED("killer")] public wCHandle<entEntity> Killer { get; set; }
		[Ordinal(89)] [RED("objectActionsCallbackCtrl")] public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl { get; set; }
		[Ordinal(90)] [RED("isActiveCached")] public AIUtilsCachedBoolValue IsActiveCached { get; set; }
		[Ordinal(91)] [RED("isCyberpsycho")] public CBool IsCyberpsycho { get; set; }
		[Ordinal(92)] [RED("isCivilian")] public CBool IsCivilian { get; set; }
		[Ordinal(93)] [RED("isPolice")] public CBool IsPolice { get; set; }
		[Ordinal(94)] [RED("isGanger")] public CBool IsGanger { get; set; }
		[Ordinal(95)] [RED("attemptedShards")] public CArray<gameItemID> AttemptedShards { get; set; }

		public ScriptedPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

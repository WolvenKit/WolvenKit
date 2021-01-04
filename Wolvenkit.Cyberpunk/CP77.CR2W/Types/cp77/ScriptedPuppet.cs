using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScriptedPuppet : gamePuppet
	{
		[Ordinal(0)]  [RED("activeQualityRangeInteraction")] public CName ActiveQualityRangeInteraction { get; set; }
		[Ordinal(1)]  [RED("aiController")] public CHandle<AIHumanComponent> AiController { get; set; }
		[Ordinal(2)]  [RED("aiStateHandlerComponent")] public CHandle<AIPhaseStateEventHandlerComponent> AiStateHandlerComponent { get; set; }
		[Ordinal(3)]  [RED("animationControllerComponent")] public CHandle<entAnimationControllerComponent> AnimationControllerComponent { get; set; }
		[Ordinal(4)]  [RED("attemptedShards")] public CArray<gameItemID> AttemptedShards { get; set; }
		[Ordinal(5)]  [RED("bloodPuddleSpawned")] public CBool BloodPuddleSpawned { get; set; }
		[Ordinal(6)]  [RED("bumpComponent")] public CHandle<gameinfluenceBumpComponent> BumpComponent { get; set; }
		[Ordinal(7)]  [RED("combatHUDManager")] public CHandle<CombatHUDManager> CombatHUDManager { get; set; }
		[Ordinal(8)]  [RED("crowdMemberComponent")] public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent { get; set; }
		[Ordinal(9)]  [RED("currentWorkspotTags")] public CArray<CName> CurrentWorkspotTags { get; set; }
		[Ordinal(10)]  [RED("customAIComponents")] public CArray<CHandle<AICustomComponents>> CustomAIComponents { get; set; }
		[Ordinal(11)]  [RED("customBlackboard")] public CHandle<gameIBlackboard> CustomBlackboard { get; set; }
		[Ordinal(12)]  [RED("dismembermentComponent")] public CHandle<gameDismembermentComponent> DismembermentComponent { get; set; }
		[Ordinal(13)]  [RED("exposePosition")] public CBool ExposePosition { get; set; }
		[Ordinal(14)]  [RED("fxResourceMapper")] public CHandle<FxResourceMapperComponent> FxResourceMapper { get; set; }
		[Ordinal(15)]  [RED("hasQuestItems")] public CBool HasQuestItems { get; set; }
		[Ordinal(16)]  [RED("highlightData")] public CHandle<FocusForcedHighlightData> HighlightData { get; set; }
		[Ordinal(17)]  [RED("hitHistory")] public CHandle<HitHistory> HitHistory { get; set; }
		[Ordinal(18)]  [RED("hitReactionComponent")] public CHandle<HitReactionComponent> HitReactionComponent { get; set; }
		[Ordinal(19)]  [RED("hitRepresantation")] public CHandle<entSlotComponent> HitRepresantation { get; set; }
		[Ordinal(20)]  [RED("inputProcessed")] public CBool InputProcessed { get; set; }
		[Ordinal(21)]  [RED("interactionComponent")] public CHandle<gameinteractionsComponent> InteractionComponent { get; set; }
		[Ordinal(22)]  [RED("inventoryComponent")] public CHandle<gameInventory> InventoryComponent { get; set; }
		[Ordinal(23)]  [RED("isActiveCached")] public AIUtilsCachedBoolValue IsActiveCached { get; set; }
		[Ordinal(24)]  [RED("isCivilian")] public CBool IsCivilian { get; set; }
		[Ordinal(25)]  [RED("isCrowd")] public CBool IsCrowd { get; set; }
		[Ordinal(26)]  [RED("isCyberpsycho")] public CBool IsCyberpsycho { get; set; }
		[Ordinal(27)]  [RED("isGanger")] public CBool IsGanger { get; set; }
		[Ordinal(28)]  [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(29)]  [RED("isPolice")] public CBool IsPolice { get; set; }
		[Ordinal(30)]  [RED("killer")] public wCHandle<entEntity> Killer { get; set; }
		[Ordinal(31)]  [RED("linkedStatusEffect")] public LinkedStatusEffect LinkedStatusEffect { get; set; }
		[Ordinal(32)]  [RED("listeners")] public CArray<CHandle<PuppetListener>> Listeners { get; set; }
		[Ordinal(33)]  [RED("lootQuality")] public CEnum<gamedataQuality> LootQuality { get; set; }
		[Ordinal(34)]  [RED("movePolicies")] public CHandle<movePoliciesComponent> MovePolicies { get; set; }
		[Ordinal(35)]  [RED("objectActionsCallbackCtrl")] public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl { get; set; }
		[Ordinal(36)]  [RED("objectSelectionComponent")] public CHandle<AIObjectSelectionComponent> ObjectSelectionComponent { get; set; }
		[Ordinal(37)]  [RED("puppetStateBlackboard")] public CHandle<gameIBlackboard> PuppetStateBlackboard { get; set; }
		[Ordinal(38)]  [RED("reactionComponent")] public CHandle<ReactionManagerComponent> ReactionComponent { get; set; }
		[Ordinal(39)]  [RED("resourceLibraryComponent")] public CHandle<ResourceLibraryComponent> ResourceLibraryComponent { get; set; }
		[Ordinal(40)]  [RED("securityAreaCallbackID")] public CUInt32 SecurityAreaCallbackID { get; set; }
		[Ordinal(41)]  [RED("securitySupportListener")] public CHandle<SecuritySupportListener> SecuritySupportListener { get; set; }
		[Ordinal(42)]  [RED("sensesComponent")] public CHandle<senseComponent> SensesComponent { get; set; }
		[Ordinal(43)]  [RED("sensorObjectComponent")] public CHandle<senseSensorObjectComponent> SensorObjectComponent { get; set; }
		[Ordinal(44)]  [RED("shouldBeRevealedStorage")] public CHandle<RevealRequestsStorage> ShouldBeRevealedStorage { get; set; }
		[Ordinal(45)]  [RED("shouldSpawnBloodPuddle")] public CBool ShouldSpawnBloodPuddle { get; set; }
		[Ordinal(46)]  [RED("signalHandlerComponent")] public CHandle<AISignalHandlerComponent> SignalHandlerComponent { get; set; }
		[Ordinal(47)]  [RED("skipDeathAnimation")] public CBool SkipDeathAnimation { get; set; }
		[Ordinal(48)]  [RED("slotComponent")] public CHandle<entSlotComponent> SlotComponent { get; set; }
		[Ordinal(49)]  [RED("statesComponent")] public CHandle<NPCStatesComponent> StatesComponent { get; set; }
		[Ordinal(50)]  [RED("targetTrackerComponent")] public CHandle<AITargetTrackerComponent> TargetTrackerComponent { get; set; }
		[Ordinal(51)]  [RED("targetedBlackBoard")] public CHandle<gameIBlackboard> TargetedBlackBoard { get; set; }
		[Ordinal(52)]  [RED("targetingComponentsArray")] public CArray<CHandle<gameTargetingComponent>> TargetingComponentsArray { get; set; }
		[Ordinal(53)]  [RED("transformHistoryComponent")] public CHandle<entTransformHistoryComponent> TransformHistoryComponent { get; set; }
		[Ordinal(54)]  [RED("visibleObjectComponent")] public CHandle<senseVisibleObjectComponent> VisibleObjectComponent { get; set; }
		[Ordinal(55)]  [RED("weakspotComponent")] public CHandle<gameWeakspotComponent> WeakspotComponent { get; set; }

		public ScriptedPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

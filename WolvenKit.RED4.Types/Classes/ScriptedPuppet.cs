using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScriptedPuppet : gamePuppet
	{
		[Ordinal(40)] 
		[RED("aiController")] 
		public CHandle<AIHumanComponent> AiController
		{
			get => GetPropertyValue<CHandle<AIHumanComponent>>();
			set => SetPropertyValue<CHandle<AIHumanComponent>>(value);
		}

		[Ordinal(41)] 
		[RED("movePolicies")] 
		public CHandle<movePoliciesComponent> MovePolicies
		{
			get => GetPropertyValue<CHandle<movePoliciesComponent>>();
			set => SetPropertyValue<CHandle<movePoliciesComponent>>(value);
		}

		[Ordinal(42)] 
		[RED("aiStateHandlerComponent")] 
		public CHandle<AIPhaseStateEventHandlerComponent> AiStateHandlerComponent
		{
			get => GetPropertyValue<CHandle<AIPhaseStateEventHandlerComponent>>();
			set => SetPropertyValue<CHandle<AIPhaseStateEventHandlerComponent>>(value);
		}

		[Ordinal(43)] 
		[RED("hitReactionComponent")] 
		public CHandle<HitReactionComponent> HitReactionComponent
		{
			get => GetPropertyValue<CHandle<HitReactionComponent>>();
			set => SetPropertyValue<CHandle<HitReactionComponent>>(value);
		}

		[Ordinal(44)] 
		[RED("signalHandlerComponent")] 
		public CHandle<AISignalHandlerComponent> SignalHandlerComponent
		{
			get => GetPropertyValue<CHandle<AISignalHandlerComponent>>();
			set => SetPropertyValue<CHandle<AISignalHandlerComponent>>(value);
		}

		[Ordinal(45)] 
		[RED("reactionComponent")] 
		public CHandle<ReactionManagerComponent> ReactionComponent
		{
			get => GetPropertyValue<CHandle<ReactionManagerComponent>>();
			set => SetPropertyValue<CHandle<ReactionManagerComponent>>(value);
		}

		[Ordinal(46)] 
		[RED("dismembermentComponent")] 
		public CHandle<gameDismembermentComponent> DismembermentComponent
		{
			get => GetPropertyValue<CHandle<gameDismembermentComponent>>();
			set => SetPropertyValue<CHandle<gameDismembermentComponent>>(value);
		}

		[Ordinal(47)] 
		[RED("hitRepresantation")] 
		public CHandle<entSlotComponent> HitRepresantation
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(48)] 
		[RED("interactionComponent")] 
		public CHandle<gameinteractionsComponent> InteractionComponent
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(49)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(50)] 
		[RED("sensesComponent")] 
		public CHandle<senseComponent> SensesComponent
		{
			get => GetPropertyValue<CHandle<senseComponent>>();
			set => SetPropertyValue<CHandle<senseComponent>>(value);
		}

		[Ordinal(51)] 
		[RED("visibleObjectComponent")] 
		public CHandle<senseVisibleObjectComponent> VisibleObjectComponent
		{
			get => GetPropertyValue<CHandle<senseVisibleObjectComponent>>();
			set => SetPropertyValue<CHandle<senseVisibleObjectComponent>>(value);
		}

		[Ordinal(52)] 
		[RED("sensorObjectComponent")] 
		public CHandle<senseSensorObjectComponent> SensorObjectComponent
		{
			get => GetPropertyValue<CHandle<senseSensorObjectComponent>>();
			set => SetPropertyValue<CHandle<senseSensorObjectComponent>>(value);
		}

		[Ordinal(53)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetPropertyValue<CHandle<AITargetTrackerComponent>>();
			set => SetPropertyValue<CHandle<AITargetTrackerComponent>>(value);
		}

		[Ordinal(54)] 
		[RED("targetingComponentsArray")] 
		public CArray<CHandle<gameTargetingComponent>> TargetingComponentsArray
		{
			get => GetPropertyValue<CArray<CHandle<gameTargetingComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameTargetingComponent>>>(value);
		}

		[Ordinal(55)] 
		[RED("statesComponent")] 
		public CHandle<NPCStatesComponent> StatesComponent
		{
			get => GetPropertyValue<CHandle<NPCStatesComponent>>();
			set => SetPropertyValue<CHandle<NPCStatesComponent>>(value);
		}

		[Ordinal(56)] 
		[RED("fxResourceMapper")] 
		public CHandle<FxResourceMapperComponent> FxResourceMapper
		{
			get => GetPropertyValue<CHandle<FxResourceMapperComponent>>();
			set => SetPropertyValue<CHandle<FxResourceMapperComponent>>(value);
		}

		[Ordinal(57)] 
		[RED("linkedStatusEffect")] 
		public LinkedStatusEffect LinkedStatusEffect
		{
			get => GetPropertyValue<LinkedStatusEffect>();
			set => SetPropertyValue<LinkedStatusEffect>(value);
		}

		[Ordinal(58)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetPropertyValue<CHandle<ResourceLibraryComponent>>();
			set => SetPropertyValue<CHandle<ResourceLibraryComponent>>(value);
		}

		[Ordinal(59)] 
		[RED("crowdMemberComponent")] 
		public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent
		{
			get => GetPropertyValue<CHandle<CrowdMemberBaseComponent>>();
			set => SetPropertyValue<CHandle<CrowdMemberBaseComponent>>(value);
		}

		[Ordinal(60)] 
		[RED("inventoryComponent")] 
		public CHandle<gameInventory> InventoryComponent
		{
			get => GetPropertyValue<CHandle<gameInventory>>();
			set => SetPropertyValue<CHandle<gameInventory>>(value);
		}

		[Ordinal(61)] 
		[RED("objectSelectionComponent")] 
		public CHandle<AIObjectSelectionComponent> ObjectSelectionComponent
		{
			get => GetPropertyValue<CHandle<AIObjectSelectionComponent>>();
			set => SetPropertyValue<CHandle<AIObjectSelectionComponent>>(value);
		}

		[Ordinal(62)] 
		[RED("transformHistoryComponent")] 
		public CHandle<entTransformHistoryComponent> TransformHistoryComponent
		{
			get => GetPropertyValue<CHandle<entTransformHistoryComponent>>();
			set => SetPropertyValue<CHandle<entTransformHistoryComponent>>(value);
		}

		[Ordinal(63)] 
		[RED("animationControllerComponent")] 
		public CHandle<entAnimationControllerComponent> AnimationControllerComponent
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		[Ordinal(64)] 
		[RED("bumpComponent")] 
		public CHandle<gameinfluenceBumpComponent> BumpComponent
		{
			get => GetPropertyValue<CHandle<gameinfluenceBumpComponent>>();
			set => SetPropertyValue<CHandle<gameinfluenceBumpComponent>>(value);
		}

		[Ordinal(65)] 
		[RED("isCrowd")] 
		public CBool IsCrowd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(66)] 
		[RED("incapacitatedOnAttach")] 
		public CBool IncapacitatedOnAttach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("combatHUDManager")] 
		public CHandle<CombatHUDManager> CombatHUDManager
		{
			get => GetPropertyValue<CHandle<CombatHUDManager>>();
			set => SetPropertyValue<CHandle<CombatHUDManager>>(value);
		}

		[Ordinal(69)] 
		[RED("exposePosition")] 
		public CBool ExposePosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("puppetStateBlackboard")] 
		public CHandle<gameIBlackboard> PuppetStateBlackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		[Ordinal(71)] 
		[RED("customBlackboard")] 
		public CHandle<gameIBlackboard> CustomBlackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		[Ordinal(72)] 
		[RED("securityAreaCallbackID")] 
		public CUInt32 SecurityAreaCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(73)] 
		[RED("customAIComponents")] 
		public CArray<CHandle<AICustomComponents>> CustomAIComponents
		{
			get => GetPropertyValue<CArray<CHandle<AICustomComponents>>>();
			set => SetPropertyValue<CArray<CHandle<AICustomComponents>>>(value);
		}

		[Ordinal(74)] 
		[RED("listeners")] 
		public CArray<CHandle<PuppetListener>> Listeners
		{
			get => GetPropertyValue<CArray<CHandle<PuppetListener>>>();
			set => SetPropertyValue<CArray<CHandle<PuppetListener>>>(value);
		}

		[Ordinal(75)] 
		[RED("securitySupportListener")] 
		public CHandle<SecuritySupportListener> SecuritySupportListener
		{
			get => GetPropertyValue<CHandle<SecuritySupportListener>>();
			set => SetPropertyValue<CHandle<SecuritySupportListener>>(value);
		}

		[Ordinal(76)] 
		[RED("shouldBeRevealedStorage")] 
		public CHandle<RevealRequestsStorage> ShouldBeRevealedStorage
		{
			get => GetPropertyValue<CHandle<RevealRequestsStorage>>();
			set => SetPropertyValue<CHandle<RevealRequestsStorage>>(value);
		}

		[Ordinal(77)] 
		[RED("inputProcessed")] 
		public CBool InputProcessed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(78)] 
		[RED("shouldSpawnBloodPuddle")] 
		public CBool ShouldSpawnBloodPuddle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(79)] 
		[RED("bloodPuddleSpawned")] 
		public CBool BloodPuddleSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(80)] 
		[RED("skipDeathAnimation")] 
		public CBool SkipDeathAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(81)] 
		[RED("hitHistory")] 
		public CHandle<HitHistory> HitHistory
		{
			get => GetPropertyValue<CHandle<HitHistory>>();
			set => SetPropertyValue<CHandle<HitHistory>>(value);
		}

		[Ordinal(82)] 
		[RED("currentWorkspotTags")] 
		public CArray<CName> CurrentWorkspotTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(83)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(84)] 
		[RED("hasQuestItems")] 
		public CBool HasQuestItems
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(85)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(86)] 
		[RED("weakspotComponent")] 
		public CHandle<gameWeakspotComponent> WeakspotComponent
		{
			get => GetPropertyValue<CHandle<gameWeakspotComponent>>();
			set => SetPropertyValue<CHandle<gameWeakspotComponent>>(value);
		}

		[Ordinal(87)] 
		[RED("highlightData")] 
		public CHandle<FocusForcedHighlightData> HighlightData
		{
			get => GetPropertyValue<CHandle<FocusForcedHighlightData>>();
			set => SetPropertyValue<CHandle<FocusForcedHighlightData>>(value);
		}

		[Ordinal(88)] 
		[RED("killer")] 
		public CWeakHandle<entEntity> Killer
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(89)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get => GetPropertyValue<CHandle<gameObjectActionsCallbackController>>();
			set => SetPropertyValue<CHandle<gameObjectActionsCallbackController>>(value);
		}

		[Ordinal(90)] 
		[RED("isActiveCached")] 
		public AIUtilsCachedBoolValue IsActiveCached
		{
			get => GetPropertyValue<AIUtilsCachedBoolValue>();
			set => SetPropertyValue<AIUtilsCachedBoolValue>(value);
		}

		[Ordinal(91)] 
		[RED("isCyberpsycho")] 
		public CBool IsCyberpsycho
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(92)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(93)] 
		[RED("isPolice")] 
		public CBool IsPolice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(94)] 
		[RED("isGanger")] 
		public CBool IsGanger
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(95)] 
		[RED("attemptedShards")] 
		public CArray<gameItemID> AttemptedShards
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		public ScriptedPuppet()
		{
			TargetingComponentsArray = new();
			LinkedStatusEffect = new() { NetrunnerIDs = new(), TargetID = new(), StatusEffectList = new() };
			CustomAIComponents = new();
			Listeners = new();
			ShouldSpawnBloodPuddle = true;
			CurrentWorkspotTags = new();
			LootQuality = Enums.gamedataQuality.Invalid;
			IsActiveCached = new();
			AttemptedShards = new();
		}
	}
}

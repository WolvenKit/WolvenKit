using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScriptedPuppet : gamePuppet
	{
		[Ordinal(36)] 
		[RED("aiController")] 
		public CHandle<AIHumanComponent> AiController
		{
			get => GetPropertyValue<CHandle<AIHumanComponent>>();
			set => SetPropertyValue<CHandle<AIHumanComponent>>(value);
		}

		[Ordinal(37)] 
		[RED("movePolicies")] 
		public CHandle<movePoliciesComponent> MovePolicies
		{
			get => GetPropertyValue<CHandle<movePoliciesComponent>>();
			set => SetPropertyValue<CHandle<movePoliciesComponent>>(value);
		}

		[Ordinal(38)] 
		[RED("aiStateHandlerComponent")] 
		public CHandle<AIPhaseStateEventHandlerComponent> AiStateHandlerComponent
		{
			get => GetPropertyValue<CHandle<AIPhaseStateEventHandlerComponent>>();
			set => SetPropertyValue<CHandle<AIPhaseStateEventHandlerComponent>>(value);
		}

		[Ordinal(39)] 
		[RED("hitReactionComponent")] 
		public CHandle<HitReactionComponent> HitReactionComponent
		{
			get => GetPropertyValue<CHandle<HitReactionComponent>>();
			set => SetPropertyValue<CHandle<HitReactionComponent>>(value);
		}

		[Ordinal(40)] 
		[RED("signalHandlerComponent")] 
		public CHandle<AISignalHandlerComponent> SignalHandlerComponent
		{
			get => GetPropertyValue<CHandle<AISignalHandlerComponent>>();
			set => SetPropertyValue<CHandle<AISignalHandlerComponent>>(value);
		}

		[Ordinal(41)] 
		[RED("reactionComponent")] 
		public CHandle<ReactionManagerComponent> ReactionComponent
		{
			get => GetPropertyValue<CHandle<ReactionManagerComponent>>();
			set => SetPropertyValue<CHandle<ReactionManagerComponent>>(value);
		}

		[Ordinal(42)] 
		[RED("dismembermentComponent")] 
		public CHandle<gameDismembermentComponent> DismembermentComponent
		{
			get => GetPropertyValue<CHandle<gameDismembermentComponent>>();
			set => SetPropertyValue<CHandle<gameDismembermentComponent>>(value);
		}

		[Ordinal(43)] 
		[RED("hitRepresantation")] 
		public CHandle<entSlotComponent> HitRepresantation
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(44)] 
		[RED("interactionComponent")] 
		public CHandle<gameinteractionsComponent> InteractionComponent
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(45)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(46)] 
		[RED("sensesComponent")] 
		public CHandle<senseComponent> SensesComponent
		{
			get => GetPropertyValue<CHandle<senseComponent>>();
			set => SetPropertyValue<CHandle<senseComponent>>(value);
		}

		[Ordinal(47)] 
		[RED("visibleObjectComponent")] 
		public CHandle<senseVisibleObjectComponent> VisibleObjectComponent
		{
			get => GetPropertyValue<CHandle<senseVisibleObjectComponent>>();
			set => SetPropertyValue<CHandle<senseVisibleObjectComponent>>(value);
		}

		[Ordinal(48)] 
		[RED("visibleObjectPositionUpdated")] 
		public CBool VisibleObjectPositionUpdated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("sensorObjectComponent")] 
		public CHandle<senseSensorObjectComponent> SensorObjectComponent
		{
			get => GetPropertyValue<CHandle<senseSensorObjectComponent>>();
			set => SetPropertyValue<CHandle<senseSensorObjectComponent>>(value);
		}

		[Ordinal(50)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetPropertyValue<CHandle<AITargetTrackerComponent>>();
			set => SetPropertyValue<CHandle<AITargetTrackerComponent>>(value);
		}

		[Ordinal(51)] 
		[RED("targetingComponentsArray")] 
		public CArray<CHandle<gameTargetingComponent>> TargetingComponentsArray
		{
			get => GetPropertyValue<CArray<CHandle<gameTargetingComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameTargetingComponent>>>(value);
		}

		[Ordinal(52)] 
		[RED("statesComponent")] 
		public CHandle<NPCStatesComponent> StatesComponent
		{
			get => GetPropertyValue<CHandle<NPCStatesComponent>>();
			set => SetPropertyValue<CHandle<NPCStatesComponent>>(value);
		}

		[Ordinal(53)] 
		[RED("fxResourceMapper")] 
		public CHandle<FxResourceMapperComponent> FxResourceMapper
		{
			get => GetPropertyValue<CHandle<FxResourceMapperComponent>>();
			set => SetPropertyValue<CHandle<FxResourceMapperComponent>>(value);
		}

		[Ordinal(54)] 
		[RED("linkedStatusEffect")] 
		public LinkedStatusEffect LinkedStatusEffect
		{
			get => GetPropertyValue<LinkedStatusEffect>();
			set => SetPropertyValue<LinkedStatusEffect>(value);
		}

		[Ordinal(55)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetPropertyValue<CHandle<ResourceLibraryComponent>>();
			set => SetPropertyValue<CHandle<ResourceLibraryComponent>>(value);
		}

		[Ordinal(56)] 
		[RED("crowdMemberComponent")] 
		public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent
		{
			get => GetPropertyValue<CHandle<CrowdMemberBaseComponent>>();
			set => SetPropertyValue<CHandle<CrowdMemberBaseComponent>>(value);
		}

		[Ordinal(57)] 
		[RED("inventoryComponent")] 
		public CWeakHandle<gameInventory> InventoryComponent
		{
			get => GetPropertyValue<CWeakHandle<gameInventory>>();
			set => SetPropertyValue<CWeakHandle<gameInventory>>(value);
		}

		[Ordinal(58)] 
		[RED("objectSelectionComponent")] 
		public CHandle<AIObjectSelectionComponent> ObjectSelectionComponent
		{
			get => GetPropertyValue<CHandle<AIObjectSelectionComponent>>();
			set => SetPropertyValue<CHandle<AIObjectSelectionComponent>>(value);
		}

		[Ordinal(59)] 
		[RED("transformHistoryComponent")] 
		public CHandle<entTransformHistoryComponent> TransformHistoryComponent
		{
			get => GetPropertyValue<CHandle<entTransformHistoryComponent>>();
			set => SetPropertyValue<CHandle<entTransformHistoryComponent>>(value);
		}

		[Ordinal(60)] 
		[RED("animationControllerComponent")] 
		public CHandle<entAnimationControllerComponent> AnimationControllerComponent
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		[Ordinal(61)] 
		[RED("bumpComponent")] 
		public CHandle<gameinfluenceBumpComponent> BumpComponent
		{
			get => GetPropertyValue<CHandle<gameinfluenceBumpComponent>>();
			set => SetPropertyValue<CHandle<gameinfluenceBumpComponent>>(value);
		}

		[Ordinal(62)] 
		[RED("isCrowd")] 
		public CBool IsCrowd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("incapacitatedOnAttach")] 
		public CBool IncapacitatedOnAttach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("combatHUDManager")] 
		public CHandle<CombatHUDManager> CombatHUDManager
		{
			get => GetPropertyValue<CHandle<CombatHUDManager>>();
			set => SetPropertyValue<CHandle<CombatHUDManager>>(value);
		}

		[Ordinal(66)] 
		[RED("exposePosition")] 
		public CBool ExposePosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("puppetStateBlackboard")] 
		public CHandle<gameIBlackboard> PuppetStateBlackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		[Ordinal(68)] 
		[RED("customBlackboard")] 
		public CHandle<gameIBlackboard> CustomBlackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		[Ordinal(69)] 
		[RED("securityAreaCallbackID")] 
		public CUInt32 SecurityAreaCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(70)] 
		[RED("customAIComponents")] 
		public CArray<CHandle<AICustomComponents>> CustomAIComponents
		{
			get => GetPropertyValue<CArray<CHandle<AICustomComponents>>>();
			set => SetPropertyValue<CArray<CHandle<AICustomComponents>>>(value);
		}

		[Ordinal(71)] 
		[RED("listeners")] 
		public CArray<CHandle<PuppetListener>> Listeners
		{
			get => GetPropertyValue<CArray<CHandle<PuppetListener>>>();
			set => SetPropertyValue<CArray<CHandle<PuppetListener>>>(value);
		}

		[Ordinal(72)] 
		[RED("securitySupportListener")] 
		public CHandle<SecuritySupportListener> SecuritySupportListener
		{
			get => GetPropertyValue<CHandle<SecuritySupportListener>>();
			set => SetPropertyValue<CHandle<SecuritySupportListener>>(value);
		}

		[Ordinal(73)] 
		[RED("shouldBeRevealedStorage")] 
		public CHandle<RevealRequestsStorage> ShouldBeRevealedStorage
		{
			get => GetPropertyValue<CHandle<RevealRequestsStorage>>();
			set => SetPropertyValue<CHandle<RevealRequestsStorage>>(value);
		}

		[Ordinal(74)] 
		[RED("inputProcessed")] 
		public CBool InputProcessed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(75)] 
		[RED("shouldSpawnBloodPuddle")] 
		public CBool ShouldSpawnBloodPuddle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(76)] 
		[RED("bloodPuddleSpawned")] 
		public CBool BloodPuddleSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(77)] 
		[RED("skipDeathAnimation")] 
		public CBool SkipDeathAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(78)] 
		[RED("hitHistory")] 
		public CHandle<HitHistory> HitHistory
		{
			get => GetPropertyValue<CHandle<HitHistory>>();
			set => SetPropertyValue<CHandle<HitHistory>>(value);
		}

		[Ordinal(79)] 
		[RED("currentWorkspotTags")] 
		public CArray<CName> CurrentWorkspotTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(80)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(81)] 
		[RED("hasQuestItems")] 
		public CBool HasQuestItems
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(82)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(83)] 
		[RED("droppedWeapons")] 
		public CBool DroppedWeapons
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(84)] 
		[RED("weakspotComponent")] 
		public CHandle<gameWeakspotComponent> WeakspotComponent
		{
			get => GetPropertyValue<CHandle<gameWeakspotComponent>>();
			set => SetPropertyValue<CHandle<gameWeakspotComponent>>(value);
		}

		[Ordinal(85)] 
		[RED("breachControllerComponent")] 
		public CHandle<gameBreachControllerComponent> BreachControllerComponent
		{
			get => GetPropertyValue<CHandle<gameBreachControllerComponent>>();
			set => SetPropertyValue<CHandle<gameBreachControllerComponent>>(value);
		}

		[Ordinal(86)] 
		[RED("highlightData")] 
		public CHandle<FocusForcedHighlightData> HighlightData
		{
			get => GetPropertyValue<CHandle<FocusForcedHighlightData>>();
			set => SetPropertyValue<CHandle<FocusForcedHighlightData>>(value);
		}

		[Ordinal(87)] 
		[RED("currentTagsStack")] 
		public CUInt32 CurrentTagsStack
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
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
		[RED("currentlyUploadingAction")] 
		public CWeakHandle<ScriptableDeviceAction> CurrentlyUploadingAction
		{
			get => GetPropertyValue<CWeakHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CWeakHandle<ScriptableDeviceAction>>(value);
		}

		[Ordinal(96)] 
		[RED("gameplayRoleComponent")] 
		public CWeakHandle<GameplayRoleComponent> GameplayRoleComponent
		{
			get => GetPropertyValue<CWeakHandle<GameplayRoleComponent>>();
			set => SetPropertyValue<CWeakHandle<GameplayRoleComponent>>(value);
		}

		[Ordinal(97)] 
		[RED("activeQuickhackActionHistory")] 
		public CArray<CHandle<ScriptableDeviceAction>> ActiveQuickhackActionHistory
		{
			get => GetPropertyValue<CArray<CHandle<ScriptableDeviceAction>>>();
			set => SetPropertyValue<CArray<CHandle<ScriptableDeviceAction>>>(value);
		}

		[Ordinal(98)] 
		[RED("completedQuickhackHistory")] 
		public CArray<CHandle<ScriptableDeviceAction>> CompletedQuickhackHistory
		{
			get => GetPropertyValue<CArray<CHandle<ScriptableDeviceAction>>>();
			set => SetPropertyValue<CArray<CHandle<ScriptableDeviceAction>>>(value);
		}

		[Ordinal(99)] 
		[RED("isFinsherSoundPlayed")] 
		public CBool IsFinsherSoundPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(100)] 
		[RED("attemptedShards")] 
		public CArray<gameItemID> AttemptedShards
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		public ScriptedPuppet()
		{
			TargetingComponentsArray = new();
			LinkedStatusEffect = new LinkedStatusEffect { NetrunnerIDs = new(), TargetID = new entEntityID(), StatusEffectList = new() };
			CustomAIComponents = new();
			Listeners = new();
			ShouldSpawnBloodPuddle = true;
			CurrentWorkspotTags = new();
			LootQuality = Enums.gamedataQuality.Invalid;
			IsActiveCached = new AIUtilsCachedBoolValue();
			ActiveQuickhackActionHistory = new();
			CompletedQuickhackHistory = new();
			AttemptedShards = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

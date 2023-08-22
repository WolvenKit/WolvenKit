using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScriptedPuppet : gamePuppet
	{
		[Ordinal(35)] 
		[RED("aiController")] 
		public CHandle<AIHumanComponent> AiController
		{
			get => GetPropertyValue<CHandle<AIHumanComponent>>();
			set => SetPropertyValue<CHandle<AIHumanComponent>>(value);
		}

		[Ordinal(36)] 
		[RED("movePolicies")] 
		public CHandle<movePoliciesComponent> MovePolicies
		{
			get => GetPropertyValue<CHandle<movePoliciesComponent>>();
			set => SetPropertyValue<CHandle<movePoliciesComponent>>(value);
		}

		[Ordinal(37)] 
		[RED("aiStateHandlerComponent")] 
		public CHandle<AIPhaseStateEventHandlerComponent> AiStateHandlerComponent
		{
			get => GetPropertyValue<CHandle<AIPhaseStateEventHandlerComponent>>();
			set => SetPropertyValue<CHandle<AIPhaseStateEventHandlerComponent>>(value);
		}

		[Ordinal(38)] 
		[RED("hitReactionComponent")] 
		public CHandle<HitReactionComponent> HitReactionComponent
		{
			get => GetPropertyValue<CHandle<HitReactionComponent>>();
			set => SetPropertyValue<CHandle<HitReactionComponent>>(value);
		}

		[Ordinal(39)] 
		[RED("signalHandlerComponent")] 
		public CHandle<AISignalHandlerComponent> SignalHandlerComponent
		{
			get => GetPropertyValue<CHandle<AISignalHandlerComponent>>();
			set => SetPropertyValue<CHandle<AISignalHandlerComponent>>(value);
		}

		[Ordinal(40)] 
		[RED("reactionComponent")] 
		public CHandle<ReactionManagerComponent> ReactionComponent
		{
			get => GetPropertyValue<CHandle<ReactionManagerComponent>>();
			set => SetPropertyValue<CHandle<ReactionManagerComponent>>(value);
		}

		[Ordinal(41)] 
		[RED("dismembermentComponent")] 
		public CHandle<gameDismembermentComponent> DismembermentComponent
		{
			get => GetPropertyValue<CHandle<gameDismembermentComponent>>();
			set => SetPropertyValue<CHandle<gameDismembermentComponent>>(value);
		}

		[Ordinal(42)] 
		[RED("hitRepresantation")] 
		public CHandle<entSlotComponent> HitRepresantation
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(43)] 
		[RED("interactionComponent")] 
		public CHandle<gameinteractionsComponent> InteractionComponent
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(44)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(45)] 
		[RED("sensesComponent")] 
		public CHandle<senseComponent> SensesComponent
		{
			get => GetPropertyValue<CHandle<senseComponent>>();
			set => SetPropertyValue<CHandle<senseComponent>>(value);
		}

		[Ordinal(46)] 
		[RED("visibleObjectComponent")] 
		public CHandle<senseVisibleObjectComponent> VisibleObjectComponent
		{
			get => GetPropertyValue<CHandle<senseVisibleObjectComponent>>();
			set => SetPropertyValue<CHandle<senseVisibleObjectComponent>>(value);
		}

		[Ordinal(47)] 
		[RED("sensorObjectComponent")] 
		public CHandle<senseSensorObjectComponent> SensorObjectComponent
		{
			get => GetPropertyValue<CHandle<senseSensorObjectComponent>>();
			set => SetPropertyValue<CHandle<senseSensorObjectComponent>>(value);
		}

		[Ordinal(48)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetPropertyValue<CHandle<AITargetTrackerComponent>>();
			set => SetPropertyValue<CHandle<AITargetTrackerComponent>>(value);
		}

		[Ordinal(49)] 
		[RED("targetingComponentsArray")] 
		public CArray<CHandle<gameTargetingComponent>> TargetingComponentsArray
		{
			get => GetPropertyValue<CArray<CHandle<gameTargetingComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameTargetingComponent>>>(value);
		}

		[Ordinal(50)] 
		[RED("statesComponent")] 
		public CHandle<NPCStatesComponent> StatesComponent
		{
			get => GetPropertyValue<CHandle<NPCStatesComponent>>();
			set => SetPropertyValue<CHandle<NPCStatesComponent>>(value);
		}

		[Ordinal(51)] 
		[RED("fxResourceMapper")] 
		public CHandle<FxResourceMapperComponent> FxResourceMapper
		{
			get => GetPropertyValue<CHandle<FxResourceMapperComponent>>();
			set => SetPropertyValue<CHandle<FxResourceMapperComponent>>(value);
		}

		[Ordinal(52)] 
		[RED("linkedStatusEffect")] 
		public LinkedStatusEffect LinkedStatusEffect
		{
			get => GetPropertyValue<LinkedStatusEffect>();
			set => SetPropertyValue<LinkedStatusEffect>(value);
		}

		[Ordinal(53)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetPropertyValue<CHandle<ResourceLibraryComponent>>();
			set => SetPropertyValue<CHandle<ResourceLibraryComponent>>(value);
		}

		[Ordinal(54)] 
		[RED("crowdMemberComponent")] 
		public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent
		{
			get => GetPropertyValue<CHandle<CrowdMemberBaseComponent>>();
			set => SetPropertyValue<CHandle<CrowdMemberBaseComponent>>(value);
		}

		[Ordinal(55)] 
		[RED("inventoryComponent")] 
		public CHandle<gameInventory> InventoryComponent
		{
			get => GetPropertyValue<CHandle<gameInventory>>();
			set => SetPropertyValue<CHandle<gameInventory>>(value);
		}

		[Ordinal(56)] 
		[RED("objectSelectionComponent")] 
		public CHandle<AIObjectSelectionComponent> ObjectSelectionComponent
		{
			get => GetPropertyValue<CHandle<AIObjectSelectionComponent>>();
			set => SetPropertyValue<CHandle<AIObjectSelectionComponent>>(value);
		}

		[Ordinal(57)] 
		[RED("transformHistoryComponent")] 
		public CHandle<entTransformHistoryComponent> TransformHistoryComponent
		{
			get => GetPropertyValue<CHandle<entTransformHistoryComponent>>();
			set => SetPropertyValue<CHandle<entTransformHistoryComponent>>(value);
		}

		[Ordinal(58)] 
		[RED("animationControllerComponent")] 
		public CHandle<entAnimationControllerComponent> AnimationControllerComponent
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		[Ordinal(59)] 
		[RED("bumpComponent")] 
		public CHandle<gameinfluenceBumpComponent> BumpComponent
		{
			get => GetPropertyValue<CHandle<gameinfluenceBumpComponent>>();
			set => SetPropertyValue<CHandle<gameinfluenceBumpComponent>>(value);
		}

		[Ordinal(60)] 
		[RED("isCrowd")] 
		public CBool IsCrowd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("incapacitatedOnAttach")] 
		public CBool IncapacitatedOnAttach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("combatHUDManager")] 
		public CHandle<CombatHUDManager> CombatHUDManager
		{
			get => GetPropertyValue<CHandle<CombatHUDManager>>();
			set => SetPropertyValue<CHandle<CombatHUDManager>>(value);
		}

		[Ordinal(64)] 
		[RED("exposePosition")] 
		public CBool ExposePosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("puppetStateBlackboard")] 
		public CHandle<gameIBlackboard> PuppetStateBlackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		[Ordinal(66)] 
		[RED("customBlackboard")] 
		public CHandle<gameIBlackboard> CustomBlackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		[Ordinal(67)] 
		[RED("securityAreaCallbackID")] 
		public CUInt32 SecurityAreaCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(68)] 
		[RED("customAIComponents")] 
		public CArray<CHandle<AICustomComponents>> CustomAIComponents
		{
			get => GetPropertyValue<CArray<CHandle<AICustomComponents>>>();
			set => SetPropertyValue<CArray<CHandle<AICustomComponents>>>(value);
		}

		[Ordinal(69)] 
		[RED("listeners")] 
		public CArray<CHandle<PuppetListener>> Listeners
		{
			get => GetPropertyValue<CArray<CHandle<PuppetListener>>>();
			set => SetPropertyValue<CArray<CHandle<PuppetListener>>>(value);
		}

		[Ordinal(70)] 
		[RED("securitySupportListener")] 
		public CHandle<SecuritySupportListener> SecuritySupportListener
		{
			get => GetPropertyValue<CHandle<SecuritySupportListener>>();
			set => SetPropertyValue<CHandle<SecuritySupportListener>>(value);
		}

		[Ordinal(71)] 
		[RED("shouldBeRevealedStorage")] 
		public CHandle<RevealRequestsStorage> ShouldBeRevealedStorage
		{
			get => GetPropertyValue<CHandle<RevealRequestsStorage>>();
			set => SetPropertyValue<CHandle<RevealRequestsStorage>>(value);
		}

		[Ordinal(72)] 
		[RED("inputProcessed")] 
		public CBool InputProcessed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("shouldSpawnBloodPuddle")] 
		public CBool ShouldSpawnBloodPuddle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(74)] 
		[RED("bloodPuddleSpawned")] 
		public CBool BloodPuddleSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(75)] 
		[RED("skipDeathAnimation")] 
		public CBool SkipDeathAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(76)] 
		[RED("hitHistory")] 
		public CHandle<HitHistory> HitHistory
		{
			get => GetPropertyValue<CHandle<HitHistory>>();
			set => SetPropertyValue<CHandle<HitHistory>>(value);
		}

		[Ordinal(77)] 
		[RED("currentWorkspotTags")] 
		public CArray<CName> CurrentWorkspotTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(78)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(79)] 
		[RED("hasQuestItems")] 
		public CBool HasQuestItems
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(80)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(81)] 
		[RED("droppedWeapons")] 
		public CBool DroppedWeapons
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(82)] 
		[RED("weakspotComponent")] 
		public CHandle<gameWeakspotComponent> WeakspotComponent
		{
			get => GetPropertyValue<CHandle<gameWeakspotComponent>>();
			set => SetPropertyValue<CHandle<gameWeakspotComponent>>(value);
		}

		[Ordinal(83)] 
		[RED("highlightData")] 
		public CHandle<FocusForcedHighlightData> HighlightData
		{
			get => GetPropertyValue<CHandle<FocusForcedHighlightData>>();
			set => SetPropertyValue<CHandle<FocusForcedHighlightData>>(value);
		}

		[Ordinal(84)] 
		[RED("killer")] 
		public CWeakHandle<entEntity> Killer
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(85)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get => GetPropertyValue<CHandle<gameObjectActionsCallbackController>>();
			set => SetPropertyValue<CHandle<gameObjectActionsCallbackController>>(value);
		}

		[Ordinal(86)] 
		[RED("isActiveCached")] 
		public AIUtilsCachedBoolValue IsActiveCached
		{
			get => GetPropertyValue<AIUtilsCachedBoolValue>();
			set => SetPropertyValue<AIUtilsCachedBoolValue>(value);
		}

		[Ordinal(87)] 
		[RED("isCyberpsycho")] 
		public CBool IsCyberpsycho
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(88)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(89)] 
		[RED("isPolice")] 
		public CBool IsPolice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(90)] 
		[RED("isGanger")] 
		public CBool IsGanger
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(91)] 
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
			AttemptedShards = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

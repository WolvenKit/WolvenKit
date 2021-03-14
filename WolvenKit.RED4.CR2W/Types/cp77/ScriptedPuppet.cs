using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptedPuppet : gamePuppet
	{
		private CHandle<AIHumanComponent> _aiController;
		private CHandle<movePoliciesComponent> _movePolicies;
		private CHandle<AIPhaseStateEventHandlerComponent> _aiStateHandlerComponent;
		private CHandle<HitReactionComponent> _hitReactionComponent;
		private CHandle<AISignalHandlerComponent> _signalHandlerComponent;
		private CHandle<ReactionManagerComponent> _reactionComponent;
		private CHandle<gameDismembermentComponent> _dismembermentComponent;
		private CHandle<entSlotComponent> _hitRepresantation;
		private CHandle<gameinteractionsComponent> _interactionComponent;
		private CHandle<entSlotComponent> _slotComponent;
		private CHandle<senseComponent> _sensesComponent;
		private CHandle<senseVisibleObjectComponent> _visibleObjectComponent;
		private CHandle<senseSensorObjectComponent> _sensorObjectComponent;
		private CHandle<AITargetTrackerComponent> _targetTrackerComponent;
		private CArray<CHandle<gameTargetingComponent>> _targetingComponentsArray;
		private CHandle<NPCStatesComponent> _statesComponent;
		private CHandle<FxResourceMapperComponent> _fxResourceMapper;
		private LinkedStatusEffect _linkedStatusEffect;
		private CHandle<ResourceLibraryComponent> _resourceLibraryComponent;
		private CHandle<CrowdMemberBaseComponent> _crowdMemberComponent;
		private CHandle<gameInventory> _inventoryComponent;
		private CHandle<AIObjectSelectionComponent> _objectSelectionComponent;
		private CHandle<entTransformHistoryComponent> _transformHistoryComponent;
		private CHandle<entAnimationControllerComponent> _animationControllerComponent;
		private CHandle<gameinfluenceBumpComponent> _bumpComponent;
		private CBool _isCrowd;
		private CBool _isIconic;
		private CHandle<CombatHUDManager> _combatHUDManager;
		private CBool _exposePosition;
		private CHandle<gameIBlackboard> _puppetStateBlackboard;
		private CHandle<gameIBlackboard> _customBlackboard;
		private CUInt32 _securityAreaCallbackID;
		private CArray<CHandle<AICustomComponents>> _customAIComponents;
		private CArray<CHandle<PuppetListener>> _listeners;
		private CHandle<SecuritySupportListener> _securitySupportListener;
		private CHandle<RevealRequestsStorage> _shouldBeRevealedStorage;
		private CBool _inputProcessed;
		private CHandle<gameIBlackboard> _targetedBlackBoard;
		private CBool _shouldSpawnBloodPuddle;
		private CBool _bloodPuddleSpawned;
		private CBool _skipDeathAnimation;
		private CHandle<HitHistory> _hitHistory;
		private CArray<CName> _currentWorkspotTags;
		private CEnum<gamedataQuality> _lootQuality;
		private CBool _hasQuestItems;
		private CName _activeQualityRangeInteraction;
		private CHandle<gameWeakspotComponent> _weakspotComponent;
		private CHandle<FocusForcedHighlightData> _highlightData;
		private wCHandle<entEntity> _killer;
		private CHandle<gameObjectActionsCallbackController> _objectActionsCallbackCtrl;
		private AIUtilsCachedBoolValue _isActiveCached;
		private CBool _isCyberpsycho;
		private CBool _isCivilian;
		private CBool _isPolice;
		private CBool _isGanger;
		private CArray<gameItemID> _attemptedShards;

		[Ordinal(40)] 
		[RED("aiController")] 
		public CHandle<AIHumanComponent> AiController
		{
			get
			{
				if (_aiController == null)
				{
					_aiController = (CHandle<AIHumanComponent>) CR2WTypeManager.Create("handle:AIHumanComponent", "aiController", cr2w, this);
				}
				return _aiController;
			}
			set
			{
				if (_aiController == value)
				{
					return;
				}
				_aiController = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("movePolicies")] 
		public CHandle<movePoliciesComponent> MovePolicies
		{
			get
			{
				if (_movePolicies == null)
				{
					_movePolicies = (CHandle<movePoliciesComponent>) CR2WTypeManager.Create("handle:movePoliciesComponent", "movePolicies", cr2w, this);
				}
				return _movePolicies;
			}
			set
			{
				if (_movePolicies == value)
				{
					return;
				}
				_movePolicies = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("aiStateHandlerComponent")] 
		public CHandle<AIPhaseStateEventHandlerComponent> AiStateHandlerComponent
		{
			get
			{
				if (_aiStateHandlerComponent == null)
				{
					_aiStateHandlerComponent = (CHandle<AIPhaseStateEventHandlerComponent>) CR2WTypeManager.Create("handle:AIPhaseStateEventHandlerComponent", "aiStateHandlerComponent", cr2w, this);
				}
				return _aiStateHandlerComponent;
			}
			set
			{
				if (_aiStateHandlerComponent == value)
				{
					return;
				}
				_aiStateHandlerComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("hitReactionComponent")] 
		public CHandle<HitReactionComponent> HitReactionComponent
		{
			get
			{
				if (_hitReactionComponent == null)
				{
					_hitReactionComponent = (CHandle<HitReactionComponent>) CR2WTypeManager.Create("handle:HitReactionComponent", "hitReactionComponent", cr2w, this);
				}
				return _hitReactionComponent;
			}
			set
			{
				if (_hitReactionComponent == value)
				{
					return;
				}
				_hitReactionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("signalHandlerComponent")] 
		public CHandle<AISignalHandlerComponent> SignalHandlerComponent
		{
			get
			{
				if (_signalHandlerComponent == null)
				{
					_signalHandlerComponent = (CHandle<AISignalHandlerComponent>) CR2WTypeManager.Create("handle:AISignalHandlerComponent", "signalHandlerComponent", cr2w, this);
				}
				return _signalHandlerComponent;
			}
			set
			{
				if (_signalHandlerComponent == value)
				{
					return;
				}
				_signalHandlerComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("reactionComponent")] 
		public CHandle<ReactionManagerComponent> ReactionComponent
		{
			get
			{
				if (_reactionComponent == null)
				{
					_reactionComponent = (CHandle<ReactionManagerComponent>) CR2WTypeManager.Create("handle:ReactionManagerComponent", "reactionComponent", cr2w, this);
				}
				return _reactionComponent;
			}
			set
			{
				if (_reactionComponent == value)
				{
					return;
				}
				_reactionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("dismembermentComponent")] 
		public CHandle<gameDismembermentComponent> DismembermentComponent
		{
			get
			{
				if (_dismembermentComponent == null)
				{
					_dismembermentComponent = (CHandle<gameDismembermentComponent>) CR2WTypeManager.Create("handle:gameDismembermentComponent", "dismembermentComponent", cr2w, this);
				}
				return _dismembermentComponent;
			}
			set
			{
				if (_dismembermentComponent == value)
				{
					return;
				}
				_dismembermentComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("hitRepresantation")] 
		public CHandle<entSlotComponent> HitRepresantation
		{
			get
			{
				if (_hitRepresantation == null)
				{
					_hitRepresantation = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "hitRepresantation", cr2w, this);
				}
				return _hitRepresantation;
			}
			set
			{
				if (_hitRepresantation == value)
				{
					return;
				}
				_hitRepresantation = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("interactionComponent")] 
		public CHandle<gameinteractionsComponent> InteractionComponent
		{
			get
			{
				if (_interactionComponent == null)
				{
					_interactionComponent = (CHandle<gameinteractionsComponent>) CR2WTypeManager.Create("handle:gameinteractionsComponent", "interactionComponent", cr2w, this);
				}
				return _interactionComponent;
			}
			set
			{
				if (_interactionComponent == value)
				{
					return;
				}
				_interactionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get
			{
				if (_slotComponent == null)
				{
					_slotComponent = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "slotComponent", cr2w, this);
				}
				return _slotComponent;
			}
			set
			{
				if (_slotComponent == value)
				{
					return;
				}
				_slotComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("sensesComponent")] 
		public CHandle<senseComponent> SensesComponent
		{
			get
			{
				if (_sensesComponent == null)
				{
					_sensesComponent = (CHandle<senseComponent>) CR2WTypeManager.Create("handle:senseComponent", "sensesComponent", cr2w, this);
				}
				return _sensesComponent;
			}
			set
			{
				if (_sensesComponent == value)
				{
					return;
				}
				_sensesComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("visibleObjectComponent")] 
		public CHandle<senseVisibleObjectComponent> VisibleObjectComponent
		{
			get
			{
				if (_visibleObjectComponent == null)
				{
					_visibleObjectComponent = (CHandle<senseVisibleObjectComponent>) CR2WTypeManager.Create("handle:senseVisibleObjectComponent", "visibleObjectComponent", cr2w, this);
				}
				return _visibleObjectComponent;
			}
			set
			{
				if (_visibleObjectComponent == value)
				{
					return;
				}
				_visibleObjectComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("sensorObjectComponent")] 
		public CHandle<senseSensorObjectComponent> SensorObjectComponent
		{
			get
			{
				if (_sensorObjectComponent == null)
				{
					_sensorObjectComponent = (CHandle<senseSensorObjectComponent>) CR2WTypeManager.Create("handle:senseSensorObjectComponent", "sensorObjectComponent", cr2w, this);
				}
				return _sensorObjectComponent;
			}
			set
			{
				if (_sensorObjectComponent == value)
				{
					return;
				}
				_sensorObjectComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get
			{
				if (_targetTrackerComponent == null)
				{
					_targetTrackerComponent = (CHandle<AITargetTrackerComponent>) CR2WTypeManager.Create("handle:AITargetTrackerComponent", "targetTrackerComponent", cr2w, this);
				}
				return _targetTrackerComponent;
			}
			set
			{
				if (_targetTrackerComponent == value)
				{
					return;
				}
				_targetTrackerComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("targetingComponentsArray")] 
		public CArray<CHandle<gameTargetingComponent>> TargetingComponentsArray
		{
			get
			{
				if (_targetingComponentsArray == null)
				{
					_targetingComponentsArray = (CArray<CHandle<gameTargetingComponent>>) CR2WTypeManager.Create("array:handle:gameTargetingComponent", "targetingComponentsArray", cr2w, this);
				}
				return _targetingComponentsArray;
			}
			set
			{
				if (_targetingComponentsArray == value)
				{
					return;
				}
				_targetingComponentsArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("statesComponent")] 
		public CHandle<NPCStatesComponent> StatesComponent
		{
			get
			{
				if (_statesComponent == null)
				{
					_statesComponent = (CHandle<NPCStatesComponent>) CR2WTypeManager.Create("handle:NPCStatesComponent", "statesComponent", cr2w, this);
				}
				return _statesComponent;
			}
			set
			{
				if (_statesComponent == value)
				{
					return;
				}
				_statesComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("fxResourceMapper")] 
		public CHandle<FxResourceMapperComponent> FxResourceMapper
		{
			get
			{
				if (_fxResourceMapper == null)
				{
					_fxResourceMapper = (CHandle<FxResourceMapperComponent>) CR2WTypeManager.Create("handle:FxResourceMapperComponent", "fxResourceMapper", cr2w, this);
				}
				return _fxResourceMapper;
			}
			set
			{
				if (_fxResourceMapper == value)
				{
					return;
				}
				_fxResourceMapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("linkedStatusEffect")] 
		public LinkedStatusEffect LinkedStatusEffect
		{
			get
			{
				if (_linkedStatusEffect == null)
				{
					_linkedStatusEffect = (LinkedStatusEffect) CR2WTypeManager.Create("LinkedStatusEffect", "linkedStatusEffect", cr2w, this);
				}
				return _linkedStatusEffect;
			}
			set
			{
				if (_linkedStatusEffect == value)
				{
					return;
				}
				_linkedStatusEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get
			{
				if (_resourceLibraryComponent == null)
				{
					_resourceLibraryComponent = (CHandle<ResourceLibraryComponent>) CR2WTypeManager.Create("handle:ResourceLibraryComponent", "resourceLibraryComponent", cr2w, this);
				}
				return _resourceLibraryComponent;
			}
			set
			{
				if (_resourceLibraryComponent == value)
				{
					return;
				}
				_resourceLibraryComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("crowdMemberComponent")] 
		public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent
		{
			get
			{
				if (_crowdMemberComponent == null)
				{
					_crowdMemberComponent = (CHandle<CrowdMemberBaseComponent>) CR2WTypeManager.Create("handle:CrowdMemberBaseComponent", "crowdMemberComponent", cr2w, this);
				}
				return _crowdMemberComponent;
			}
			set
			{
				if (_crowdMemberComponent == value)
				{
					return;
				}
				_crowdMemberComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("inventoryComponent")] 
		public CHandle<gameInventory> InventoryComponent
		{
			get
			{
				if (_inventoryComponent == null)
				{
					_inventoryComponent = (CHandle<gameInventory>) CR2WTypeManager.Create("handle:gameInventory", "inventoryComponent", cr2w, this);
				}
				return _inventoryComponent;
			}
			set
			{
				if (_inventoryComponent == value)
				{
					return;
				}
				_inventoryComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("objectSelectionComponent")] 
		public CHandle<AIObjectSelectionComponent> ObjectSelectionComponent
		{
			get
			{
				if (_objectSelectionComponent == null)
				{
					_objectSelectionComponent = (CHandle<AIObjectSelectionComponent>) CR2WTypeManager.Create("handle:AIObjectSelectionComponent", "objectSelectionComponent", cr2w, this);
				}
				return _objectSelectionComponent;
			}
			set
			{
				if (_objectSelectionComponent == value)
				{
					return;
				}
				_objectSelectionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("transformHistoryComponent")] 
		public CHandle<entTransformHistoryComponent> TransformHistoryComponent
		{
			get
			{
				if (_transformHistoryComponent == null)
				{
					_transformHistoryComponent = (CHandle<entTransformHistoryComponent>) CR2WTypeManager.Create("handle:entTransformHistoryComponent", "transformHistoryComponent", cr2w, this);
				}
				return _transformHistoryComponent;
			}
			set
			{
				if (_transformHistoryComponent == value)
				{
					return;
				}
				_transformHistoryComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("animationControllerComponent")] 
		public CHandle<entAnimationControllerComponent> AnimationControllerComponent
		{
			get
			{
				if (_animationControllerComponent == null)
				{
					_animationControllerComponent = (CHandle<entAnimationControllerComponent>) CR2WTypeManager.Create("handle:entAnimationControllerComponent", "animationControllerComponent", cr2w, this);
				}
				return _animationControllerComponent;
			}
			set
			{
				if (_animationControllerComponent == value)
				{
					return;
				}
				_animationControllerComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("bumpComponent")] 
		public CHandle<gameinfluenceBumpComponent> BumpComponent
		{
			get
			{
				if (_bumpComponent == null)
				{
					_bumpComponent = (CHandle<gameinfluenceBumpComponent>) CR2WTypeManager.Create("handle:gameinfluenceBumpComponent", "bumpComponent", cr2w, this);
				}
				return _bumpComponent;
			}
			set
			{
				if (_bumpComponent == value)
				{
					return;
				}
				_bumpComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("isCrowd")] 
		public CBool IsCrowd
		{
			get
			{
				if (_isCrowd == null)
				{
					_isCrowd = (CBool) CR2WTypeManager.Create("Bool", "isCrowd", cr2w, this);
				}
				return _isCrowd;
			}
			set
			{
				if (_isCrowd == value)
				{
					return;
				}
				_isCrowd = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get
			{
				if (_isIconic == null)
				{
					_isIconic = (CBool) CR2WTypeManager.Create("Bool", "isIconic", cr2w, this);
				}
				return _isIconic;
			}
			set
			{
				if (_isIconic == value)
				{
					return;
				}
				_isIconic = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("combatHUDManager")] 
		public CHandle<CombatHUDManager> CombatHUDManager
		{
			get
			{
				if (_combatHUDManager == null)
				{
					_combatHUDManager = (CHandle<CombatHUDManager>) CR2WTypeManager.Create("handle:CombatHUDManager", "combatHUDManager", cr2w, this);
				}
				return _combatHUDManager;
			}
			set
			{
				if (_combatHUDManager == value)
				{
					return;
				}
				_combatHUDManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("exposePosition")] 
		public CBool ExposePosition
		{
			get
			{
				if (_exposePosition == null)
				{
					_exposePosition = (CBool) CR2WTypeManager.Create("Bool", "exposePosition", cr2w, this);
				}
				return _exposePosition;
			}
			set
			{
				if (_exposePosition == value)
				{
					return;
				}
				_exposePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("puppetStateBlackboard")] 
		public CHandle<gameIBlackboard> PuppetStateBlackboard
		{
			get
			{
				if (_puppetStateBlackboard == null)
				{
					_puppetStateBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "puppetStateBlackboard", cr2w, this);
				}
				return _puppetStateBlackboard;
			}
			set
			{
				if (_puppetStateBlackboard == value)
				{
					return;
				}
				_puppetStateBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("customBlackboard")] 
		public CHandle<gameIBlackboard> CustomBlackboard
		{
			get
			{
				if (_customBlackboard == null)
				{
					_customBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "customBlackboard", cr2w, this);
				}
				return _customBlackboard;
			}
			set
			{
				if (_customBlackboard == value)
				{
					return;
				}
				_customBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("securityAreaCallbackID")] 
		public CUInt32 SecurityAreaCallbackID
		{
			get
			{
				if (_securityAreaCallbackID == null)
				{
					_securityAreaCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "securityAreaCallbackID", cr2w, this);
				}
				return _securityAreaCallbackID;
			}
			set
			{
				if (_securityAreaCallbackID == value)
				{
					return;
				}
				_securityAreaCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("customAIComponents")] 
		public CArray<CHandle<AICustomComponents>> CustomAIComponents
		{
			get
			{
				if (_customAIComponents == null)
				{
					_customAIComponents = (CArray<CHandle<AICustomComponents>>) CR2WTypeManager.Create("array:handle:AICustomComponents", "customAIComponents", cr2w, this);
				}
				return _customAIComponents;
			}
			set
			{
				if (_customAIComponents == value)
				{
					return;
				}
				_customAIComponents = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("listeners")] 
		public CArray<CHandle<PuppetListener>> Listeners
		{
			get
			{
				if (_listeners == null)
				{
					_listeners = (CArray<CHandle<PuppetListener>>) CR2WTypeManager.Create("array:handle:PuppetListener", "listeners", cr2w, this);
				}
				return _listeners;
			}
			set
			{
				if (_listeners == value)
				{
					return;
				}
				_listeners = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("securitySupportListener")] 
		public CHandle<SecuritySupportListener> SecuritySupportListener
		{
			get
			{
				if (_securitySupportListener == null)
				{
					_securitySupportListener = (CHandle<SecuritySupportListener>) CR2WTypeManager.Create("handle:SecuritySupportListener", "securitySupportListener", cr2w, this);
				}
				return _securitySupportListener;
			}
			set
			{
				if (_securitySupportListener == value)
				{
					return;
				}
				_securitySupportListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("shouldBeRevealedStorage")] 
		public CHandle<RevealRequestsStorage> ShouldBeRevealedStorage
		{
			get
			{
				if (_shouldBeRevealedStorage == null)
				{
					_shouldBeRevealedStorage = (CHandle<RevealRequestsStorage>) CR2WTypeManager.Create("handle:RevealRequestsStorage", "shouldBeRevealedStorage", cr2w, this);
				}
				return _shouldBeRevealedStorage;
			}
			set
			{
				if (_shouldBeRevealedStorage == value)
				{
					return;
				}
				_shouldBeRevealedStorage = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("inputProcessed")] 
		public CBool InputProcessed
		{
			get
			{
				if (_inputProcessed == null)
				{
					_inputProcessed = (CBool) CR2WTypeManager.Create("Bool", "inputProcessed", cr2w, this);
				}
				return _inputProcessed;
			}
			set
			{
				if (_inputProcessed == value)
				{
					return;
				}
				_inputProcessed = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("targetedBlackBoard")] 
		public CHandle<gameIBlackboard> TargetedBlackBoard
		{
			get
			{
				if (_targetedBlackBoard == null)
				{
					_targetedBlackBoard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "targetedBlackBoard", cr2w, this);
				}
				return _targetedBlackBoard;
			}
			set
			{
				if (_targetedBlackBoard == value)
				{
					return;
				}
				_targetedBlackBoard = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("shouldSpawnBloodPuddle")] 
		public CBool ShouldSpawnBloodPuddle
		{
			get
			{
				if (_shouldSpawnBloodPuddle == null)
				{
					_shouldSpawnBloodPuddle = (CBool) CR2WTypeManager.Create("Bool", "shouldSpawnBloodPuddle", cr2w, this);
				}
				return _shouldSpawnBloodPuddle;
			}
			set
			{
				if (_shouldSpawnBloodPuddle == value)
				{
					return;
				}
				_shouldSpawnBloodPuddle = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("bloodPuddleSpawned")] 
		public CBool BloodPuddleSpawned
		{
			get
			{
				if (_bloodPuddleSpawned == null)
				{
					_bloodPuddleSpawned = (CBool) CR2WTypeManager.Create("Bool", "bloodPuddleSpawned", cr2w, this);
				}
				return _bloodPuddleSpawned;
			}
			set
			{
				if (_bloodPuddleSpawned == value)
				{
					return;
				}
				_bloodPuddleSpawned = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("skipDeathAnimation")] 
		public CBool SkipDeathAnimation
		{
			get
			{
				if (_skipDeathAnimation == null)
				{
					_skipDeathAnimation = (CBool) CR2WTypeManager.Create("Bool", "skipDeathAnimation", cr2w, this);
				}
				return _skipDeathAnimation;
			}
			set
			{
				if (_skipDeathAnimation == value)
				{
					return;
				}
				_skipDeathAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("hitHistory")] 
		public CHandle<HitHistory> HitHistory
		{
			get
			{
				if (_hitHistory == null)
				{
					_hitHistory = (CHandle<HitHistory>) CR2WTypeManager.Create("handle:HitHistory", "hitHistory", cr2w, this);
				}
				return _hitHistory;
			}
			set
			{
				if (_hitHistory == value)
				{
					return;
				}
				_hitHistory = value;
				PropertySet(this);
			}
		}

		[Ordinal(82)] 
		[RED("currentWorkspotTags")] 
		public CArray<CName> CurrentWorkspotTags
		{
			get
			{
				if (_currentWorkspotTags == null)
				{
					_currentWorkspotTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "currentWorkspotTags", cr2w, this);
				}
				return _currentWorkspotTags;
			}
			set
			{
				if (_currentWorkspotTags == value)
				{
					return;
				}
				_currentWorkspotTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(83)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get
			{
				if (_lootQuality == null)
				{
					_lootQuality = (CEnum<gamedataQuality>) CR2WTypeManager.Create("gamedataQuality", "lootQuality", cr2w, this);
				}
				return _lootQuality;
			}
			set
			{
				if (_lootQuality == value)
				{
					return;
				}
				_lootQuality = value;
				PropertySet(this);
			}
		}

		[Ordinal(84)] 
		[RED("hasQuestItems")] 
		public CBool HasQuestItems
		{
			get
			{
				if (_hasQuestItems == null)
				{
					_hasQuestItems = (CBool) CR2WTypeManager.Create("Bool", "hasQuestItems", cr2w, this);
				}
				return _hasQuestItems;
			}
			set
			{
				if (_hasQuestItems == value)
				{
					return;
				}
				_hasQuestItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(85)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get
			{
				if (_activeQualityRangeInteraction == null)
				{
					_activeQualityRangeInteraction = (CName) CR2WTypeManager.Create("CName", "activeQualityRangeInteraction", cr2w, this);
				}
				return _activeQualityRangeInteraction;
			}
			set
			{
				if (_activeQualityRangeInteraction == value)
				{
					return;
				}
				_activeQualityRangeInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(86)] 
		[RED("weakspotComponent")] 
		public CHandle<gameWeakspotComponent> WeakspotComponent
		{
			get
			{
				if (_weakspotComponent == null)
				{
					_weakspotComponent = (CHandle<gameWeakspotComponent>) CR2WTypeManager.Create("handle:gameWeakspotComponent", "weakspotComponent", cr2w, this);
				}
				return _weakspotComponent;
			}
			set
			{
				if (_weakspotComponent == value)
				{
					return;
				}
				_weakspotComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("highlightData")] 
		public CHandle<FocusForcedHighlightData> HighlightData
		{
			get
			{
				if (_highlightData == null)
				{
					_highlightData = (CHandle<FocusForcedHighlightData>) CR2WTypeManager.Create("handle:FocusForcedHighlightData", "highlightData", cr2w, this);
				}
				return _highlightData;
			}
			set
			{
				if (_highlightData == value)
				{
					return;
				}
				_highlightData = value;
				PropertySet(this);
			}
		}

		[Ordinal(88)] 
		[RED("killer")] 
		public wCHandle<entEntity> Killer
		{
			get
			{
				if (_killer == null)
				{
					_killer = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "killer", cr2w, this);
				}
				return _killer;
			}
			set
			{
				if (_killer == value)
				{
					return;
				}
				_killer = value;
				PropertySet(this);
			}
		}

		[Ordinal(89)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get
			{
				if (_objectActionsCallbackCtrl == null)
				{
					_objectActionsCallbackCtrl = (CHandle<gameObjectActionsCallbackController>) CR2WTypeManager.Create("handle:gameObjectActionsCallbackController", "objectActionsCallbackCtrl", cr2w, this);
				}
				return _objectActionsCallbackCtrl;
			}
			set
			{
				if (_objectActionsCallbackCtrl == value)
				{
					return;
				}
				_objectActionsCallbackCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(90)] 
		[RED("isActiveCached")] 
		public AIUtilsCachedBoolValue IsActiveCached
		{
			get
			{
				if (_isActiveCached == null)
				{
					_isActiveCached = (AIUtilsCachedBoolValue) CR2WTypeManager.Create("AIUtilsCachedBoolValue", "isActiveCached", cr2w, this);
				}
				return _isActiveCached;
			}
			set
			{
				if (_isActiveCached == value)
				{
					return;
				}
				_isActiveCached = value;
				PropertySet(this);
			}
		}

		[Ordinal(91)] 
		[RED("isCyberpsycho")] 
		public CBool IsCyberpsycho
		{
			get
			{
				if (_isCyberpsycho == null)
				{
					_isCyberpsycho = (CBool) CR2WTypeManager.Create("Bool", "isCyberpsycho", cr2w, this);
				}
				return _isCyberpsycho;
			}
			set
			{
				if (_isCyberpsycho == value)
				{
					return;
				}
				_isCyberpsycho = value;
				PropertySet(this);
			}
		}

		[Ordinal(92)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get
			{
				if (_isCivilian == null)
				{
					_isCivilian = (CBool) CR2WTypeManager.Create("Bool", "isCivilian", cr2w, this);
				}
				return _isCivilian;
			}
			set
			{
				if (_isCivilian == value)
				{
					return;
				}
				_isCivilian = value;
				PropertySet(this);
			}
		}

		[Ordinal(93)] 
		[RED("isPolice")] 
		public CBool IsPolice
		{
			get
			{
				if (_isPolice == null)
				{
					_isPolice = (CBool) CR2WTypeManager.Create("Bool", "isPolice", cr2w, this);
				}
				return _isPolice;
			}
			set
			{
				if (_isPolice == value)
				{
					return;
				}
				_isPolice = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("isGanger")] 
		public CBool IsGanger
		{
			get
			{
				if (_isGanger == null)
				{
					_isGanger = (CBool) CR2WTypeManager.Create("Bool", "isGanger", cr2w, this);
				}
				return _isGanger;
			}
			set
			{
				if (_isGanger == value)
				{
					return;
				}
				_isGanger = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("attemptedShards")] 
		public CArray<gameItemID> AttemptedShards
		{
			get
			{
				if (_attemptedShards == null)
				{
					_attemptedShards = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "attemptedShards", cr2w, this);
				}
				return _attemptedShards;
			}
			set
			{
				if (_attemptedShards == value)
				{
					return;
				}
				_attemptedShards = value;
				PropertySet(this);
			}
		}

		public ScriptedPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

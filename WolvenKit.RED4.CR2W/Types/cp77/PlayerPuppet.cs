using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerPuppet : ScriptedPuppet
	{
		private CHandle<QuickSlotsManager> _quickSlotsManager;
		private CHandle<InspectionComponent> _inspectionComponent;
		private CHandle<PlayerPhone> _phone;
		private CHandle<gameFPPCameraComponent> _fppCameraComponent;
		private CHandle<gameTargetingComponent> _primaryTargetingComponent;
		private CHandle<DEBUG_VisualizerComponent> _dEBUG_Visualizer;
		private CHandle<DEBUG_DamageInputReceiver> _debug_DamageInputRec;
		private CFloat _highDamageThreshold;
		private CFloat _medDamageThreshold;
		private CFloat _lowDamageThreshold;
		private CFloat _meleeHighDamageThreshold;
		private CFloat _meleeMedDamageThreshold;
		private CFloat _meleeLowDamageThreshold;
		private CFloat _explosionHighDamageThreshold;
		private CFloat _explosionMedDamageThreshold;
		private CFloat _explosionLowDamageThreshold;
		private CFloat _effectTimeStamp;
		private CFloat _curInventoryWeight;
		private CHandle<worldEffectBlackboard> _healthVfxBlackboard;
		private CHandle<worldEffectBlackboard> _laserTargettingVfxBlackboard;
		private CHandle<gameIBlackboard> _itemLogBlackboard;
		private wCHandle<gameObject> _lastScanTarget;
		private CBool _meleeSelectInputProcessed;
		private CBool _waitingForDelayEvent;
		private CFloat _randomizedTime;
		private CBool _isResetting;
		private gameDelayID _delayEventID;
		private gameDelayID _resetTickID;
		private CFloat _katanaAnimProgression;
		private CBool _coverModifierActive;
		private CBool _workspotDamageReductionActive;
		private CBool _workspotVisibilityReductionActive;
		private CArray<CName> _currentPlayerWorkspotTags;
		private CBool _incapacitated;
		private gameNewMappinID _remoteMappinId;
		private CHandle<CPOMissionDataState> _cPOMissionDataState;
		private CUInt32 _cPOMissionDataBbId;
		private CHandle<ArmorStatListener> _armorStatListener;
		private CHandle<HealthStatListener> _healthStatListener;
		private CHandle<OxygenStatListener> _oxygenStatListener;
		private CHandle<AimAssistSettingsListener> _aimAssistListener;
		private CHandle<AutoRevealStatListener> _autoRevealListener;
		private CBool _isTalkingOnPhone;
		private gameDelayID _dataDamageUpdateID;
		private CUInt32 _playerAttachedCallbackID;
		private CUInt32 _playerDetachedCallbackID;
		private CUInt32 _combatStateListener;
		private CUInt32 _locomotionStateListener;
		private CUInt32 _numberOfCombatantsListenerID;
		private CInt32 _numberOfCombatants;
		private CUInt32 _zoneChangeListener;
		private CBool _coverVisibilityPerkBlocked;
		private CBool _behindCover;
		private CBool _inCombat;
		private CBool _hasBeenDetected;
		private CBool _inCrouch;
		private CFloat _gunshotRange;
		private CFloat _explosionRange;
		private CInt32 _nextBufferModifier;
		private entEntityID _attackingNetrunnerID;
		private wCHandle<NPCPuppet> _nPCDeathInstigator;
		private wCHandle<gameweaponObject> _bestTargettingWeapon;
		private CFloat _bestTargettingDot;
		private CInt32 _targettingEnemies;
		private TweakDBID _coverRecordID;
		private TweakDBID _damageReductionRecordID;
		private TweakDBID _visReductionRecordID;
		private EngineTime _lastDmgInflicted;
		private CFloat _lowHealthNextRumbleTime;
		private CEnum<ESecurityAreaType> _securityAreaTypeE3HACK;
		private CArray<gamePersistentID> _overlappedSecurityZones;
		private InterestingFacts _interestingFacts;
		private InterestingFactsListenersIds _interestingFactsListenersIds;
		private InterestingFactsListenersFunctions _interestingFactsListenersFunctions;
		private CHandle<PlayerVisionModeController> _visionModeController;
		private CArray<TweakDBID> _cachedGameplayRestrictions;
		private gameDelayID _delayEndGracePeriodAfterSpawnEventID;
		private entEntityID _bossThatTargetsPlayer;
		private CUInt32 _choiceTokenTextLayerId;
		private CBool _choiceTokenTextDrawn;

		[Ordinal(96)] 
		[RED("quickSlotsManager")] 
		public CHandle<QuickSlotsManager> QuickSlotsManager
		{
			get
			{
				if (_quickSlotsManager == null)
				{
					_quickSlotsManager = (CHandle<QuickSlotsManager>) CR2WTypeManager.Create("handle:QuickSlotsManager", "quickSlotsManager", cr2w, this);
				}
				return _quickSlotsManager;
			}
			set
			{
				if (_quickSlotsManager == value)
				{
					return;
				}
				_quickSlotsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("inspectionComponent")] 
		public CHandle<InspectionComponent> InspectionComponent
		{
			get
			{
				if (_inspectionComponent == null)
				{
					_inspectionComponent = (CHandle<InspectionComponent>) CR2WTypeManager.Create("handle:InspectionComponent", "inspectionComponent", cr2w, this);
				}
				return _inspectionComponent;
			}
			set
			{
				if (_inspectionComponent == value)
				{
					return;
				}
				_inspectionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("Phone")] 
		public CHandle<PlayerPhone> Phone
		{
			get
			{
				if (_phone == null)
				{
					_phone = (CHandle<PlayerPhone>) CR2WTypeManager.Create("handle:PlayerPhone", "Phone", cr2w, this);
				}
				return _phone;
			}
			set
			{
				if (_phone == value)
				{
					return;
				}
				_phone = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("fppCameraComponent")] 
		public CHandle<gameFPPCameraComponent> FppCameraComponent
		{
			get
			{
				if (_fppCameraComponent == null)
				{
					_fppCameraComponent = (CHandle<gameFPPCameraComponent>) CR2WTypeManager.Create("handle:gameFPPCameraComponent", "fppCameraComponent", cr2w, this);
				}
				return _fppCameraComponent;
			}
			set
			{
				if (_fppCameraComponent == value)
				{
					return;
				}
				_fppCameraComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("primaryTargetingComponent")] 
		public CHandle<gameTargetingComponent> PrimaryTargetingComponent
		{
			get
			{
				if (_primaryTargetingComponent == null)
				{
					_primaryTargetingComponent = (CHandle<gameTargetingComponent>) CR2WTypeManager.Create("handle:gameTargetingComponent", "primaryTargetingComponent", cr2w, this);
				}
				return _primaryTargetingComponent;
			}
			set
			{
				if (_primaryTargetingComponent == value)
				{
					return;
				}
				_primaryTargetingComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("DEBUG_Visualizer")] 
		public CHandle<DEBUG_VisualizerComponent> DEBUG_Visualizer
		{
			get
			{
				if (_dEBUG_Visualizer == null)
				{
					_dEBUG_Visualizer = (CHandle<DEBUG_VisualizerComponent>) CR2WTypeManager.Create("handle:DEBUG_VisualizerComponent", "DEBUG_Visualizer", cr2w, this);
				}
				return _dEBUG_Visualizer;
			}
			set
			{
				if (_dEBUG_Visualizer == value)
				{
					return;
				}
				_dEBUG_Visualizer = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("Debug_DamageInputRec")] 
		public CHandle<DEBUG_DamageInputReceiver> Debug_DamageInputRec
		{
			get
			{
				if (_debug_DamageInputRec == null)
				{
					_debug_DamageInputRec = (CHandle<DEBUG_DamageInputReceiver>) CR2WTypeManager.Create("handle:DEBUG_DamageInputReceiver", "Debug_DamageInputRec", cr2w, this);
				}
				return _debug_DamageInputRec;
			}
			set
			{
				if (_debug_DamageInputRec == value)
				{
					return;
				}
				_debug_DamageInputRec = value;
				PropertySet(this);
			}
		}

		[Ordinal(103)] 
		[RED("highDamageThreshold")] 
		public CFloat HighDamageThreshold
		{
			get
			{
				if (_highDamageThreshold == null)
				{
					_highDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "highDamageThreshold", cr2w, this);
				}
				return _highDamageThreshold;
			}
			set
			{
				if (_highDamageThreshold == value)
				{
					return;
				}
				_highDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("medDamageThreshold")] 
		public CFloat MedDamageThreshold
		{
			get
			{
				if (_medDamageThreshold == null)
				{
					_medDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "medDamageThreshold", cr2w, this);
				}
				return _medDamageThreshold;
			}
			set
			{
				if (_medDamageThreshold == value)
				{
					return;
				}
				_medDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("lowDamageThreshold")] 
		public CFloat LowDamageThreshold
		{
			get
			{
				if (_lowDamageThreshold == null)
				{
					_lowDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "lowDamageThreshold", cr2w, this);
				}
				return _lowDamageThreshold;
			}
			set
			{
				if (_lowDamageThreshold == value)
				{
					return;
				}
				_lowDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("meleeHighDamageThreshold")] 
		public CFloat MeleeHighDamageThreshold
		{
			get
			{
				if (_meleeHighDamageThreshold == null)
				{
					_meleeHighDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "meleeHighDamageThreshold", cr2w, this);
				}
				return _meleeHighDamageThreshold;
			}
			set
			{
				if (_meleeHighDamageThreshold == value)
				{
					return;
				}
				_meleeHighDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("meleeMedDamageThreshold")] 
		public CFloat MeleeMedDamageThreshold
		{
			get
			{
				if (_meleeMedDamageThreshold == null)
				{
					_meleeMedDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "meleeMedDamageThreshold", cr2w, this);
				}
				return _meleeMedDamageThreshold;
			}
			set
			{
				if (_meleeMedDamageThreshold == value)
				{
					return;
				}
				_meleeMedDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("meleeLowDamageThreshold")] 
		public CFloat MeleeLowDamageThreshold
		{
			get
			{
				if (_meleeLowDamageThreshold == null)
				{
					_meleeLowDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "meleeLowDamageThreshold", cr2w, this);
				}
				return _meleeLowDamageThreshold;
			}
			set
			{
				if (_meleeLowDamageThreshold == value)
				{
					return;
				}
				_meleeLowDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("explosionHighDamageThreshold")] 
		public CFloat ExplosionHighDamageThreshold
		{
			get
			{
				if (_explosionHighDamageThreshold == null)
				{
					_explosionHighDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "explosionHighDamageThreshold", cr2w, this);
				}
				return _explosionHighDamageThreshold;
			}
			set
			{
				if (_explosionHighDamageThreshold == value)
				{
					return;
				}
				_explosionHighDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("explosionMedDamageThreshold")] 
		public CFloat ExplosionMedDamageThreshold
		{
			get
			{
				if (_explosionMedDamageThreshold == null)
				{
					_explosionMedDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "explosionMedDamageThreshold", cr2w, this);
				}
				return _explosionMedDamageThreshold;
			}
			set
			{
				if (_explosionMedDamageThreshold == value)
				{
					return;
				}
				_explosionMedDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("explosionLowDamageThreshold")] 
		public CFloat ExplosionLowDamageThreshold
		{
			get
			{
				if (_explosionLowDamageThreshold == null)
				{
					_explosionLowDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "explosionLowDamageThreshold", cr2w, this);
				}
				return _explosionLowDamageThreshold;
			}
			set
			{
				if (_explosionLowDamageThreshold == value)
				{
					return;
				}
				_explosionLowDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("effectTimeStamp")] 
		public CFloat EffectTimeStamp
		{
			get
			{
				if (_effectTimeStamp == null)
				{
					_effectTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "effectTimeStamp", cr2w, this);
				}
				return _effectTimeStamp;
			}
			set
			{
				if (_effectTimeStamp == value)
				{
					return;
				}
				_effectTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(113)] 
		[RED("curInventoryWeight")] 
		public CFloat CurInventoryWeight
		{
			get
			{
				if (_curInventoryWeight == null)
				{
					_curInventoryWeight = (CFloat) CR2WTypeManager.Create("Float", "curInventoryWeight", cr2w, this);
				}
				return _curInventoryWeight;
			}
			set
			{
				if (_curInventoryWeight == value)
				{
					return;
				}
				_curInventoryWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("healthVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> HealthVfxBlackboard
		{
			get
			{
				if (_healthVfxBlackboard == null)
				{
					_healthVfxBlackboard = (CHandle<worldEffectBlackboard>) CR2WTypeManager.Create("handle:worldEffectBlackboard", "healthVfxBlackboard", cr2w, this);
				}
				return _healthVfxBlackboard;
			}
			set
			{
				if (_healthVfxBlackboard == value)
				{
					return;
				}
				_healthVfxBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("laserTargettingVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> LaserTargettingVfxBlackboard
		{
			get
			{
				if (_laserTargettingVfxBlackboard == null)
				{
					_laserTargettingVfxBlackboard = (CHandle<worldEffectBlackboard>) CR2WTypeManager.Create("handle:worldEffectBlackboard", "laserTargettingVfxBlackboard", cr2w, this);
				}
				return _laserTargettingVfxBlackboard;
			}
			set
			{
				if (_laserTargettingVfxBlackboard == value)
				{
					return;
				}
				_laserTargettingVfxBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(116)] 
		[RED("itemLogBlackboard")] 
		public CHandle<gameIBlackboard> ItemLogBlackboard
		{
			get
			{
				if (_itemLogBlackboard == null)
				{
					_itemLogBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "itemLogBlackboard", cr2w, this);
				}
				return _itemLogBlackboard;
			}
			set
			{
				if (_itemLogBlackboard == value)
				{
					return;
				}
				_itemLogBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("lastScanTarget")] 
		public wCHandle<gameObject> LastScanTarget
		{
			get
			{
				if (_lastScanTarget == null)
				{
					_lastScanTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "lastScanTarget", cr2w, this);
				}
				return _lastScanTarget;
			}
			set
			{
				if (_lastScanTarget == value)
				{
					return;
				}
				_lastScanTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("meleeSelectInputProcessed")] 
		public CBool MeleeSelectInputProcessed
		{
			get
			{
				if (_meleeSelectInputProcessed == null)
				{
					_meleeSelectInputProcessed = (CBool) CR2WTypeManager.Create("Bool", "meleeSelectInputProcessed", cr2w, this);
				}
				return _meleeSelectInputProcessed;
			}
			set
			{
				if (_meleeSelectInputProcessed == value)
				{
					return;
				}
				_meleeSelectInputProcessed = value;
				PropertySet(this);
			}
		}

		[Ordinal(119)] 
		[RED("waitingForDelayEvent")] 
		public CBool WaitingForDelayEvent
		{
			get
			{
				if (_waitingForDelayEvent == null)
				{
					_waitingForDelayEvent = (CBool) CR2WTypeManager.Create("Bool", "waitingForDelayEvent", cr2w, this);
				}
				return _waitingForDelayEvent;
			}
			set
			{
				if (_waitingForDelayEvent == value)
				{
					return;
				}
				_waitingForDelayEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(120)] 
		[RED("randomizedTime")] 
		public CFloat RandomizedTime
		{
			get
			{
				if (_randomizedTime == null)
				{
					_randomizedTime = (CFloat) CR2WTypeManager.Create("Float", "randomizedTime", cr2w, this);
				}
				return _randomizedTime;
			}
			set
			{
				if (_randomizedTime == value)
				{
					return;
				}
				_randomizedTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(121)] 
		[RED("isResetting")] 
		public CBool IsResetting
		{
			get
			{
				if (_isResetting == null)
				{
					_isResetting = (CBool) CR2WTypeManager.Create("Bool", "isResetting", cr2w, this);
				}
				return _isResetting;
			}
			set
			{
				if (_isResetting == value)
				{
					return;
				}
				_isResetting = value;
				PropertySet(this);
			}
		}

		[Ordinal(122)] 
		[RED("delayEventID")] 
		public gameDelayID DelayEventID
		{
			get
			{
				if (_delayEventID == null)
				{
					_delayEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayEventID", cr2w, this);
				}
				return _delayEventID;
			}
			set
			{
				if (_delayEventID == value)
				{
					return;
				}
				_delayEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(123)] 
		[RED("resetTickID")] 
		public gameDelayID ResetTickID
		{
			get
			{
				if (_resetTickID == null)
				{
					_resetTickID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetTickID", cr2w, this);
				}
				return _resetTickID;
			}
			set
			{
				if (_resetTickID == value)
				{
					return;
				}
				_resetTickID = value;
				PropertySet(this);
			}
		}

		[Ordinal(124)] 
		[RED("katanaAnimProgression")] 
		public CFloat KatanaAnimProgression
		{
			get
			{
				if (_katanaAnimProgression == null)
				{
					_katanaAnimProgression = (CFloat) CR2WTypeManager.Create("Float", "katanaAnimProgression", cr2w, this);
				}
				return _katanaAnimProgression;
			}
			set
			{
				if (_katanaAnimProgression == value)
				{
					return;
				}
				_katanaAnimProgression = value;
				PropertySet(this);
			}
		}

		[Ordinal(125)] 
		[RED("coverModifierActive")] 
		public CBool CoverModifierActive
		{
			get
			{
				if (_coverModifierActive == null)
				{
					_coverModifierActive = (CBool) CR2WTypeManager.Create("Bool", "coverModifierActive", cr2w, this);
				}
				return _coverModifierActive;
			}
			set
			{
				if (_coverModifierActive == value)
				{
					return;
				}
				_coverModifierActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(126)] 
		[RED("workspotDamageReductionActive")] 
		public CBool WorkspotDamageReductionActive
		{
			get
			{
				if (_workspotDamageReductionActive == null)
				{
					_workspotDamageReductionActive = (CBool) CR2WTypeManager.Create("Bool", "workspotDamageReductionActive", cr2w, this);
				}
				return _workspotDamageReductionActive;
			}
			set
			{
				if (_workspotDamageReductionActive == value)
				{
					return;
				}
				_workspotDamageReductionActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(127)] 
		[RED("workspotVisibilityReductionActive")] 
		public CBool WorkspotVisibilityReductionActive
		{
			get
			{
				if (_workspotVisibilityReductionActive == null)
				{
					_workspotVisibilityReductionActive = (CBool) CR2WTypeManager.Create("Bool", "workspotVisibilityReductionActive", cr2w, this);
				}
				return _workspotVisibilityReductionActive;
			}
			set
			{
				if (_workspotVisibilityReductionActive == value)
				{
					return;
				}
				_workspotVisibilityReductionActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(128)] 
		[RED("currentPlayerWorkspotTags")] 
		public CArray<CName> CurrentPlayerWorkspotTags
		{
			get
			{
				if (_currentPlayerWorkspotTags == null)
				{
					_currentPlayerWorkspotTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "currentPlayerWorkspotTags", cr2w, this);
				}
				return _currentPlayerWorkspotTags;
			}
			set
			{
				if (_currentPlayerWorkspotTags == value)
				{
					return;
				}
				_currentPlayerWorkspotTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(129)] 
		[RED("incapacitated")] 
		public CBool Incapacitated
		{
			get
			{
				if (_incapacitated == null)
				{
					_incapacitated = (CBool) CR2WTypeManager.Create("Bool", "incapacitated", cr2w, this);
				}
				return _incapacitated;
			}
			set
			{
				if (_incapacitated == value)
				{
					return;
				}
				_incapacitated = value;
				PropertySet(this);
			}
		}

		[Ordinal(130)] 
		[RED("remoteMappinId")] 
		public gameNewMappinID RemoteMappinId
		{
			get
			{
				if (_remoteMappinId == null)
				{
					_remoteMappinId = (gameNewMappinID) CR2WTypeManager.Create("gameNewMappinID", "remoteMappinId", cr2w, this);
				}
				return _remoteMappinId;
			}
			set
			{
				if (_remoteMappinId == value)
				{
					return;
				}
				_remoteMappinId = value;
				PropertySet(this);
			}
		}

		[Ordinal(131)] 
		[RED("CPOMissionDataState")] 
		public CHandle<CPOMissionDataState> CPOMissionDataState
		{
			get
			{
				if (_cPOMissionDataState == null)
				{
					_cPOMissionDataState = (CHandle<CPOMissionDataState>) CR2WTypeManager.Create("handle:CPOMissionDataState", "CPOMissionDataState", cr2w, this);
				}
				return _cPOMissionDataState;
			}
			set
			{
				if (_cPOMissionDataState == value)
				{
					return;
				}
				_cPOMissionDataState = value;
				PropertySet(this);
			}
		}

		[Ordinal(132)] 
		[RED("CPOMissionDataBbId")] 
		public CUInt32 CPOMissionDataBbId
		{
			get
			{
				if (_cPOMissionDataBbId == null)
				{
					_cPOMissionDataBbId = (CUInt32) CR2WTypeManager.Create("Uint32", "CPOMissionDataBbId", cr2w, this);
				}
				return _cPOMissionDataBbId;
			}
			set
			{
				if (_cPOMissionDataBbId == value)
				{
					return;
				}
				_cPOMissionDataBbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(133)] 
		[RED("armorStatListener")] 
		public CHandle<ArmorStatListener> ArmorStatListener
		{
			get
			{
				if (_armorStatListener == null)
				{
					_armorStatListener = (CHandle<ArmorStatListener>) CR2WTypeManager.Create("handle:ArmorStatListener", "armorStatListener", cr2w, this);
				}
				return _armorStatListener;
			}
			set
			{
				if (_armorStatListener == value)
				{
					return;
				}
				_armorStatListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(134)] 
		[RED("healthStatListener")] 
		public CHandle<HealthStatListener> HealthStatListener
		{
			get
			{
				if (_healthStatListener == null)
				{
					_healthStatListener = (CHandle<HealthStatListener>) CR2WTypeManager.Create("handle:HealthStatListener", "healthStatListener", cr2w, this);
				}
				return _healthStatListener;
			}
			set
			{
				if (_healthStatListener == value)
				{
					return;
				}
				_healthStatListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(135)] 
		[RED("oxygenStatListener")] 
		public CHandle<OxygenStatListener> OxygenStatListener
		{
			get
			{
				if (_oxygenStatListener == null)
				{
					_oxygenStatListener = (CHandle<OxygenStatListener>) CR2WTypeManager.Create("handle:OxygenStatListener", "oxygenStatListener", cr2w, this);
				}
				return _oxygenStatListener;
			}
			set
			{
				if (_oxygenStatListener == value)
				{
					return;
				}
				_oxygenStatListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(136)] 
		[RED("aimAssistListener")] 
		public CHandle<AimAssistSettingsListener> AimAssistListener
		{
			get
			{
				if (_aimAssistListener == null)
				{
					_aimAssistListener = (CHandle<AimAssistSettingsListener>) CR2WTypeManager.Create("handle:AimAssistSettingsListener", "aimAssistListener", cr2w, this);
				}
				return _aimAssistListener;
			}
			set
			{
				if (_aimAssistListener == value)
				{
					return;
				}
				_aimAssistListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(137)] 
		[RED("autoRevealListener")] 
		public CHandle<AutoRevealStatListener> AutoRevealListener
		{
			get
			{
				if (_autoRevealListener == null)
				{
					_autoRevealListener = (CHandle<AutoRevealStatListener>) CR2WTypeManager.Create("handle:AutoRevealStatListener", "autoRevealListener", cr2w, this);
				}
				return _autoRevealListener;
			}
			set
			{
				if (_autoRevealListener == value)
				{
					return;
				}
				_autoRevealListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(138)] 
		[RED("isTalkingOnPhone")] 
		public CBool IsTalkingOnPhone
		{
			get
			{
				if (_isTalkingOnPhone == null)
				{
					_isTalkingOnPhone = (CBool) CR2WTypeManager.Create("Bool", "isTalkingOnPhone", cr2w, this);
				}
				return _isTalkingOnPhone;
			}
			set
			{
				if (_isTalkingOnPhone == value)
				{
					return;
				}
				_isTalkingOnPhone = value;
				PropertySet(this);
			}
		}

		[Ordinal(139)] 
		[RED("DataDamageUpdateID")] 
		public gameDelayID DataDamageUpdateID
		{
			get
			{
				if (_dataDamageUpdateID == null)
				{
					_dataDamageUpdateID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "DataDamageUpdateID", cr2w, this);
				}
				return _dataDamageUpdateID;
			}
			set
			{
				if (_dataDamageUpdateID == value)
				{
					return;
				}
				_dataDamageUpdateID = value;
				PropertySet(this);
			}
		}

		[Ordinal(140)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get
			{
				if (_playerAttachedCallbackID == null)
				{
					_playerAttachedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerAttachedCallbackID", cr2w, this);
				}
				return _playerAttachedCallbackID;
			}
			set
			{
				if (_playerAttachedCallbackID == value)
				{
					return;
				}
				_playerAttachedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(141)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get
			{
				if (_playerDetachedCallbackID == null)
				{
					_playerDetachedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerDetachedCallbackID", cr2w, this);
				}
				return _playerDetachedCallbackID;
			}
			set
			{
				if (_playerDetachedCallbackID == value)
				{
					return;
				}
				_playerDetachedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(142)] 
		[RED("combatStateListener")] 
		public CUInt32 CombatStateListener
		{
			get
			{
				if (_combatStateListener == null)
				{
					_combatStateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "combatStateListener", cr2w, this);
				}
				return _combatStateListener;
			}
			set
			{
				if (_combatStateListener == value)
				{
					return;
				}
				_combatStateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(143)] 
		[RED("LocomotionStateListener")] 
		public CUInt32 LocomotionStateListener
		{
			get
			{
				if (_locomotionStateListener == null)
				{
					_locomotionStateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "LocomotionStateListener", cr2w, this);
				}
				return _locomotionStateListener;
			}
			set
			{
				if (_locomotionStateListener == value)
				{
					return;
				}
				_locomotionStateListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(144)] 
		[RED("numberOfCombatantsListenerID")] 
		public CUInt32 NumberOfCombatantsListenerID
		{
			get
			{
				if (_numberOfCombatantsListenerID == null)
				{
					_numberOfCombatantsListenerID = (CUInt32) CR2WTypeManager.Create("Uint32", "numberOfCombatantsListenerID", cr2w, this);
				}
				return _numberOfCombatantsListenerID;
			}
			set
			{
				if (_numberOfCombatantsListenerID == value)
				{
					return;
				}
				_numberOfCombatantsListenerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(145)] 
		[RED("numberOfCombatants")] 
		public CInt32 NumberOfCombatants
		{
			get
			{
				if (_numberOfCombatants == null)
				{
					_numberOfCombatants = (CInt32) CR2WTypeManager.Create("Int32", "numberOfCombatants", cr2w, this);
				}
				return _numberOfCombatants;
			}
			set
			{
				if (_numberOfCombatants == value)
				{
					return;
				}
				_numberOfCombatants = value;
				PropertySet(this);
			}
		}

		[Ordinal(146)] 
		[RED("zoneChangeListener")] 
		public CUInt32 ZoneChangeListener
		{
			get
			{
				if (_zoneChangeListener == null)
				{
					_zoneChangeListener = (CUInt32) CR2WTypeManager.Create("Uint32", "zoneChangeListener", cr2w, this);
				}
				return _zoneChangeListener;
			}
			set
			{
				if (_zoneChangeListener == value)
				{
					return;
				}
				_zoneChangeListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(147)] 
		[RED("coverVisibilityPerkBlocked")] 
		public CBool CoverVisibilityPerkBlocked
		{
			get
			{
				if (_coverVisibilityPerkBlocked == null)
				{
					_coverVisibilityPerkBlocked = (CBool) CR2WTypeManager.Create("Bool", "coverVisibilityPerkBlocked", cr2w, this);
				}
				return _coverVisibilityPerkBlocked;
			}
			set
			{
				if (_coverVisibilityPerkBlocked == value)
				{
					return;
				}
				_coverVisibilityPerkBlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(148)] 
		[RED("behindCover")] 
		public CBool BehindCover
		{
			get
			{
				if (_behindCover == null)
				{
					_behindCover = (CBool) CR2WTypeManager.Create("Bool", "behindCover", cr2w, this);
				}
				return _behindCover;
			}
			set
			{
				if (_behindCover == value)
				{
					return;
				}
				_behindCover = value;
				PropertySet(this);
			}
		}

		[Ordinal(149)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get
			{
				if (_inCombat == null)
				{
					_inCombat = (CBool) CR2WTypeManager.Create("Bool", "inCombat", cr2w, this);
				}
				return _inCombat;
			}
			set
			{
				if (_inCombat == value)
				{
					return;
				}
				_inCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(150)] 
		[RED("hasBeenDetected")] 
		public CBool HasBeenDetected
		{
			get
			{
				if (_hasBeenDetected == null)
				{
					_hasBeenDetected = (CBool) CR2WTypeManager.Create("Bool", "hasBeenDetected", cr2w, this);
				}
				return _hasBeenDetected;
			}
			set
			{
				if (_hasBeenDetected == value)
				{
					return;
				}
				_hasBeenDetected = value;
				PropertySet(this);
			}
		}

		[Ordinal(151)] 
		[RED("inCrouch")] 
		public CBool InCrouch
		{
			get
			{
				if (_inCrouch == null)
				{
					_inCrouch = (CBool) CR2WTypeManager.Create("Bool", "inCrouch", cr2w, this);
				}
				return _inCrouch;
			}
			set
			{
				if (_inCrouch == value)
				{
					return;
				}
				_inCrouch = value;
				PropertySet(this);
			}
		}

		[Ordinal(152)] 
		[RED("gunshotRange")] 
		public CFloat GunshotRange
		{
			get
			{
				if (_gunshotRange == null)
				{
					_gunshotRange = (CFloat) CR2WTypeManager.Create("Float", "gunshotRange", cr2w, this);
				}
				return _gunshotRange;
			}
			set
			{
				if (_gunshotRange == value)
				{
					return;
				}
				_gunshotRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(153)] 
		[RED("explosionRange")] 
		public CFloat ExplosionRange
		{
			get
			{
				if (_explosionRange == null)
				{
					_explosionRange = (CFloat) CR2WTypeManager.Create("Float", "explosionRange", cr2w, this);
				}
				return _explosionRange;
			}
			set
			{
				if (_explosionRange == value)
				{
					return;
				}
				_explosionRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(154)] 
		[RED("nextBufferModifier")] 
		public CInt32 NextBufferModifier
		{
			get
			{
				if (_nextBufferModifier == null)
				{
					_nextBufferModifier = (CInt32) CR2WTypeManager.Create("Int32", "nextBufferModifier", cr2w, this);
				}
				return _nextBufferModifier;
			}
			set
			{
				if (_nextBufferModifier == value)
				{
					return;
				}
				_nextBufferModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(155)] 
		[RED("attackingNetrunnerID")] 
		public entEntityID AttackingNetrunnerID
		{
			get
			{
				if (_attackingNetrunnerID == null)
				{
					_attackingNetrunnerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "attackingNetrunnerID", cr2w, this);
				}
				return _attackingNetrunnerID;
			}
			set
			{
				if (_attackingNetrunnerID == value)
				{
					return;
				}
				_attackingNetrunnerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(156)] 
		[RED("NPCDeathInstigator")] 
		public wCHandle<NPCPuppet> NPCDeathInstigator
		{
			get
			{
				if (_nPCDeathInstigator == null)
				{
					_nPCDeathInstigator = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "NPCDeathInstigator", cr2w, this);
				}
				return _nPCDeathInstigator;
			}
			set
			{
				if (_nPCDeathInstigator == value)
				{
					return;
				}
				_nPCDeathInstigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(157)] 
		[RED("bestTargettingWeapon")] 
		public wCHandle<gameweaponObject> BestTargettingWeapon
		{
			get
			{
				if (_bestTargettingWeapon == null)
				{
					_bestTargettingWeapon = (wCHandle<gameweaponObject>) CR2WTypeManager.Create("whandle:gameweaponObject", "bestTargettingWeapon", cr2w, this);
				}
				return _bestTargettingWeapon;
			}
			set
			{
				if (_bestTargettingWeapon == value)
				{
					return;
				}
				_bestTargettingWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(158)] 
		[RED("bestTargettingDot")] 
		public CFloat BestTargettingDot
		{
			get
			{
				if (_bestTargettingDot == null)
				{
					_bestTargettingDot = (CFloat) CR2WTypeManager.Create("Float", "bestTargettingDot", cr2w, this);
				}
				return _bestTargettingDot;
			}
			set
			{
				if (_bestTargettingDot == value)
				{
					return;
				}
				_bestTargettingDot = value;
				PropertySet(this);
			}
		}

		[Ordinal(159)] 
		[RED("targettingEnemies")] 
		public CInt32 TargettingEnemies
		{
			get
			{
				if (_targettingEnemies == null)
				{
					_targettingEnemies = (CInt32) CR2WTypeManager.Create("Int32", "targettingEnemies", cr2w, this);
				}
				return _targettingEnemies;
			}
			set
			{
				if (_targettingEnemies == value)
				{
					return;
				}
				_targettingEnemies = value;
				PropertySet(this);
			}
		}

		[Ordinal(160)] 
		[RED("coverRecordID")] 
		public TweakDBID CoverRecordID
		{
			get
			{
				if (_coverRecordID == null)
				{
					_coverRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "coverRecordID", cr2w, this);
				}
				return _coverRecordID;
			}
			set
			{
				if (_coverRecordID == value)
				{
					return;
				}
				_coverRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(161)] 
		[RED("damageReductionRecordID")] 
		public TweakDBID DamageReductionRecordID
		{
			get
			{
				if (_damageReductionRecordID == null)
				{
					_damageReductionRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "damageReductionRecordID", cr2w, this);
				}
				return _damageReductionRecordID;
			}
			set
			{
				if (_damageReductionRecordID == value)
				{
					return;
				}
				_damageReductionRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(162)] 
		[RED("visReductionRecordID")] 
		public TweakDBID VisReductionRecordID
		{
			get
			{
				if (_visReductionRecordID == null)
				{
					_visReductionRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "visReductionRecordID", cr2w, this);
				}
				return _visReductionRecordID;
			}
			set
			{
				if (_visReductionRecordID == value)
				{
					return;
				}
				_visReductionRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(163)] 
		[RED("lastDmgInflicted")] 
		public EngineTime LastDmgInflicted
		{
			get
			{
				if (_lastDmgInflicted == null)
				{
					_lastDmgInflicted = (EngineTime) CR2WTypeManager.Create("EngineTime", "lastDmgInflicted", cr2w, this);
				}
				return _lastDmgInflicted;
			}
			set
			{
				if (_lastDmgInflicted == value)
				{
					return;
				}
				_lastDmgInflicted = value;
				PropertySet(this);
			}
		}

		[Ordinal(164)] 
		[RED("lowHealthNextRumbleTime")] 
		public CFloat LowHealthNextRumbleTime
		{
			get
			{
				if (_lowHealthNextRumbleTime == null)
				{
					_lowHealthNextRumbleTime = (CFloat) CR2WTypeManager.Create("Float", "lowHealthNextRumbleTime", cr2w, this);
				}
				return _lowHealthNextRumbleTime;
			}
			set
			{
				if (_lowHealthNextRumbleTime == value)
				{
					return;
				}
				_lowHealthNextRumbleTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(165)] 
		[RED("securityAreaTypeE3HACK")] 
		public CEnum<ESecurityAreaType> SecurityAreaTypeE3HACK
		{
			get
			{
				if (_securityAreaTypeE3HACK == null)
				{
					_securityAreaTypeE3HACK = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "securityAreaTypeE3HACK", cr2w, this);
				}
				return _securityAreaTypeE3HACK;
			}
			set
			{
				if (_securityAreaTypeE3HACK == value)
				{
					return;
				}
				_securityAreaTypeE3HACK = value;
				PropertySet(this);
			}
		}

		[Ordinal(166)] 
		[RED("overlappedSecurityZones")] 
		public CArray<gamePersistentID> OverlappedSecurityZones
		{
			get
			{
				if (_overlappedSecurityZones == null)
				{
					_overlappedSecurityZones = (CArray<gamePersistentID>) CR2WTypeManager.Create("array:gamePersistentID", "overlappedSecurityZones", cr2w, this);
				}
				return _overlappedSecurityZones;
			}
			set
			{
				if (_overlappedSecurityZones == value)
				{
					return;
				}
				_overlappedSecurityZones = value;
				PropertySet(this);
			}
		}

		[Ordinal(167)] 
		[RED("interestingFacts")] 
		public InterestingFacts InterestingFacts
		{
			get
			{
				if (_interestingFacts == null)
				{
					_interestingFacts = (InterestingFacts) CR2WTypeManager.Create("InterestingFacts", "interestingFacts", cr2w, this);
				}
				return _interestingFacts;
			}
			set
			{
				if (_interestingFacts == value)
				{
					return;
				}
				_interestingFacts = value;
				PropertySet(this);
			}
		}

		[Ordinal(168)] 
		[RED("interestingFactsListenersIds")] 
		public InterestingFactsListenersIds InterestingFactsListenersIds
		{
			get
			{
				if (_interestingFactsListenersIds == null)
				{
					_interestingFactsListenersIds = (InterestingFactsListenersIds) CR2WTypeManager.Create("InterestingFactsListenersIds", "interestingFactsListenersIds", cr2w, this);
				}
				return _interestingFactsListenersIds;
			}
			set
			{
				if (_interestingFactsListenersIds == value)
				{
					return;
				}
				_interestingFactsListenersIds = value;
				PropertySet(this);
			}
		}

		[Ordinal(169)] 
		[RED("interestingFactsListenersFunctions")] 
		public InterestingFactsListenersFunctions InterestingFactsListenersFunctions
		{
			get
			{
				if (_interestingFactsListenersFunctions == null)
				{
					_interestingFactsListenersFunctions = (InterestingFactsListenersFunctions) CR2WTypeManager.Create("InterestingFactsListenersFunctions", "interestingFactsListenersFunctions", cr2w, this);
				}
				return _interestingFactsListenersFunctions;
			}
			set
			{
				if (_interestingFactsListenersFunctions == value)
				{
					return;
				}
				_interestingFactsListenersFunctions = value;
				PropertySet(this);
			}
		}

		[Ordinal(170)] 
		[RED("visionModeController")] 
		public CHandle<PlayerVisionModeController> VisionModeController
		{
			get
			{
				if (_visionModeController == null)
				{
					_visionModeController = (CHandle<PlayerVisionModeController>) CR2WTypeManager.Create("handle:PlayerVisionModeController", "visionModeController", cr2w, this);
				}
				return _visionModeController;
			}
			set
			{
				if (_visionModeController == value)
				{
					return;
				}
				_visionModeController = value;
				PropertySet(this);
			}
		}

		[Ordinal(171)] 
		[RED("cachedGameplayRestrictions")] 
		public CArray<TweakDBID> CachedGameplayRestrictions
		{
			get
			{
				if (_cachedGameplayRestrictions == null)
				{
					_cachedGameplayRestrictions = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "cachedGameplayRestrictions", cr2w, this);
				}
				return _cachedGameplayRestrictions;
			}
			set
			{
				if (_cachedGameplayRestrictions == value)
				{
					return;
				}
				_cachedGameplayRestrictions = value;
				PropertySet(this);
			}
		}

		[Ordinal(172)] 
		[RED("delayEndGracePeriodAfterSpawnEventID")] 
		public gameDelayID DelayEndGracePeriodAfterSpawnEventID
		{
			get
			{
				if (_delayEndGracePeriodAfterSpawnEventID == null)
				{
					_delayEndGracePeriodAfterSpawnEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayEndGracePeriodAfterSpawnEventID", cr2w, this);
				}
				return _delayEndGracePeriodAfterSpawnEventID;
			}
			set
			{
				if (_delayEndGracePeriodAfterSpawnEventID == value)
				{
					return;
				}
				_delayEndGracePeriodAfterSpawnEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(173)] 
		[RED("bossThatTargetsPlayer")] 
		public entEntityID BossThatTargetsPlayer
		{
			get
			{
				if (_bossThatTargetsPlayer == null)
				{
					_bossThatTargetsPlayer = (entEntityID) CR2WTypeManager.Create("entEntityID", "bossThatTargetsPlayer", cr2w, this);
				}
				return _bossThatTargetsPlayer;
			}
			set
			{
				if (_bossThatTargetsPlayer == value)
				{
					return;
				}
				_bossThatTargetsPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(174)] 
		[RED("choiceTokenTextLayerId")] 
		public CUInt32 ChoiceTokenTextLayerId
		{
			get
			{
				if (_choiceTokenTextLayerId == null)
				{
					_choiceTokenTextLayerId = (CUInt32) CR2WTypeManager.Create("Uint32", "choiceTokenTextLayerId", cr2w, this);
				}
				return _choiceTokenTextLayerId;
			}
			set
			{
				if (_choiceTokenTextLayerId == value)
				{
					return;
				}
				_choiceTokenTextLayerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(175)] 
		[RED("choiceTokenTextDrawn")] 
		public CBool ChoiceTokenTextDrawn
		{
			get
			{
				if (_choiceTokenTextDrawn == null)
				{
					_choiceTokenTextDrawn = (CBool) CR2WTypeManager.Create("Bool", "choiceTokenTextDrawn", cr2w, this);
				}
				return _choiceTokenTextDrawn;
			}
			set
			{
				if (_choiceTokenTextDrawn == value)
				{
					return;
				}
				_choiceTokenTextDrawn = value;
				PropertySet(this);
			}
		}

		public PlayerPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

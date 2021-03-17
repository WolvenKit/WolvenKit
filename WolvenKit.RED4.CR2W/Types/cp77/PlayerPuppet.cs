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
			get => GetProperty(ref _quickSlotsManager);
			set => SetProperty(ref _quickSlotsManager, value);
		}

		[Ordinal(97)] 
		[RED("inspectionComponent")] 
		public CHandle<InspectionComponent> InspectionComponent
		{
			get => GetProperty(ref _inspectionComponent);
			set => SetProperty(ref _inspectionComponent, value);
		}

		[Ordinal(98)] 
		[RED("Phone")] 
		public CHandle<PlayerPhone> Phone
		{
			get => GetProperty(ref _phone);
			set => SetProperty(ref _phone, value);
		}

		[Ordinal(99)] 
		[RED("fppCameraComponent")] 
		public CHandle<gameFPPCameraComponent> FppCameraComponent
		{
			get => GetProperty(ref _fppCameraComponent);
			set => SetProperty(ref _fppCameraComponent, value);
		}

		[Ordinal(100)] 
		[RED("primaryTargetingComponent")] 
		public CHandle<gameTargetingComponent> PrimaryTargetingComponent
		{
			get => GetProperty(ref _primaryTargetingComponent);
			set => SetProperty(ref _primaryTargetingComponent, value);
		}

		[Ordinal(101)] 
		[RED("DEBUG_Visualizer")] 
		public CHandle<DEBUG_VisualizerComponent> DEBUG_Visualizer
		{
			get => GetProperty(ref _dEBUG_Visualizer);
			set => SetProperty(ref _dEBUG_Visualizer, value);
		}

		[Ordinal(102)] 
		[RED("Debug_DamageInputRec")] 
		public CHandle<DEBUG_DamageInputReceiver> Debug_DamageInputRec
		{
			get => GetProperty(ref _debug_DamageInputRec);
			set => SetProperty(ref _debug_DamageInputRec, value);
		}

		[Ordinal(103)] 
		[RED("highDamageThreshold")] 
		public CFloat HighDamageThreshold
		{
			get => GetProperty(ref _highDamageThreshold);
			set => SetProperty(ref _highDamageThreshold, value);
		}

		[Ordinal(104)] 
		[RED("medDamageThreshold")] 
		public CFloat MedDamageThreshold
		{
			get => GetProperty(ref _medDamageThreshold);
			set => SetProperty(ref _medDamageThreshold, value);
		}

		[Ordinal(105)] 
		[RED("lowDamageThreshold")] 
		public CFloat LowDamageThreshold
		{
			get => GetProperty(ref _lowDamageThreshold);
			set => SetProperty(ref _lowDamageThreshold, value);
		}

		[Ordinal(106)] 
		[RED("meleeHighDamageThreshold")] 
		public CFloat MeleeHighDamageThreshold
		{
			get => GetProperty(ref _meleeHighDamageThreshold);
			set => SetProperty(ref _meleeHighDamageThreshold, value);
		}

		[Ordinal(107)] 
		[RED("meleeMedDamageThreshold")] 
		public CFloat MeleeMedDamageThreshold
		{
			get => GetProperty(ref _meleeMedDamageThreshold);
			set => SetProperty(ref _meleeMedDamageThreshold, value);
		}

		[Ordinal(108)] 
		[RED("meleeLowDamageThreshold")] 
		public CFloat MeleeLowDamageThreshold
		{
			get => GetProperty(ref _meleeLowDamageThreshold);
			set => SetProperty(ref _meleeLowDamageThreshold, value);
		}

		[Ordinal(109)] 
		[RED("explosionHighDamageThreshold")] 
		public CFloat ExplosionHighDamageThreshold
		{
			get => GetProperty(ref _explosionHighDamageThreshold);
			set => SetProperty(ref _explosionHighDamageThreshold, value);
		}

		[Ordinal(110)] 
		[RED("explosionMedDamageThreshold")] 
		public CFloat ExplosionMedDamageThreshold
		{
			get => GetProperty(ref _explosionMedDamageThreshold);
			set => SetProperty(ref _explosionMedDamageThreshold, value);
		}

		[Ordinal(111)] 
		[RED("explosionLowDamageThreshold")] 
		public CFloat ExplosionLowDamageThreshold
		{
			get => GetProperty(ref _explosionLowDamageThreshold);
			set => SetProperty(ref _explosionLowDamageThreshold, value);
		}

		[Ordinal(112)] 
		[RED("effectTimeStamp")] 
		public CFloat EffectTimeStamp
		{
			get => GetProperty(ref _effectTimeStamp);
			set => SetProperty(ref _effectTimeStamp, value);
		}

		[Ordinal(113)] 
		[RED("curInventoryWeight")] 
		public CFloat CurInventoryWeight
		{
			get => GetProperty(ref _curInventoryWeight);
			set => SetProperty(ref _curInventoryWeight, value);
		}

		[Ordinal(114)] 
		[RED("healthVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> HealthVfxBlackboard
		{
			get => GetProperty(ref _healthVfxBlackboard);
			set => SetProperty(ref _healthVfxBlackboard, value);
		}

		[Ordinal(115)] 
		[RED("laserTargettingVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> LaserTargettingVfxBlackboard
		{
			get => GetProperty(ref _laserTargettingVfxBlackboard);
			set => SetProperty(ref _laserTargettingVfxBlackboard, value);
		}

		[Ordinal(116)] 
		[RED("itemLogBlackboard")] 
		public CHandle<gameIBlackboard> ItemLogBlackboard
		{
			get => GetProperty(ref _itemLogBlackboard);
			set => SetProperty(ref _itemLogBlackboard, value);
		}

		[Ordinal(117)] 
		[RED("lastScanTarget")] 
		public wCHandle<gameObject> LastScanTarget
		{
			get => GetProperty(ref _lastScanTarget);
			set => SetProperty(ref _lastScanTarget, value);
		}

		[Ordinal(118)] 
		[RED("meleeSelectInputProcessed")] 
		public CBool MeleeSelectInputProcessed
		{
			get => GetProperty(ref _meleeSelectInputProcessed);
			set => SetProperty(ref _meleeSelectInputProcessed, value);
		}

		[Ordinal(119)] 
		[RED("waitingForDelayEvent")] 
		public CBool WaitingForDelayEvent
		{
			get => GetProperty(ref _waitingForDelayEvent);
			set => SetProperty(ref _waitingForDelayEvent, value);
		}

		[Ordinal(120)] 
		[RED("randomizedTime")] 
		public CFloat RandomizedTime
		{
			get => GetProperty(ref _randomizedTime);
			set => SetProperty(ref _randomizedTime, value);
		}

		[Ordinal(121)] 
		[RED("isResetting")] 
		public CBool IsResetting
		{
			get => GetProperty(ref _isResetting);
			set => SetProperty(ref _isResetting, value);
		}

		[Ordinal(122)] 
		[RED("delayEventID")] 
		public gameDelayID DelayEventID
		{
			get => GetProperty(ref _delayEventID);
			set => SetProperty(ref _delayEventID, value);
		}

		[Ordinal(123)] 
		[RED("resetTickID")] 
		public gameDelayID ResetTickID
		{
			get => GetProperty(ref _resetTickID);
			set => SetProperty(ref _resetTickID, value);
		}

		[Ordinal(124)] 
		[RED("katanaAnimProgression")] 
		public CFloat KatanaAnimProgression
		{
			get => GetProperty(ref _katanaAnimProgression);
			set => SetProperty(ref _katanaAnimProgression, value);
		}

		[Ordinal(125)] 
		[RED("coverModifierActive")] 
		public CBool CoverModifierActive
		{
			get => GetProperty(ref _coverModifierActive);
			set => SetProperty(ref _coverModifierActive, value);
		}

		[Ordinal(126)] 
		[RED("workspotDamageReductionActive")] 
		public CBool WorkspotDamageReductionActive
		{
			get => GetProperty(ref _workspotDamageReductionActive);
			set => SetProperty(ref _workspotDamageReductionActive, value);
		}

		[Ordinal(127)] 
		[RED("workspotVisibilityReductionActive")] 
		public CBool WorkspotVisibilityReductionActive
		{
			get => GetProperty(ref _workspotVisibilityReductionActive);
			set => SetProperty(ref _workspotVisibilityReductionActive, value);
		}

		[Ordinal(128)] 
		[RED("currentPlayerWorkspotTags")] 
		public CArray<CName> CurrentPlayerWorkspotTags
		{
			get => GetProperty(ref _currentPlayerWorkspotTags);
			set => SetProperty(ref _currentPlayerWorkspotTags, value);
		}

		[Ordinal(129)] 
		[RED("incapacitated")] 
		public CBool Incapacitated
		{
			get => GetProperty(ref _incapacitated);
			set => SetProperty(ref _incapacitated, value);
		}

		[Ordinal(130)] 
		[RED("remoteMappinId")] 
		public gameNewMappinID RemoteMappinId
		{
			get => GetProperty(ref _remoteMappinId);
			set => SetProperty(ref _remoteMappinId, value);
		}

		[Ordinal(131)] 
		[RED("CPOMissionDataState")] 
		public CHandle<CPOMissionDataState> CPOMissionDataState
		{
			get => GetProperty(ref _cPOMissionDataState);
			set => SetProperty(ref _cPOMissionDataState, value);
		}

		[Ordinal(132)] 
		[RED("CPOMissionDataBbId")] 
		public CUInt32 CPOMissionDataBbId
		{
			get => GetProperty(ref _cPOMissionDataBbId);
			set => SetProperty(ref _cPOMissionDataBbId, value);
		}

		[Ordinal(133)] 
		[RED("armorStatListener")] 
		public CHandle<ArmorStatListener> ArmorStatListener
		{
			get => GetProperty(ref _armorStatListener);
			set => SetProperty(ref _armorStatListener, value);
		}

		[Ordinal(134)] 
		[RED("healthStatListener")] 
		public CHandle<HealthStatListener> HealthStatListener
		{
			get => GetProperty(ref _healthStatListener);
			set => SetProperty(ref _healthStatListener, value);
		}

		[Ordinal(135)] 
		[RED("oxygenStatListener")] 
		public CHandle<OxygenStatListener> OxygenStatListener
		{
			get => GetProperty(ref _oxygenStatListener);
			set => SetProperty(ref _oxygenStatListener, value);
		}

		[Ordinal(136)] 
		[RED("aimAssistListener")] 
		public CHandle<AimAssistSettingsListener> AimAssistListener
		{
			get => GetProperty(ref _aimAssistListener);
			set => SetProperty(ref _aimAssistListener, value);
		}

		[Ordinal(137)] 
		[RED("autoRevealListener")] 
		public CHandle<AutoRevealStatListener> AutoRevealListener
		{
			get => GetProperty(ref _autoRevealListener);
			set => SetProperty(ref _autoRevealListener, value);
		}

		[Ordinal(138)] 
		[RED("isTalkingOnPhone")] 
		public CBool IsTalkingOnPhone
		{
			get => GetProperty(ref _isTalkingOnPhone);
			set => SetProperty(ref _isTalkingOnPhone, value);
		}

		[Ordinal(139)] 
		[RED("DataDamageUpdateID")] 
		public gameDelayID DataDamageUpdateID
		{
			get => GetProperty(ref _dataDamageUpdateID);
			set => SetProperty(ref _dataDamageUpdateID, value);
		}

		[Ordinal(140)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetProperty(ref _playerAttachedCallbackID);
			set => SetProperty(ref _playerAttachedCallbackID, value);
		}

		[Ordinal(141)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetProperty(ref _playerDetachedCallbackID);
			set => SetProperty(ref _playerDetachedCallbackID, value);
		}

		[Ordinal(142)] 
		[RED("combatStateListener")] 
		public CUInt32 CombatStateListener
		{
			get => GetProperty(ref _combatStateListener);
			set => SetProperty(ref _combatStateListener, value);
		}

		[Ordinal(143)] 
		[RED("LocomotionStateListener")] 
		public CUInt32 LocomotionStateListener
		{
			get => GetProperty(ref _locomotionStateListener);
			set => SetProperty(ref _locomotionStateListener, value);
		}

		[Ordinal(144)] 
		[RED("numberOfCombatantsListenerID")] 
		public CUInt32 NumberOfCombatantsListenerID
		{
			get => GetProperty(ref _numberOfCombatantsListenerID);
			set => SetProperty(ref _numberOfCombatantsListenerID, value);
		}

		[Ordinal(145)] 
		[RED("numberOfCombatants")] 
		public CInt32 NumberOfCombatants
		{
			get => GetProperty(ref _numberOfCombatants);
			set => SetProperty(ref _numberOfCombatants, value);
		}

		[Ordinal(146)] 
		[RED("zoneChangeListener")] 
		public CUInt32 ZoneChangeListener
		{
			get => GetProperty(ref _zoneChangeListener);
			set => SetProperty(ref _zoneChangeListener, value);
		}

		[Ordinal(147)] 
		[RED("coverVisibilityPerkBlocked")] 
		public CBool CoverVisibilityPerkBlocked
		{
			get => GetProperty(ref _coverVisibilityPerkBlocked);
			set => SetProperty(ref _coverVisibilityPerkBlocked, value);
		}

		[Ordinal(148)] 
		[RED("behindCover")] 
		public CBool BehindCover
		{
			get => GetProperty(ref _behindCover);
			set => SetProperty(ref _behindCover, value);
		}

		[Ordinal(149)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get => GetProperty(ref _inCombat);
			set => SetProperty(ref _inCombat, value);
		}

		[Ordinal(150)] 
		[RED("hasBeenDetected")] 
		public CBool HasBeenDetected
		{
			get => GetProperty(ref _hasBeenDetected);
			set => SetProperty(ref _hasBeenDetected, value);
		}

		[Ordinal(151)] 
		[RED("inCrouch")] 
		public CBool InCrouch
		{
			get => GetProperty(ref _inCrouch);
			set => SetProperty(ref _inCrouch, value);
		}

		[Ordinal(152)] 
		[RED("gunshotRange")] 
		public CFloat GunshotRange
		{
			get => GetProperty(ref _gunshotRange);
			set => SetProperty(ref _gunshotRange, value);
		}

		[Ordinal(153)] 
		[RED("explosionRange")] 
		public CFloat ExplosionRange
		{
			get => GetProperty(ref _explosionRange);
			set => SetProperty(ref _explosionRange, value);
		}

		[Ordinal(154)] 
		[RED("nextBufferModifier")] 
		public CInt32 NextBufferModifier
		{
			get => GetProperty(ref _nextBufferModifier);
			set => SetProperty(ref _nextBufferModifier, value);
		}

		[Ordinal(155)] 
		[RED("attackingNetrunnerID")] 
		public entEntityID AttackingNetrunnerID
		{
			get => GetProperty(ref _attackingNetrunnerID);
			set => SetProperty(ref _attackingNetrunnerID, value);
		}

		[Ordinal(156)] 
		[RED("NPCDeathInstigator")] 
		public wCHandle<NPCPuppet> NPCDeathInstigator
		{
			get => GetProperty(ref _nPCDeathInstigator);
			set => SetProperty(ref _nPCDeathInstigator, value);
		}

		[Ordinal(157)] 
		[RED("bestTargettingWeapon")] 
		public wCHandle<gameweaponObject> BestTargettingWeapon
		{
			get => GetProperty(ref _bestTargettingWeapon);
			set => SetProperty(ref _bestTargettingWeapon, value);
		}

		[Ordinal(158)] 
		[RED("bestTargettingDot")] 
		public CFloat BestTargettingDot
		{
			get => GetProperty(ref _bestTargettingDot);
			set => SetProperty(ref _bestTargettingDot, value);
		}

		[Ordinal(159)] 
		[RED("targettingEnemies")] 
		public CInt32 TargettingEnemies
		{
			get => GetProperty(ref _targettingEnemies);
			set => SetProperty(ref _targettingEnemies, value);
		}

		[Ordinal(160)] 
		[RED("coverRecordID")] 
		public TweakDBID CoverRecordID
		{
			get => GetProperty(ref _coverRecordID);
			set => SetProperty(ref _coverRecordID, value);
		}

		[Ordinal(161)] 
		[RED("damageReductionRecordID")] 
		public TweakDBID DamageReductionRecordID
		{
			get => GetProperty(ref _damageReductionRecordID);
			set => SetProperty(ref _damageReductionRecordID, value);
		}

		[Ordinal(162)] 
		[RED("visReductionRecordID")] 
		public TweakDBID VisReductionRecordID
		{
			get => GetProperty(ref _visReductionRecordID);
			set => SetProperty(ref _visReductionRecordID, value);
		}

		[Ordinal(163)] 
		[RED("lastDmgInflicted")] 
		public EngineTime LastDmgInflicted
		{
			get => GetProperty(ref _lastDmgInflicted);
			set => SetProperty(ref _lastDmgInflicted, value);
		}

		[Ordinal(164)] 
		[RED("lowHealthNextRumbleTime")] 
		public CFloat LowHealthNextRumbleTime
		{
			get => GetProperty(ref _lowHealthNextRumbleTime);
			set => SetProperty(ref _lowHealthNextRumbleTime, value);
		}

		[Ordinal(165)] 
		[RED("securityAreaTypeE3HACK")] 
		public CEnum<ESecurityAreaType> SecurityAreaTypeE3HACK
		{
			get => GetProperty(ref _securityAreaTypeE3HACK);
			set => SetProperty(ref _securityAreaTypeE3HACK, value);
		}

		[Ordinal(166)] 
		[RED("overlappedSecurityZones")] 
		public CArray<gamePersistentID> OverlappedSecurityZones
		{
			get => GetProperty(ref _overlappedSecurityZones);
			set => SetProperty(ref _overlappedSecurityZones, value);
		}

		[Ordinal(167)] 
		[RED("interestingFacts")] 
		public InterestingFacts InterestingFacts
		{
			get => GetProperty(ref _interestingFacts);
			set => SetProperty(ref _interestingFacts, value);
		}

		[Ordinal(168)] 
		[RED("interestingFactsListenersIds")] 
		public InterestingFactsListenersIds InterestingFactsListenersIds
		{
			get => GetProperty(ref _interestingFactsListenersIds);
			set => SetProperty(ref _interestingFactsListenersIds, value);
		}

		[Ordinal(169)] 
		[RED("interestingFactsListenersFunctions")] 
		public InterestingFactsListenersFunctions InterestingFactsListenersFunctions
		{
			get => GetProperty(ref _interestingFactsListenersFunctions);
			set => SetProperty(ref _interestingFactsListenersFunctions, value);
		}

		[Ordinal(170)] 
		[RED("visionModeController")] 
		public CHandle<PlayerVisionModeController> VisionModeController
		{
			get => GetProperty(ref _visionModeController);
			set => SetProperty(ref _visionModeController, value);
		}

		[Ordinal(171)] 
		[RED("cachedGameplayRestrictions")] 
		public CArray<TweakDBID> CachedGameplayRestrictions
		{
			get => GetProperty(ref _cachedGameplayRestrictions);
			set => SetProperty(ref _cachedGameplayRestrictions, value);
		}

		[Ordinal(172)] 
		[RED("delayEndGracePeriodAfterSpawnEventID")] 
		public gameDelayID DelayEndGracePeriodAfterSpawnEventID
		{
			get => GetProperty(ref _delayEndGracePeriodAfterSpawnEventID);
			set => SetProperty(ref _delayEndGracePeriodAfterSpawnEventID, value);
		}

		[Ordinal(173)] 
		[RED("bossThatTargetsPlayer")] 
		public entEntityID BossThatTargetsPlayer
		{
			get => GetProperty(ref _bossThatTargetsPlayer);
			set => SetProperty(ref _bossThatTargetsPlayer, value);
		}

		[Ordinal(174)] 
		[RED("choiceTokenTextLayerId")] 
		public CUInt32 ChoiceTokenTextLayerId
		{
			get => GetProperty(ref _choiceTokenTextLayerId);
			set => SetProperty(ref _choiceTokenTextLayerId, value);
		}

		[Ordinal(175)] 
		[RED("choiceTokenTextDrawn")] 
		public CBool ChoiceTokenTextDrawn
		{
			get => GetProperty(ref _choiceTokenTextDrawn);
			set => SetProperty(ref _choiceTokenTextDrawn, value);
		}

		public PlayerPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiStealthMappinController : gameuiInteractionMappinController
	{
		private inkImageWidgetReference _animImage;
		private inkImageWidgetReference _arrow;
		private inkWidgetReference _fill;
		private inkWidgetReference _eyeFillWhite;
		private inkWidgetReference _eyeFillBlack;
		private inkTextWidgetReference _markExclamation;
		private inkTextWidgetReference _distance;
		private inkWidgetReference _mainArt;
		private inkImageWidgetReference _frame;
		private CName _eliteFrameName;
		private Vector2 _eliteFrameSize;
		private inkWidgetReference _objectMarker;
		private inkImageWidgetReference _levelIcon;
		private inkWidgetReference _statusEffectHolder;
		private inkImageWidgetReference _statusEffectIcon;
		private inkTextWidgetReference _statusEffectTimer;
		private inkWidgetReference _taggedContainer;
		private CWeakHandle<gameObject> _ownerObject;
		private CWeakHandle<NPCPuppet> _ownerNPC;
		private CWeakHandle<Device> _ownerDevice;
		private CWeakHandle<gamemappinsStealthMappin> _mappin;
		private CWeakHandle<inkWidget> _root;
		private CWeakHandle<inkWidget> _canvas;
		private CWeakHandle<gameuiNpcNameplateGameController> _nameplateController;
		private CBool _isFriendly;
		private CBool _isFriendlyFromHack;
		private CBool _isHostile;
		private CBool _isAggressive;
		private CBool _isDevice;
		private CBool _isDrone;
		private CBool _isMech;
		private CBool _isCamera;
		private CBool _isTurret;
		private CBool _isHiddenByQuest;
		private CEnum<gamedataNPCRarity> _nPCRarity;
		private CWeakHandle<gameIBlackboard> _puppetStateBlackboard;
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private CInt32 _numberOfCombatants;
		private CBool _waitingToExitCombat;
		private CEnum<gamedataOutput> _reaction;
		private CEnum<gamedataNPCHighLevelState> _lastState;
		private CEnum<gamedataOutput> _lastReaction;
		private CFloat _lastPercent;
		private CBool _canSeePlayer;
		private CBool _squadInCombat;
		private CName _archetypeTextureName;
		private CBool _isTagged;
		private CBool _canHaveObjectMarker;
		private CBool _canShowObjectMarker;
		private CBool _objectMarkerVisible;
		private CBool _nameplateVisible;
		private CBool _detectionVisible;
		private CBool _inNameplateMode;
		private CBool _objectMarkerFirstShowing;
		private CBool _statusEffectShowing;
		private CFloat _statusEffectCurrentPriority;
		private CBool _animationIsPlaying;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _nameplateAnimationProxy;
		private CBool _nameplateAnimationIsPlaying;
		private CHandle<inkanimProxy> _reprimandAnimationProxy;
		private CBool _reprimandAnimationIsPlaying;
		private CEnum<gameReprimandMappinAnimationState> _reprimandAnimationState;
		private CEnum<gameEnemyStealthAwarenessState> _currentAnimState;
		private CFloat _c_emptyThreshold;
		private CFloat _c_awareToCombatThreshold;
		private CFloat _c_combatToAwareThreshold;
		private CFloat _c_deviceCombatToAwareThreshold;
		private CFloat _c_objectMarkerMaxDistance;
		private CFloat _c_objectMarkerMaxCameraDistance;

		[Ordinal(11)] 
		[RED("animImage")] 
		public inkImageWidgetReference AnimImage
		{
			get => GetProperty(ref _animImage);
			set => SetProperty(ref _animImage, value);
		}

		[Ordinal(12)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetProperty(ref _arrow);
			set => SetProperty(ref _arrow, value);
		}

		[Ordinal(13)] 
		[RED("fill")] 
		public inkWidgetReference Fill
		{
			get => GetProperty(ref _fill);
			set => SetProperty(ref _fill, value);
		}

		[Ordinal(14)] 
		[RED("eyeFillWhite")] 
		public inkWidgetReference EyeFillWhite
		{
			get => GetProperty(ref _eyeFillWhite);
			set => SetProperty(ref _eyeFillWhite, value);
		}

		[Ordinal(15)] 
		[RED("eyeFillBlack")] 
		public inkWidgetReference EyeFillBlack
		{
			get => GetProperty(ref _eyeFillBlack);
			set => SetProperty(ref _eyeFillBlack, value);
		}

		[Ordinal(16)] 
		[RED("markExclamation")] 
		public inkTextWidgetReference MarkExclamation
		{
			get => GetProperty(ref _markExclamation);
			set => SetProperty(ref _markExclamation, value);
		}

		[Ordinal(17)] 
		[RED("distance")] 
		public inkTextWidgetReference Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(18)] 
		[RED("mainArt")] 
		public inkWidgetReference MainArt
		{
			get => GetProperty(ref _mainArt);
			set => SetProperty(ref _mainArt, value);
		}

		[Ordinal(19)] 
		[RED("frame")] 
		public inkImageWidgetReference Frame
		{
			get => GetProperty(ref _frame);
			set => SetProperty(ref _frame, value);
		}

		[Ordinal(20)] 
		[RED("eliteFrameName")] 
		public CName EliteFrameName
		{
			get => GetProperty(ref _eliteFrameName);
			set => SetProperty(ref _eliteFrameName, value);
		}

		[Ordinal(21)] 
		[RED("eliteFrameSize")] 
		public Vector2 EliteFrameSize
		{
			get => GetProperty(ref _eliteFrameSize);
			set => SetProperty(ref _eliteFrameSize, value);
		}

		[Ordinal(22)] 
		[RED("objectMarker")] 
		public inkWidgetReference ObjectMarker
		{
			get => GetProperty(ref _objectMarker);
			set => SetProperty(ref _objectMarker, value);
		}

		[Ordinal(23)] 
		[RED("levelIcon")] 
		public inkImageWidgetReference LevelIcon
		{
			get => GetProperty(ref _levelIcon);
			set => SetProperty(ref _levelIcon, value);
		}

		[Ordinal(24)] 
		[RED("statusEffectHolder")] 
		public inkWidgetReference StatusEffectHolder
		{
			get => GetProperty(ref _statusEffectHolder);
			set => SetProperty(ref _statusEffectHolder, value);
		}

		[Ordinal(25)] 
		[RED("statusEffectIcon")] 
		public inkImageWidgetReference StatusEffectIcon
		{
			get => GetProperty(ref _statusEffectIcon);
			set => SetProperty(ref _statusEffectIcon, value);
		}

		[Ordinal(26)] 
		[RED("statusEffectTimer")] 
		public inkTextWidgetReference StatusEffectTimer
		{
			get => GetProperty(ref _statusEffectTimer);
			set => SetProperty(ref _statusEffectTimer, value);
		}

		[Ordinal(27)] 
		[RED("taggedContainer")] 
		public inkWidgetReference TaggedContainer
		{
			get => GetProperty(ref _taggedContainer);
			set => SetProperty(ref _taggedContainer, value);
		}

		[Ordinal(28)] 
		[RED("ownerObject")] 
		public CWeakHandle<gameObject> OwnerObject
		{
			get => GetProperty(ref _ownerObject);
			set => SetProperty(ref _ownerObject, value);
		}

		[Ordinal(29)] 
		[RED("ownerNPC")] 
		public CWeakHandle<NPCPuppet> OwnerNPC
		{
			get => GetProperty(ref _ownerNPC);
			set => SetProperty(ref _ownerNPC, value);
		}

		[Ordinal(30)] 
		[RED("ownerDevice")] 
		public CWeakHandle<Device> OwnerDevice
		{
			get => GetProperty(ref _ownerDevice);
			set => SetProperty(ref _ownerDevice, value);
		}

		[Ordinal(31)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsStealthMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(32)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(33)] 
		[RED("canvas")] 
		public CWeakHandle<inkWidget> Canvas
		{
			get => GetProperty(ref _canvas);
			set => SetProperty(ref _canvas, value);
		}

		[Ordinal(34)] 
		[RED("nameplateController")] 
		public CWeakHandle<gameuiNpcNameplateGameController> NameplateController
		{
			get => GetProperty(ref _nameplateController);
			set => SetProperty(ref _nameplateController, value);
		}

		[Ordinal(35)] 
		[RED("isFriendly")] 
		public CBool IsFriendly
		{
			get => GetProperty(ref _isFriendly);
			set => SetProperty(ref _isFriendly, value);
		}

		[Ordinal(36)] 
		[RED("isFriendlyFromHack")] 
		public CBool IsFriendlyFromHack
		{
			get => GetProperty(ref _isFriendlyFromHack);
			set => SetProperty(ref _isFriendlyFromHack, value);
		}

		[Ordinal(37)] 
		[RED("isHostile")] 
		public CBool IsHostile
		{
			get => GetProperty(ref _isHostile);
			set => SetProperty(ref _isHostile, value);
		}

		[Ordinal(38)] 
		[RED("isAggressive")] 
		public CBool IsAggressive
		{
			get => GetProperty(ref _isAggressive);
			set => SetProperty(ref _isAggressive, value);
		}

		[Ordinal(39)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get => GetProperty(ref _isDevice);
			set => SetProperty(ref _isDevice, value);
		}

		[Ordinal(40)] 
		[RED("isDrone")] 
		public CBool IsDrone
		{
			get => GetProperty(ref _isDrone);
			set => SetProperty(ref _isDrone, value);
		}

		[Ordinal(41)] 
		[RED("isMech")] 
		public CBool IsMech
		{
			get => GetProperty(ref _isMech);
			set => SetProperty(ref _isMech, value);
		}

		[Ordinal(42)] 
		[RED("isCamera")] 
		public CBool IsCamera
		{
			get => GetProperty(ref _isCamera);
			set => SetProperty(ref _isCamera, value);
		}

		[Ordinal(43)] 
		[RED("isTurret")] 
		public CBool IsTurret
		{
			get => GetProperty(ref _isTurret);
			set => SetProperty(ref _isTurret, value);
		}

		[Ordinal(44)] 
		[RED("isHiddenByQuest")] 
		public CBool IsHiddenByQuest
		{
			get => GetProperty(ref _isHiddenByQuest);
			set => SetProperty(ref _isHiddenByQuest, value);
		}

		[Ordinal(45)] 
		[RED("NPCRarity")] 
		public CEnum<gamedataNPCRarity> NPCRarity
		{
			get => GetProperty(ref _nPCRarity);
			set => SetProperty(ref _nPCRarity, value);
		}

		[Ordinal(46)] 
		[RED("puppetStateBlackboard")] 
		public CWeakHandle<gameIBlackboard> PuppetStateBlackboard
		{
			get => GetProperty(ref _puppetStateBlackboard);
			set => SetProperty(ref _puppetStateBlackboard, value);
		}

		[Ordinal(47)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetProperty(ref _highLevelState);
			set => SetProperty(ref _highLevelState, value);
		}

		[Ordinal(48)] 
		[RED("numberOfCombatants")] 
		public CInt32 NumberOfCombatants
		{
			get => GetProperty(ref _numberOfCombatants);
			set => SetProperty(ref _numberOfCombatants, value);
		}

		[Ordinal(49)] 
		[RED("waitingToExitCombat")] 
		public CBool WaitingToExitCombat
		{
			get => GetProperty(ref _waitingToExitCombat);
			set => SetProperty(ref _waitingToExitCombat, value);
		}

		[Ordinal(50)] 
		[RED("reaction")] 
		public CEnum<gamedataOutput> Reaction
		{
			get => GetProperty(ref _reaction);
			set => SetProperty(ref _reaction, value);
		}

		[Ordinal(51)] 
		[RED("lastState")] 
		public CEnum<gamedataNPCHighLevelState> LastState
		{
			get => GetProperty(ref _lastState);
			set => SetProperty(ref _lastState, value);
		}

		[Ordinal(52)] 
		[RED("lastReaction")] 
		public CEnum<gamedataOutput> LastReaction
		{
			get => GetProperty(ref _lastReaction);
			set => SetProperty(ref _lastReaction, value);
		}

		[Ordinal(53)] 
		[RED("lastPercent")] 
		public CFloat LastPercent
		{
			get => GetProperty(ref _lastPercent);
			set => SetProperty(ref _lastPercent, value);
		}

		[Ordinal(54)] 
		[RED("canSeePlayer")] 
		public CBool CanSeePlayer
		{
			get => GetProperty(ref _canSeePlayer);
			set => SetProperty(ref _canSeePlayer, value);
		}

		[Ordinal(55)] 
		[RED("squadInCombat")] 
		public CBool SquadInCombat
		{
			get => GetProperty(ref _squadInCombat);
			set => SetProperty(ref _squadInCombat, value);
		}

		[Ordinal(56)] 
		[RED("archetypeTextureName")] 
		public CName ArchetypeTextureName
		{
			get => GetProperty(ref _archetypeTextureName);
			set => SetProperty(ref _archetypeTextureName, value);
		}

		[Ordinal(57)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetProperty(ref _isTagged);
			set => SetProperty(ref _isTagged, value);
		}

		[Ordinal(58)] 
		[RED("canHaveObjectMarker")] 
		public CBool CanHaveObjectMarker
		{
			get => GetProperty(ref _canHaveObjectMarker);
			set => SetProperty(ref _canHaveObjectMarker, value);
		}

		[Ordinal(59)] 
		[RED("canShowObjectMarker")] 
		public CBool CanShowObjectMarker
		{
			get => GetProperty(ref _canShowObjectMarker);
			set => SetProperty(ref _canShowObjectMarker, value);
		}

		[Ordinal(60)] 
		[RED("objectMarkerVisible")] 
		public CBool ObjectMarkerVisible
		{
			get => GetProperty(ref _objectMarkerVisible);
			set => SetProperty(ref _objectMarkerVisible, value);
		}

		[Ordinal(61)] 
		[RED("nameplateVisible")] 
		public CBool NameplateVisible
		{
			get => GetProperty(ref _nameplateVisible);
			set => SetProperty(ref _nameplateVisible, value);
		}

		[Ordinal(62)] 
		[RED("detectionVisible")] 
		public CBool DetectionVisible
		{
			get => GetProperty(ref _detectionVisible);
			set => SetProperty(ref _detectionVisible, value);
		}

		[Ordinal(63)] 
		[RED("inNameplateMode")] 
		public CBool InNameplateMode
		{
			get => GetProperty(ref _inNameplateMode);
			set => SetProperty(ref _inNameplateMode, value);
		}

		[Ordinal(64)] 
		[RED("objectMarkerFirstShowing")] 
		public CBool ObjectMarkerFirstShowing
		{
			get => GetProperty(ref _objectMarkerFirstShowing);
			set => SetProperty(ref _objectMarkerFirstShowing, value);
		}

		[Ordinal(65)] 
		[RED("statusEffectShowing")] 
		public CBool StatusEffectShowing
		{
			get => GetProperty(ref _statusEffectShowing);
			set => SetProperty(ref _statusEffectShowing, value);
		}

		[Ordinal(66)] 
		[RED("statusEffectCurrentPriority")] 
		public CFloat StatusEffectCurrentPriority
		{
			get => GetProperty(ref _statusEffectCurrentPriority);
			set => SetProperty(ref _statusEffectCurrentPriority, value);
		}

		[Ordinal(67)] 
		[RED("animationIsPlaying")] 
		public CBool AnimationIsPlaying
		{
			get => GetProperty(ref _animationIsPlaying);
			set => SetProperty(ref _animationIsPlaying, value);
		}

		[Ordinal(68)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(69)] 
		[RED("nameplateAnimationProxy")] 
		public CHandle<inkanimProxy> NameplateAnimationProxy
		{
			get => GetProperty(ref _nameplateAnimationProxy);
			set => SetProperty(ref _nameplateAnimationProxy, value);
		}

		[Ordinal(70)] 
		[RED("nameplateAnimationIsPlaying")] 
		public CBool NameplateAnimationIsPlaying
		{
			get => GetProperty(ref _nameplateAnimationIsPlaying);
			set => SetProperty(ref _nameplateAnimationIsPlaying, value);
		}

		[Ordinal(71)] 
		[RED("reprimandAnimationProxy")] 
		public CHandle<inkanimProxy> ReprimandAnimationProxy
		{
			get => GetProperty(ref _reprimandAnimationProxy);
			set => SetProperty(ref _reprimandAnimationProxy, value);
		}

		[Ordinal(72)] 
		[RED("reprimandAnimationIsPlaying")] 
		public CBool ReprimandAnimationIsPlaying
		{
			get => GetProperty(ref _reprimandAnimationIsPlaying);
			set => SetProperty(ref _reprimandAnimationIsPlaying, value);
		}

		[Ordinal(73)] 
		[RED("reprimandAnimationState")] 
		public CEnum<gameReprimandMappinAnimationState> ReprimandAnimationState
		{
			get => GetProperty(ref _reprimandAnimationState);
			set => SetProperty(ref _reprimandAnimationState, value);
		}

		[Ordinal(74)] 
		[RED("currentAnimState")] 
		public CEnum<gameEnemyStealthAwarenessState> CurrentAnimState
		{
			get => GetProperty(ref _currentAnimState);
			set => SetProperty(ref _currentAnimState, value);
		}

		[Ordinal(75)] 
		[RED("c_emptyThreshold")] 
		public CFloat C_emptyThreshold
		{
			get => GetProperty(ref _c_emptyThreshold);
			set => SetProperty(ref _c_emptyThreshold, value);
		}

		[Ordinal(76)] 
		[RED("c_awareToCombatThreshold")] 
		public CFloat C_awareToCombatThreshold
		{
			get => GetProperty(ref _c_awareToCombatThreshold);
			set => SetProperty(ref _c_awareToCombatThreshold, value);
		}

		[Ordinal(77)] 
		[RED("c_combatToAwareThreshold")] 
		public CFloat C_combatToAwareThreshold
		{
			get => GetProperty(ref _c_combatToAwareThreshold);
			set => SetProperty(ref _c_combatToAwareThreshold, value);
		}

		[Ordinal(78)] 
		[RED("c_deviceCombatToAwareThreshold")] 
		public CFloat C_deviceCombatToAwareThreshold
		{
			get => GetProperty(ref _c_deviceCombatToAwareThreshold);
			set => SetProperty(ref _c_deviceCombatToAwareThreshold, value);
		}

		[Ordinal(79)] 
		[RED("c_objectMarkerMaxDistance")] 
		public CFloat C_objectMarkerMaxDistance
		{
			get => GetProperty(ref _c_objectMarkerMaxDistance);
			set => SetProperty(ref _c_objectMarkerMaxDistance, value);
		}

		[Ordinal(80)] 
		[RED("c_objectMarkerMaxCameraDistance")] 
		public CFloat C_objectMarkerMaxCameraDistance
		{
			get => GetProperty(ref _c_objectMarkerMaxCameraDistance);
			set => SetProperty(ref _c_objectMarkerMaxCameraDistance, value);
		}

		public gameuiStealthMappinController()
		{
			_objectMarkerFirstShowing = true;
			_c_awareToCombatThreshold = 1.000000F;
			_c_combatToAwareThreshold = 99.900002F;
			_c_deviceCombatToAwareThreshold = 35.000000F;
			_c_objectMarkerMaxDistance = 50.000000F;
			_c_objectMarkerMaxCameraDistance = 30.000000F;
		}
	}
}

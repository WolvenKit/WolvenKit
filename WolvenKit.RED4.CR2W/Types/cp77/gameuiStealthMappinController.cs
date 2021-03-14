using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiStealthMappinController : gameuiInteractionMappinController
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
		private wCHandle<gameObject> _ownerObject;
		private wCHandle<NPCPuppet> _ownerNPC;
		private wCHandle<Device> _ownerDevice;
		private wCHandle<gamemappinsStealthMappin> _mappin;
		private wCHandle<inkWidget> _root;
		private wCHandle<inkWidget> _canvas;
		private wCHandle<gameuiNpcNameplateGameController> _nameplateController;
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
		private CHandle<gameIBlackboard> _puppetStateBlackboard;
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
			get
			{
				if (_animImage == null)
				{
					_animImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "animImage", cr2w, this);
				}
				return _animImage;
			}
			set
			{
				if (_animImage == value)
				{
					return;
				}
				_animImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get
			{
				if (_arrow == null)
				{
					_arrow = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "arrow", cr2w, this);
				}
				return _arrow;
			}
			set
			{
				if (_arrow == value)
				{
					return;
				}
				_arrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("fill")] 
		public inkWidgetReference Fill
		{
			get
			{
				if (_fill == null)
				{
					_fill = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "fill", cr2w, this);
				}
				return _fill;
			}
			set
			{
				if (_fill == value)
				{
					return;
				}
				_fill = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("eyeFillWhite")] 
		public inkWidgetReference EyeFillWhite
		{
			get
			{
				if (_eyeFillWhite == null)
				{
					_eyeFillWhite = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "eyeFillWhite", cr2w, this);
				}
				return _eyeFillWhite;
			}
			set
			{
				if (_eyeFillWhite == value)
				{
					return;
				}
				_eyeFillWhite = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("eyeFillBlack")] 
		public inkWidgetReference EyeFillBlack
		{
			get
			{
				if (_eyeFillBlack == null)
				{
					_eyeFillBlack = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "eyeFillBlack", cr2w, this);
				}
				return _eyeFillBlack;
			}
			set
			{
				if (_eyeFillBlack == value)
				{
					return;
				}
				_eyeFillBlack = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("markExclamation")] 
		public inkTextWidgetReference MarkExclamation
		{
			get
			{
				if (_markExclamation == null)
				{
					_markExclamation = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "markExclamation", cr2w, this);
				}
				return _markExclamation;
			}
			set
			{
				if (_markExclamation == value)
				{
					return;
				}
				_markExclamation = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("distance")] 
		public inkTextWidgetReference Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("mainArt")] 
		public inkWidgetReference MainArt
		{
			get
			{
				if (_mainArt == null)
				{
					_mainArt = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "mainArt", cr2w, this);
				}
				return _mainArt;
			}
			set
			{
				if (_mainArt == value)
				{
					return;
				}
				_mainArt = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("frame")] 
		public inkImageWidgetReference Frame
		{
			get
			{
				if (_frame == null)
				{
					_frame = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "frame", cr2w, this);
				}
				return _frame;
			}
			set
			{
				if (_frame == value)
				{
					return;
				}
				_frame = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("eliteFrameName")] 
		public CName EliteFrameName
		{
			get
			{
				if (_eliteFrameName == null)
				{
					_eliteFrameName = (CName) CR2WTypeManager.Create("CName", "eliteFrameName", cr2w, this);
				}
				return _eliteFrameName;
			}
			set
			{
				if (_eliteFrameName == value)
				{
					return;
				}
				_eliteFrameName = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("eliteFrameSize")] 
		public Vector2 EliteFrameSize
		{
			get
			{
				if (_eliteFrameSize == null)
				{
					_eliteFrameSize = (Vector2) CR2WTypeManager.Create("Vector2", "eliteFrameSize", cr2w, this);
				}
				return _eliteFrameSize;
			}
			set
			{
				if (_eliteFrameSize == value)
				{
					return;
				}
				_eliteFrameSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("objectMarker")] 
		public inkWidgetReference ObjectMarker
		{
			get
			{
				if (_objectMarker == null)
				{
					_objectMarker = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "objectMarker", cr2w, this);
				}
				return _objectMarker;
			}
			set
			{
				if (_objectMarker == value)
				{
					return;
				}
				_objectMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("levelIcon")] 
		public inkImageWidgetReference LevelIcon
		{
			get
			{
				if (_levelIcon == null)
				{
					_levelIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "levelIcon", cr2w, this);
				}
				return _levelIcon;
			}
			set
			{
				if (_levelIcon == value)
				{
					return;
				}
				_levelIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("statusEffectHolder")] 
		public inkWidgetReference StatusEffectHolder
		{
			get
			{
				if (_statusEffectHolder == null)
				{
					_statusEffectHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "statusEffectHolder", cr2w, this);
				}
				return _statusEffectHolder;
			}
			set
			{
				if (_statusEffectHolder == value)
				{
					return;
				}
				_statusEffectHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("statusEffectIcon")] 
		public inkImageWidgetReference StatusEffectIcon
		{
			get
			{
				if (_statusEffectIcon == null)
				{
					_statusEffectIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "statusEffectIcon", cr2w, this);
				}
				return _statusEffectIcon;
			}
			set
			{
				if (_statusEffectIcon == value)
				{
					return;
				}
				_statusEffectIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("statusEffectTimer")] 
		public inkTextWidgetReference StatusEffectTimer
		{
			get
			{
				if (_statusEffectTimer == null)
				{
					_statusEffectTimer = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "statusEffectTimer", cr2w, this);
				}
				return _statusEffectTimer;
			}
			set
			{
				if (_statusEffectTimer == value)
				{
					return;
				}
				_statusEffectTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("taggedContainer")] 
		public inkWidgetReference TaggedContainer
		{
			get
			{
				if (_taggedContainer == null)
				{
					_taggedContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "taggedContainer", cr2w, this);
				}
				return _taggedContainer;
			}
			set
			{
				if (_taggedContainer == value)
				{
					return;
				}
				_taggedContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("ownerObject")] 
		public wCHandle<gameObject> OwnerObject
		{
			get
			{
				if (_ownerObject == null)
				{
					_ownerObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "ownerObject", cr2w, this);
				}
				return _ownerObject;
			}
			set
			{
				if (_ownerObject == value)
				{
					return;
				}
				_ownerObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("ownerNPC")] 
		public wCHandle<NPCPuppet> OwnerNPC
		{
			get
			{
				if (_ownerNPC == null)
				{
					_ownerNPC = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "ownerNPC", cr2w, this);
				}
				return _ownerNPC;
			}
			set
			{
				if (_ownerNPC == value)
				{
					return;
				}
				_ownerNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("ownerDevice")] 
		public wCHandle<Device> OwnerDevice
		{
			get
			{
				if (_ownerDevice == null)
				{
					_ownerDevice = (wCHandle<Device>) CR2WTypeManager.Create("whandle:Device", "ownerDevice", cr2w, this);
				}
				return _ownerDevice;
			}
			set
			{
				if (_ownerDevice == value)
				{
					return;
				}
				_ownerDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsStealthMappin> Mappin
		{
			get
			{
				if (_mappin == null)
				{
					_mappin = (wCHandle<gamemappinsStealthMappin>) CR2WTypeManager.Create("whandle:gamemappinsStealthMappin", "mappin", cr2w, this);
				}
				return _mappin;
			}
			set
			{
				if (_mappin == value)
				{
					return;
				}
				_mappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("canvas")] 
		public wCHandle<inkWidget> Canvas
		{
			get
			{
				if (_canvas == null)
				{
					_canvas = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "canvas", cr2w, this);
				}
				return _canvas;
			}
			set
			{
				if (_canvas == value)
				{
					return;
				}
				_canvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("nameplateController")] 
		public wCHandle<gameuiNpcNameplateGameController> NameplateController
		{
			get
			{
				if (_nameplateController == null)
				{
					_nameplateController = (wCHandle<gameuiNpcNameplateGameController>) CR2WTypeManager.Create("whandle:gameuiNpcNameplateGameController", "nameplateController", cr2w, this);
				}
				return _nameplateController;
			}
			set
			{
				if (_nameplateController == value)
				{
					return;
				}
				_nameplateController = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("isFriendly")] 
		public CBool IsFriendly
		{
			get
			{
				if (_isFriendly == null)
				{
					_isFriendly = (CBool) CR2WTypeManager.Create("Bool", "isFriendly", cr2w, this);
				}
				return _isFriendly;
			}
			set
			{
				if (_isFriendly == value)
				{
					return;
				}
				_isFriendly = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("isFriendlyFromHack")] 
		public CBool IsFriendlyFromHack
		{
			get
			{
				if (_isFriendlyFromHack == null)
				{
					_isFriendlyFromHack = (CBool) CR2WTypeManager.Create("Bool", "isFriendlyFromHack", cr2w, this);
				}
				return _isFriendlyFromHack;
			}
			set
			{
				if (_isFriendlyFromHack == value)
				{
					return;
				}
				_isFriendlyFromHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("isHostile")] 
		public CBool IsHostile
		{
			get
			{
				if (_isHostile == null)
				{
					_isHostile = (CBool) CR2WTypeManager.Create("Bool", "isHostile", cr2w, this);
				}
				return _isHostile;
			}
			set
			{
				if (_isHostile == value)
				{
					return;
				}
				_isHostile = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("isAggressive")] 
		public CBool IsAggressive
		{
			get
			{
				if (_isAggressive == null)
				{
					_isAggressive = (CBool) CR2WTypeManager.Create("Bool", "isAggressive", cr2w, this);
				}
				return _isAggressive;
			}
			set
			{
				if (_isAggressive == value)
				{
					return;
				}
				_isAggressive = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get
			{
				if (_isDevice == null)
				{
					_isDevice = (CBool) CR2WTypeManager.Create("Bool", "isDevice", cr2w, this);
				}
				return _isDevice;
			}
			set
			{
				if (_isDevice == value)
				{
					return;
				}
				_isDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("isDrone")] 
		public CBool IsDrone
		{
			get
			{
				if (_isDrone == null)
				{
					_isDrone = (CBool) CR2WTypeManager.Create("Bool", "isDrone", cr2w, this);
				}
				return _isDrone;
			}
			set
			{
				if (_isDrone == value)
				{
					return;
				}
				_isDrone = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("isMech")] 
		public CBool IsMech
		{
			get
			{
				if (_isMech == null)
				{
					_isMech = (CBool) CR2WTypeManager.Create("Bool", "isMech", cr2w, this);
				}
				return _isMech;
			}
			set
			{
				if (_isMech == value)
				{
					return;
				}
				_isMech = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("isCamera")] 
		public CBool IsCamera
		{
			get
			{
				if (_isCamera == null)
				{
					_isCamera = (CBool) CR2WTypeManager.Create("Bool", "isCamera", cr2w, this);
				}
				return _isCamera;
			}
			set
			{
				if (_isCamera == value)
				{
					return;
				}
				_isCamera = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("isTurret")] 
		public CBool IsTurret
		{
			get
			{
				if (_isTurret == null)
				{
					_isTurret = (CBool) CR2WTypeManager.Create("Bool", "isTurret", cr2w, this);
				}
				return _isTurret;
			}
			set
			{
				if (_isTurret == value)
				{
					return;
				}
				_isTurret = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("isHiddenByQuest")] 
		public CBool IsHiddenByQuest
		{
			get
			{
				if (_isHiddenByQuest == null)
				{
					_isHiddenByQuest = (CBool) CR2WTypeManager.Create("Bool", "isHiddenByQuest", cr2w, this);
				}
				return _isHiddenByQuest;
			}
			set
			{
				if (_isHiddenByQuest == value)
				{
					return;
				}
				_isHiddenByQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("NPCRarity")] 
		public CEnum<gamedataNPCRarity> NPCRarity
		{
			get
			{
				if (_nPCRarity == null)
				{
					_nPCRarity = (CEnum<gamedataNPCRarity>) CR2WTypeManager.Create("gamedataNPCRarity", "NPCRarity", cr2w, this);
				}
				return _nPCRarity;
			}
			set
			{
				if (_nPCRarity == value)
				{
					return;
				}
				_nPCRarity = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
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

		[Ordinal(47)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get
			{
				if (_highLevelState == null)
				{
					_highLevelState = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "highLevelState", cr2w, this);
				}
				return _highLevelState;
			}
			set
			{
				if (_highLevelState == value)
				{
					return;
				}
				_highLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
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

		[Ordinal(49)] 
		[RED("waitingToExitCombat")] 
		public CBool WaitingToExitCombat
		{
			get
			{
				if (_waitingToExitCombat == null)
				{
					_waitingToExitCombat = (CBool) CR2WTypeManager.Create("Bool", "waitingToExitCombat", cr2w, this);
				}
				return _waitingToExitCombat;
			}
			set
			{
				if (_waitingToExitCombat == value)
				{
					return;
				}
				_waitingToExitCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("reaction")] 
		public CEnum<gamedataOutput> Reaction
		{
			get
			{
				if (_reaction == null)
				{
					_reaction = (CEnum<gamedataOutput>) CR2WTypeManager.Create("gamedataOutput", "reaction", cr2w, this);
				}
				return _reaction;
			}
			set
			{
				if (_reaction == value)
				{
					return;
				}
				_reaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("lastState")] 
		public CEnum<gamedataNPCHighLevelState> LastState
		{
			get
			{
				if (_lastState == null)
				{
					_lastState = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "lastState", cr2w, this);
				}
				return _lastState;
			}
			set
			{
				if (_lastState == value)
				{
					return;
				}
				_lastState = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("lastReaction")] 
		public CEnum<gamedataOutput> LastReaction
		{
			get
			{
				if (_lastReaction == null)
				{
					_lastReaction = (CEnum<gamedataOutput>) CR2WTypeManager.Create("gamedataOutput", "lastReaction", cr2w, this);
				}
				return _lastReaction;
			}
			set
			{
				if (_lastReaction == value)
				{
					return;
				}
				_lastReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("lastPercent")] 
		public CFloat LastPercent
		{
			get
			{
				if (_lastPercent == null)
				{
					_lastPercent = (CFloat) CR2WTypeManager.Create("Float", "lastPercent", cr2w, this);
				}
				return _lastPercent;
			}
			set
			{
				if (_lastPercent == value)
				{
					return;
				}
				_lastPercent = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("canSeePlayer")] 
		public CBool CanSeePlayer
		{
			get
			{
				if (_canSeePlayer == null)
				{
					_canSeePlayer = (CBool) CR2WTypeManager.Create("Bool", "canSeePlayer", cr2w, this);
				}
				return _canSeePlayer;
			}
			set
			{
				if (_canSeePlayer == value)
				{
					return;
				}
				_canSeePlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("squadInCombat")] 
		public CBool SquadInCombat
		{
			get
			{
				if (_squadInCombat == null)
				{
					_squadInCombat = (CBool) CR2WTypeManager.Create("Bool", "squadInCombat", cr2w, this);
				}
				return _squadInCombat;
			}
			set
			{
				if (_squadInCombat == value)
				{
					return;
				}
				_squadInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("archetypeTextureName")] 
		public CName ArchetypeTextureName
		{
			get
			{
				if (_archetypeTextureName == null)
				{
					_archetypeTextureName = (CName) CR2WTypeManager.Create("CName", "archetypeTextureName", cr2w, this);
				}
				return _archetypeTextureName;
			}
			set
			{
				if (_archetypeTextureName == value)
				{
					return;
				}
				_archetypeTextureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get
			{
				if (_isTagged == null)
				{
					_isTagged = (CBool) CR2WTypeManager.Create("Bool", "isTagged", cr2w, this);
				}
				return _isTagged;
			}
			set
			{
				if (_isTagged == value)
				{
					return;
				}
				_isTagged = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("canHaveObjectMarker")] 
		public CBool CanHaveObjectMarker
		{
			get
			{
				if (_canHaveObjectMarker == null)
				{
					_canHaveObjectMarker = (CBool) CR2WTypeManager.Create("Bool", "canHaveObjectMarker", cr2w, this);
				}
				return _canHaveObjectMarker;
			}
			set
			{
				if (_canHaveObjectMarker == value)
				{
					return;
				}
				_canHaveObjectMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("canShowObjectMarker")] 
		public CBool CanShowObjectMarker
		{
			get
			{
				if (_canShowObjectMarker == null)
				{
					_canShowObjectMarker = (CBool) CR2WTypeManager.Create("Bool", "canShowObjectMarker", cr2w, this);
				}
				return _canShowObjectMarker;
			}
			set
			{
				if (_canShowObjectMarker == value)
				{
					return;
				}
				_canShowObjectMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("objectMarkerVisible")] 
		public CBool ObjectMarkerVisible
		{
			get
			{
				if (_objectMarkerVisible == null)
				{
					_objectMarkerVisible = (CBool) CR2WTypeManager.Create("Bool", "objectMarkerVisible", cr2w, this);
				}
				return _objectMarkerVisible;
			}
			set
			{
				if (_objectMarkerVisible == value)
				{
					return;
				}
				_objectMarkerVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("nameplateVisible")] 
		public CBool NameplateVisible
		{
			get
			{
				if (_nameplateVisible == null)
				{
					_nameplateVisible = (CBool) CR2WTypeManager.Create("Bool", "nameplateVisible", cr2w, this);
				}
				return _nameplateVisible;
			}
			set
			{
				if (_nameplateVisible == value)
				{
					return;
				}
				_nameplateVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("detectionVisible")] 
		public CBool DetectionVisible
		{
			get
			{
				if (_detectionVisible == null)
				{
					_detectionVisible = (CBool) CR2WTypeManager.Create("Bool", "detectionVisible", cr2w, this);
				}
				return _detectionVisible;
			}
			set
			{
				if (_detectionVisible == value)
				{
					return;
				}
				_detectionVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("inNameplateMode")] 
		public CBool InNameplateMode
		{
			get
			{
				if (_inNameplateMode == null)
				{
					_inNameplateMode = (CBool) CR2WTypeManager.Create("Bool", "inNameplateMode", cr2w, this);
				}
				return _inNameplateMode;
			}
			set
			{
				if (_inNameplateMode == value)
				{
					return;
				}
				_inNameplateMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("objectMarkerFirstShowing")] 
		public CBool ObjectMarkerFirstShowing
		{
			get
			{
				if (_objectMarkerFirstShowing == null)
				{
					_objectMarkerFirstShowing = (CBool) CR2WTypeManager.Create("Bool", "objectMarkerFirstShowing", cr2w, this);
				}
				return _objectMarkerFirstShowing;
			}
			set
			{
				if (_objectMarkerFirstShowing == value)
				{
					return;
				}
				_objectMarkerFirstShowing = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("statusEffectShowing")] 
		public CBool StatusEffectShowing
		{
			get
			{
				if (_statusEffectShowing == null)
				{
					_statusEffectShowing = (CBool) CR2WTypeManager.Create("Bool", "statusEffectShowing", cr2w, this);
				}
				return _statusEffectShowing;
			}
			set
			{
				if (_statusEffectShowing == value)
				{
					return;
				}
				_statusEffectShowing = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("statusEffectCurrentPriority")] 
		public CFloat StatusEffectCurrentPriority
		{
			get
			{
				if (_statusEffectCurrentPriority == null)
				{
					_statusEffectCurrentPriority = (CFloat) CR2WTypeManager.Create("Float", "statusEffectCurrentPriority", cr2w, this);
				}
				return _statusEffectCurrentPriority;
			}
			set
			{
				if (_statusEffectCurrentPriority == value)
				{
					return;
				}
				_statusEffectCurrentPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("animationIsPlaying")] 
		public CBool AnimationIsPlaying
		{
			get
			{
				if (_animationIsPlaying == null)
				{
					_animationIsPlaying = (CBool) CR2WTypeManager.Create("Bool", "animationIsPlaying", cr2w, this);
				}
				return _animationIsPlaying;
			}
			set
			{
				if (_animationIsPlaying == value)
				{
					return;
				}
				_animationIsPlaying = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("nameplateAnimationProxy")] 
		public CHandle<inkanimProxy> NameplateAnimationProxy
		{
			get
			{
				if (_nameplateAnimationProxy == null)
				{
					_nameplateAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "nameplateAnimationProxy", cr2w, this);
				}
				return _nameplateAnimationProxy;
			}
			set
			{
				if (_nameplateAnimationProxy == value)
				{
					return;
				}
				_nameplateAnimationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("nameplateAnimationIsPlaying")] 
		public CBool NameplateAnimationIsPlaying
		{
			get
			{
				if (_nameplateAnimationIsPlaying == null)
				{
					_nameplateAnimationIsPlaying = (CBool) CR2WTypeManager.Create("Bool", "nameplateAnimationIsPlaying", cr2w, this);
				}
				return _nameplateAnimationIsPlaying;
			}
			set
			{
				if (_nameplateAnimationIsPlaying == value)
				{
					return;
				}
				_nameplateAnimationIsPlaying = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("reprimandAnimationProxy")] 
		public CHandle<inkanimProxy> ReprimandAnimationProxy
		{
			get
			{
				if (_reprimandAnimationProxy == null)
				{
					_reprimandAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "reprimandAnimationProxy", cr2w, this);
				}
				return _reprimandAnimationProxy;
			}
			set
			{
				if (_reprimandAnimationProxy == value)
				{
					return;
				}
				_reprimandAnimationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("reprimandAnimationIsPlaying")] 
		public CBool ReprimandAnimationIsPlaying
		{
			get
			{
				if (_reprimandAnimationIsPlaying == null)
				{
					_reprimandAnimationIsPlaying = (CBool) CR2WTypeManager.Create("Bool", "reprimandAnimationIsPlaying", cr2w, this);
				}
				return _reprimandAnimationIsPlaying;
			}
			set
			{
				if (_reprimandAnimationIsPlaying == value)
				{
					return;
				}
				_reprimandAnimationIsPlaying = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("reprimandAnimationState")] 
		public CEnum<gameReprimandMappinAnimationState> ReprimandAnimationState
		{
			get
			{
				if (_reprimandAnimationState == null)
				{
					_reprimandAnimationState = (CEnum<gameReprimandMappinAnimationState>) CR2WTypeManager.Create("gameReprimandMappinAnimationState", "reprimandAnimationState", cr2w, this);
				}
				return _reprimandAnimationState;
			}
			set
			{
				if (_reprimandAnimationState == value)
				{
					return;
				}
				_reprimandAnimationState = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("currentAnimState")] 
		public CEnum<gameEnemyStealthAwarenessState> CurrentAnimState
		{
			get
			{
				if (_currentAnimState == null)
				{
					_currentAnimState = (CEnum<gameEnemyStealthAwarenessState>) CR2WTypeManager.Create("gameEnemyStealthAwarenessState", "currentAnimState", cr2w, this);
				}
				return _currentAnimState;
			}
			set
			{
				if (_currentAnimState == value)
				{
					return;
				}
				_currentAnimState = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("c_emptyThreshold")] 
		public CFloat C_emptyThreshold
		{
			get
			{
				if (_c_emptyThreshold == null)
				{
					_c_emptyThreshold = (CFloat) CR2WTypeManager.Create("Float", "c_emptyThreshold", cr2w, this);
				}
				return _c_emptyThreshold;
			}
			set
			{
				if (_c_emptyThreshold == value)
				{
					return;
				}
				_c_emptyThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("c_awareToCombatThreshold")] 
		public CFloat C_awareToCombatThreshold
		{
			get
			{
				if (_c_awareToCombatThreshold == null)
				{
					_c_awareToCombatThreshold = (CFloat) CR2WTypeManager.Create("Float", "c_awareToCombatThreshold", cr2w, this);
				}
				return _c_awareToCombatThreshold;
			}
			set
			{
				if (_c_awareToCombatThreshold == value)
				{
					return;
				}
				_c_awareToCombatThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("c_combatToAwareThreshold")] 
		public CFloat C_combatToAwareThreshold
		{
			get
			{
				if (_c_combatToAwareThreshold == null)
				{
					_c_combatToAwareThreshold = (CFloat) CR2WTypeManager.Create("Float", "c_combatToAwareThreshold", cr2w, this);
				}
				return _c_combatToAwareThreshold;
			}
			set
			{
				if (_c_combatToAwareThreshold == value)
				{
					return;
				}
				_c_combatToAwareThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("c_deviceCombatToAwareThreshold")] 
		public CFloat C_deviceCombatToAwareThreshold
		{
			get
			{
				if (_c_deviceCombatToAwareThreshold == null)
				{
					_c_deviceCombatToAwareThreshold = (CFloat) CR2WTypeManager.Create("Float", "c_deviceCombatToAwareThreshold", cr2w, this);
				}
				return _c_deviceCombatToAwareThreshold;
			}
			set
			{
				if (_c_deviceCombatToAwareThreshold == value)
				{
					return;
				}
				_c_deviceCombatToAwareThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("c_objectMarkerMaxDistance")] 
		public CFloat C_objectMarkerMaxDistance
		{
			get
			{
				if (_c_objectMarkerMaxDistance == null)
				{
					_c_objectMarkerMaxDistance = (CFloat) CR2WTypeManager.Create("Float", "c_objectMarkerMaxDistance", cr2w, this);
				}
				return _c_objectMarkerMaxDistance;
			}
			set
			{
				if (_c_objectMarkerMaxDistance == value)
				{
					return;
				}
				_c_objectMarkerMaxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("c_objectMarkerMaxCameraDistance")] 
		public CFloat C_objectMarkerMaxCameraDistance
		{
			get
			{
				if (_c_objectMarkerMaxCameraDistance == null)
				{
					_c_objectMarkerMaxCameraDistance = (CFloat) CR2WTypeManager.Create("Float", "c_objectMarkerMaxCameraDistance", cr2w, this);
				}
				return _c_objectMarkerMaxCameraDistance;
			}
			set
			{
				if (_c_objectMarkerMaxCameraDistance == value)
				{
					return;
				}
				_c_objectMarkerMaxCameraDistance = value;
				PropertySet(this);
			}
		}

		public gameuiStealthMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

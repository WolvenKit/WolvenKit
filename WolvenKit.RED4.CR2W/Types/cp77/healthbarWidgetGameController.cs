using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class healthbarWidgetGameController : gameuiHUDGameController
	{
		private CHandle<gameIBlackboard> _bbPlayerStats;
		private CUInt32 _bbPlayerEventId;
		private CHandle<gameIBlackboard> _bbRightWeaponInfo;
		private CUInt32 _bbRightWeaponEventId;
		private CHandle<gameIBlackboard> _bbLeftWeaponInfo;
		private CUInt32 _bbLeftWeaponEventId;
		private CUInt32 _bbPSceneTierEventId;
		private CUInt32 _visionStateBlackboardId;
		private CUInt32 _combatModeBlackboardId;
		private CUInt32 _bbQuickhacksMemeoryEventId;
		private inkWidgetPath _healthPath;
		private inkWidgetPath _healthBarPath;
		private inkWidgetPath _armorPath;
		private inkWidgetPath _armorBarPath;
		private inkWidgetReference _expBar;
		private inkWidgetReference _expBarSpacer;
		private inkCompoundWidgetReference _barsLayoutPath;
		private inkCompoundWidgetReference _buffsHolder;
		private inkTextWidgetReference _invulnerableTextPath;
		private inkTextWidgetReference _levelTextPath;
		private inkTextWidgetReference _nextLevelTextPath;
		private inkTextWidgetReference _healthTextPath;
		private inkTextWidgetReference _maxHealthTextPath;
		private inkCompoundWidgetReference _quickhacksContainer;
		private inkTextWidgetReference _expText;
		private inkTextWidgetReference _expTextLabel;
		private inkWidgetReference _lostHealthAggregationBar;
		private inkWidgetReference _levelUpRectangle;
		private wCHandle<NameplateBarLogicController> _healthController;
		private wCHandle<ProgressBarSimpleWidgetLogicController> _armorController;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkWidget> _buffWidget;
		private wCHandle<inkWidget> _hPBar;
		private wCHandle<inkWidget> _armorBar;
		private wCHandle<inkTextWidget> _invulnerableText;
		private CHandle<inkanimDefinition> _animHideTemp;
		private CHandle<inkanimDefinition> _animShortFade;
		private CHandle<inkanimDefinition> _animLongFade;
		private CHandle<inkanimProxy> _animHideHPProxy;
		private CHandle<inkanimDefinition> _delayAnimation;
		private CBool _animCreated;
		private CBool _aggregatingActive;
		private CInt32 _countingStartHealth;
		private CInt32 _currentHealth;
		private CInt32 _previousHealth;
		private CInt32 _maximumHealth;
		private CFloat _quickhacksMemoryPercent;
		private CInt32 _currentArmor;
		private CInt32 _maximumArmor;
		private CArray<wCHandle<inkWidget>> _quickhackBarArray;
		private CInt32 _maxQuickhackBars;
		private CInt32 _usedQuickhacks;
		private CBool _buffsVisible;
		private CBool _isUnarmedRightHand;
		private CBool _isUnarmedLeftHand;
		private CEnum<gamePSMVision> _currentVisionPSM;
		private CEnum<gamePSMCombat> _combatModePSM;
		private CEnum<GameplayTier> _sceneTier;
		private CHandle<GodModeStatListener> _godModeStatListener;
		private CHandle<gameIBlackboard> _playerStatsBlackboard;
		private CUInt32 _characterCurrentXPListener;
		private CHandle<gameIBlackboard> _levelUpBlackboard;
		private CUInt32 _playerLevelUpListener;
		private CInt32 _currentLevel;
		private wCHandle<gameObject> _playerObject;
		private CHandle<PlayerDevelopmentSystem> _playerDevelopmentSystem;
		private ScriptGameInstance _gameInstance;

		[Ordinal(9)] 
		[RED("bbPlayerStats")] 
		public CHandle<gameIBlackboard> BbPlayerStats
		{
			get
			{
				if (_bbPlayerStats == null)
				{
					_bbPlayerStats = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbPlayerStats", cr2w, this);
				}
				return _bbPlayerStats;
			}
			set
			{
				if (_bbPlayerStats == value)
				{
					return;
				}
				_bbPlayerStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("bbPlayerEventId")] 
		public CUInt32 BbPlayerEventId
		{
			get
			{
				if (_bbPlayerEventId == null)
				{
					_bbPlayerEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbPlayerEventId", cr2w, this);
				}
				return _bbPlayerEventId;
			}
			set
			{
				if (_bbPlayerEventId == value)
				{
					return;
				}
				_bbPlayerEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("bbRightWeaponInfo")] 
		public CHandle<gameIBlackboard> BbRightWeaponInfo
		{
			get
			{
				if (_bbRightWeaponInfo == null)
				{
					_bbRightWeaponInfo = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbRightWeaponInfo", cr2w, this);
				}
				return _bbRightWeaponInfo;
			}
			set
			{
				if (_bbRightWeaponInfo == value)
				{
					return;
				}
				_bbRightWeaponInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("bbRightWeaponEventId")] 
		public CUInt32 BbRightWeaponEventId
		{
			get
			{
				if (_bbRightWeaponEventId == null)
				{
					_bbRightWeaponEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbRightWeaponEventId", cr2w, this);
				}
				return _bbRightWeaponEventId;
			}
			set
			{
				if (_bbRightWeaponEventId == value)
				{
					return;
				}
				_bbRightWeaponEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bbLeftWeaponInfo")] 
		public CHandle<gameIBlackboard> BbLeftWeaponInfo
		{
			get
			{
				if (_bbLeftWeaponInfo == null)
				{
					_bbLeftWeaponInfo = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbLeftWeaponInfo", cr2w, this);
				}
				return _bbLeftWeaponInfo;
			}
			set
			{
				if (_bbLeftWeaponInfo == value)
				{
					return;
				}
				_bbLeftWeaponInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bbLeftWeaponEventId")] 
		public CUInt32 BbLeftWeaponEventId
		{
			get
			{
				if (_bbLeftWeaponEventId == null)
				{
					_bbLeftWeaponEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbLeftWeaponEventId", cr2w, this);
				}
				return _bbLeftWeaponEventId;
			}
			set
			{
				if (_bbLeftWeaponEventId == value)
				{
					return;
				}
				_bbLeftWeaponEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bbPSceneTierEventId")] 
		public CUInt32 BbPSceneTierEventId
		{
			get
			{
				if (_bbPSceneTierEventId == null)
				{
					_bbPSceneTierEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbPSceneTierEventId", cr2w, this);
				}
				return _bbPSceneTierEventId;
			}
			set
			{
				if (_bbPSceneTierEventId == value)
				{
					return;
				}
				_bbPSceneTierEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("visionStateBlackboardId")] 
		public CUInt32 VisionStateBlackboardId
		{
			get
			{
				if (_visionStateBlackboardId == null)
				{
					_visionStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "visionStateBlackboardId", cr2w, this);
				}
				return _visionStateBlackboardId;
			}
			set
			{
				if (_visionStateBlackboardId == value)
				{
					return;
				}
				_visionStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("combatModeBlackboardId")] 
		public CUInt32 CombatModeBlackboardId
		{
			get
			{
				if (_combatModeBlackboardId == null)
				{
					_combatModeBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "combatModeBlackboardId", cr2w, this);
				}
				return _combatModeBlackboardId;
			}
			set
			{
				if (_combatModeBlackboardId == value)
				{
					return;
				}
				_combatModeBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("bbQuickhacksMemeoryEventId")] 
		public CUInt32 BbQuickhacksMemeoryEventId
		{
			get
			{
				if (_bbQuickhacksMemeoryEventId == null)
				{
					_bbQuickhacksMemeoryEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbQuickhacksMemeoryEventId", cr2w, this);
				}
				return _bbQuickhacksMemeoryEventId;
			}
			set
			{
				if (_bbQuickhacksMemeoryEventId == value)
				{
					return;
				}
				_bbQuickhacksMemeoryEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("healthPath")] 
		public inkWidgetPath HealthPath
		{
			get
			{
				if (_healthPath == null)
				{
					_healthPath = (inkWidgetPath) CR2WTypeManager.Create("inkWidgetPath", "healthPath", cr2w, this);
				}
				return _healthPath;
			}
			set
			{
				if (_healthPath == value)
				{
					return;
				}
				_healthPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("healthBarPath")] 
		public inkWidgetPath HealthBarPath
		{
			get
			{
				if (_healthBarPath == null)
				{
					_healthBarPath = (inkWidgetPath) CR2WTypeManager.Create("inkWidgetPath", "healthBarPath", cr2w, this);
				}
				return _healthBarPath;
			}
			set
			{
				if (_healthBarPath == value)
				{
					return;
				}
				_healthBarPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("armorPath")] 
		public inkWidgetPath ArmorPath
		{
			get
			{
				if (_armorPath == null)
				{
					_armorPath = (inkWidgetPath) CR2WTypeManager.Create("inkWidgetPath", "armorPath", cr2w, this);
				}
				return _armorPath;
			}
			set
			{
				if (_armorPath == value)
				{
					return;
				}
				_armorPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("armorBarPath")] 
		public inkWidgetPath ArmorBarPath
		{
			get
			{
				if (_armorBarPath == null)
				{
					_armorBarPath = (inkWidgetPath) CR2WTypeManager.Create("inkWidgetPath", "armorBarPath", cr2w, this);
				}
				return _armorBarPath;
			}
			set
			{
				if (_armorBarPath == value)
				{
					return;
				}
				_armorBarPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("expBar")] 
		public inkWidgetReference ExpBar
		{
			get
			{
				if (_expBar == null)
				{
					_expBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "expBar", cr2w, this);
				}
				return _expBar;
			}
			set
			{
				if (_expBar == value)
				{
					return;
				}
				_expBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("expBarSpacer")] 
		public inkWidgetReference ExpBarSpacer
		{
			get
			{
				if (_expBarSpacer == null)
				{
					_expBarSpacer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "expBarSpacer", cr2w, this);
				}
				return _expBarSpacer;
			}
			set
			{
				if (_expBarSpacer == value)
				{
					return;
				}
				_expBarSpacer = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("barsLayoutPath")] 
		public inkCompoundWidgetReference BarsLayoutPath
		{
			get
			{
				if (_barsLayoutPath == null)
				{
					_barsLayoutPath = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "barsLayoutPath", cr2w, this);
				}
				return _barsLayoutPath;
			}
			set
			{
				if (_barsLayoutPath == value)
				{
					return;
				}
				_barsLayoutPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("buffsHolder")] 
		public inkCompoundWidgetReference BuffsHolder
		{
			get
			{
				if (_buffsHolder == null)
				{
					_buffsHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "buffsHolder", cr2w, this);
				}
				return _buffsHolder;
			}
			set
			{
				if (_buffsHolder == value)
				{
					return;
				}
				_buffsHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("invulnerableTextPath")] 
		public inkTextWidgetReference InvulnerableTextPath
		{
			get
			{
				if (_invulnerableTextPath == null)
				{
					_invulnerableTextPath = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "invulnerableTextPath", cr2w, this);
				}
				return _invulnerableTextPath;
			}
			set
			{
				if (_invulnerableTextPath == value)
				{
					return;
				}
				_invulnerableTextPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("levelTextPath")] 
		public inkTextWidgetReference LevelTextPath
		{
			get
			{
				if (_levelTextPath == null)
				{
					_levelTextPath = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelTextPath", cr2w, this);
				}
				return _levelTextPath;
			}
			set
			{
				if (_levelTextPath == value)
				{
					return;
				}
				_levelTextPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("nextLevelTextPath")] 
		public inkTextWidgetReference NextLevelTextPath
		{
			get
			{
				if (_nextLevelTextPath == null)
				{
					_nextLevelTextPath = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nextLevelTextPath", cr2w, this);
				}
				return _nextLevelTextPath;
			}
			set
			{
				if (_nextLevelTextPath == value)
				{
					return;
				}
				_nextLevelTextPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("healthTextPath")] 
		public inkTextWidgetReference HealthTextPath
		{
			get
			{
				if (_healthTextPath == null)
				{
					_healthTextPath = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "healthTextPath", cr2w, this);
				}
				return _healthTextPath;
			}
			set
			{
				if (_healthTextPath == value)
				{
					return;
				}
				_healthTextPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("maxHealthTextPath")] 
		public inkTextWidgetReference MaxHealthTextPath
		{
			get
			{
				if (_maxHealthTextPath == null)
				{
					_maxHealthTextPath = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "maxHealthTextPath", cr2w, this);
				}
				return _maxHealthTextPath;
			}
			set
			{
				if (_maxHealthTextPath == value)
				{
					return;
				}
				_maxHealthTextPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("quickhacksContainer")] 
		public inkCompoundWidgetReference QuickhacksContainer
		{
			get
			{
				if (_quickhacksContainer == null)
				{
					_quickhacksContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "quickhacksContainer", cr2w, this);
				}
				return _quickhacksContainer;
			}
			set
			{
				if (_quickhacksContainer == value)
				{
					return;
				}
				_quickhacksContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("expText")] 
		public inkTextWidgetReference ExpText
		{
			get
			{
				if (_expText == null)
				{
					_expText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "expText", cr2w, this);
				}
				return _expText;
			}
			set
			{
				if (_expText == value)
				{
					return;
				}
				_expText = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("expTextLabel")] 
		public inkTextWidgetReference ExpTextLabel
		{
			get
			{
				if (_expTextLabel == null)
				{
					_expTextLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "expTextLabel", cr2w, this);
				}
				return _expTextLabel;
			}
			set
			{
				if (_expTextLabel == value)
				{
					return;
				}
				_expTextLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("lostHealthAggregationBar")] 
		public inkWidgetReference LostHealthAggregationBar
		{
			get
			{
				if (_lostHealthAggregationBar == null)
				{
					_lostHealthAggregationBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "lostHealthAggregationBar", cr2w, this);
				}
				return _lostHealthAggregationBar;
			}
			set
			{
				if (_lostHealthAggregationBar == value)
				{
					return;
				}
				_lostHealthAggregationBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("levelUpRectangle")] 
		public inkWidgetReference LevelUpRectangle
		{
			get
			{
				if (_levelUpRectangle == null)
				{
					_levelUpRectangle = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelUpRectangle", cr2w, this);
				}
				return _levelUpRectangle;
			}
			set
			{
				if (_levelUpRectangle == value)
				{
					return;
				}
				_levelUpRectangle = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("healthController")] 
		public wCHandle<NameplateBarLogicController> HealthController
		{
			get
			{
				if (_healthController == null)
				{
					_healthController = (wCHandle<NameplateBarLogicController>) CR2WTypeManager.Create("whandle:NameplateBarLogicController", "healthController", cr2w, this);
				}
				return _healthController;
			}
			set
			{
				if (_healthController == value)
				{
					return;
				}
				_healthController = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("armorController")] 
		public wCHandle<ProgressBarSimpleWidgetLogicController> ArmorController
		{
			get
			{
				if (_armorController == null)
				{
					_armorController = (wCHandle<ProgressBarSimpleWidgetLogicController>) CR2WTypeManager.Create("whandle:ProgressBarSimpleWidgetLogicController", "armorController", cr2w, this);
				}
				return _armorController;
			}
			set
			{
				if (_armorController == value)
				{
					return;
				}
				_armorController = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "RootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("buffWidget")] 
		public wCHandle<inkWidget> BuffWidget
		{
			get
			{
				if (_buffWidget == null)
				{
					_buffWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "buffWidget", cr2w, this);
				}
				return _buffWidget;
			}
			set
			{
				if (_buffWidget == value)
				{
					return;
				}
				_buffWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("HPBar")] 
		public wCHandle<inkWidget> HPBar
		{
			get
			{
				if (_hPBar == null)
				{
					_hPBar = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "HPBar", cr2w, this);
				}
				return _hPBar;
			}
			set
			{
				if (_hPBar == value)
				{
					return;
				}
				_hPBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("armorBar")] 
		public wCHandle<inkWidget> ArmorBar
		{
			get
			{
				if (_armorBar == null)
				{
					_armorBar = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "armorBar", cr2w, this);
				}
				return _armorBar;
			}
			set
			{
				if (_armorBar == value)
				{
					return;
				}
				_armorBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("invulnerableText")] 
		public wCHandle<inkTextWidget> InvulnerableText
		{
			get
			{
				if (_invulnerableText == null)
				{
					_invulnerableText = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "invulnerableText", cr2w, this);
				}
				return _invulnerableText;
			}
			set
			{
				if (_invulnerableText == value)
				{
					return;
				}
				_invulnerableText = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("animHideTemp")] 
		public CHandle<inkanimDefinition> AnimHideTemp
		{
			get
			{
				if (_animHideTemp == null)
				{
					_animHideTemp = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animHideTemp", cr2w, this);
				}
				return _animHideTemp;
			}
			set
			{
				if (_animHideTemp == value)
				{
					return;
				}
				_animHideTemp = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("animShortFade")] 
		public CHandle<inkanimDefinition> AnimShortFade
		{
			get
			{
				if (_animShortFade == null)
				{
					_animShortFade = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animShortFade", cr2w, this);
				}
				return _animShortFade;
			}
			set
			{
				if (_animShortFade == value)
				{
					return;
				}
				_animShortFade = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("animLongFade")] 
		public CHandle<inkanimDefinition> AnimLongFade
		{
			get
			{
				if (_animLongFade == null)
				{
					_animLongFade = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animLongFade", cr2w, this);
				}
				return _animLongFade;
			}
			set
			{
				if (_animLongFade == value)
				{
					return;
				}
				_animLongFade = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("animHideHPProxy")] 
		public CHandle<inkanimProxy> AnimHideHPProxy
		{
			get
			{
				if (_animHideHPProxy == null)
				{
					_animHideHPProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animHideHPProxy", cr2w, this);
				}
				return _animHideHPProxy;
			}
			set
			{
				if (_animHideHPProxy == value)
				{
					return;
				}
				_animHideHPProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("delayAnimation")] 
		public CHandle<inkanimDefinition> DelayAnimation
		{
			get
			{
				if (_delayAnimation == null)
				{
					_delayAnimation = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "delayAnimation", cr2w, this);
				}
				return _delayAnimation;
			}
			set
			{
				if (_delayAnimation == value)
				{
					return;
				}
				_delayAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("animCreated")] 
		public CBool AnimCreated
		{
			get
			{
				if (_animCreated == null)
				{
					_animCreated = (CBool) CR2WTypeManager.Create("Bool", "animCreated", cr2w, this);
				}
				return _animCreated;
			}
			set
			{
				if (_animCreated == value)
				{
					return;
				}
				_animCreated = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("aggregatingActive")] 
		public CBool AggregatingActive
		{
			get
			{
				if (_aggregatingActive == null)
				{
					_aggregatingActive = (CBool) CR2WTypeManager.Create("Bool", "aggregatingActive", cr2w, this);
				}
				return _aggregatingActive;
			}
			set
			{
				if (_aggregatingActive == value)
				{
					return;
				}
				_aggregatingActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("countingStartHealth")] 
		public CInt32 CountingStartHealth
		{
			get
			{
				if (_countingStartHealth == null)
				{
					_countingStartHealth = (CInt32) CR2WTypeManager.Create("Int32", "countingStartHealth", cr2w, this);
				}
				return _countingStartHealth;
			}
			set
			{
				if (_countingStartHealth == value)
				{
					return;
				}
				_countingStartHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get
			{
				if (_currentHealth == null)
				{
					_currentHealth = (CInt32) CR2WTypeManager.Create("Int32", "currentHealth", cr2w, this);
				}
				return _currentHealth;
			}
			set
			{
				if (_currentHealth == value)
				{
					return;
				}
				_currentHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get
			{
				if (_previousHealth == null)
				{
					_previousHealth = (CInt32) CR2WTypeManager.Create("Int32", "previousHealth", cr2w, this);
				}
				return _previousHealth;
			}
			set
			{
				if (_previousHealth == value)
				{
					return;
				}
				_previousHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get
			{
				if (_maximumHealth == null)
				{
					_maximumHealth = (CInt32) CR2WTypeManager.Create("Int32", "maximumHealth", cr2w, this);
				}
				return _maximumHealth;
			}
			set
			{
				if (_maximumHealth == value)
				{
					return;
				}
				_maximumHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("quickhacksMemoryPercent")] 
		public CFloat QuickhacksMemoryPercent
		{
			get
			{
				if (_quickhacksMemoryPercent == null)
				{
					_quickhacksMemoryPercent = (CFloat) CR2WTypeManager.Create("Float", "quickhacksMemoryPercent", cr2w, this);
				}
				return _quickhacksMemoryPercent;
			}
			set
			{
				if (_quickhacksMemoryPercent == value)
				{
					return;
				}
				_quickhacksMemoryPercent = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("currentArmor")] 
		public CInt32 CurrentArmor
		{
			get
			{
				if (_currentArmor == null)
				{
					_currentArmor = (CInt32) CR2WTypeManager.Create("Int32", "currentArmor", cr2w, this);
				}
				return _currentArmor;
			}
			set
			{
				if (_currentArmor == value)
				{
					return;
				}
				_currentArmor = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("maximumArmor")] 
		public CInt32 MaximumArmor
		{
			get
			{
				if (_maximumArmor == null)
				{
					_maximumArmor = (CInt32) CR2WTypeManager.Create("Int32", "maximumArmor", cr2w, this);
				}
				return _maximumArmor;
			}
			set
			{
				if (_maximumArmor == value)
				{
					return;
				}
				_maximumArmor = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("quickhackBarArray")] 
		public CArray<wCHandle<inkWidget>> QuickhackBarArray
		{
			get
			{
				if (_quickhackBarArray == null)
				{
					_quickhackBarArray = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "quickhackBarArray", cr2w, this);
				}
				return _quickhackBarArray;
			}
			set
			{
				if (_quickhackBarArray == value)
				{
					return;
				}
				_quickhackBarArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("maxQuickhackBars")] 
		public CInt32 MaxQuickhackBars
		{
			get
			{
				if (_maxQuickhackBars == null)
				{
					_maxQuickhackBars = (CInt32) CR2WTypeManager.Create("Int32", "maxQuickhackBars", cr2w, this);
				}
				return _maxQuickhackBars;
			}
			set
			{
				if (_maxQuickhackBars == value)
				{
					return;
				}
				_maxQuickhackBars = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("usedQuickhacks")] 
		public CInt32 UsedQuickhacks
		{
			get
			{
				if (_usedQuickhacks == null)
				{
					_usedQuickhacks = (CInt32) CR2WTypeManager.Create("Int32", "usedQuickhacks", cr2w, this);
				}
				return _usedQuickhacks;
			}
			set
			{
				if (_usedQuickhacks == value)
				{
					return;
				}
				_usedQuickhacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("buffsVisible")] 
		public CBool BuffsVisible
		{
			get
			{
				if (_buffsVisible == null)
				{
					_buffsVisible = (CBool) CR2WTypeManager.Create("Bool", "buffsVisible", cr2w, this);
				}
				return _buffsVisible;
			}
			set
			{
				if (_buffsVisible == value)
				{
					return;
				}
				_buffsVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("isUnarmedRightHand")] 
		public CBool IsUnarmedRightHand
		{
			get
			{
				if (_isUnarmedRightHand == null)
				{
					_isUnarmedRightHand = (CBool) CR2WTypeManager.Create("Bool", "isUnarmedRightHand", cr2w, this);
				}
				return _isUnarmedRightHand;
			}
			set
			{
				if (_isUnarmedRightHand == value)
				{
					return;
				}
				_isUnarmedRightHand = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("isUnarmedLeftHand")] 
		public CBool IsUnarmedLeftHand
		{
			get
			{
				if (_isUnarmedLeftHand == null)
				{
					_isUnarmedLeftHand = (CBool) CR2WTypeManager.Create("Bool", "isUnarmedLeftHand", cr2w, this);
				}
				return _isUnarmedLeftHand;
			}
			set
			{
				if (_isUnarmedLeftHand == value)
				{
					return;
				}
				_isUnarmedLeftHand = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("currentVisionPSM")] 
		public CEnum<gamePSMVision> CurrentVisionPSM
		{
			get
			{
				if (_currentVisionPSM == null)
				{
					_currentVisionPSM = (CEnum<gamePSMVision>) CR2WTypeManager.Create("gamePSMVision", "currentVisionPSM", cr2w, this);
				}
				return _currentVisionPSM;
			}
			set
			{
				if (_currentVisionPSM == value)
				{
					return;
				}
				_currentVisionPSM = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("combatModePSM")] 
		public CEnum<gamePSMCombat> CombatModePSM
		{
			get
			{
				if (_combatModePSM == null)
				{
					_combatModePSM = (CEnum<gamePSMCombat>) CR2WTypeManager.Create("gamePSMCombat", "combatModePSM", cr2w, this);
				}
				return _combatModePSM;
			}
			set
			{
				if (_combatModePSM == value)
				{
					return;
				}
				_combatModePSM = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get
			{
				if (_sceneTier == null)
				{
					_sceneTier = (CEnum<GameplayTier>) CR2WTypeManager.Create("GameplayTier", "sceneTier", cr2w, this);
				}
				return _sceneTier;
			}
			set
			{
				if (_sceneTier == value)
				{
					return;
				}
				_sceneTier = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("godModeStatListener")] 
		public CHandle<GodModeStatListener> GodModeStatListener
		{
			get
			{
				if (_godModeStatListener == null)
				{
					_godModeStatListener = (CHandle<GodModeStatListener>) CR2WTypeManager.Create("handle:GodModeStatListener", "godModeStatListener", cr2w, this);
				}
				return _godModeStatListener;
			}
			set
			{
				if (_godModeStatListener == value)
				{
					return;
				}
				_godModeStatListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("playerStatsBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get
			{
				if (_playerStatsBlackboard == null)
				{
					_playerStatsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "playerStatsBlackboard", cr2w, this);
				}
				return _playerStatsBlackboard;
			}
			set
			{
				if (_playerStatsBlackboard == value)
				{
					return;
				}
				_playerStatsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("characterCurrentXPListener")] 
		public CUInt32 CharacterCurrentXPListener
		{
			get
			{
				if (_characterCurrentXPListener == null)
				{
					_characterCurrentXPListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterCurrentXPListener", cr2w, this);
				}
				return _characterCurrentXPListener;
			}
			set
			{
				if (_characterCurrentXPListener == value)
				{
					return;
				}
				_characterCurrentXPListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("levelUpBlackboard")] 
		public CHandle<gameIBlackboard> LevelUpBlackboard
		{
			get
			{
				if (_levelUpBlackboard == null)
				{
					_levelUpBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "levelUpBlackboard", cr2w, this);
				}
				return _levelUpBlackboard;
			}
			set
			{
				if (_levelUpBlackboard == value)
				{
					return;
				}
				_levelUpBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("playerLevelUpListener")] 
		public CUInt32 PlayerLevelUpListener
		{
			get
			{
				if (_playerLevelUpListener == null)
				{
					_playerLevelUpListener = (CUInt32) CR2WTypeManager.Create("Uint32", "playerLevelUpListener", cr2w, this);
				}
				return _playerLevelUpListener;
			}
			set
			{
				if (_playerLevelUpListener == value)
				{
					return;
				}
				_playerLevelUpListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get
			{
				if (_currentLevel == null)
				{
					_currentLevel = (CInt32) CR2WTypeManager.Create("Int32", "currentLevel", cr2w, this);
				}
				return _currentLevel;
			}
			set
			{
				if (_currentLevel == value)
				{
					return;
				}
				_currentLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("playerObject")] 
		public wCHandle<gameObject> PlayerObject
		{
			get
			{
				if (_playerObject == null)
				{
					_playerObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerObject", cr2w, this);
				}
				return _playerObject;
			}
			set
			{
				if (_playerObject == value)
				{
					return;
				}
				_playerObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("playerDevelopmentSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem
		{
			get
			{
				if (_playerDevelopmentSystem == null)
				{
					_playerDevelopmentSystem = (CHandle<PlayerDevelopmentSystem>) CR2WTypeManager.Create("handle:PlayerDevelopmentSystem", "playerDevelopmentSystem", cr2w, this);
				}
				return _playerDevelopmentSystem;
			}
			set
			{
				if (_playerDevelopmentSystem == value)
				{
					return;
				}
				_playerDevelopmentSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		public healthbarWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

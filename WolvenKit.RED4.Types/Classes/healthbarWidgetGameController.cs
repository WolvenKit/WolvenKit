using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class healthbarWidgetGameController : gameuiHUDGameController
	{
		private CWeakHandle<gameIBlackboard> _bbPlayerStats;
		private CHandle<redCallbackObject> _bbPlayerEventId;
		private CWeakHandle<gameIBlackboard> _bbRightWeaponInfo;
		private CHandle<redCallbackObject> _bbRightWeaponEventId;
		private CWeakHandle<gameIBlackboard> _bbLeftWeaponInfo;
		private CHandle<redCallbackObject> _bbLeftWeaponEventId;
		private CHandle<redCallbackObject> _bbPSceneTierEventId;
		private CHandle<redCallbackObject> _visionStateBlackboardId;
		private CHandle<redCallbackObject> _combatModeBlackboardId;
		private CHandle<redCallbackObject> _bbQuickhacksMemeoryEventId;
		private inkWidgetPath _healthPath;
		private inkWidgetPath _healthBarPath;
		private inkWidgetPath _armorPath;
		private inkWidgetPath _armorBarPath;
		private inkWidgetReference _expBar;
		private inkWidgetReference _expBarSpacer;
		private inkWidgetReference _levelUpArrow;
		private inkWidgetReference _levelUpFrame;
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
		private CWeakHandle<NameplateBarLogicController> _healthController;
		private CWeakHandle<ProgressBarSimpleWidgetLogicController> _armorController;
		private CWeakHandle<inkWidget> _rootWidget;
		private CWeakHandle<inkWidget> _buffWidget;
		private CWeakHandle<inkWidget> _hPBar;
		private CWeakHandle<inkWidget> _armorBar;
		private CWeakHandle<inkTextWidget> _invulnerableText;
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
		private CArray<CWeakHandle<inkWidget>> _quickhackBarArray;
		private CInt32 _spawnedMemoryCells;
		private CInt32 _usedQuickhacks;
		private CBool _buffsVisible;
		private CBool _isUnarmedRightHand;
		private CBool _isUnarmedLeftHand;
		private CEnum<gamePSMVision> _currentVisionPSM;
		private CEnum<gamePSMCombat> _combatModePSM;
		private CEnum<GameplayTier> _sceneTier;
		private CHandle<GodModeStatListener> _godModeStatListener;
		private CWeakHandle<gameIBlackboard> _playerStatsBlackboard;
		private CHandle<redCallbackObject> _characterCurrentXPListener;
		private CWeakHandle<gameIBlackboard> _levelUpBlackboard;
		private CHandle<redCallbackObject> _playerLevelUpListener;
		private CInt32 _currentLevel;
		private CWeakHandle<gameObject> _playerObject;
		private CHandle<PlayerDevelopmentSystem> _playerDevelopmentSystem;
		private ScriptGameInstance _gameInstance;
		private CHandle<inkanimProxy> _foldingAnimProxy;
		private CFloat _memoryFillCells;
		private CInt32 _memoryMaxCells;
		private CInt32 _pendingRequests;
		private CArray<CWeakHandle<inkAsyncSpawnRequest>> _spawnTokens;

		[Ordinal(9)] 
		[RED("bbPlayerStats")] 
		public CWeakHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetProperty(ref _bbPlayerStats);
			set => SetProperty(ref _bbPlayerStats, value);
		}

		[Ordinal(10)] 
		[RED("bbPlayerEventId")] 
		public CHandle<redCallbackObject> BbPlayerEventId
		{
			get => GetProperty(ref _bbPlayerEventId);
			set => SetProperty(ref _bbPlayerEventId, value);
		}

		[Ordinal(11)] 
		[RED("bbRightWeaponInfo")] 
		public CWeakHandle<gameIBlackboard> BbRightWeaponInfo
		{
			get => GetProperty(ref _bbRightWeaponInfo);
			set => SetProperty(ref _bbRightWeaponInfo, value);
		}

		[Ordinal(12)] 
		[RED("bbRightWeaponEventId")] 
		public CHandle<redCallbackObject> BbRightWeaponEventId
		{
			get => GetProperty(ref _bbRightWeaponEventId);
			set => SetProperty(ref _bbRightWeaponEventId, value);
		}

		[Ordinal(13)] 
		[RED("bbLeftWeaponInfo")] 
		public CWeakHandle<gameIBlackboard> BbLeftWeaponInfo
		{
			get => GetProperty(ref _bbLeftWeaponInfo);
			set => SetProperty(ref _bbLeftWeaponInfo, value);
		}

		[Ordinal(14)] 
		[RED("bbLeftWeaponEventId")] 
		public CHandle<redCallbackObject> BbLeftWeaponEventId
		{
			get => GetProperty(ref _bbLeftWeaponEventId);
			set => SetProperty(ref _bbLeftWeaponEventId, value);
		}

		[Ordinal(15)] 
		[RED("bbPSceneTierEventId")] 
		public CHandle<redCallbackObject> BbPSceneTierEventId
		{
			get => GetProperty(ref _bbPSceneTierEventId);
			set => SetProperty(ref _bbPSceneTierEventId, value);
		}

		[Ordinal(16)] 
		[RED("visionStateBlackboardId")] 
		public CHandle<redCallbackObject> VisionStateBlackboardId
		{
			get => GetProperty(ref _visionStateBlackboardId);
			set => SetProperty(ref _visionStateBlackboardId, value);
		}

		[Ordinal(17)] 
		[RED("combatModeBlackboardId")] 
		public CHandle<redCallbackObject> CombatModeBlackboardId
		{
			get => GetProperty(ref _combatModeBlackboardId);
			set => SetProperty(ref _combatModeBlackboardId, value);
		}

		[Ordinal(18)] 
		[RED("bbQuickhacksMemeoryEventId")] 
		public CHandle<redCallbackObject> BbQuickhacksMemeoryEventId
		{
			get => GetProperty(ref _bbQuickhacksMemeoryEventId);
			set => SetProperty(ref _bbQuickhacksMemeoryEventId, value);
		}

		[Ordinal(19)] 
		[RED("healthPath")] 
		public inkWidgetPath HealthPath
		{
			get => GetProperty(ref _healthPath);
			set => SetProperty(ref _healthPath, value);
		}

		[Ordinal(20)] 
		[RED("healthBarPath")] 
		public inkWidgetPath HealthBarPath
		{
			get => GetProperty(ref _healthBarPath);
			set => SetProperty(ref _healthBarPath, value);
		}

		[Ordinal(21)] 
		[RED("armorPath")] 
		public inkWidgetPath ArmorPath
		{
			get => GetProperty(ref _armorPath);
			set => SetProperty(ref _armorPath, value);
		}

		[Ordinal(22)] 
		[RED("armorBarPath")] 
		public inkWidgetPath ArmorBarPath
		{
			get => GetProperty(ref _armorBarPath);
			set => SetProperty(ref _armorBarPath, value);
		}

		[Ordinal(23)] 
		[RED("expBar")] 
		public inkWidgetReference ExpBar
		{
			get => GetProperty(ref _expBar);
			set => SetProperty(ref _expBar, value);
		}

		[Ordinal(24)] 
		[RED("expBarSpacer")] 
		public inkWidgetReference ExpBarSpacer
		{
			get => GetProperty(ref _expBarSpacer);
			set => SetProperty(ref _expBarSpacer, value);
		}

		[Ordinal(25)] 
		[RED("levelUpArrow")] 
		public inkWidgetReference LevelUpArrow
		{
			get => GetProperty(ref _levelUpArrow);
			set => SetProperty(ref _levelUpArrow, value);
		}

		[Ordinal(26)] 
		[RED("levelUpFrame")] 
		public inkWidgetReference LevelUpFrame
		{
			get => GetProperty(ref _levelUpFrame);
			set => SetProperty(ref _levelUpFrame, value);
		}

		[Ordinal(27)] 
		[RED("barsLayoutPath")] 
		public inkCompoundWidgetReference BarsLayoutPath
		{
			get => GetProperty(ref _barsLayoutPath);
			set => SetProperty(ref _barsLayoutPath, value);
		}

		[Ordinal(28)] 
		[RED("buffsHolder")] 
		public inkCompoundWidgetReference BuffsHolder
		{
			get => GetProperty(ref _buffsHolder);
			set => SetProperty(ref _buffsHolder, value);
		}

		[Ordinal(29)] 
		[RED("invulnerableTextPath")] 
		public inkTextWidgetReference InvulnerableTextPath
		{
			get => GetProperty(ref _invulnerableTextPath);
			set => SetProperty(ref _invulnerableTextPath, value);
		}

		[Ordinal(30)] 
		[RED("levelTextPath")] 
		public inkTextWidgetReference LevelTextPath
		{
			get => GetProperty(ref _levelTextPath);
			set => SetProperty(ref _levelTextPath, value);
		}

		[Ordinal(31)] 
		[RED("nextLevelTextPath")] 
		public inkTextWidgetReference NextLevelTextPath
		{
			get => GetProperty(ref _nextLevelTextPath);
			set => SetProperty(ref _nextLevelTextPath, value);
		}

		[Ordinal(32)] 
		[RED("healthTextPath")] 
		public inkTextWidgetReference HealthTextPath
		{
			get => GetProperty(ref _healthTextPath);
			set => SetProperty(ref _healthTextPath, value);
		}

		[Ordinal(33)] 
		[RED("maxHealthTextPath")] 
		public inkTextWidgetReference MaxHealthTextPath
		{
			get => GetProperty(ref _maxHealthTextPath);
			set => SetProperty(ref _maxHealthTextPath, value);
		}

		[Ordinal(34)] 
		[RED("quickhacksContainer")] 
		public inkCompoundWidgetReference QuickhacksContainer
		{
			get => GetProperty(ref _quickhacksContainer);
			set => SetProperty(ref _quickhacksContainer, value);
		}

		[Ordinal(35)] 
		[RED("expText")] 
		public inkTextWidgetReference ExpText
		{
			get => GetProperty(ref _expText);
			set => SetProperty(ref _expText, value);
		}

		[Ordinal(36)] 
		[RED("expTextLabel")] 
		public inkTextWidgetReference ExpTextLabel
		{
			get => GetProperty(ref _expTextLabel);
			set => SetProperty(ref _expTextLabel, value);
		}

		[Ordinal(37)] 
		[RED("lostHealthAggregationBar")] 
		public inkWidgetReference LostHealthAggregationBar
		{
			get => GetProperty(ref _lostHealthAggregationBar);
			set => SetProperty(ref _lostHealthAggregationBar, value);
		}

		[Ordinal(38)] 
		[RED("levelUpRectangle")] 
		public inkWidgetReference LevelUpRectangle
		{
			get => GetProperty(ref _levelUpRectangle);
			set => SetProperty(ref _levelUpRectangle, value);
		}

		[Ordinal(39)] 
		[RED("healthController")] 
		public CWeakHandle<NameplateBarLogicController> HealthController
		{
			get => GetProperty(ref _healthController);
			set => SetProperty(ref _healthController, value);
		}

		[Ordinal(40)] 
		[RED("armorController")] 
		public CWeakHandle<ProgressBarSimpleWidgetLogicController> ArmorController
		{
			get => GetProperty(ref _armorController);
			set => SetProperty(ref _armorController, value);
		}

		[Ordinal(41)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(42)] 
		[RED("buffWidget")] 
		public CWeakHandle<inkWidget> BuffWidget
		{
			get => GetProperty(ref _buffWidget);
			set => SetProperty(ref _buffWidget, value);
		}

		[Ordinal(43)] 
		[RED("HPBar")] 
		public CWeakHandle<inkWidget> HPBar
		{
			get => GetProperty(ref _hPBar);
			set => SetProperty(ref _hPBar, value);
		}

		[Ordinal(44)] 
		[RED("armorBar")] 
		public CWeakHandle<inkWidget> ArmorBar
		{
			get => GetProperty(ref _armorBar);
			set => SetProperty(ref _armorBar, value);
		}

		[Ordinal(45)] 
		[RED("invulnerableText")] 
		public CWeakHandle<inkTextWidget> InvulnerableText
		{
			get => GetProperty(ref _invulnerableText);
			set => SetProperty(ref _invulnerableText, value);
		}

		[Ordinal(46)] 
		[RED("animHideTemp")] 
		public CHandle<inkanimDefinition> AnimHideTemp
		{
			get => GetProperty(ref _animHideTemp);
			set => SetProperty(ref _animHideTemp, value);
		}

		[Ordinal(47)] 
		[RED("animShortFade")] 
		public CHandle<inkanimDefinition> AnimShortFade
		{
			get => GetProperty(ref _animShortFade);
			set => SetProperty(ref _animShortFade, value);
		}

		[Ordinal(48)] 
		[RED("animLongFade")] 
		public CHandle<inkanimDefinition> AnimLongFade
		{
			get => GetProperty(ref _animLongFade);
			set => SetProperty(ref _animLongFade, value);
		}

		[Ordinal(49)] 
		[RED("animHideHPProxy")] 
		public CHandle<inkanimProxy> AnimHideHPProxy
		{
			get => GetProperty(ref _animHideHPProxy);
			set => SetProperty(ref _animHideHPProxy, value);
		}

		[Ordinal(50)] 
		[RED("delayAnimation")] 
		public CHandle<inkanimDefinition> DelayAnimation
		{
			get => GetProperty(ref _delayAnimation);
			set => SetProperty(ref _delayAnimation, value);
		}

		[Ordinal(51)] 
		[RED("animCreated")] 
		public CBool AnimCreated
		{
			get => GetProperty(ref _animCreated);
			set => SetProperty(ref _animCreated, value);
		}

		[Ordinal(52)] 
		[RED("aggregatingActive")] 
		public CBool AggregatingActive
		{
			get => GetProperty(ref _aggregatingActive);
			set => SetProperty(ref _aggregatingActive, value);
		}

		[Ordinal(53)] 
		[RED("countingStartHealth")] 
		public CInt32 CountingStartHealth
		{
			get => GetProperty(ref _countingStartHealth);
			set => SetProperty(ref _countingStartHealth, value);
		}

		[Ordinal(54)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(55)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get => GetProperty(ref _previousHealth);
			set => SetProperty(ref _previousHealth, value);
		}

		[Ordinal(56)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetProperty(ref _maximumHealth);
			set => SetProperty(ref _maximumHealth, value);
		}

		[Ordinal(57)] 
		[RED("quickhacksMemoryPercent")] 
		public CFloat QuickhacksMemoryPercent
		{
			get => GetProperty(ref _quickhacksMemoryPercent);
			set => SetProperty(ref _quickhacksMemoryPercent, value);
		}

		[Ordinal(58)] 
		[RED("currentArmor")] 
		public CInt32 CurrentArmor
		{
			get => GetProperty(ref _currentArmor);
			set => SetProperty(ref _currentArmor, value);
		}

		[Ordinal(59)] 
		[RED("maximumArmor")] 
		public CInt32 MaximumArmor
		{
			get => GetProperty(ref _maximumArmor);
			set => SetProperty(ref _maximumArmor, value);
		}

		[Ordinal(60)] 
		[RED("quickhackBarArray")] 
		public CArray<CWeakHandle<inkWidget>> QuickhackBarArray
		{
			get => GetProperty(ref _quickhackBarArray);
			set => SetProperty(ref _quickhackBarArray, value);
		}

		[Ordinal(61)] 
		[RED("spawnedMemoryCells")] 
		public CInt32 SpawnedMemoryCells
		{
			get => GetProperty(ref _spawnedMemoryCells);
			set => SetProperty(ref _spawnedMemoryCells, value);
		}

		[Ordinal(62)] 
		[RED("usedQuickhacks")] 
		public CInt32 UsedQuickhacks
		{
			get => GetProperty(ref _usedQuickhacks);
			set => SetProperty(ref _usedQuickhacks, value);
		}

		[Ordinal(63)] 
		[RED("buffsVisible")] 
		public CBool BuffsVisible
		{
			get => GetProperty(ref _buffsVisible);
			set => SetProperty(ref _buffsVisible, value);
		}

		[Ordinal(64)] 
		[RED("isUnarmedRightHand")] 
		public CBool IsUnarmedRightHand
		{
			get => GetProperty(ref _isUnarmedRightHand);
			set => SetProperty(ref _isUnarmedRightHand, value);
		}

		[Ordinal(65)] 
		[RED("isUnarmedLeftHand")] 
		public CBool IsUnarmedLeftHand
		{
			get => GetProperty(ref _isUnarmedLeftHand);
			set => SetProperty(ref _isUnarmedLeftHand, value);
		}

		[Ordinal(66)] 
		[RED("currentVisionPSM")] 
		public CEnum<gamePSMVision> CurrentVisionPSM
		{
			get => GetProperty(ref _currentVisionPSM);
			set => SetProperty(ref _currentVisionPSM, value);
		}

		[Ordinal(67)] 
		[RED("combatModePSM")] 
		public CEnum<gamePSMCombat> CombatModePSM
		{
			get => GetProperty(ref _combatModePSM);
			set => SetProperty(ref _combatModePSM, value);
		}

		[Ordinal(68)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(69)] 
		[RED("godModeStatListener")] 
		public CHandle<GodModeStatListener> GodModeStatListener
		{
			get => GetProperty(ref _godModeStatListener);
			set => SetProperty(ref _godModeStatListener, value);
		}

		[Ordinal(70)] 
		[RED("playerStatsBlackboard")] 
		public CWeakHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(71)] 
		[RED("characterCurrentXPListener")] 
		public CHandle<redCallbackObject> CharacterCurrentXPListener
		{
			get => GetProperty(ref _characterCurrentXPListener);
			set => SetProperty(ref _characterCurrentXPListener, value);
		}

		[Ordinal(72)] 
		[RED("levelUpBlackboard")] 
		public CWeakHandle<gameIBlackboard> LevelUpBlackboard
		{
			get => GetProperty(ref _levelUpBlackboard);
			set => SetProperty(ref _levelUpBlackboard, value);
		}

		[Ordinal(73)] 
		[RED("playerLevelUpListener")] 
		public CHandle<redCallbackObject> PlayerLevelUpListener
		{
			get => GetProperty(ref _playerLevelUpListener);
			set => SetProperty(ref _playerLevelUpListener, value);
		}

		[Ordinal(74)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get => GetProperty(ref _currentLevel);
			set => SetProperty(ref _currentLevel, value);
		}

		[Ordinal(75)] 
		[RED("playerObject")] 
		public CWeakHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}

		[Ordinal(76)] 
		[RED("playerDevelopmentSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem
		{
			get => GetProperty(ref _playerDevelopmentSystem);
			set => SetProperty(ref _playerDevelopmentSystem, value);
		}

		[Ordinal(77)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(78)] 
		[RED("foldingAnimProxy")] 
		public CHandle<inkanimProxy> FoldingAnimProxy
		{
			get => GetProperty(ref _foldingAnimProxy);
			set => SetProperty(ref _foldingAnimProxy, value);
		}

		[Ordinal(79)] 
		[RED("memoryFillCells")] 
		public CFloat MemoryFillCells
		{
			get => GetProperty(ref _memoryFillCells);
			set => SetProperty(ref _memoryFillCells, value);
		}

		[Ordinal(80)] 
		[RED("memoryMaxCells")] 
		public CInt32 MemoryMaxCells
		{
			get => GetProperty(ref _memoryMaxCells);
			set => SetProperty(ref _memoryMaxCells, value);
		}

		[Ordinal(81)] 
		[RED("pendingRequests")] 
		public CInt32 PendingRequests
		{
			get => GetProperty(ref _pendingRequests);
			set => SetProperty(ref _pendingRequests, value);
		}

		[Ordinal(82)] 
		[RED("spawnTokens")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> SpawnTokens
		{
			get => GetProperty(ref _spawnTokens);
			set => SetProperty(ref _spawnTokens, value);
		}

		public healthbarWidgetGameController()
		{
			_isUnarmedRightHand = true;
			_isUnarmedLeftHand = true;
		}
	}
}

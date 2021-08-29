using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickhacksListGameController : gameuiHUDGameController
	{
		private CFloat _timeBetweenIntroAndIntroDescription;
		private gameDelayID _timeBetweenIntroAndDescritpionDelayID;
		private CBool _timeBetweenIntroAndDescritpionCheck;
		private CHandle<inkanimProxy> _introDescriptionAnimProxy;
		private inkWidgetReference _middleDots;
		private inkWidgetReference _memoryWidget;
		private inkTextWidgetReference _avaliableMemory;
		private inkWidgetReference _listWidget;
		private inkWidgetReference _executeBtn;
		private inkWidgetReference _executeAndCloseBtn;
		private inkWidgetReference _rightPanel;
		private inkWidgetReference _networkBreach;
		private inkWidgetReference _costReductionPanel;
		private inkTextWidgetReference _costReductionValue;
		private inkTextWidgetReference _targetName;
		private inkWidgetReference _icePanel;
		private inkTextWidgetReference _iceValue;
		private inkWidgetReference _vulnerabilitiesPanel;
		private CArray<inkWidgetReference> _vulnerabilityFields;
		private inkTextWidgetReference _subHeader;
		private inkTextWidgetReference _tier;
		private inkTextWidgetReference _description;
		private inkTextWidgetReference _recompileTimer;
		private inkTextWidgetReference _damage;
		private inkTextWidgetReference _duration;
		private inkTextWidgetReference _cooldown;
		private inkTextWidgetReference _uploadTime;
		private inkTextWidgetReference _memoryCost;
		private inkTextWidgetReference _memoryRawCost;
		private inkWidgetReference _warningWidget;
		private inkTextWidgetReference _warningText;
		private inkWidgetReference _recompilePanel;
		private inkTextWidgetReference _recompileText;
		private CBool _isUILocked;
		private ScriptGameInstance _gameInstance;
		private CWeakHandle<gameVisionModeSystem> _visionModeSystem;
		private CWeakHandle<gameScanningController> _scanningCtrl;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private CBool _contextHelpOverlay;
		private CUInt32 _quickHackDescriptionVisibility;
		private CHandle<redCallbackObject> _buffListListener;
		private CWeakHandle<gameIBlackboard> _memoryBoard;
		private CHandle<UI_PlayerBioMonitorDef> _memoryBoardDef;
		private CHandle<redCallbackObject> _memoryPercentListener;
		private CArray<CWeakHandle<inkCompoundWidget>> _quickhackBarArray;
		private CInt32 _maxQuickhackBars;
		private CWeakHandle<inkListController> _listController;
		private CArray<CHandle<QuickhackData>> _data;
		private CHandle<QuickhackData> _selectedData;
		private CBool _active;
		private CHandle<inkanimProxy> _memorySpendAnimation;
		private CInt32 _currentMemoryCellsActive;
		private CInt32 _desiredMemoryCellsActive;
		private CArray<CHandle<inkanimProxy>> _selectedMemoryLoop;
		private CHandle<inkanimProxy> _inkIntroAnimProxy;
		private CHandle<inkanimProxy> _inkVulnerabilityAnimProxy;
		private CHandle<inkanimProxy> _inkWarningAnimProxy;
		private CHandle<inkanimProxy> _inkRecompileAnimProxy;
		private CHandle<inkanimProxy> _inkReductionAnimProxy;
		private CBool _hACK_wasPlayedOnTarget;
		private CHandle<inkanimProxy> _inkMemoryWarningTransitionAnimProxy;
		private CName _lastMemoryWarningTransitionAnimName;
		private CBool _hasActiveUpload;
		private entEntityID _lastCompiledTarget;
		private CArray<CInt32> _statPoolListenersIndexes;
		private CWeakHandle<gameIBlackboard> _chunkBlackboard;
		private CHandle<redCallbackObject> _nameCallbackID;
		private CInt32 _lastFillCells;
		private CInt32 _lastUsedCells;
		private CInt32 _lastMaxCells;
		private CBool _axisInputConsumed;
		private CWeakHandle<gameObject> _playerObject;

		[Ordinal(9)] 
		[RED("timeBetweenIntroAndIntroDescription")] 
		public CFloat TimeBetweenIntroAndIntroDescription
		{
			get => GetProperty(ref _timeBetweenIntroAndIntroDescription);
			set => SetProperty(ref _timeBetweenIntroAndIntroDescription, value);
		}

		[Ordinal(10)] 
		[RED("timeBetweenIntroAndDescritpionDelayID")] 
		public gameDelayID TimeBetweenIntroAndDescritpionDelayID
		{
			get => GetProperty(ref _timeBetweenIntroAndDescritpionDelayID);
			set => SetProperty(ref _timeBetweenIntroAndDescritpionDelayID, value);
		}

		[Ordinal(11)] 
		[RED("timeBetweenIntroAndDescritpionCheck")] 
		public CBool TimeBetweenIntroAndDescritpionCheck
		{
			get => GetProperty(ref _timeBetweenIntroAndDescritpionCheck);
			set => SetProperty(ref _timeBetweenIntroAndDescritpionCheck, value);
		}

		[Ordinal(12)] 
		[RED("introDescriptionAnimProxy")] 
		public CHandle<inkanimProxy> IntroDescriptionAnimProxy
		{
			get => GetProperty(ref _introDescriptionAnimProxy);
			set => SetProperty(ref _introDescriptionAnimProxy, value);
		}

		[Ordinal(13)] 
		[RED("middleDots")] 
		public inkWidgetReference MiddleDots
		{
			get => GetProperty(ref _middleDots);
			set => SetProperty(ref _middleDots, value);
		}

		[Ordinal(14)] 
		[RED("memoryWidget")] 
		public inkWidgetReference MemoryWidget
		{
			get => GetProperty(ref _memoryWidget);
			set => SetProperty(ref _memoryWidget, value);
		}

		[Ordinal(15)] 
		[RED("avaliableMemory")] 
		public inkTextWidgetReference AvaliableMemory
		{
			get => GetProperty(ref _avaliableMemory);
			set => SetProperty(ref _avaliableMemory, value);
		}

		[Ordinal(16)] 
		[RED("listWidget")] 
		public inkWidgetReference ListWidget
		{
			get => GetProperty(ref _listWidget);
			set => SetProperty(ref _listWidget, value);
		}

		[Ordinal(17)] 
		[RED("executeBtn")] 
		public inkWidgetReference ExecuteBtn
		{
			get => GetProperty(ref _executeBtn);
			set => SetProperty(ref _executeBtn, value);
		}

		[Ordinal(18)] 
		[RED("executeAndCloseBtn")] 
		public inkWidgetReference ExecuteAndCloseBtn
		{
			get => GetProperty(ref _executeAndCloseBtn);
			set => SetProperty(ref _executeAndCloseBtn, value);
		}

		[Ordinal(19)] 
		[RED("rightPanel")] 
		public inkWidgetReference RightPanel
		{
			get => GetProperty(ref _rightPanel);
			set => SetProperty(ref _rightPanel, value);
		}

		[Ordinal(20)] 
		[RED("networkBreach")] 
		public inkWidgetReference NetworkBreach
		{
			get => GetProperty(ref _networkBreach);
			set => SetProperty(ref _networkBreach, value);
		}

		[Ordinal(21)] 
		[RED("costReductionPanel")] 
		public inkWidgetReference CostReductionPanel
		{
			get => GetProperty(ref _costReductionPanel);
			set => SetProperty(ref _costReductionPanel, value);
		}

		[Ordinal(22)] 
		[RED("costReductionValue")] 
		public inkTextWidgetReference CostReductionValue
		{
			get => GetProperty(ref _costReductionValue);
			set => SetProperty(ref _costReductionValue, value);
		}

		[Ordinal(23)] 
		[RED("targetName")] 
		public inkTextWidgetReference TargetName
		{
			get => GetProperty(ref _targetName);
			set => SetProperty(ref _targetName, value);
		}

		[Ordinal(24)] 
		[RED("icePanel")] 
		public inkWidgetReference IcePanel
		{
			get => GetProperty(ref _icePanel);
			set => SetProperty(ref _icePanel, value);
		}

		[Ordinal(25)] 
		[RED("iceValue")] 
		public inkTextWidgetReference IceValue
		{
			get => GetProperty(ref _iceValue);
			set => SetProperty(ref _iceValue, value);
		}

		[Ordinal(26)] 
		[RED("vulnerabilitiesPanel")] 
		public inkWidgetReference VulnerabilitiesPanel
		{
			get => GetProperty(ref _vulnerabilitiesPanel);
			set => SetProperty(ref _vulnerabilitiesPanel, value);
		}

		[Ordinal(27)] 
		[RED("vulnerabilityFields")] 
		public CArray<inkWidgetReference> VulnerabilityFields
		{
			get => GetProperty(ref _vulnerabilityFields);
			set => SetProperty(ref _vulnerabilityFields, value);
		}

		[Ordinal(28)] 
		[RED("subHeader")] 
		public inkTextWidgetReference SubHeader
		{
			get => GetProperty(ref _subHeader);
			set => SetProperty(ref _subHeader, value);
		}

		[Ordinal(29)] 
		[RED("tier")] 
		public inkTextWidgetReference Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}

		[Ordinal(30)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(31)] 
		[RED("recompileTimer")] 
		public inkTextWidgetReference RecompileTimer
		{
			get => GetProperty(ref _recompileTimer);
			set => SetProperty(ref _recompileTimer, value);
		}

		[Ordinal(32)] 
		[RED("damage")] 
		public inkTextWidgetReference Damage
		{
			get => GetProperty(ref _damage);
			set => SetProperty(ref _damage, value);
		}

		[Ordinal(33)] 
		[RED("duration")] 
		public inkTextWidgetReference Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(34)] 
		[RED("cooldown")] 
		public inkTextWidgetReference Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(35)] 
		[RED("uploadTime")] 
		public inkTextWidgetReference UploadTime
		{
			get => GetProperty(ref _uploadTime);
			set => SetProperty(ref _uploadTime, value);
		}

		[Ordinal(36)] 
		[RED("memoryCost")] 
		public inkTextWidgetReference MemoryCost
		{
			get => GetProperty(ref _memoryCost);
			set => SetProperty(ref _memoryCost, value);
		}

		[Ordinal(37)] 
		[RED("memoryRawCost")] 
		public inkTextWidgetReference MemoryRawCost
		{
			get => GetProperty(ref _memoryRawCost);
			set => SetProperty(ref _memoryRawCost, value);
		}

		[Ordinal(38)] 
		[RED("warningWidget")] 
		public inkWidgetReference WarningWidget
		{
			get => GetProperty(ref _warningWidget);
			set => SetProperty(ref _warningWidget, value);
		}

		[Ordinal(39)] 
		[RED("warningText")] 
		public inkTextWidgetReference WarningText
		{
			get => GetProperty(ref _warningText);
			set => SetProperty(ref _warningText, value);
		}

		[Ordinal(40)] 
		[RED("recompilePanel")] 
		public inkWidgetReference RecompilePanel
		{
			get => GetProperty(ref _recompilePanel);
			set => SetProperty(ref _recompilePanel, value);
		}

		[Ordinal(41)] 
		[RED("recompileText")] 
		public inkTextWidgetReference RecompileText
		{
			get => GetProperty(ref _recompileText);
			set => SetProperty(ref _recompileText, value);
		}

		[Ordinal(42)] 
		[RED("isUILocked")] 
		public CBool IsUILocked
		{
			get => GetProperty(ref _isUILocked);
			set => SetProperty(ref _isUILocked, value);
		}

		[Ordinal(43)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(44)] 
		[RED("visionModeSystem")] 
		public CWeakHandle<gameVisionModeSystem> VisionModeSystem
		{
			get => GetProperty(ref _visionModeSystem);
			set => SetProperty(ref _visionModeSystem, value);
		}

		[Ordinal(45)] 
		[RED("scanningCtrl")] 
		public CWeakHandle<gameScanningController> ScanningCtrl
		{
			get => GetProperty(ref _scanningCtrl);
			set => SetProperty(ref _scanningCtrl, value);
		}

		[Ordinal(46)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(47)] 
		[RED("contextHelpOverlay")] 
		public CBool ContextHelpOverlay
		{
			get => GetProperty(ref _contextHelpOverlay);
			set => SetProperty(ref _contextHelpOverlay, value);
		}

		[Ordinal(48)] 
		[RED("quickHackDescriptionVisibility")] 
		public CUInt32 QuickHackDescriptionVisibility
		{
			get => GetProperty(ref _quickHackDescriptionVisibility);
			set => SetProperty(ref _quickHackDescriptionVisibility, value);
		}

		[Ordinal(49)] 
		[RED("buffListListener")] 
		public CHandle<redCallbackObject> BuffListListener
		{
			get => GetProperty(ref _buffListListener);
			set => SetProperty(ref _buffListListener, value);
		}

		[Ordinal(50)] 
		[RED("memoryBoard")] 
		public CWeakHandle<gameIBlackboard> MemoryBoard
		{
			get => GetProperty(ref _memoryBoard);
			set => SetProperty(ref _memoryBoard, value);
		}

		[Ordinal(51)] 
		[RED("memoryBoardDef")] 
		public CHandle<UI_PlayerBioMonitorDef> MemoryBoardDef
		{
			get => GetProperty(ref _memoryBoardDef);
			set => SetProperty(ref _memoryBoardDef, value);
		}

		[Ordinal(52)] 
		[RED("memoryPercentListener")] 
		public CHandle<redCallbackObject> MemoryPercentListener
		{
			get => GetProperty(ref _memoryPercentListener);
			set => SetProperty(ref _memoryPercentListener, value);
		}

		[Ordinal(53)] 
		[RED("quickhackBarArray")] 
		public CArray<CWeakHandle<inkCompoundWidget>> QuickhackBarArray
		{
			get => GetProperty(ref _quickhackBarArray);
			set => SetProperty(ref _quickhackBarArray, value);
		}

		[Ordinal(54)] 
		[RED("maxQuickhackBars")] 
		public CInt32 MaxQuickhackBars
		{
			get => GetProperty(ref _maxQuickhackBars);
			set => SetProperty(ref _maxQuickhackBars, value);
		}

		[Ordinal(55)] 
		[RED("listController")] 
		public CWeakHandle<inkListController> ListController
		{
			get => GetProperty(ref _listController);
			set => SetProperty(ref _listController, value);
		}

		[Ordinal(56)] 
		[RED("data")] 
		public CArray<CHandle<QuickhackData>> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(57)] 
		[RED("selectedData")] 
		public CHandle<QuickhackData> SelectedData
		{
			get => GetProperty(ref _selectedData);
			set => SetProperty(ref _selectedData, value);
		}

		[Ordinal(58)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(59)] 
		[RED("memorySpendAnimation")] 
		public CHandle<inkanimProxy> MemorySpendAnimation
		{
			get => GetProperty(ref _memorySpendAnimation);
			set => SetProperty(ref _memorySpendAnimation, value);
		}

		[Ordinal(60)] 
		[RED("currentMemoryCellsActive")] 
		public CInt32 CurrentMemoryCellsActive
		{
			get => GetProperty(ref _currentMemoryCellsActive);
			set => SetProperty(ref _currentMemoryCellsActive, value);
		}

		[Ordinal(61)] 
		[RED("desiredMemoryCellsActive")] 
		public CInt32 DesiredMemoryCellsActive
		{
			get => GetProperty(ref _desiredMemoryCellsActive);
			set => SetProperty(ref _desiredMemoryCellsActive, value);
		}

		[Ordinal(62)] 
		[RED("selectedMemoryLoop")] 
		public CArray<CHandle<inkanimProxy>> SelectedMemoryLoop
		{
			get => GetProperty(ref _selectedMemoryLoop);
			set => SetProperty(ref _selectedMemoryLoop, value);
		}

		[Ordinal(63)] 
		[RED("inkIntroAnimProxy")] 
		public CHandle<inkanimProxy> InkIntroAnimProxy
		{
			get => GetProperty(ref _inkIntroAnimProxy);
			set => SetProperty(ref _inkIntroAnimProxy, value);
		}

		[Ordinal(64)] 
		[RED("inkVulnerabilityAnimProxy")] 
		public CHandle<inkanimProxy> InkVulnerabilityAnimProxy
		{
			get => GetProperty(ref _inkVulnerabilityAnimProxy);
			set => SetProperty(ref _inkVulnerabilityAnimProxy, value);
		}

		[Ordinal(65)] 
		[RED("inkWarningAnimProxy")] 
		public CHandle<inkanimProxy> InkWarningAnimProxy
		{
			get => GetProperty(ref _inkWarningAnimProxy);
			set => SetProperty(ref _inkWarningAnimProxy, value);
		}

		[Ordinal(66)] 
		[RED("inkRecompileAnimProxy")] 
		public CHandle<inkanimProxy> InkRecompileAnimProxy
		{
			get => GetProperty(ref _inkRecompileAnimProxy);
			set => SetProperty(ref _inkRecompileAnimProxy, value);
		}

		[Ordinal(67)] 
		[RED("inkReductionAnimProxy")] 
		public CHandle<inkanimProxy> InkReductionAnimProxy
		{
			get => GetProperty(ref _inkReductionAnimProxy);
			set => SetProperty(ref _inkReductionAnimProxy, value);
		}

		[Ordinal(68)] 
		[RED("HACK_wasPlayedOnTarget")] 
		public CBool HACK_wasPlayedOnTarget
		{
			get => GetProperty(ref _hACK_wasPlayedOnTarget);
			set => SetProperty(ref _hACK_wasPlayedOnTarget, value);
		}

		[Ordinal(69)] 
		[RED("inkMemoryWarningTransitionAnimProxy")] 
		public CHandle<inkanimProxy> InkMemoryWarningTransitionAnimProxy
		{
			get => GetProperty(ref _inkMemoryWarningTransitionAnimProxy);
			set => SetProperty(ref _inkMemoryWarningTransitionAnimProxy, value);
		}

		[Ordinal(70)] 
		[RED("lastMemoryWarningTransitionAnimName")] 
		public CName LastMemoryWarningTransitionAnimName
		{
			get => GetProperty(ref _lastMemoryWarningTransitionAnimName);
			set => SetProperty(ref _lastMemoryWarningTransitionAnimName, value);
		}

		[Ordinal(71)] 
		[RED("hasActiveUpload")] 
		public CBool HasActiveUpload
		{
			get => GetProperty(ref _hasActiveUpload);
			set => SetProperty(ref _hasActiveUpload, value);
		}

		[Ordinal(72)] 
		[RED("lastCompiledTarget")] 
		public entEntityID LastCompiledTarget
		{
			get => GetProperty(ref _lastCompiledTarget);
			set => SetProperty(ref _lastCompiledTarget, value);
		}

		[Ordinal(73)] 
		[RED("statPoolListenersIndexes")] 
		public CArray<CInt32> StatPoolListenersIndexes
		{
			get => GetProperty(ref _statPoolListenersIndexes);
			set => SetProperty(ref _statPoolListenersIndexes, value);
		}

		[Ordinal(74)] 
		[RED("chunkBlackboard")] 
		public CWeakHandle<gameIBlackboard> ChunkBlackboard
		{
			get => GetProperty(ref _chunkBlackboard);
			set => SetProperty(ref _chunkBlackboard, value);
		}

		[Ordinal(75)] 
		[RED("nameCallbackID")] 
		public CHandle<redCallbackObject> NameCallbackID
		{
			get => GetProperty(ref _nameCallbackID);
			set => SetProperty(ref _nameCallbackID, value);
		}

		[Ordinal(76)] 
		[RED("lastFillCells")] 
		public CInt32 LastFillCells
		{
			get => GetProperty(ref _lastFillCells);
			set => SetProperty(ref _lastFillCells, value);
		}

		[Ordinal(77)] 
		[RED("lastUsedCells")] 
		public CInt32 LastUsedCells
		{
			get => GetProperty(ref _lastUsedCells);
			set => SetProperty(ref _lastUsedCells, value);
		}

		[Ordinal(78)] 
		[RED("lastMaxCells")] 
		public CInt32 LastMaxCells
		{
			get => GetProperty(ref _lastMaxCells);
			set => SetProperty(ref _lastMaxCells, value);
		}

		[Ordinal(79)] 
		[RED("axisInputConsumed")] 
		public CBool AxisInputConsumed
		{
			get => GetProperty(ref _axisInputConsumed);
			set => SetProperty(ref _axisInputConsumed, value);
		}

		[Ordinal(80)] 
		[RED("playerObject")] 
		public CWeakHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}
	}
}

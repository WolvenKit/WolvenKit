using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhacksListGameController : gameuiHUDGameController
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
		private wCHandle<gameVisionModeSystem> _visionModeSystem;
		private wCHandle<gameScanningController> _scanningCtrl;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private CBool _contextHelpOverlay;
		private CUInt32 _quickHackDescriptionVisibility;
		private CUInt32 _buffListListener;
		private CHandle<gameIBlackboard> _memoryBoard;
		private CHandle<UI_PlayerBioMonitorDef> _memoryBoardDef;
		private CUInt32 _memoryPercentListener;
		private CArray<wCHandle<inkCompoundWidget>> _quickhackBarArray;
		private CInt32 _maxQuickhackBars;
		private CHandle<inkListController> _listController;
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
		private CHandle<gameIBlackboard> _chunkBlackboard;
		private CUInt32 _nameCallbackID;
		private CBool _axisInputConsumed;
		private wCHandle<gameObject> _playerObject;

		[Ordinal(9)] 
		[RED("timeBetweenIntroAndIntroDescription")] 
		public CFloat TimeBetweenIntroAndIntroDescription
		{
			get
			{
				if (_timeBetweenIntroAndIntroDescription == null)
				{
					_timeBetweenIntroAndIntroDescription = (CFloat) CR2WTypeManager.Create("Float", "timeBetweenIntroAndIntroDescription", cr2w, this);
				}
				return _timeBetweenIntroAndIntroDescription;
			}
			set
			{
				if (_timeBetweenIntroAndIntroDescription == value)
				{
					return;
				}
				_timeBetweenIntroAndIntroDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("timeBetweenIntroAndDescritpionDelayID")] 
		public gameDelayID TimeBetweenIntroAndDescritpionDelayID
		{
			get
			{
				if (_timeBetweenIntroAndDescritpionDelayID == null)
				{
					_timeBetweenIntroAndDescritpionDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "timeBetweenIntroAndDescritpionDelayID", cr2w, this);
				}
				return _timeBetweenIntroAndDescritpionDelayID;
			}
			set
			{
				if (_timeBetweenIntroAndDescritpionDelayID == value)
				{
					return;
				}
				_timeBetweenIntroAndDescritpionDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("timeBetweenIntroAndDescritpionCheck")] 
		public CBool TimeBetweenIntroAndDescritpionCheck
		{
			get
			{
				if (_timeBetweenIntroAndDescritpionCheck == null)
				{
					_timeBetweenIntroAndDescritpionCheck = (CBool) CR2WTypeManager.Create("Bool", "timeBetweenIntroAndDescritpionCheck", cr2w, this);
				}
				return _timeBetweenIntroAndDescritpionCheck;
			}
			set
			{
				if (_timeBetweenIntroAndDescritpionCheck == value)
				{
					return;
				}
				_timeBetweenIntroAndDescritpionCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("introDescriptionAnimProxy")] 
		public CHandle<inkanimProxy> IntroDescriptionAnimProxy
		{
			get
			{
				if (_introDescriptionAnimProxy == null)
				{
					_introDescriptionAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "introDescriptionAnimProxy", cr2w, this);
				}
				return _introDescriptionAnimProxy;
			}
			set
			{
				if (_introDescriptionAnimProxy == value)
				{
					return;
				}
				_introDescriptionAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("middleDots")] 
		public inkWidgetReference MiddleDots
		{
			get
			{
				if (_middleDots == null)
				{
					_middleDots = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "middleDots", cr2w, this);
				}
				return _middleDots;
			}
			set
			{
				if (_middleDots == value)
				{
					return;
				}
				_middleDots = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("memoryWidget")] 
		public inkWidgetReference MemoryWidget
		{
			get
			{
				if (_memoryWidget == null)
				{
					_memoryWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "memoryWidget", cr2w, this);
				}
				return _memoryWidget;
			}
			set
			{
				if (_memoryWidget == value)
				{
					return;
				}
				_memoryWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("avaliableMemory")] 
		public inkTextWidgetReference AvaliableMemory
		{
			get
			{
				if (_avaliableMemory == null)
				{
					_avaliableMemory = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "avaliableMemory", cr2w, this);
				}
				return _avaliableMemory;
			}
			set
			{
				if (_avaliableMemory == value)
				{
					return;
				}
				_avaliableMemory = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("listWidget")] 
		public inkWidgetReference ListWidget
		{
			get
			{
				if (_listWidget == null)
				{
					_listWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "listWidget", cr2w, this);
				}
				return _listWidget;
			}
			set
			{
				if (_listWidget == value)
				{
					return;
				}
				_listWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("executeBtn")] 
		public inkWidgetReference ExecuteBtn
		{
			get
			{
				if (_executeBtn == null)
				{
					_executeBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "executeBtn", cr2w, this);
				}
				return _executeBtn;
			}
			set
			{
				if (_executeBtn == value)
				{
					return;
				}
				_executeBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("executeAndCloseBtn")] 
		public inkWidgetReference ExecuteAndCloseBtn
		{
			get
			{
				if (_executeAndCloseBtn == null)
				{
					_executeAndCloseBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "executeAndCloseBtn", cr2w, this);
				}
				return _executeAndCloseBtn;
			}
			set
			{
				if (_executeAndCloseBtn == value)
				{
					return;
				}
				_executeAndCloseBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("rightPanel")] 
		public inkWidgetReference RightPanel
		{
			get
			{
				if (_rightPanel == null)
				{
					_rightPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rightPanel", cr2w, this);
				}
				return _rightPanel;
			}
			set
			{
				if (_rightPanel == value)
				{
					return;
				}
				_rightPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("networkBreach")] 
		public inkWidgetReference NetworkBreach
		{
			get
			{
				if (_networkBreach == null)
				{
					_networkBreach = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "networkBreach", cr2w, this);
				}
				return _networkBreach;
			}
			set
			{
				if (_networkBreach == value)
				{
					return;
				}
				_networkBreach = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("costReductionPanel")] 
		public inkWidgetReference CostReductionPanel
		{
			get
			{
				if (_costReductionPanel == null)
				{
					_costReductionPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "costReductionPanel", cr2w, this);
				}
				return _costReductionPanel;
			}
			set
			{
				if (_costReductionPanel == value)
				{
					return;
				}
				_costReductionPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("costReductionValue")] 
		public inkTextWidgetReference CostReductionValue
		{
			get
			{
				if (_costReductionValue == null)
				{
					_costReductionValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "costReductionValue", cr2w, this);
				}
				return _costReductionValue;
			}
			set
			{
				if (_costReductionValue == value)
				{
					return;
				}
				_costReductionValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("targetName")] 
		public inkTextWidgetReference TargetName
		{
			get
			{
				if (_targetName == null)
				{
					_targetName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "targetName", cr2w, this);
				}
				return _targetName;
			}
			set
			{
				if (_targetName == value)
				{
					return;
				}
				_targetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("icePanel")] 
		public inkWidgetReference IcePanel
		{
			get
			{
				if (_icePanel == null)
				{
					_icePanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "icePanel", cr2w, this);
				}
				return _icePanel;
			}
			set
			{
				if (_icePanel == value)
				{
					return;
				}
				_icePanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("iceValue")] 
		public inkTextWidgetReference IceValue
		{
			get
			{
				if (_iceValue == null)
				{
					_iceValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "iceValue", cr2w, this);
				}
				return _iceValue;
			}
			set
			{
				if (_iceValue == value)
				{
					return;
				}
				_iceValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("vulnerabilitiesPanel")] 
		public inkWidgetReference VulnerabilitiesPanel
		{
			get
			{
				if (_vulnerabilitiesPanel == null)
				{
					_vulnerabilitiesPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vulnerabilitiesPanel", cr2w, this);
				}
				return _vulnerabilitiesPanel;
			}
			set
			{
				if (_vulnerabilitiesPanel == value)
				{
					return;
				}
				_vulnerabilitiesPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("vulnerabilityFields")] 
		public CArray<inkWidgetReference> VulnerabilityFields
		{
			get
			{
				if (_vulnerabilityFields == null)
				{
					_vulnerabilityFields = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "vulnerabilityFields", cr2w, this);
				}
				return _vulnerabilityFields;
			}
			set
			{
				if (_vulnerabilityFields == value)
				{
					return;
				}
				_vulnerabilityFields = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("subHeader")] 
		public inkTextWidgetReference SubHeader
		{
			get
			{
				if (_subHeader == null)
				{
					_subHeader = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "subHeader", cr2w, this);
				}
				return _subHeader;
			}
			set
			{
				if (_subHeader == value)
				{
					return;
				}
				_subHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("tier")] 
		public inkTextWidgetReference Tier
		{
			get
			{
				if (_tier == null)
				{
					_tier = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "tier", cr2w, this);
				}
				return _tier;
			}
			set
			{
				if (_tier == value)
				{
					return;
				}
				_tier = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get
			{
				if (_description == null)
				{
					_description = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("recompileTimer")] 
		public inkTextWidgetReference RecompileTimer
		{
			get
			{
				if (_recompileTimer == null)
				{
					_recompileTimer = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "recompileTimer", cr2w, this);
				}
				return _recompileTimer;
			}
			set
			{
				if (_recompileTimer == value)
				{
					return;
				}
				_recompileTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("damage")] 
		public inkTextWidgetReference Damage
		{
			get
			{
				if (_damage == null)
				{
					_damage = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "damage", cr2w, this);
				}
				return _damage;
			}
			set
			{
				if (_damage == value)
				{
					return;
				}
				_damage = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("duration")] 
		public inkTextWidgetReference Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("cooldown")] 
		public inkTextWidgetReference Cooldown
		{
			get
			{
				if (_cooldown == null)
				{
					_cooldown = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "cooldown", cr2w, this);
				}
				return _cooldown;
			}
			set
			{
				if (_cooldown == value)
				{
					return;
				}
				_cooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("uploadTime")] 
		public inkTextWidgetReference UploadTime
		{
			get
			{
				if (_uploadTime == null)
				{
					_uploadTime = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "uploadTime", cr2w, this);
				}
				return _uploadTime;
			}
			set
			{
				if (_uploadTime == value)
				{
					return;
				}
				_uploadTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("memoryCost")] 
		public inkTextWidgetReference MemoryCost
		{
			get
			{
				if (_memoryCost == null)
				{
					_memoryCost = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "memoryCost", cr2w, this);
				}
				return _memoryCost;
			}
			set
			{
				if (_memoryCost == value)
				{
					return;
				}
				_memoryCost = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("memoryRawCost")] 
		public inkTextWidgetReference MemoryRawCost
		{
			get
			{
				if (_memoryRawCost == null)
				{
					_memoryRawCost = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "memoryRawCost", cr2w, this);
				}
				return _memoryRawCost;
			}
			set
			{
				if (_memoryRawCost == value)
				{
					return;
				}
				_memoryRawCost = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("warningWidget")] 
		public inkWidgetReference WarningWidget
		{
			get
			{
				if (_warningWidget == null)
				{
					_warningWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "warningWidget", cr2w, this);
				}
				return _warningWidget;
			}
			set
			{
				if (_warningWidget == value)
				{
					return;
				}
				_warningWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("warningText")] 
		public inkTextWidgetReference WarningText
		{
			get
			{
				if (_warningText == null)
				{
					_warningText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "warningText", cr2w, this);
				}
				return _warningText;
			}
			set
			{
				if (_warningText == value)
				{
					return;
				}
				_warningText = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("recompilePanel")] 
		public inkWidgetReference RecompilePanel
		{
			get
			{
				if (_recompilePanel == null)
				{
					_recompilePanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "recompilePanel", cr2w, this);
				}
				return _recompilePanel;
			}
			set
			{
				if (_recompilePanel == value)
				{
					return;
				}
				_recompilePanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("recompileText")] 
		public inkTextWidgetReference RecompileText
		{
			get
			{
				if (_recompileText == null)
				{
					_recompileText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "recompileText", cr2w, this);
				}
				return _recompileText;
			}
			set
			{
				if (_recompileText == value)
				{
					return;
				}
				_recompileText = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("isUILocked")] 
		public CBool IsUILocked
		{
			get
			{
				if (_isUILocked == null)
				{
					_isUILocked = (CBool) CR2WTypeManager.Create("Bool", "isUILocked", cr2w, this);
				}
				return _isUILocked;
			}
			set
			{
				if (_isUILocked == value)
				{
					return;
				}
				_isUILocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
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

		[Ordinal(44)] 
		[RED("visionModeSystem")] 
		public wCHandle<gameVisionModeSystem> VisionModeSystem
		{
			get
			{
				if (_visionModeSystem == null)
				{
					_visionModeSystem = (wCHandle<gameVisionModeSystem>) CR2WTypeManager.Create("whandle:gameVisionModeSystem", "visionModeSystem", cr2w, this);
				}
				return _visionModeSystem;
			}
			set
			{
				if (_visionModeSystem == value)
				{
					return;
				}
				_visionModeSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("scanningCtrl")] 
		public wCHandle<gameScanningController> ScanningCtrl
		{
			get
			{
				if (_scanningCtrl == null)
				{
					_scanningCtrl = (wCHandle<gameScanningController>) CR2WTypeManager.Create("whandle:gameScanningController", "scanningCtrl", cr2w, this);
				}
				return _scanningCtrl;
			}
			set
			{
				if (_scanningCtrl == value)
				{
					return;
				}
				_scanningCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get
			{
				if (_uiSystem == null)
				{
					_uiSystem = (CHandle<gameuiGameSystemUI>) CR2WTypeManager.Create("handle:gameuiGameSystemUI", "uiSystem", cr2w, this);
				}
				return _uiSystem;
			}
			set
			{
				if (_uiSystem == value)
				{
					return;
				}
				_uiSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("contextHelpOverlay")] 
		public CBool ContextHelpOverlay
		{
			get
			{
				if (_contextHelpOverlay == null)
				{
					_contextHelpOverlay = (CBool) CR2WTypeManager.Create("Bool", "contextHelpOverlay", cr2w, this);
				}
				return _contextHelpOverlay;
			}
			set
			{
				if (_contextHelpOverlay == value)
				{
					return;
				}
				_contextHelpOverlay = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("quickHackDescriptionVisibility")] 
		public CUInt32 QuickHackDescriptionVisibility
		{
			get
			{
				if (_quickHackDescriptionVisibility == null)
				{
					_quickHackDescriptionVisibility = (CUInt32) CR2WTypeManager.Create("Uint32", "quickHackDescriptionVisibility", cr2w, this);
				}
				return _quickHackDescriptionVisibility;
			}
			set
			{
				if (_quickHackDescriptionVisibility == value)
				{
					return;
				}
				_quickHackDescriptionVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("buffListListener")] 
		public CUInt32 BuffListListener
		{
			get
			{
				if (_buffListListener == null)
				{
					_buffListListener = (CUInt32) CR2WTypeManager.Create("Uint32", "buffListListener", cr2w, this);
				}
				return _buffListListener;
			}
			set
			{
				if (_buffListListener == value)
				{
					return;
				}
				_buffListListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("memoryBoard")] 
		public CHandle<gameIBlackboard> MemoryBoard
		{
			get
			{
				if (_memoryBoard == null)
				{
					_memoryBoard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "memoryBoard", cr2w, this);
				}
				return _memoryBoard;
			}
			set
			{
				if (_memoryBoard == value)
				{
					return;
				}
				_memoryBoard = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("memoryBoardDef")] 
		public CHandle<UI_PlayerBioMonitorDef> MemoryBoardDef
		{
			get
			{
				if (_memoryBoardDef == null)
				{
					_memoryBoardDef = (CHandle<UI_PlayerBioMonitorDef>) CR2WTypeManager.Create("handle:UI_PlayerBioMonitorDef", "memoryBoardDef", cr2w, this);
				}
				return _memoryBoardDef;
			}
			set
			{
				if (_memoryBoardDef == value)
				{
					return;
				}
				_memoryBoardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("memoryPercentListener")] 
		public CUInt32 MemoryPercentListener
		{
			get
			{
				if (_memoryPercentListener == null)
				{
					_memoryPercentListener = (CUInt32) CR2WTypeManager.Create("Uint32", "memoryPercentListener", cr2w, this);
				}
				return _memoryPercentListener;
			}
			set
			{
				if (_memoryPercentListener == value)
				{
					return;
				}
				_memoryPercentListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("quickhackBarArray")] 
		public CArray<wCHandle<inkCompoundWidget>> QuickhackBarArray
		{
			get
			{
				if (_quickhackBarArray == null)
				{
					_quickhackBarArray = (CArray<wCHandle<inkCompoundWidget>>) CR2WTypeManager.Create("array:whandle:inkCompoundWidget", "quickhackBarArray", cr2w, this);
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

		[Ordinal(54)] 
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

		[Ordinal(55)] 
		[RED("listController")] 
		public CHandle<inkListController> ListController
		{
			get
			{
				if (_listController == null)
				{
					_listController = (CHandle<inkListController>) CR2WTypeManager.Create("handle:inkListController", "listController", cr2w, this);
				}
				return _listController;
			}
			set
			{
				if (_listController == value)
				{
					return;
				}
				_listController = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("data")] 
		public CArray<CHandle<QuickhackData>> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<CHandle<QuickhackData>>) CR2WTypeManager.Create("array:handle:QuickhackData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("selectedData")] 
		public CHandle<QuickhackData> SelectedData
		{
			get
			{
				if (_selectedData == null)
				{
					_selectedData = (CHandle<QuickhackData>) CR2WTypeManager.Create("handle:QuickhackData", "selectedData", cr2w, this);
				}
				return _selectedData;
			}
			set
			{
				if (_selectedData == value)
				{
					return;
				}
				_selectedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("memorySpendAnimation")] 
		public CHandle<inkanimProxy> MemorySpendAnimation
		{
			get
			{
				if (_memorySpendAnimation == null)
				{
					_memorySpendAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "memorySpendAnimation", cr2w, this);
				}
				return _memorySpendAnimation;
			}
			set
			{
				if (_memorySpendAnimation == value)
				{
					return;
				}
				_memorySpendAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("currentMemoryCellsActive")] 
		public CInt32 CurrentMemoryCellsActive
		{
			get
			{
				if (_currentMemoryCellsActive == null)
				{
					_currentMemoryCellsActive = (CInt32) CR2WTypeManager.Create("Int32", "currentMemoryCellsActive", cr2w, this);
				}
				return _currentMemoryCellsActive;
			}
			set
			{
				if (_currentMemoryCellsActive == value)
				{
					return;
				}
				_currentMemoryCellsActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("desiredMemoryCellsActive")] 
		public CInt32 DesiredMemoryCellsActive
		{
			get
			{
				if (_desiredMemoryCellsActive == null)
				{
					_desiredMemoryCellsActive = (CInt32) CR2WTypeManager.Create("Int32", "desiredMemoryCellsActive", cr2w, this);
				}
				return _desiredMemoryCellsActive;
			}
			set
			{
				if (_desiredMemoryCellsActive == value)
				{
					return;
				}
				_desiredMemoryCellsActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("selectedMemoryLoop")] 
		public CArray<CHandle<inkanimProxy>> SelectedMemoryLoop
		{
			get
			{
				if (_selectedMemoryLoop == null)
				{
					_selectedMemoryLoop = (CArray<CHandle<inkanimProxy>>) CR2WTypeManager.Create("array:handle:inkanimProxy", "selectedMemoryLoop", cr2w, this);
				}
				return _selectedMemoryLoop;
			}
			set
			{
				if (_selectedMemoryLoop == value)
				{
					return;
				}
				_selectedMemoryLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("inkIntroAnimProxy")] 
		public CHandle<inkanimProxy> InkIntroAnimProxy
		{
			get
			{
				if (_inkIntroAnimProxy == null)
				{
					_inkIntroAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "inkIntroAnimProxy", cr2w, this);
				}
				return _inkIntroAnimProxy;
			}
			set
			{
				if (_inkIntroAnimProxy == value)
				{
					return;
				}
				_inkIntroAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("inkVulnerabilityAnimProxy")] 
		public CHandle<inkanimProxy> InkVulnerabilityAnimProxy
		{
			get
			{
				if (_inkVulnerabilityAnimProxy == null)
				{
					_inkVulnerabilityAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "inkVulnerabilityAnimProxy", cr2w, this);
				}
				return _inkVulnerabilityAnimProxy;
			}
			set
			{
				if (_inkVulnerabilityAnimProxy == value)
				{
					return;
				}
				_inkVulnerabilityAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("inkWarningAnimProxy")] 
		public CHandle<inkanimProxy> InkWarningAnimProxy
		{
			get
			{
				if (_inkWarningAnimProxy == null)
				{
					_inkWarningAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "inkWarningAnimProxy", cr2w, this);
				}
				return _inkWarningAnimProxy;
			}
			set
			{
				if (_inkWarningAnimProxy == value)
				{
					return;
				}
				_inkWarningAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("inkRecompileAnimProxy")] 
		public CHandle<inkanimProxy> InkRecompileAnimProxy
		{
			get
			{
				if (_inkRecompileAnimProxy == null)
				{
					_inkRecompileAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "inkRecompileAnimProxy", cr2w, this);
				}
				return _inkRecompileAnimProxy;
			}
			set
			{
				if (_inkRecompileAnimProxy == value)
				{
					return;
				}
				_inkRecompileAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("inkReductionAnimProxy")] 
		public CHandle<inkanimProxy> InkReductionAnimProxy
		{
			get
			{
				if (_inkReductionAnimProxy == null)
				{
					_inkReductionAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "inkReductionAnimProxy", cr2w, this);
				}
				return _inkReductionAnimProxy;
			}
			set
			{
				if (_inkReductionAnimProxy == value)
				{
					return;
				}
				_inkReductionAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("HACK_wasPlayedOnTarget")] 
		public CBool HACK_wasPlayedOnTarget
		{
			get
			{
				if (_hACK_wasPlayedOnTarget == null)
				{
					_hACK_wasPlayedOnTarget = (CBool) CR2WTypeManager.Create("Bool", "HACK_wasPlayedOnTarget", cr2w, this);
				}
				return _hACK_wasPlayedOnTarget;
			}
			set
			{
				if (_hACK_wasPlayedOnTarget == value)
				{
					return;
				}
				_hACK_wasPlayedOnTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("inkMemoryWarningTransitionAnimProxy")] 
		public CHandle<inkanimProxy> InkMemoryWarningTransitionAnimProxy
		{
			get
			{
				if (_inkMemoryWarningTransitionAnimProxy == null)
				{
					_inkMemoryWarningTransitionAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "inkMemoryWarningTransitionAnimProxy", cr2w, this);
				}
				return _inkMemoryWarningTransitionAnimProxy;
			}
			set
			{
				if (_inkMemoryWarningTransitionAnimProxy == value)
				{
					return;
				}
				_inkMemoryWarningTransitionAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("lastMemoryWarningTransitionAnimName")] 
		public CName LastMemoryWarningTransitionAnimName
		{
			get
			{
				if (_lastMemoryWarningTransitionAnimName == null)
				{
					_lastMemoryWarningTransitionAnimName = (CName) CR2WTypeManager.Create("CName", "lastMemoryWarningTransitionAnimName", cr2w, this);
				}
				return _lastMemoryWarningTransitionAnimName;
			}
			set
			{
				if (_lastMemoryWarningTransitionAnimName == value)
				{
					return;
				}
				_lastMemoryWarningTransitionAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("hasActiveUpload")] 
		public CBool HasActiveUpload
		{
			get
			{
				if (_hasActiveUpload == null)
				{
					_hasActiveUpload = (CBool) CR2WTypeManager.Create("Bool", "hasActiveUpload", cr2w, this);
				}
				return _hasActiveUpload;
			}
			set
			{
				if (_hasActiveUpload == value)
				{
					return;
				}
				_hasActiveUpload = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("lastCompiledTarget")] 
		public entEntityID LastCompiledTarget
		{
			get
			{
				if (_lastCompiledTarget == null)
				{
					_lastCompiledTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "lastCompiledTarget", cr2w, this);
				}
				return _lastCompiledTarget;
			}
			set
			{
				if (_lastCompiledTarget == value)
				{
					return;
				}
				_lastCompiledTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("statPoolListenersIndexes")] 
		public CArray<CInt32> StatPoolListenersIndexes
		{
			get
			{
				if (_statPoolListenersIndexes == null)
				{
					_statPoolListenersIndexes = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "statPoolListenersIndexes", cr2w, this);
				}
				return _statPoolListenersIndexes;
			}
			set
			{
				if (_statPoolListenersIndexes == value)
				{
					return;
				}
				_statPoolListenersIndexes = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("chunkBlackboard")] 
		public CHandle<gameIBlackboard> ChunkBlackboard
		{
			get
			{
				if (_chunkBlackboard == null)
				{
					_chunkBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "chunkBlackboard", cr2w, this);
				}
				return _chunkBlackboard;
			}
			set
			{
				if (_chunkBlackboard == value)
				{
					return;
				}
				_chunkBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("nameCallbackID")] 
		public CUInt32 NameCallbackID
		{
			get
			{
				if (_nameCallbackID == null)
				{
					_nameCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "nameCallbackID", cr2w, this);
				}
				return _nameCallbackID;
			}
			set
			{
				if (_nameCallbackID == value)
				{
					return;
				}
				_nameCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("axisInputConsumed")] 
		public CBool AxisInputConsumed
		{
			get
			{
				if (_axisInputConsumed == null)
				{
					_axisInputConsumed = (CBool) CR2WTypeManager.Create("Bool", "axisInputConsumed", cr2w, this);
				}
				return _axisInputConsumed;
			}
			set
			{
				if (_axisInputConsumed == value)
				{
					return;
				}
				_axisInputConsumed = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
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

		public QuickhacksListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

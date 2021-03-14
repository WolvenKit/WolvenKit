using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimeMenuGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _selectTimeText;
		private inkWidgetReference _selectorRef;
		private inkTextWidgetReference _currentTime;
		private inkWidgetReference _applyBtn;
		private inkWidgetReference _backBtn;
		private inkTextWidgetReference _combatWarning;
		private CHandle<TimeSkipPopupData> _data;
		private ScriptGameInstance _gameInstance;
		private CBool _inputEnabled;
		private CBool _timeChanged;
		private wCHandle<inkSelectorController> _selectorCtrl;
		private CHandle<gameTimeSystem> _timeSystem;
		private CInt32 _hoursToSkip;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<textTextParameterSet> _currentTimeTextParams;
		private CHandle<inkanimProxy> _animProxy;
		private CUInt32 _playerSpawnedCallbackID;

		[Ordinal(2)] 
		[RED("selectTimeText")] 
		public inkWidgetReference SelectTimeText
		{
			get
			{
				if (_selectTimeText == null)
				{
					_selectTimeText = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectTimeText", cr2w, this);
				}
				return _selectTimeText;
			}
			set
			{
				if (_selectTimeText == value)
				{
					return;
				}
				_selectTimeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("selectorRef")] 
		public inkWidgetReference SelectorRef
		{
			get
			{
				if (_selectorRef == null)
				{
					_selectorRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectorRef", cr2w, this);
				}
				return _selectorRef;
			}
			set
			{
				if (_selectorRef == value)
				{
					return;
				}
				_selectorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentTime")] 
		public inkTextWidgetReference CurrentTime
		{
			get
			{
				if (_currentTime == null)
				{
					_currentTime = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "currentTime", cr2w, this);
				}
				return _currentTime;
			}
			set
			{
				if (_currentTime == value)
				{
					return;
				}
				_currentTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("applyBtn")] 
		public inkWidgetReference ApplyBtn
		{
			get
			{
				if (_applyBtn == null)
				{
					_applyBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "applyBtn", cr2w, this);
				}
				return _applyBtn;
			}
			set
			{
				if (_applyBtn == value)
				{
					return;
				}
				_applyBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("backBtn")] 
		public inkWidgetReference BackBtn
		{
			get
			{
				if (_backBtn == null)
				{
					_backBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "backBtn", cr2w, this);
				}
				return _backBtn;
			}
			set
			{
				if (_backBtn == value)
				{
					return;
				}
				_backBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("combatWarning")] 
		public inkTextWidgetReference CombatWarning
		{
			get
			{
				if (_combatWarning == null)
				{
					_combatWarning = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "combatWarning", cr2w, this);
				}
				return _combatWarning;
			}
			set
			{
				if (_combatWarning == value)
				{
					return;
				}
				_combatWarning = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("data")] 
		public CHandle<TimeSkipPopupData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<TimeSkipPopupData>) CR2WTypeManager.Create("handle:TimeSkipPopupData", "data", cr2w, this);
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("inputEnabled")] 
		public CBool InputEnabled
		{
			get
			{
				if (_inputEnabled == null)
				{
					_inputEnabled = (CBool) CR2WTypeManager.Create("Bool", "inputEnabled", cr2w, this);
				}
				return _inputEnabled;
			}
			set
			{
				if (_inputEnabled == value)
				{
					return;
				}
				_inputEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("timeChanged")] 
		public CBool TimeChanged
		{
			get
			{
				if (_timeChanged == null)
				{
					_timeChanged = (CBool) CR2WTypeManager.Create("Bool", "timeChanged", cr2w, this);
				}
				return _timeChanged;
			}
			set
			{
				if (_timeChanged == value)
				{
					return;
				}
				_timeChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("selectorCtrl")] 
		public wCHandle<inkSelectorController> SelectorCtrl
		{
			get
			{
				if (_selectorCtrl == null)
				{
					_selectorCtrl = (wCHandle<inkSelectorController>) CR2WTypeManager.Create("whandle:inkSelectorController", "selectorCtrl", cr2w, this);
				}
				return _selectorCtrl;
			}
			set
			{
				if (_selectorCtrl == value)
				{
					return;
				}
				_selectorCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("timeSystem")] 
		public CHandle<gameTimeSystem> TimeSystem
		{
			get
			{
				if (_timeSystem == null)
				{
					_timeSystem = (CHandle<gameTimeSystem>) CR2WTypeManager.Create("handle:gameTimeSystem", "timeSystem", cr2w, this);
				}
				return _timeSystem;
			}
			set
			{
				if (_timeSystem == value)
				{
					return;
				}
				_timeSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("hoursToSkip")] 
		public CInt32 HoursToSkip
		{
			get
			{
				if (_hoursToSkip == null)
				{
					_hoursToSkip = (CInt32) CR2WTypeManager.Create("Int32", "hoursToSkip", cr2w, this);
				}
				return _hoursToSkip;
			}
			set
			{
				if (_hoursToSkip == value)
				{
					return;
				}
				_hoursToSkip = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("currentTimeTextParams")] 
		public CHandle<textTextParameterSet> CurrentTimeTextParams
		{
			get
			{
				if (_currentTimeTextParams == null)
				{
					_currentTimeTextParams = (CHandle<textTextParameterSet>) CR2WTypeManager.Create("handle:textTextParameterSet", "currentTimeTextParams", cr2w, this);
				}
				return _currentTimeTextParams;
			}
			set
			{
				if (_currentTimeTextParams == value)
				{
					return;
				}
				_currentTimeTextParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("playerSpawnedCallbackID")] 
		public CUInt32 PlayerSpawnedCallbackID
		{
			get
			{
				if (_playerSpawnedCallbackID == null)
				{
					_playerSpawnedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerSpawnedCallbackID", cr2w, this);
				}
				return _playerSpawnedCallbackID;
			}
			set
			{
				if (_playerSpawnedCallbackID == value)
				{
					return;
				}
				_playerSpawnedCallbackID = value;
				PropertySet(this);
			}
		}

		public TimeMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

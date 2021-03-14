using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsMainGameController : gameuiMenuGameController
	{
		private inkWidgetReference _scrollPanel;
		private inkWidgetReference _selectorWidget;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkCompoundWidgetReference _settingsOptionsList;
		private inkWidgetReference _applyButton;
		private inkWidgetReference _resetButton;
		private inkWidgetReference _defaultButton;
		private inkWidgetReference _brightnessButton;
		private inkWidgetReference _hdrButton;
		private inkWidgetReference _controllerButton;
		private inkTextWidgetReference _descriptionText;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CArray<wCHandle<inkSettingsSelectorController>> _settingsElements;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CArray<SettingsCategory> _data;
		private CArray<CName> _menusList;
		private CArray<CName> _eventsList;
		private CHandle<SettingsVarListener> _settingsListener;
		private CHandle<SettingsNotificationListener> _settingsNotificationListener;
		private CHandle<userSettingsUserSettings> _settings;
		private CBool _isPreGame;
		private CBool _applyButtonEnabled;
		private CBool _resetButtonEnabled;
		private CBool _closeSettingsRequest;
		private wCHandle<inkListController> _selectorCtrl;

		[Ordinal(3)] 
		[RED("scrollPanel")] 
		public inkWidgetReference ScrollPanel
		{
			get
			{
				if (_scrollPanel == null)
				{
					_scrollPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "scrollPanel", cr2w, this);
				}
				return _scrollPanel;
			}
			set
			{
				if (_scrollPanel == value)
				{
					return;
				}
				_scrollPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("selectorWidget")] 
		public inkWidgetReference SelectorWidget
		{
			get
			{
				if (_selectorWidget == null)
				{
					_selectorWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectorWidget", cr2w, this);
				}
				return _selectorWidget;
			}
			set
			{
				if (_selectorWidget == value)
				{
					return;
				}
				_selectorWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("settingsOptionsList")] 
		public inkCompoundWidgetReference SettingsOptionsList
		{
			get
			{
				if (_settingsOptionsList == null)
				{
					_settingsOptionsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "settingsOptionsList", cr2w, this);
				}
				return _settingsOptionsList;
			}
			set
			{
				if (_settingsOptionsList == value)
				{
					return;
				}
				_settingsOptionsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("applyButton")] 
		public inkWidgetReference ApplyButton
		{
			get
			{
				if (_applyButton == null)
				{
					_applyButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "applyButton", cr2w, this);
				}
				return _applyButton;
			}
			set
			{
				if (_applyButton == value)
				{
					return;
				}
				_applyButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("resetButton")] 
		public inkWidgetReference ResetButton
		{
			get
			{
				if (_resetButton == null)
				{
					_resetButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "resetButton", cr2w, this);
				}
				return _resetButton;
			}
			set
			{
				if (_resetButton == value)
				{
					return;
				}
				_resetButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("defaultButton")] 
		public inkWidgetReference DefaultButton
		{
			get
			{
				if (_defaultButton == null)
				{
					_defaultButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "defaultButton", cr2w, this);
				}
				return _defaultButton;
			}
			set
			{
				if (_defaultButton == value)
				{
					return;
				}
				_defaultButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("brightnessButton")] 
		public inkWidgetReference BrightnessButton
		{
			get
			{
				if (_brightnessButton == null)
				{
					_brightnessButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "brightnessButton", cr2w, this);
				}
				return _brightnessButton;
			}
			set
			{
				if (_brightnessButton == value)
				{
					return;
				}
				_brightnessButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("hdrButton")] 
		public inkWidgetReference HdrButton
		{
			get
			{
				if (_hdrButton == null)
				{
					_hdrButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hdrButton", cr2w, this);
				}
				return _hdrButton;
			}
			set
			{
				if (_hdrButton == value)
				{
					return;
				}
				_hdrButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("controllerButton")] 
		public inkWidgetReference ControllerButton
		{
			get
			{
				if (_controllerButton == null)
				{
					_controllerButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "controllerButton", cr2w, this);
				}
				return _controllerButton;
			}
			set
			{
				if (_controllerButton == value)
				{
					return;
				}
				_controllerButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get
			{
				if (_descriptionText == null)
				{
					_descriptionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "descriptionText", cr2w, this);
				}
				return _descriptionText;
			}
			set
			{
				if (_descriptionText == value)
				{
					return;
				}
				_descriptionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("settingsElements")] 
		public CArray<wCHandle<inkSettingsSelectorController>> SettingsElements
		{
			get
			{
				if (_settingsElements == null)
				{
					_settingsElements = (CArray<wCHandle<inkSettingsSelectorController>>) CR2WTypeManager.Create("array:whandle:inkSettingsSelectorController", "settingsElements", cr2w, this);
				}
				return _settingsElements;
			}
			set
			{
				if (_settingsElements == value)
				{
					return;
				}
				_settingsElements = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("data")] 
		public CArray<SettingsCategory> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<SettingsCategory>) CR2WTypeManager.Create("array:SettingsCategory", "data", cr2w, this);
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

		[Ordinal(18)] 
		[RED("menusList")] 
		public CArray<CName> MenusList
		{
			get
			{
				if (_menusList == null)
				{
					_menusList = (CArray<CName>) CR2WTypeManager.Create("array:CName", "menusList", cr2w, this);
				}
				return _menusList;
			}
			set
			{
				if (_menusList == value)
				{
					return;
				}
				_menusList = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("eventsList")] 
		public CArray<CName> EventsList
		{
			get
			{
				if (_eventsList == null)
				{
					_eventsList = (CArray<CName>) CR2WTypeManager.Create("array:CName", "eventsList", cr2w, this);
				}
				return _eventsList;
			}
			set
			{
				if (_eventsList == value)
				{
					return;
				}
				_eventsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("settingsListener")] 
		public CHandle<SettingsVarListener> SettingsListener
		{
			get
			{
				if (_settingsListener == null)
				{
					_settingsListener = (CHandle<SettingsVarListener>) CR2WTypeManager.Create("handle:SettingsVarListener", "settingsListener", cr2w, this);
				}
				return _settingsListener;
			}
			set
			{
				if (_settingsListener == value)
				{
					return;
				}
				_settingsListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("settingsNotificationListener")] 
		public CHandle<SettingsNotificationListener> SettingsNotificationListener
		{
			get
			{
				if (_settingsNotificationListener == null)
				{
					_settingsNotificationListener = (CHandle<SettingsNotificationListener>) CR2WTypeManager.Create("handle:SettingsNotificationListener", "settingsNotificationListener", cr2w, this);
				}
				return _settingsNotificationListener;
			}
			set
			{
				if (_settingsNotificationListener == value)
				{
					return;
				}
				_settingsNotificationListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get
			{
				if (_settings == null)
				{
					_settings = (CHandle<userSettingsUserSettings>) CR2WTypeManager.Create("handle:userSettingsUserSettings", "settings", cr2w, this);
				}
				return _settings;
			}
			set
			{
				if (_settings == value)
				{
					return;
				}
				_settings = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isPreGame")] 
		public CBool IsPreGame
		{
			get
			{
				if (_isPreGame == null)
				{
					_isPreGame = (CBool) CR2WTypeManager.Create("Bool", "isPreGame", cr2w, this);
				}
				return _isPreGame;
			}
			set
			{
				if (_isPreGame == value)
				{
					return;
				}
				_isPreGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("applyButtonEnabled")] 
		public CBool ApplyButtonEnabled
		{
			get
			{
				if (_applyButtonEnabled == null)
				{
					_applyButtonEnabled = (CBool) CR2WTypeManager.Create("Bool", "applyButtonEnabled", cr2w, this);
				}
				return _applyButtonEnabled;
			}
			set
			{
				if (_applyButtonEnabled == value)
				{
					return;
				}
				_applyButtonEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("resetButtonEnabled")] 
		public CBool ResetButtonEnabled
		{
			get
			{
				if (_resetButtonEnabled == null)
				{
					_resetButtonEnabled = (CBool) CR2WTypeManager.Create("Bool", "resetButtonEnabled", cr2w, this);
				}
				return _resetButtonEnabled;
			}
			set
			{
				if (_resetButtonEnabled == value)
				{
					return;
				}
				_resetButtonEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("closeSettingsRequest")] 
		public CBool CloseSettingsRequest
		{
			get
			{
				if (_closeSettingsRequest == null)
				{
					_closeSettingsRequest = (CBool) CR2WTypeManager.Create("Bool", "closeSettingsRequest", cr2w, this);
				}
				return _closeSettingsRequest;
			}
			set
			{
				if (_closeSettingsRequest == value)
				{
					return;
				}
				_closeSettingsRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("selectorCtrl")] 
		public wCHandle<inkListController> SelectorCtrl
		{
			get
			{
				if (_selectorCtrl == null)
				{
					_selectorCtrl = (wCHandle<inkListController>) CR2WTypeManager.Create("whandle:inkListController", "selectorCtrl", cr2w, this);
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

		public SettingsMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BrightnessSettingsGameController : gameuiMenuGameController
	{
		private CName _s_brightnessGroup;
		private inkCompoundWidgetReference _settingsOptionsList;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<BrightnessSettingsVarListener> _settingsListener;
		private CArray<wCHandle<inkSettingsSelectorController>> _settingsElements;
		private CBool _isPreGame;

		[Ordinal(3)] 
		[RED("s_brightnessGroup")] 
		public CName S_brightnessGroup
		{
			get
			{
				if (_s_brightnessGroup == null)
				{
					_s_brightnessGroup = (CName) CR2WTypeManager.Create("CName", "s_brightnessGroup", cr2w, this);
				}
				return _s_brightnessGroup;
			}
			set
			{
				if (_s_brightnessGroup == value)
				{
					return;
				}
				_s_brightnessGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("settingsListener")] 
		public CHandle<BrightnessSettingsVarListener> SettingsListener
		{
			get
			{
				if (_settingsListener == null)
				{
					_settingsListener = (CHandle<BrightnessSettingsVarListener>) CR2WTypeManager.Create("handle:BrightnessSettingsVarListener", "settingsListener", cr2w, this);
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

		[Ordinal(8)] 
		[RED("SettingsElements")] 
		public CArray<wCHandle<inkSettingsSelectorController>> SettingsElements
		{
			get
			{
				if (_settingsElements == null)
				{
					_settingsElements = (CArray<wCHandle<inkSettingsSelectorController>>) CR2WTypeManager.Create("array:whandle:inkSettingsSelectorController", "SettingsElements", cr2w, this);
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

		[Ordinal(9)] 
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

		public BrightnessSettingsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

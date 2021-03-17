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
			get => GetProperty(ref _s_brightnessGroup);
			set => SetProperty(ref _s_brightnessGroup, value);
		}

		[Ordinal(4)] 
		[RED("settingsOptionsList")] 
		public inkCompoundWidgetReference SettingsOptionsList
		{
			get => GetProperty(ref _settingsOptionsList);
			set => SetProperty(ref _settingsOptionsList, value);
		}

		[Ordinal(5)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(6)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(7)] 
		[RED("settingsListener")] 
		public CHandle<BrightnessSettingsVarListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(8)] 
		[RED("SettingsElements")] 
		public CArray<wCHandle<inkSettingsSelectorController>> SettingsElements
		{
			get => GetProperty(ref _settingsElements);
			set => SetProperty(ref _settingsElements, value);
		}

		[Ordinal(9)] 
		[RED("isPreGame")] 
		public CBool IsPreGame
		{
			get => GetProperty(ref _isPreGame);
			set => SetProperty(ref _isPreGame, value);
		}

		public BrightnessSettingsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

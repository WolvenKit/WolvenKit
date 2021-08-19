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
		private inkWidgetReference _previousButtonHint;
		private inkWidgetReference _nextButtonHint;
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
		private CBool _resetSettingsRequest;
		private CBool _isDlcSettings;
		private wCHandle<inkListController> _selectorCtrl;

		[Ordinal(3)] 
		[RED("scrollPanel")] 
		public inkWidgetReference ScrollPanel
		{
			get => GetProperty(ref _scrollPanel);
			set => SetProperty(ref _scrollPanel, value);
		}

		[Ordinal(4)] 
		[RED("selectorWidget")] 
		public inkWidgetReference SelectorWidget
		{
			get => GetProperty(ref _selectorWidget);
			set => SetProperty(ref _selectorWidget, value);
		}

		[Ordinal(5)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(6)] 
		[RED("settingsOptionsList")] 
		public inkCompoundWidgetReference SettingsOptionsList
		{
			get => GetProperty(ref _settingsOptionsList);
			set => SetProperty(ref _settingsOptionsList, value);
		}

		[Ordinal(7)] 
		[RED("applyButton")] 
		public inkWidgetReference ApplyButton
		{
			get => GetProperty(ref _applyButton);
			set => SetProperty(ref _applyButton, value);
		}

		[Ordinal(8)] 
		[RED("resetButton")] 
		public inkWidgetReference ResetButton
		{
			get => GetProperty(ref _resetButton);
			set => SetProperty(ref _resetButton, value);
		}

		[Ordinal(9)] 
		[RED("defaultButton")] 
		public inkWidgetReference DefaultButton
		{
			get => GetProperty(ref _defaultButton);
			set => SetProperty(ref _defaultButton, value);
		}

		[Ordinal(10)] 
		[RED("brightnessButton")] 
		public inkWidgetReference BrightnessButton
		{
			get => GetProperty(ref _brightnessButton);
			set => SetProperty(ref _brightnessButton, value);
		}

		[Ordinal(11)] 
		[RED("hdrButton")] 
		public inkWidgetReference HdrButton
		{
			get => GetProperty(ref _hdrButton);
			set => SetProperty(ref _hdrButton, value);
		}

		[Ordinal(12)] 
		[RED("controllerButton")] 
		public inkWidgetReference ControllerButton
		{
			get => GetProperty(ref _controllerButton);
			set => SetProperty(ref _controllerButton, value);
		}

		[Ordinal(13)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(14)] 
		[RED("previousButtonHint")] 
		public inkWidgetReference PreviousButtonHint
		{
			get => GetProperty(ref _previousButtonHint);
			set => SetProperty(ref _previousButtonHint, value);
		}

		[Ordinal(15)] 
		[RED("nextButtonHint")] 
		public inkWidgetReference NextButtonHint
		{
			get => GetProperty(ref _nextButtonHint);
			set => SetProperty(ref _nextButtonHint, value);
		}

		[Ordinal(16)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(17)] 
		[RED("settingsElements")] 
		public CArray<wCHandle<inkSettingsSelectorController>> SettingsElements
		{
			get => GetProperty(ref _settingsElements);
			set => SetProperty(ref _settingsElements, value);
		}

		[Ordinal(18)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(19)] 
		[RED("data")] 
		public CArray<SettingsCategory> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(20)] 
		[RED("menusList")] 
		public CArray<CName> MenusList
		{
			get => GetProperty(ref _menusList);
			set => SetProperty(ref _menusList, value);
		}

		[Ordinal(21)] 
		[RED("eventsList")] 
		public CArray<CName> EventsList
		{
			get => GetProperty(ref _eventsList);
			set => SetProperty(ref _eventsList, value);
		}

		[Ordinal(22)] 
		[RED("settingsListener")] 
		public CHandle<SettingsVarListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(23)] 
		[RED("settingsNotificationListener")] 
		public CHandle<SettingsNotificationListener> SettingsNotificationListener
		{
			get => GetProperty(ref _settingsNotificationListener);
			set => SetProperty(ref _settingsNotificationListener, value);
		}

		[Ordinal(24)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(25)] 
		[RED("isPreGame")] 
		public CBool IsPreGame
		{
			get => GetProperty(ref _isPreGame);
			set => SetProperty(ref _isPreGame, value);
		}

		[Ordinal(26)] 
		[RED("applyButtonEnabled")] 
		public CBool ApplyButtonEnabled
		{
			get => GetProperty(ref _applyButtonEnabled);
			set => SetProperty(ref _applyButtonEnabled, value);
		}

		[Ordinal(27)] 
		[RED("resetButtonEnabled")] 
		public CBool ResetButtonEnabled
		{
			get => GetProperty(ref _resetButtonEnabled);
			set => SetProperty(ref _resetButtonEnabled, value);
		}

		[Ordinal(28)] 
		[RED("closeSettingsRequest")] 
		public CBool CloseSettingsRequest
		{
			get => GetProperty(ref _closeSettingsRequest);
			set => SetProperty(ref _closeSettingsRequest, value);
		}

		[Ordinal(29)] 
		[RED("resetSettingsRequest")] 
		public CBool ResetSettingsRequest
		{
			get => GetProperty(ref _resetSettingsRequest);
			set => SetProperty(ref _resetSettingsRequest, value);
		}

		[Ordinal(30)] 
		[RED("isDlcSettings")] 
		public CBool IsDlcSettings
		{
			get => GetProperty(ref _isDlcSettings);
			set => SetProperty(ref _isDlcSettings, value);
		}

		[Ordinal(31)] 
		[RED("selectorCtrl")] 
		public wCHandle<inkListController> SelectorCtrl
		{
			get => GetProperty(ref _selectorCtrl);
			set => SetProperty(ref _selectorCtrl, value);
		}

		public SettingsMainGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

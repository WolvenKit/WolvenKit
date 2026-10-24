using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsMainGameController : gameuiSettingsMenuGameController
	{
		[Ordinal(3)] 
		[RED("scrollPanel")] 
		public inkWidgetReference ScrollPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("groupsSelectorWidget")] 
		public inkWidgetReference GroupsSelectorWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("settingsOptionsList")] 
		public inkCompoundWidgetReference SettingsOptionsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("applyButton")] 
		public inkWidgetReference ApplyButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("resetButton")] 
		public inkWidgetReference ResetButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("defaultButton")] 
		public inkWidgetReference DefaultButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("benchmarkButton")] 
		public inkWidgetReference BenchmarkButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("brightnessButton")] 
		public inkWidgetReference BrightnessButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("hdrButton")] 
		public inkWidgetReference HdrButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("controllerButton")] 
		public inkWidgetReference ControllerButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("safezonesButton")] 
		public inkWidgetReference SafezonesButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("replayTutorialButton")] 
		public inkWidgetReference ReplayTutorialButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("languageInstallProgressBarRoot")] 
		public inkWidgetReference LanguageInstallProgressBarRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("languageDisclaimer")] 
		public inkWidgetReference LanguageDisclaimer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("settingGroupName_Video")] 
		public CName SettingGroupName_Video
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("settingGroupName_Graphics")] 
		public CName SettingGroupName_Graphics
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("settingGroupName_Interface")] 
		public CName SettingGroupName_Interface
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("settingGroupName_Controls")] 
		public CName SettingGroupName_Controls
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("settingGroupName_Language")] 
		public CName SettingGroupName_Language
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("settingGroupName_KeyBindings")] 
		public CName SettingGroupName_KeyBindings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("controlsStyleContainer")] 
		public inkWidgetReference ControlsStyleContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("controlsStyleWidget")] 
		public inkWidgetReference ControlsStyleWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("descriptionWarningRichColor")] 
		public CString DescriptionWarningRichColor
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(28)] 
		[RED("globalPreloaderContainer")] 
		public inkWidgetReference GlobalPreloaderContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("languageInstallProgressBar")] 
		public CWeakHandle<SettingsLanguageInstallProgressBar> LanguageInstallProgressBar
		{
			get => GetPropertyValue<CWeakHandle<SettingsLanguageInstallProgressBar>>();
			set => SetPropertyValue<CWeakHandle<SettingsLanguageInstallProgressBar>>(value);
		}

		[Ordinal(30)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(31)] 
		[RED("settingsElements")] 
		public CArray<CWeakHandle<inkSettingsSelectorController>> SettingsElements
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkSettingsSelectorController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkSettingsSelectorController>>>(value);
		}

		[Ordinal(32)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(33)] 
		[RED("data")] 
		public CArray<SettingsCategory> Data
		{
			get => GetPropertyValue<CArray<SettingsCategory>>();
			set => SetPropertyValue<CArray<SettingsCategory>>(value);
		}

		[Ordinal(34)] 
		[RED("menusList")] 
		public CArray<CName> MenusList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(35)] 
		[RED("settingsListener")] 
		public CHandle<SettingsVarListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<SettingsVarListener>>();
			set => SetPropertyValue<CHandle<SettingsVarListener>>(value);
		}

		[Ordinal(36)] 
		[RED("settingsNotificationListener")] 
		public CHandle<SettingsNotificationListener> SettingsNotificationListener
		{
			get => GetPropertyValue<CHandle<SettingsNotificationListener>>();
			set => SetPropertyValue<CHandle<SettingsNotificationListener>>(value);
		}

		[Ordinal(37)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(38)] 
		[RED("isPreGame")] 
		public CBool IsPreGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("benchmarkNotificationToken")] 
		public CHandle<inkGameNotificationToken> BenchmarkNotificationToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(40)] 
		[RED("safezonesEditorToken")] 
		public CHandle<inkGameNotificationToken> SafezonesEditorToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(41)] 
		[RED("onInputStyleChangedCallbackID")] 
		public CHandle<redCallbackObject> OnInputStyleChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("applyButtonEnabled")] 
		public CBool ApplyButtonEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("resetButtonEnabled")] 
		public CBool ResetButtonEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("closeSettingsRequest")] 
		public CBool CloseSettingsRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("resetSettingsRequest")] 
		public CBool ResetSettingsRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("isDlcSettings")] 
		public CBool IsDlcSettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("isBenchmarkSettings")] 
		public CBool IsBenchmarkSettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("showHdrButton")] 
		public CBool ShowHdrButton
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("showBrightnessButton")] 
		public CBool ShowBrightnessButton
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("useRightAligned")] 
		public CBool UseRightAligned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("currentHDRindex")] 
		public CInt32 CurrentHDRindex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(52)] 
		[RED("groupsSelectorCtrl")] 
		public CWeakHandle<inkListController> GroupsSelectorCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(53)] 
		[RED("showControlsStyle")] 
		public CBool ShowControlsStyle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("controlsStyleCtrl")] 
		public CWeakHandle<inkListController> ControlsStyleCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(55)] 
		[RED("controlsStyleConfigVar")] 
		public CHandle<userSettingsVarListString> ControlsStyleConfigVar
		{
			get => GetPropertyValue<CHandle<userSettingsVarListString>>();
			set => SetPropertyValue<CHandle<userSettingsVarListString>>(value);
		}

		[Ordinal(56)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(57)] 
		[RED("globalPreloader")] 
		public CWeakHandle<inkWidget> GlobalPreloader
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(58)] 
		[RED("interactionsBlocked")] 
		public CBool InteractionsBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("telemetryUpdatePopupToken")] 
		public CHandle<inkGameNotificationToken> TelemetryUpdatePopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(60)] 
		[RED("delayPopupProxy")] 
		public CHandle<inkanimProxy> DelayPopupProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(61)] 
		[RED("preventNextTelemetryLog")] 
		public CBool PreventNextTelemetryLog
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("currentSelectLanguage")] 
		public CName CurrentSelectLanguage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SettingsMainGameController()
		{
			ScrollPanel = new inkWidgetReference();
			GroupsSelectorWidget = new inkWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			SettingsOptionsList = new inkCompoundWidgetReference();
			ApplyButton = new inkWidgetReference();
			ResetButton = new inkWidgetReference();
			DefaultButton = new inkWidgetReference();
			BenchmarkButton = new inkWidgetReference();
			BrightnessButton = new inkWidgetReference();
			HdrButton = new inkWidgetReference();
			ControllerButton = new inkWidgetReference();
			SafezonesButton = new inkWidgetReference();
			ReplayTutorialButton = new inkWidgetReference();
			LanguageInstallProgressBarRoot = new inkWidgetReference();
			LanguageDisclaimer = new inkWidgetReference();
			DescriptionText = new inkTextWidgetReference();
			SettingGroupName_Video = "/video";
			SettingGroupName_Graphics = "/graphics";
			SettingGroupName_Interface = "/interface";
			SettingGroupName_Controls = "/controls";
			SettingGroupName_Language = "/language";
			SettingGroupName_KeyBindings = "/key_bindings";
			ControlsStyleContainer = new inkWidgetReference();
			ControlsStyleWidget = new inkWidgetReference();
			GlobalPreloaderContainer = new inkWidgetReference();
			SettingsElements = new();
			Data = new();
			MenusList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

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
		[RED("selectorWidget")] 
		public inkWidgetReference SelectorWidget
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
		[RED("brightnessButton")] 
		public inkWidgetReference BrightnessButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("hdrButton")] 
		public inkWidgetReference HdrButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("controllerButton")] 
		public inkWidgetReference ControllerButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("benchmarkButton")] 
		public inkWidgetReference BenchmarkButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("previousButtonHint")] 
		public inkWidgetReference PreviousButtonHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("nextButtonHint")] 
		public inkWidgetReference NextButtonHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("languageInstallProgressBarRoot")] 
		public inkWidgetReference LanguageInstallProgressBarRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("languageInstallProgressBar")] 
		public CWeakHandle<SettingsLanguageInstallProgressBar> LanguageInstallProgressBar
		{
			get => GetPropertyValue<CWeakHandle<SettingsLanguageInstallProgressBar>>();
			set => SetPropertyValue<CWeakHandle<SettingsLanguageInstallProgressBar>>(value);
		}

		[Ordinal(19)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(20)] 
		[RED("settingsElements")] 
		public CArray<CWeakHandle<inkSettingsSelectorController>> SettingsElements
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkSettingsSelectorController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkSettingsSelectorController>>>(value);
		}

		[Ordinal(21)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(22)] 
		[RED("data")] 
		public CArray<SettingsCategory> Data
		{
			get => GetPropertyValue<CArray<SettingsCategory>>();
			set => SetPropertyValue<CArray<SettingsCategory>>(value);
		}

		[Ordinal(23)] 
		[RED("menusList")] 
		public CArray<CName> MenusList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(24)] 
		[RED("eventsList")] 
		public CArray<CName> EventsList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(25)] 
		[RED("settingsListener")] 
		public CHandle<SettingsVarListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<SettingsVarListener>>();
			set => SetPropertyValue<CHandle<SettingsVarListener>>(value);
		}

		[Ordinal(26)] 
		[RED("settingsNotificationListener")] 
		public CHandle<SettingsNotificationListener> SettingsNotificationListener
		{
			get => GetPropertyValue<CHandle<SettingsNotificationListener>>();
			set => SetPropertyValue<CHandle<SettingsNotificationListener>>(value);
		}

		[Ordinal(27)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(28)] 
		[RED("isPreGame")] 
		public CBool IsPreGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("benchmarkNotificationToken")] 
		public CHandle<inkGameNotificationToken> BenchmarkNotificationToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(30)] 
		[RED("isKeybindingAlertEnabled")] 
		public CBool IsKeybindingAlertEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("applyButtonEnabled")] 
		public CBool ApplyButtonEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("resetButtonEnabled")] 
		public CBool ResetButtonEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("closeSettingsRequest")] 
		public CBool CloseSettingsRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("resetSettingsRequest")] 
		public CBool ResetSettingsRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("isDlcSettings")] 
		public CBool IsDlcSettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("isBenchmarkSettings")] 
		public CBool IsBenchmarkSettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("selectorCtrl")] 
		public CWeakHandle<inkListController> SelectorCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(38)] 
		[RED("languageMenuIndex")] 
		public CInt32 LanguageMenuIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SettingsMainGameController()
		{
			ScrollPanel = new inkWidgetReference();
			SelectorWidget = new inkWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			SettingsOptionsList = new inkCompoundWidgetReference();
			ApplyButton = new inkWidgetReference();
			ResetButton = new inkWidgetReference();
			DefaultButton = new inkWidgetReference();
			BrightnessButton = new inkWidgetReference();
			HdrButton = new inkWidgetReference();
			ControllerButton = new inkWidgetReference();
			BenchmarkButton = new inkWidgetReference();
			DescriptionText = new inkTextWidgetReference();
			PreviousButtonHint = new inkWidgetReference();
			NextButtonHint = new inkWidgetReference();
			LanguageInstallProgressBarRoot = new inkWidgetReference();
			SettingsElements = new();
			Data = new();
			MenusList = new();
			EventsList = new();
			LanguageMenuIndex = 5;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

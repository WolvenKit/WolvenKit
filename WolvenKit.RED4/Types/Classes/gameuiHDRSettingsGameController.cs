using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiHDRSettingsGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("callibrationScreen")] 
		public CResourceReference<CBitmapTexture> CallibrationScreen
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(4)] 
		[RED("callibrationScreenTarget")] 
		public inkWidgetReference CallibrationScreenTarget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("callibrationScreenAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> CallibrationScreenAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(6)] 
		[RED("s_maxBrightnessGroup")] 
		public CName S_maxBrightnessGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("s_calibrationImageDay")] 
		public CName S_calibrationImageDay
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("s_calibrationImageNight")] 
		public CName S_calibrationImageNight
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("s_currentCalibrationImage")] 
		public CName S_currentCalibrationImage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("settingsOptionsList")] 
		public inkCompoundWidgetReference SettingsOptionsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("targetImageWidget")] 
		public inkWidgetReference TargetImageWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("defaultButton")] 
		public inkWidgetReference DefaultButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(15)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(16)] 
		[RED("settingsListener")] 
		public CHandle<HDRSettingsVarListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<HDRSettingsVarListener>>();
			set => SetPropertyValue<CHandle<HDRSettingsVarListener>>(value);
		}

		[Ordinal(17)] 
		[RED("settingsNotificationListener")] 
		public CHandle<HDRSettingsNotificationListener> SettingsNotificationListener
		{
			get => GetPropertyValue<CHandle<HDRSettingsNotificationListener>>();
			set => SetPropertyValue<CHandle<HDRSettingsNotificationListener>>(value);
		}

		[Ordinal(18)] 
		[RED("SettingsElements")] 
		public CArray<CWeakHandle<inkSettingsSelectorController>> SettingsElements
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkSettingsSelectorController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkSettingsSelectorController>>>(value);
		}

		[Ordinal(19)] 
		[RED("isPreGame")] 
		public CBool IsPreGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("calibrationImagesCycleAnimDef")] 
		public CHandle<inkanimDefinition> CalibrationImagesCycleAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(21)] 
		[RED("calibrationImagesCycleProxy")] 
		public CHandle<inkanimProxy> CalibrationImagesCycleProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("c_minMonitorBrightness")] 
		public CName C_minMonitorBrightness
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("c_maxMonitorBrightness")] 
		public CName C_maxMonitorBrightness
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("c_paperWhiteLevel")] 
		public CName C_paperWhiteLevel
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiHDRSettingsGameController()
		{
			CallibrationScreenTarget = new inkWidgetReference();
			SettingsOptionsList = new inkCompoundWidgetReference();
			TargetImageWidget = new inkWidgetReference();
			DescriptionText = new inkTextWidgetReference();
			DefaultButton = new inkWidgetReference();
			SettingsElements = new();
			C_minMonitorBrightness = "MinMonitorBrightness";
			C_maxMonitorBrightness = "MaxMonitorBrightness";
			C_paperWhiteLevel = "PaperWhiteLevel";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

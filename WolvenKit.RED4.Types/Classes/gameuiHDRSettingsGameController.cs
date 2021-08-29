using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiHDRSettingsGameController : gameuiMenuGameController
	{
		private CResourceReference<CBitmapTexture> _callibrationScreen;
		private inkWidgetReference _callibrationScreenTarget;
		private CResourceAsyncReference<inkTextureAtlas> _callibrationScreenAtlas;
		private CName _s_maxBrightnessGroup;
		private CName _s_paperWhiteGroup;
		private CName _s_toneMappingeGroup;
		private CName _s_calibrationImageDay;
		private CName _s_calibrationImageNight;
		private CName _s_currentCalibrationImage;
		private inkCompoundWidgetReference _paperWhiteOptionSelector;
		private inkCompoundWidgetReference _maxBrightnessOptionSelector;
		private inkCompoundWidgetReference _toneMappingOptionSelector;
		private inkWidgetReference _targetImageWidget;
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<HDRSettingsVarListener> _settingsListener;
		private CArray<CWeakHandle<inkSettingsSelectorController>> _settingsElements;
		private CBool _isPreGame;
		private CHandle<inkanimDefinition> _calibrationImagesCycleAnimDef;
		private CHandle<inkanimProxy> _calibrationImagesCycleProxy;

		[Ordinal(3)] 
		[RED("callibrationScreen")] 
		public CResourceReference<CBitmapTexture> CallibrationScreen
		{
			get => GetProperty(ref _callibrationScreen);
			set => SetProperty(ref _callibrationScreen, value);
		}

		[Ordinal(4)] 
		[RED("callibrationScreenTarget")] 
		public inkWidgetReference CallibrationScreenTarget
		{
			get => GetProperty(ref _callibrationScreenTarget);
			set => SetProperty(ref _callibrationScreenTarget, value);
		}

		[Ordinal(5)] 
		[RED("callibrationScreenAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> CallibrationScreenAtlas
		{
			get => GetProperty(ref _callibrationScreenAtlas);
			set => SetProperty(ref _callibrationScreenAtlas, value);
		}

		[Ordinal(6)] 
		[RED("s_maxBrightnessGroup")] 
		public CName S_maxBrightnessGroup
		{
			get => GetProperty(ref _s_maxBrightnessGroup);
			set => SetProperty(ref _s_maxBrightnessGroup, value);
		}

		[Ordinal(7)] 
		[RED("s_paperWhiteGroup")] 
		public CName S_paperWhiteGroup
		{
			get => GetProperty(ref _s_paperWhiteGroup);
			set => SetProperty(ref _s_paperWhiteGroup, value);
		}

		[Ordinal(8)] 
		[RED("s_toneMappingeGroup")] 
		public CName S_toneMappingeGroup
		{
			get => GetProperty(ref _s_toneMappingeGroup);
			set => SetProperty(ref _s_toneMappingeGroup, value);
		}

		[Ordinal(9)] 
		[RED("s_calibrationImageDay")] 
		public CName S_calibrationImageDay
		{
			get => GetProperty(ref _s_calibrationImageDay);
			set => SetProperty(ref _s_calibrationImageDay, value);
		}

		[Ordinal(10)] 
		[RED("s_calibrationImageNight")] 
		public CName S_calibrationImageNight
		{
			get => GetProperty(ref _s_calibrationImageNight);
			set => SetProperty(ref _s_calibrationImageNight, value);
		}

		[Ordinal(11)] 
		[RED("s_currentCalibrationImage")] 
		public CName S_currentCalibrationImage
		{
			get => GetProperty(ref _s_currentCalibrationImage);
			set => SetProperty(ref _s_currentCalibrationImage, value);
		}

		[Ordinal(12)] 
		[RED("paperWhiteOptionSelector")] 
		public inkCompoundWidgetReference PaperWhiteOptionSelector
		{
			get => GetProperty(ref _paperWhiteOptionSelector);
			set => SetProperty(ref _paperWhiteOptionSelector, value);
		}

		[Ordinal(13)] 
		[RED("maxBrightnessOptionSelector")] 
		public inkCompoundWidgetReference MaxBrightnessOptionSelector
		{
			get => GetProperty(ref _maxBrightnessOptionSelector);
			set => SetProperty(ref _maxBrightnessOptionSelector, value);
		}

		[Ordinal(14)] 
		[RED("toneMappingOptionSelector")] 
		public inkCompoundWidgetReference ToneMappingOptionSelector
		{
			get => GetProperty(ref _toneMappingOptionSelector);
			set => SetProperty(ref _toneMappingOptionSelector, value);
		}

		[Ordinal(15)] 
		[RED("targetImageWidget")] 
		public inkWidgetReference TargetImageWidget
		{
			get => GetProperty(ref _targetImageWidget);
			set => SetProperty(ref _targetImageWidget, value);
		}

		[Ordinal(16)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(17)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(18)] 
		[RED("settingsListener")] 
		public CHandle<HDRSettingsVarListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(19)] 
		[RED("SettingsElements")] 
		public CArray<CWeakHandle<inkSettingsSelectorController>> SettingsElements
		{
			get => GetProperty(ref _settingsElements);
			set => SetProperty(ref _settingsElements, value);
		}

		[Ordinal(20)] 
		[RED("isPreGame")] 
		public CBool IsPreGame
		{
			get => GetProperty(ref _isPreGame);
			set => SetProperty(ref _isPreGame, value);
		}

		[Ordinal(21)] 
		[RED("calibrationImagesCycleAnimDef")] 
		public CHandle<inkanimDefinition> CalibrationImagesCycleAnimDef
		{
			get => GetProperty(ref _calibrationImagesCycleAnimDef);
			set => SetProperty(ref _calibrationImagesCycleAnimDef, value);
		}

		[Ordinal(22)] 
		[RED("calibrationImagesCycleProxy")] 
		public CHandle<inkanimProxy> CalibrationImagesCycleProxy
		{
			get => GetProperty(ref _calibrationImagesCycleProxy);
			set => SetProperty(ref _calibrationImagesCycleProxy, value);
		}
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHDRSettingsGameController : gameuiMenuGameController
	{
		private rRef<CBitmapTexture> _callibrationScreen;
		private inkWidgetReference _callibrationScreenTarget;
		private raRef<inkTextureAtlas> _callibrationScreenAtlas;
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
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<HDRSettingsVarListener> _settingsListener;
		private CArray<wCHandle<inkSettingsSelectorController>> _settingsElements;
		private CBool _isPreGame;
		private CHandle<inkanimDefinition> _calibrationImagesCycleAnimDef;
		private CHandle<inkanimProxy> _calibrationImagesCycleProxy;

		[Ordinal(3)] 
		[RED("callibrationScreen")] 
		public rRef<CBitmapTexture> CallibrationScreen
		{
			get
			{
				if (_callibrationScreen == null)
				{
					_callibrationScreen = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "callibrationScreen", cr2w, this);
				}
				return _callibrationScreen;
			}
			set
			{
				if (_callibrationScreen == value)
				{
					return;
				}
				_callibrationScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("callibrationScreenTarget")] 
		public inkWidgetReference CallibrationScreenTarget
		{
			get
			{
				if (_callibrationScreenTarget == null)
				{
					_callibrationScreenTarget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "callibrationScreenTarget", cr2w, this);
				}
				return _callibrationScreenTarget;
			}
			set
			{
				if (_callibrationScreenTarget == value)
				{
					return;
				}
				_callibrationScreenTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("callibrationScreenAtlas")] 
		public raRef<inkTextureAtlas> CallibrationScreenAtlas
		{
			get
			{
				if (_callibrationScreenAtlas == null)
				{
					_callibrationScreenAtlas = (raRef<inkTextureAtlas>) CR2WTypeManager.Create("raRef:inkTextureAtlas", "callibrationScreenAtlas", cr2w, this);
				}
				return _callibrationScreenAtlas;
			}
			set
			{
				if (_callibrationScreenAtlas == value)
				{
					return;
				}
				_callibrationScreenAtlas = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("s_maxBrightnessGroup")] 
		public CName S_maxBrightnessGroup
		{
			get
			{
				if (_s_maxBrightnessGroup == null)
				{
					_s_maxBrightnessGroup = (CName) CR2WTypeManager.Create("CName", "s_maxBrightnessGroup", cr2w, this);
				}
				return _s_maxBrightnessGroup;
			}
			set
			{
				if (_s_maxBrightnessGroup == value)
				{
					return;
				}
				_s_maxBrightnessGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("s_paperWhiteGroup")] 
		public CName S_paperWhiteGroup
		{
			get
			{
				if (_s_paperWhiteGroup == null)
				{
					_s_paperWhiteGroup = (CName) CR2WTypeManager.Create("CName", "s_paperWhiteGroup", cr2w, this);
				}
				return _s_paperWhiteGroup;
			}
			set
			{
				if (_s_paperWhiteGroup == value)
				{
					return;
				}
				_s_paperWhiteGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("s_toneMappingeGroup")] 
		public CName S_toneMappingeGroup
		{
			get
			{
				if (_s_toneMappingeGroup == null)
				{
					_s_toneMappingeGroup = (CName) CR2WTypeManager.Create("CName", "s_toneMappingeGroup", cr2w, this);
				}
				return _s_toneMappingeGroup;
			}
			set
			{
				if (_s_toneMappingeGroup == value)
				{
					return;
				}
				_s_toneMappingeGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("s_calibrationImageDay")] 
		public CName S_calibrationImageDay
		{
			get
			{
				if (_s_calibrationImageDay == null)
				{
					_s_calibrationImageDay = (CName) CR2WTypeManager.Create("CName", "s_calibrationImageDay", cr2w, this);
				}
				return _s_calibrationImageDay;
			}
			set
			{
				if (_s_calibrationImageDay == value)
				{
					return;
				}
				_s_calibrationImageDay = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("s_calibrationImageNight")] 
		public CName S_calibrationImageNight
		{
			get
			{
				if (_s_calibrationImageNight == null)
				{
					_s_calibrationImageNight = (CName) CR2WTypeManager.Create("CName", "s_calibrationImageNight", cr2w, this);
				}
				return _s_calibrationImageNight;
			}
			set
			{
				if (_s_calibrationImageNight == value)
				{
					return;
				}
				_s_calibrationImageNight = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("s_currentCalibrationImage")] 
		public CName S_currentCalibrationImage
		{
			get
			{
				if (_s_currentCalibrationImage == null)
				{
					_s_currentCalibrationImage = (CName) CR2WTypeManager.Create("CName", "s_currentCalibrationImage", cr2w, this);
				}
				return _s_currentCalibrationImage;
			}
			set
			{
				if (_s_currentCalibrationImage == value)
				{
					return;
				}
				_s_currentCalibrationImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("paperWhiteOptionSelector")] 
		public inkCompoundWidgetReference PaperWhiteOptionSelector
		{
			get
			{
				if (_paperWhiteOptionSelector == null)
				{
					_paperWhiteOptionSelector = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "paperWhiteOptionSelector", cr2w, this);
				}
				return _paperWhiteOptionSelector;
			}
			set
			{
				if (_paperWhiteOptionSelector == value)
				{
					return;
				}
				_paperWhiteOptionSelector = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("maxBrightnessOptionSelector")] 
		public inkCompoundWidgetReference MaxBrightnessOptionSelector
		{
			get
			{
				if (_maxBrightnessOptionSelector == null)
				{
					_maxBrightnessOptionSelector = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "maxBrightnessOptionSelector", cr2w, this);
				}
				return _maxBrightnessOptionSelector;
			}
			set
			{
				if (_maxBrightnessOptionSelector == value)
				{
					return;
				}
				_maxBrightnessOptionSelector = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("toneMappingOptionSelector")] 
		public inkCompoundWidgetReference ToneMappingOptionSelector
		{
			get
			{
				if (_toneMappingOptionSelector == null)
				{
					_toneMappingOptionSelector = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "toneMappingOptionSelector", cr2w, this);
				}
				return _toneMappingOptionSelector;
			}
			set
			{
				if (_toneMappingOptionSelector == value)
				{
					return;
				}
				_toneMappingOptionSelector = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("targetImageWidget")] 
		public inkWidgetReference TargetImageWidget
		{
			get
			{
				if (_targetImageWidget == null)
				{
					_targetImageWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetImageWidget", cr2w, this);
				}
				return _targetImageWidget;
			}
			set
			{
				if (_targetImageWidget == value)
				{
					return;
				}
				_targetImageWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("settingsListener")] 
		public CHandle<HDRSettingsVarListener> SettingsListener
		{
			get
			{
				if (_settingsListener == null)
				{
					_settingsListener = (CHandle<HDRSettingsVarListener>) CR2WTypeManager.Create("handle:HDRSettingsVarListener", "settingsListener", cr2w, this);
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
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

		[Ordinal(21)] 
		[RED("calibrationImagesCycleAnimDef")] 
		public CHandle<inkanimDefinition> CalibrationImagesCycleAnimDef
		{
			get
			{
				if (_calibrationImagesCycleAnimDef == null)
				{
					_calibrationImagesCycleAnimDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "calibrationImagesCycleAnimDef", cr2w, this);
				}
				return _calibrationImagesCycleAnimDef;
			}
			set
			{
				if (_calibrationImagesCycleAnimDef == value)
				{
					return;
				}
				_calibrationImagesCycleAnimDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("calibrationImagesCycleProxy")] 
		public CHandle<inkanimProxy> CalibrationImagesCycleProxy
		{
			get
			{
				if (_calibrationImagesCycleProxy == null)
				{
					_calibrationImagesCycleProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "calibrationImagesCycleProxy", cr2w, this);
				}
				return _calibrationImagesCycleProxy;
			}
			set
			{
				if (_calibrationImagesCycleProxy == value)
				{
					return;
				}
				_calibrationImagesCycleProxy = value;
				PropertySet(this);
			}
		}

		public gameuiHDRSettingsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

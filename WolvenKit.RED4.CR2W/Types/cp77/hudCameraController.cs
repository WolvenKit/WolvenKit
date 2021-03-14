using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudCameraController : gameuiHUDGameController
	{
		private CFloat _pitch_min;
		private CFloat _pitch_max;
		private CFloat _yaw_min;
		private CFloat _yaw_max;
		private CFloat _tele_min;
		private CFloat _tele_max;
		private CFloat _tele_scale;
		private CFloat _max_zoom_level;
		private inkTextWidgetReference _date;
		private inkTextWidgetReference _timer;
		private inkTextWidgetReference _cameraID;
		private inkTextWidgetReference _timerHrs;
		private inkTextWidgetReference _timerMin;
		private inkTextWidgetReference _timerSec;
		private inkWidgetReference _watermark;
		private inkTextWidgetReference _yawCounter;
		private inkTextWidgetReference _pitchCounter;
		private inkCanvasWidgetReference _pitch;
		private inkCanvasWidgetReference _yaw;
		private inkCanvasWidgetReference _tele;
		private inkCanvasWidgetReference _teleScale;
		private CHandle<gameIBlackboard> _scanBlackboard;
		private CHandle<gameIBlackboard> _psmBlackboard;
		private CHandle<gameIBlackboard> _tcsBlackboard;
		private CUInt32 _pSM_BBID;
		private CUInt32 _tcs_BBID;
		private CUInt32 _deviceChain_BBID;
		private wCHandle<inkCompoundWidget> _root;
		private CFloat _currentZoom;
		private GameTime _currentTime;
		private wCHandle<gameObject> _controlledObjectRef;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private CHandle<inkanimProxy> _animProxy;
		private inkanimPlaybackOptions _animOptions;
		private wCHandle<gameObject> _ownerObject;
		private CInt32 _maxZoomLevel;

		[Ordinal(9)] 
		[RED("pitch_min")] 
		public CFloat Pitch_min
		{
			get
			{
				if (_pitch_min == null)
				{
					_pitch_min = (CFloat) CR2WTypeManager.Create("Float", "pitch_min", cr2w, this);
				}
				return _pitch_min;
			}
			set
			{
				if (_pitch_min == value)
				{
					return;
				}
				_pitch_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("pitch_max")] 
		public CFloat Pitch_max
		{
			get
			{
				if (_pitch_max == null)
				{
					_pitch_max = (CFloat) CR2WTypeManager.Create("Float", "pitch_max", cr2w, this);
				}
				return _pitch_max;
			}
			set
			{
				if (_pitch_max == value)
				{
					return;
				}
				_pitch_max = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("yaw_min")] 
		public CFloat Yaw_min
		{
			get
			{
				if (_yaw_min == null)
				{
					_yaw_min = (CFloat) CR2WTypeManager.Create("Float", "yaw_min", cr2w, this);
				}
				return _yaw_min;
			}
			set
			{
				if (_yaw_min == value)
				{
					return;
				}
				_yaw_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("yaw_max")] 
		public CFloat Yaw_max
		{
			get
			{
				if (_yaw_max == null)
				{
					_yaw_max = (CFloat) CR2WTypeManager.Create("Float", "yaw_max", cr2w, this);
				}
				return _yaw_max;
			}
			set
			{
				if (_yaw_max == value)
				{
					return;
				}
				_yaw_max = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("tele_min")] 
		public CFloat Tele_min
		{
			get
			{
				if (_tele_min == null)
				{
					_tele_min = (CFloat) CR2WTypeManager.Create("Float", "tele_min", cr2w, this);
				}
				return _tele_min;
			}
			set
			{
				if (_tele_min == value)
				{
					return;
				}
				_tele_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("tele_max")] 
		public CFloat Tele_max
		{
			get
			{
				if (_tele_max == null)
				{
					_tele_max = (CFloat) CR2WTypeManager.Create("Float", "tele_max", cr2w, this);
				}
				return _tele_max;
			}
			set
			{
				if (_tele_max == value)
				{
					return;
				}
				_tele_max = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("tele_scale")] 
		public CFloat Tele_scale
		{
			get
			{
				if (_tele_scale == null)
				{
					_tele_scale = (CFloat) CR2WTypeManager.Create("Float", "tele_scale", cr2w, this);
				}
				return _tele_scale;
			}
			set
			{
				if (_tele_scale == value)
				{
					return;
				}
				_tele_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("max_zoom_level")] 
		public CFloat Max_zoom_level
		{
			get
			{
				if (_max_zoom_level == null)
				{
					_max_zoom_level = (CFloat) CR2WTypeManager.Create("Float", "max_zoom_level", cr2w, this);
				}
				return _max_zoom_level;
			}
			set
			{
				if (_max_zoom_level == value)
				{
					return;
				}
				_max_zoom_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("Date")] 
		public inkTextWidgetReference Date
		{
			get
			{
				if (_date == null)
				{
					_date = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Date", cr2w, this);
				}
				return _date;
			}
			set
			{
				if (_date == value)
				{
					return;
				}
				_date = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("Timer")] 
		public inkTextWidgetReference Timer
		{
			get
			{
				if (_timer == null)
				{
					_timer = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Timer", cr2w, this);
				}
				return _timer;
			}
			set
			{
				if (_timer == value)
				{
					return;
				}
				_timer = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("CameraID")] 
		public inkTextWidgetReference CameraID
		{
			get
			{
				if (_cameraID == null)
				{
					_cameraID = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "CameraID", cr2w, this);
				}
				return _cameraID;
			}
			set
			{
				if (_cameraID == value)
				{
					return;
				}
				_cameraID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("timerHrs")] 
		public inkTextWidgetReference TimerHrs
		{
			get
			{
				if (_timerHrs == null)
				{
					_timerHrs = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "timerHrs", cr2w, this);
				}
				return _timerHrs;
			}
			set
			{
				if (_timerHrs == value)
				{
					return;
				}
				_timerHrs = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("timerMin")] 
		public inkTextWidgetReference TimerMin
		{
			get
			{
				if (_timerMin == null)
				{
					_timerMin = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "timerMin", cr2w, this);
				}
				return _timerMin;
			}
			set
			{
				if (_timerMin == value)
				{
					return;
				}
				_timerMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("timerSec")] 
		public inkTextWidgetReference TimerSec
		{
			get
			{
				if (_timerSec == null)
				{
					_timerSec = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "timerSec", cr2w, this);
				}
				return _timerSec;
			}
			set
			{
				if (_timerSec == value)
				{
					return;
				}
				_timerSec = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("watermark")] 
		public inkWidgetReference Watermark
		{
			get
			{
				if (_watermark == null)
				{
					_watermark = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "watermark", cr2w, this);
				}
				return _watermark;
			}
			set
			{
				if (_watermark == value)
				{
					return;
				}
				_watermark = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("yawCounter")] 
		public inkTextWidgetReference YawCounter
		{
			get
			{
				if (_yawCounter == null)
				{
					_yawCounter = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "yawCounter", cr2w, this);
				}
				return _yawCounter;
			}
			set
			{
				if (_yawCounter == value)
				{
					return;
				}
				_yawCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("pitchCounter")] 
		public inkTextWidgetReference PitchCounter
		{
			get
			{
				if (_pitchCounter == null)
				{
					_pitchCounter = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "pitchCounter", cr2w, this);
				}
				return _pitchCounter;
			}
			set
			{
				if (_pitchCounter == value)
				{
					return;
				}
				_pitchCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("pitch")] 
		public inkCanvasWidgetReference Pitch
		{
			get
			{
				if (_pitch == null)
				{
					_pitch = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "pitch", cr2w, this);
				}
				return _pitch;
			}
			set
			{
				if (_pitch == value)
				{
					return;
				}
				_pitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("yaw")] 
		public inkCanvasWidgetReference Yaw
		{
			get
			{
				if (_yaw == null)
				{
					_yaw = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "yaw", cr2w, this);
				}
				return _yaw;
			}
			set
			{
				if (_yaw == value)
				{
					return;
				}
				_yaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("tele")] 
		public inkCanvasWidgetReference Tele
		{
			get
			{
				if (_tele == null)
				{
					_tele = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "tele", cr2w, this);
				}
				return _tele;
			}
			set
			{
				if (_tele == value)
				{
					return;
				}
				_tele = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("teleScale")] 
		public inkCanvasWidgetReference TeleScale
		{
			get
			{
				if (_teleScale == null)
				{
					_teleScale = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "teleScale", cr2w, this);
				}
				return _teleScale;
			}
			set
			{
				if (_teleScale == value)
				{
					return;
				}
				_teleScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("scanBlackboard")] 
		public CHandle<gameIBlackboard> ScanBlackboard
		{
			get
			{
				if (_scanBlackboard == null)
				{
					_scanBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "scanBlackboard", cr2w, this);
				}
				return _scanBlackboard;
			}
			set
			{
				if (_scanBlackboard == value)
				{
					return;
				}
				_scanBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("psmBlackboard")] 
		public CHandle<gameIBlackboard> PsmBlackboard
		{
			get
			{
				if (_psmBlackboard == null)
				{
					_psmBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "psmBlackboard", cr2w, this);
				}
				return _psmBlackboard;
			}
			set
			{
				if (_psmBlackboard == value)
				{
					return;
				}
				_psmBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("tcsBlackboard")] 
		public CHandle<gameIBlackboard> TcsBlackboard
		{
			get
			{
				if (_tcsBlackboard == null)
				{
					_tcsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "tcsBlackboard", cr2w, this);
				}
				return _tcsBlackboard;
			}
			set
			{
				if (_tcsBlackboard == value)
				{
					return;
				}
				_tcsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("PSM_BBID")] 
		public CUInt32 PSM_BBID
		{
			get
			{
				if (_pSM_BBID == null)
				{
					_pSM_BBID = (CUInt32) CR2WTypeManager.Create("Uint32", "PSM_BBID", cr2w, this);
				}
				return _pSM_BBID;
			}
			set
			{
				if (_pSM_BBID == value)
				{
					return;
				}
				_pSM_BBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("tcs_BBID")] 
		public CUInt32 Tcs_BBID
		{
			get
			{
				if (_tcs_BBID == null)
				{
					_tcs_BBID = (CUInt32) CR2WTypeManager.Create("Uint32", "tcs_BBID", cr2w, this);
				}
				return _tcs_BBID;
			}
			set
			{
				if (_tcs_BBID == value)
				{
					return;
				}
				_tcs_BBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("deviceChain_BBID")] 
		public CUInt32 DeviceChain_BBID
		{
			get
			{
				if (_deviceChain_BBID == null)
				{
					_deviceChain_BBID = (CUInt32) CR2WTypeManager.Create("Uint32", "deviceChain_BBID", cr2w, this);
				}
				return _deviceChain_BBID;
			}
			set
			{
				if (_deviceChain_BBID == value)
				{
					return;
				}
				_deviceChain_BBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("currentZoom")] 
		public CFloat CurrentZoom
		{
			get
			{
				if (_currentZoom == null)
				{
					_currentZoom = (CFloat) CR2WTypeManager.Create("Float", "currentZoom", cr2w, this);
				}
				return _currentZoom;
			}
			set
			{
				if (_currentZoom == value)
				{
					return;
				}
				_currentZoom = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get
			{
				if (_currentTime == null)
				{
					_currentTime = (GameTime) CR2WTypeManager.Create("GameTime", "currentTime", cr2w, this);
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

		[Ordinal(39)] 
		[RED("controlledObjectRef")] 
		public wCHandle<gameObject> ControlledObjectRef
		{
			get
			{
				if (_controlledObjectRef == null)
				{
					_controlledObjectRef = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "controlledObjectRef", cr2w, this);
				}
				return _controlledObjectRef;
			}
			set
			{
				if (_controlledObjectRef == value)
				{
					return;
				}
				_controlledObjectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get
			{
				if (_alpha_fadein == null)
				{
					_alpha_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "alpha_fadein", cr2w, this);
				}
				return _alpha_fadein;
			}
			set
			{
				if (_alpha_fadein == value)
				{
					return;
				}
				_alpha_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "AnimProxy", cr2w, this);
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

		[Ordinal(42)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get
			{
				if (_animOptions == null)
				{
					_animOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "AnimOptions", cr2w, this);
				}
				return _animOptions;
			}
			set
			{
				if (_animOptions == value)
				{
					return;
				}
				_animOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("ownerObject")] 
		public wCHandle<gameObject> OwnerObject
		{
			get
			{
				if (_ownerObject == null)
				{
					_ownerObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "ownerObject", cr2w, this);
				}
				return _ownerObject;
			}
			set
			{
				if (_ownerObject == value)
				{
					return;
				}
				_ownerObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("maxZoomLevel")] 
		public CInt32 MaxZoomLevel
		{
			get
			{
				if (_maxZoomLevel == null)
				{
					_maxZoomLevel = (CInt32) CR2WTypeManager.Create("Int32", "maxZoomLevel", cr2w, this);
				}
				return _maxZoomLevel;
			}
			set
			{
				if (_maxZoomLevel == value)
				{
					return;
				}
				_maxZoomLevel = value;
				PropertySet(this);
			}
		}

		public hudCameraController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

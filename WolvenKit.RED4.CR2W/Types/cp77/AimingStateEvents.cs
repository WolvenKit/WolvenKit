using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimingStateEvents : UpperBodyEventsTransition
	{
		private CHandle<gameweaponAnimFeature_AimPlayer> _aim;
		private CFloat _mouseZoomLevel;
		private CInt32 _zoomLevelNum;
		private CInt32 _numZoomLevels;
		private CInt32 _delayAimSnap;
		private CBool _isAiming;
		private CFloat _aimInTimeRemaining;
		private CBool _aimBroadcast;
		private CFloat _zoomLevel;
		private CFloat _finalZoomLevel;
		private CFloat _previousZoomLevel;
		private CFloat _currentZoomLevel;
		private CFloat _timeToBlendZoom;
		private CFloat _time;
		private CFloat _speed;

		[Ordinal(6)] 
		[RED("aim")] 
		public CHandle<gameweaponAnimFeature_AimPlayer> Aim
		{
			get
			{
				if (_aim == null)
				{
					_aim = (CHandle<gameweaponAnimFeature_AimPlayer>) CR2WTypeManager.Create("handle:gameweaponAnimFeature_AimPlayer", "aim", cr2w, this);
				}
				return _aim;
			}
			set
			{
				if (_aim == value)
				{
					return;
				}
				_aim = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("mouseZoomLevel")] 
		public CFloat MouseZoomLevel
		{
			get
			{
				if (_mouseZoomLevel == null)
				{
					_mouseZoomLevel = (CFloat) CR2WTypeManager.Create("Float", "mouseZoomLevel", cr2w, this);
				}
				return _mouseZoomLevel;
			}
			set
			{
				if (_mouseZoomLevel == value)
				{
					return;
				}
				_mouseZoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("zoomLevelNum")] 
		public CInt32 ZoomLevelNum
		{
			get
			{
				if (_zoomLevelNum == null)
				{
					_zoomLevelNum = (CInt32) CR2WTypeManager.Create("Int32", "zoomLevelNum", cr2w, this);
				}
				return _zoomLevelNum;
			}
			set
			{
				if (_zoomLevelNum == value)
				{
					return;
				}
				_zoomLevelNum = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("numZoomLevels")] 
		public CInt32 NumZoomLevels
		{
			get
			{
				if (_numZoomLevels == null)
				{
					_numZoomLevels = (CInt32) CR2WTypeManager.Create("Int32", "numZoomLevels", cr2w, this);
				}
				return _numZoomLevels;
			}
			set
			{
				if (_numZoomLevels == value)
				{
					return;
				}
				_numZoomLevels = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("delayAimSnap")] 
		public CInt32 DelayAimSnap
		{
			get
			{
				if (_delayAimSnap == null)
				{
					_delayAimSnap = (CInt32) CR2WTypeManager.Create("Int32", "delayAimSnap", cr2w, this);
				}
				return _delayAimSnap;
			}
			set
			{
				if (_delayAimSnap == value)
				{
					return;
				}
				_delayAimSnap = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get
			{
				if (_isAiming == null)
				{
					_isAiming = (CBool) CR2WTypeManager.Create("Bool", "isAiming", cr2w, this);
				}
				return _isAiming;
			}
			set
			{
				if (_isAiming == value)
				{
					return;
				}
				_isAiming = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("aimInTimeRemaining")] 
		public CFloat AimInTimeRemaining
		{
			get
			{
				if (_aimInTimeRemaining == null)
				{
					_aimInTimeRemaining = (CFloat) CR2WTypeManager.Create("Float", "aimInTimeRemaining", cr2w, this);
				}
				return _aimInTimeRemaining;
			}
			set
			{
				if (_aimInTimeRemaining == value)
				{
					return;
				}
				_aimInTimeRemaining = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("aimBroadcast")] 
		public CBool AimBroadcast
		{
			get
			{
				if (_aimBroadcast == null)
				{
					_aimBroadcast = (CBool) CR2WTypeManager.Create("Bool", "aimBroadcast", cr2w, this);
				}
				return _aimBroadcast;
			}
			set
			{
				if (_aimBroadcast == value)
				{
					return;
				}
				_aimBroadcast = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("zoomLevel")] 
		public CFloat ZoomLevel
		{
			get
			{
				if (_zoomLevel == null)
				{
					_zoomLevel = (CFloat) CR2WTypeManager.Create("Float", "zoomLevel", cr2w, this);
				}
				return _zoomLevel;
			}
			set
			{
				if (_zoomLevel == value)
				{
					return;
				}
				_zoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("finalZoomLevel")] 
		public CFloat FinalZoomLevel
		{
			get
			{
				if (_finalZoomLevel == null)
				{
					_finalZoomLevel = (CFloat) CR2WTypeManager.Create("Float", "finalZoomLevel", cr2w, this);
				}
				return _finalZoomLevel;
			}
			set
			{
				if (_finalZoomLevel == value)
				{
					return;
				}
				_finalZoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("previousZoomLevel")] 
		public CFloat PreviousZoomLevel
		{
			get
			{
				if (_previousZoomLevel == null)
				{
					_previousZoomLevel = (CFloat) CR2WTypeManager.Create("Float", "previousZoomLevel", cr2w, this);
				}
				return _previousZoomLevel;
			}
			set
			{
				if (_previousZoomLevel == value)
				{
					return;
				}
				_previousZoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("currentZoomLevel")] 
		public CFloat CurrentZoomLevel
		{
			get
			{
				if (_currentZoomLevel == null)
				{
					_currentZoomLevel = (CFloat) CR2WTypeManager.Create("Float", "currentZoomLevel", cr2w, this);
				}
				return _currentZoomLevel;
			}
			set
			{
				if (_currentZoomLevel == value)
				{
					return;
				}
				_currentZoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("timeToBlendZoom")] 
		public CFloat TimeToBlendZoom
		{
			get
			{
				if (_timeToBlendZoom == null)
				{
					_timeToBlendZoom = (CFloat) CR2WTypeManager.Create("Float", "timeToBlendZoom", cr2w, this);
				}
				return _timeToBlendZoom;
			}
			set
			{
				if (_timeToBlendZoom == value)
				{
					return;
				}
				_timeToBlendZoom = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CFloat) CR2WTypeManager.Create("Float", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		public AimingStateEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

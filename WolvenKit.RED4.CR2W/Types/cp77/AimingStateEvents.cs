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
			get => GetProperty(ref _aim);
			set => SetProperty(ref _aim, value);
		}

		[Ordinal(7)] 
		[RED("mouseZoomLevel")] 
		public CFloat MouseZoomLevel
		{
			get => GetProperty(ref _mouseZoomLevel);
			set => SetProperty(ref _mouseZoomLevel, value);
		}

		[Ordinal(8)] 
		[RED("zoomLevelNum")] 
		public CInt32 ZoomLevelNum
		{
			get => GetProperty(ref _zoomLevelNum);
			set => SetProperty(ref _zoomLevelNum, value);
		}

		[Ordinal(9)] 
		[RED("numZoomLevels")] 
		public CInt32 NumZoomLevels
		{
			get => GetProperty(ref _numZoomLevels);
			set => SetProperty(ref _numZoomLevels, value);
		}

		[Ordinal(10)] 
		[RED("delayAimSnap")] 
		public CInt32 DelayAimSnap
		{
			get => GetProperty(ref _delayAimSnap);
			set => SetProperty(ref _delayAimSnap, value);
		}

		[Ordinal(11)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		[Ordinal(12)] 
		[RED("aimInTimeRemaining")] 
		public CFloat AimInTimeRemaining
		{
			get => GetProperty(ref _aimInTimeRemaining);
			set => SetProperty(ref _aimInTimeRemaining, value);
		}

		[Ordinal(13)] 
		[RED("aimBroadcast")] 
		public CBool AimBroadcast
		{
			get => GetProperty(ref _aimBroadcast);
			set => SetProperty(ref _aimBroadcast, value);
		}

		[Ordinal(14)] 
		[RED("zoomLevel")] 
		public CFloat ZoomLevel
		{
			get => GetProperty(ref _zoomLevel);
			set => SetProperty(ref _zoomLevel, value);
		}

		[Ordinal(15)] 
		[RED("finalZoomLevel")] 
		public CFloat FinalZoomLevel
		{
			get => GetProperty(ref _finalZoomLevel);
			set => SetProperty(ref _finalZoomLevel, value);
		}

		[Ordinal(16)] 
		[RED("previousZoomLevel")] 
		public CFloat PreviousZoomLevel
		{
			get => GetProperty(ref _previousZoomLevel);
			set => SetProperty(ref _previousZoomLevel, value);
		}

		[Ordinal(17)] 
		[RED("currentZoomLevel")] 
		public CFloat CurrentZoomLevel
		{
			get => GetProperty(ref _currentZoomLevel);
			set => SetProperty(ref _currentZoomLevel, value);
		}

		[Ordinal(18)] 
		[RED("timeToBlendZoom")] 
		public CFloat TimeToBlendZoom
		{
			get => GetProperty(ref _timeToBlendZoom);
			set => SetProperty(ref _timeToBlendZoom, value);
		}

		[Ordinal(19)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(20)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		public AimingStateEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

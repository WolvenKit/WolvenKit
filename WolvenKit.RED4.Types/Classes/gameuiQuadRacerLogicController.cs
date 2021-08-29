using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiQuadRacerLogicController : gameuiSideScrollerMiniGameLogicController
	{
		private CFloat _endgameDelay;
		private CFloat _baseMultiplicatorScale;
		private inkWidgetReference _skyWidget;
		private CArray<gameuiRoadEditorSegment> _road;
		private CName _checkpointLibraryName;
		private CName _roadLibraryName;
		private CName _backgroundLibraryName;
		private CFloat _timeToPassCheckpoint;
		private CInt32 _scorePerMeter;
		private CInt32 _scorePerExtraSecond;
		private CFloat _bonusTime;
		private CFloat _backgroundStitch;
		private CUInt32 _drawDistance;
		private CInt32 _carDistanceOfView;
		private CUInt32 _colorBlindDrawDistance;
		private CUInt32 _segmentDetails;
		private CFloat _segmentLength;
		private CFloat _roadWidth;
		private CFloat _backgroundSpeed;
		private CFloat _cameraFov;
		private CFloat _cameraHeight;
		private CFloat _startTime;
		private CFloat _defaultMaxSpeed;
		private CFloat _nitroMaxSpeed;
		private CFloat _acceleration;
		private CFloat _breaking;
		private CFloat _deceleration;
		private CFloat _offRoadLimit;
		private CFloat _offRoadDeceleration;
		private CFloat _centrifugalForce;
		private CInt32 _playerSegmentOffset;
		private inkTextWidgetReference _timeLeftText;
		private inkTextWidgetReference _scoreText;
		private inkTextWidgetReference _speedText;
		private inkTextWidgetReference _notificationText;
		private CName _notificationAnimationName;
		private CFloat _speedCoeficient;
		private CHandle<inkanimProxy> _currentNotificationAnimation;
		private CInt32 _lastTime;

		[Ordinal(10)] 
		[RED("endgameDelay")] 
		public CFloat EndgameDelay
		{
			get => GetProperty(ref _endgameDelay);
			set => SetProperty(ref _endgameDelay, value);
		}

		[Ordinal(11)] 
		[RED("baseMultiplicatorScale")] 
		public CFloat BaseMultiplicatorScale
		{
			get => GetProperty(ref _baseMultiplicatorScale);
			set => SetProperty(ref _baseMultiplicatorScale, value);
		}

		[Ordinal(12)] 
		[RED("skyWidget")] 
		public inkWidgetReference SkyWidget
		{
			get => GetProperty(ref _skyWidget);
			set => SetProperty(ref _skyWidget, value);
		}

		[Ordinal(13)] 
		[RED("road")] 
		public CArray<gameuiRoadEditorSegment> Road
		{
			get => GetProperty(ref _road);
			set => SetProperty(ref _road, value);
		}

		[Ordinal(14)] 
		[RED("checkpointLibraryName")] 
		public CName CheckpointLibraryName
		{
			get => GetProperty(ref _checkpointLibraryName);
			set => SetProperty(ref _checkpointLibraryName, value);
		}

		[Ordinal(15)] 
		[RED("roadLibraryName")] 
		public CName RoadLibraryName
		{
			get => GetProperty(ref _roadLibraryName);
			set => SetProperty(ref _roadLibraryName, value);
		}

		[Ordinal(16)] 
		[RED("backgroundLibraryName")] 
		public CName BackgroundLibraryName
		{
			get => GetProperty(ref _backgroundLibraryName);
			set => SetProperty(ref _backgroundLibraryName, value);
		}

		[Ordinal(17)] 
		[RED("timeToPassCheckpoint")] 
		public CFloat TimeToPassCheckpoint
		{
			get => GetProperty(ref _timeToPassCheckpoint);
			set => SetProperty(ref _timeToPassCheckpoint, value);
		}

		[Ordinal(18)] 
		[RED("scorePerMeter")] 
		public CInt32 ScorePerMeter
		{
			get => GetProperty(ref _scorePerMeter);
			set => SetProperty(ref _scorePerMeter, value);
		}

		[Ordinal(19)] 
		[RED("scorePerExtraSecond")] 
		public CInt32 ScorePerExtraSecond
		{
			get => GetProperty(ref _scorePerExtraSecond);
			set => SetProperty(ref _scorePerExtraSecond, value);
		}

		[Ordinal(20)] 
		[RED("bonusTime")] 
		public CFloat BonusTime
		{
			get => GetProperty(ref _bonusTime);
			set => SetProperty(ref _bonusTime, value);
		}

		[Ordinal(21)] 
		[RED("backgroundStitch")] 
		public CFloat BackgroundStitch
		{
			get => GetProperty(ref _backgroundStitch);
			set => SetProperty(ref _backgroundStitch, value);
		}

		[Ordinal(22)] 
		[RED("drawDistance")] 
		public CUInt32 DrawDistance
		{
			get => GetProperty(ref _drawDistance);
			set => SetProperty(ref _drawDistance, value);
		}

		[Ordinal(23)] 
		[RED("carDistanceOfView")] 
		public CInt32 CarDistanceOfView
		{
			get => GetProperty(ref _carDistanceOfView);
			set => SetProperty(ref _carDistanceOfView, value);
		}

		[Ordinal(24)] 
		[RED("colorBlindDrawDistance")] 
		public CUInt32 ColorBlindDrawDistance
		{
			get => GetProperty(ref _colorBlindDrawDistance);
			set => SetProperty(ref _colorBlindDrawDistance, value);
		}

		[Ordinal(25)] 
		[RED("segmentDetails")] 
		public CUInt32 SegmentDetails
		{
			get => GetProperty(ref _segmentDetails);
			set => SetProperty(ref _segmentDetails, value);
		}

		[Ordinal(26)] 
		[RED("segmentLength")] 
		public CFloat SegmentLength
		{
			get => GetProperty(ref _segmentLength);
			set => SetProperty(ref _segmentLength, value);
		}

		[Ordinal(27)] 
		[RED("roadWidth")] 
		public CFloat RoadWidth
		{
			get => GetProperty(ref _roadWidth);
			set => SetProperty(ref _roadWidth, value);
		}

		[Ordinal(28)] 
		[RED("backgroundSpeed")] 
		public CFloat BackgroundSpeed
		{
			get => GetProperty(ref _backgroundSpeed);
			set => SetProperty(ref _backgroundSpeed, value);
		}

		[Ordinal(29)] 
		[RED("cameraFov")] 
		public CFloat CameraFov
		{
			get => GetProperty(ref _cameraFov);
			set => SetProperty(ref _cameraFov, value);
		}

		[Ordinal(30)] 
		[RED("cameraHeight")] 
		public CFloat CameraHeight
		{
			get => GetProperty(ref _cameraHeight);
			set => SetProperty(ref _cameraHeight, value);
		}

		[Ordinal(31)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetProperty(ref _startTime);
			set => SetProperty(ref _startTime, value);
		}

		[Ordinal(32)] 
		[RED("defaultMaxSpeed")] 
		public CFloat DefaultMaxSpeed
		{
			get => GetProperty(ref _defaultMaxSpeed);
			set => SetProperty(ref _defaultMaxSpeed, value);
		}

		[Ordinal(33)] 
		[RED("nitroMaxSpeed")] 
		public CFloat NitroMaxSpeed
		{
			get => GetProperty(ref _nitroMaxSpeed);
			set => SetProperty(ref _nitroMaxSpeed, value);
		}

		[Ordinal(34)] 
		[RED("acceleration")] 
		public CFloat Acceleration
		{
			get => GetProperty(ref _acceleration);
			set => SetProperty(ref _acceleration, value);
		}

		[Ordinal(35)] 
		[RED("breaking")] 
		public CFloat Breaking
		{
			get => GetProperty(ref _breaking);
			set => SetProperty(ref _breaking, value);
		}

		[Ordinal(36)] 
		[RED("deceleration")] 
		public CFloat Deceleration
		{
			get => GetProperty(ref _deceleration);
			set => SetProperty(ref _deceleration, value);
		}

		[Ordinal(37)] 
		[RED("offRoadLimit")] 
		public CFloat OffRoadLimit
		{
			get => GetProperty(ref _offRoadLimit);
			set => SetProperty(ref _offRoadLimit, value);
		}

		[Ordinal(38)] 
		[RED("offRoadDeceleration")] 
		public CFloat OffRoadDeceleration
		{
			get => GetProperty(ref _offRoadDeceleration);
			set => SetProperty(ref _offRoadDeceleration, value);
		}

		[Ordinal(39)] 
		[RED("centrifugalForce")] 
		public CFloat CentrifugalForce
		{
			get => GetProperty(ref _centrifugalForce);
			set => SetProperty(ref _centrifugalForce, value);
		}

		[Ordinal(40)] 
		[RED("playerSegmentOffset")] 
		public CInt32 PlayerSegmentOffset
		{
			get => GetProperty(ref _playerSegmentOffset);
			set => SetProperty(ref _playerSegmentOffset, value);
		}

		[Ordinal(41)] 
		[RED("timeLeftText")] 
		public inkTextWidgetReference TimeLeftText
		{
			get => GetProperty(ref _timeLeftText);
			set => SetProperty(ref _timeLeftText, value);
		}

		[Ordinal(42)] 
		[RED("scoreText")] 
		public inkTextWidgetReference ScoreText
		{
			get => GetProperty(ref _scoreText);
			set => SetProperty(ref _scoreText, value);
		}

		[Ordinal(43)] 
		[RED("speedText")] 
		public inkTextWidgetReference SpeedText
		{
			get => GetProperty(ref _speedText);
			set => SetProperty(ref _speedText, value);
		}

		[Ordinal(44)] 
		[RED("notificationText")] 
		public inkTextWidgetReference NotificationText
		{
			get => GetProperty(ref _notificationText);
			set => SetProperty(ref _notificationText, value);
		}

		[Ordinal(45)] 
		[RED("notificationAnimationName")] 
		public CName NotificationAnimationName
		{
			get => GetProperty(ref _notificationAnimationName);
			set => SetProperty(ref _notificationAnimationName, value);
		}

		[Ordinal(46)] 
		[RED("speedCoeficient")] 
		public CFloat SpeedCoeficient
		{
			get => GetProperty(ref _speedCoeficient);
			set => SetProperty(ref _speedCoeficient, value);
		}

		[Ordinal(47)] 
		[RED("currentNotificationAnimation")] 
		public CHandle<inkanimProxy> CurrentNotificationAnimation
		{
			get => GetProperty(ref _currentNotificationAnimation);
			set => SetProperty(ref _currentNotificationAnimation, value);
		}

		[Ordinal(48)] 
		[RED("lastTime")] 
		public CInt32 LastTime
		{
			get => GetProperty(ref _lastTime);
			set => SetProperty(ref _lastTime, value);
		}
	}
}

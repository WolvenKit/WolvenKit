using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerLogicController : gameuiSideScrollerMiniGameLogicController
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
			get
			{
				if (_endgameDelay == null)
				{
					_endgameDelay = (CFloat) CR2WTypeManager.Create("Float", "endgameDelay", cr2w, this);
				}
				return _endgameDelay;
			}
			set
			{
				if (_endgameDelay == value)
				{
					return;
				}
				_endgameDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("baseMultiplicatorScale")] 
		public CFloat BaseMultiplicatorScale
		{
			get
			{
				if (_baseMultiplicatorScale == null)
				{
					_baseMultiplicatorScale = (CFloat) CR2WTypeManager.Create("Float", "baseMultiplicatorScale", cr2w, this);
				}
				return _baseMultiplicatorScale;
			}
			set
			{
				if (_baseMultiplicatorScale == value)
				{
					return;
				}
				_baseMultiplicatorScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("skyWidget")] 
		public inkWidgetReference SkyWidget
		{
			get
			{
				if (_skyWidget == null)
				{
					_skyWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "skyWidget", cr2w, this);
				}
				return _skyWidget;
			}
			set
			{
				if (_skyWidget == value)
				{
					return;
				}
				_skyWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("road")] 
		public CArray<gameuiRoadEditorSegment> Road
		{
			get
			{
				if (_road == null)
				{
					_road = (CArray<gameuiRoadEditorSegment>) CR2WTypeManager.Create("array:gameuiRoadEditorSegment", "road", cr2w, this);
				}
				return _road;
			}
			set
			{
				if (_road == value)
				{
					return;
				}
				_road = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("checkpointLibraryName")] 
		public CName CheckpointLibraryName
		{
			get
			{
				if (_checkpointLibraryName == null)
				{
					_checkpointLibraryName = (CName) CR2WTypeManager.Create("CName", "checkpointLibraryName", cr2w, this);
				}
				return _checkpointLibraryName;
			}
			set
			{
				if (_checkpointLibraryName == value)
				{
					return;
				}
				_checkpointLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("roadLibraryName")] 
		public CName RoadLibraryName
		{
			get
			{
				if (_roadLibraryName == null)
				{
					_roadLibraryName = (CName) CR2WTypeManager.Create("CName", "roadLibraryName", cr2w, this);
				}
				return _roadLibraryName;
			}
			set
			{
				if (_roadLibraryName == value)
				{
					return;
				}
				_roadLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("backgroundLibraryName")] 
		public CName BackgroundLibraryName
		{
			get
			{
				if (_backgroundLibraryName == null)
				{
					_backgroundLibraryName = (CName) CR2WTypeManager.Create("CName", "backgroundLibraryName", cr2w, this);
				}
				return _backgroundLibraryName;
			}
			set
			{
				if (_backgroundLibraryName == value)
				{
					return;
				}
				_backgroundLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("timeToPassCheckpoint")] 
		public CFloat TimeToPassCheckpoint
		{
			get
			{
				if (_timeToPassCheckpoint == null)
				{
					_timeToPassCheckpoint = (CFloat) CR2WTypeManager.Create("Float", "timeToPassCheckpoint", cr2w, this);
				}
				return _timeToPassCheckpoint;
			}
			set
			{
				if (_timeToPassCheckpoint == value)
				{
					return;
				}
				_timeToPassCheckpoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("scorePerMeter")] 
		public CInt32 ScorePerMeter
		{
			get
			{
				if (_scorePerMeter == null)
				{
					_scorePerMeter = (CInt32) CR2WTypeManager.Create("Int32", "scorePerMeter", cr2w, this);
				}
				return _scorePerMeter;
			}
			set
			{
				if (_scorePerMeter == value)
				{
					return;
				}
				_scorePerMeter = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("scorePerExtraSecond")] 
		public CInt32 ScorePerExtraSecond
		{
			get
			{
				if (_scorePerExtraSecond == null)
				{
					_scorePerExtraSecond = (CInt32) CR2WTypeManager.Create("Int32", "scorePerExtraSecond", cr2w, this);
				}
				return _scorePerExtraSecond;
			}
			set
			{
				if (_scorePerExtraSecond == value)
				{
					return;
				}
				_scorePerExtraSecond = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("bonusTime")] 
		public CFloat BonusTime
		{
			get
			{
				if (_bonusTime == null)
				{
					_bonusTime = (CFloat) CR2WTypeManager.Create("Float", "bonusTime", cr2w, this);
				}
				return _bonusTime;
			}
			set
			{
				if (_bonusTime == value)
				{
					return;
				}
				_bonusTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("backgroundStitch")] 
		public CFloat BackgroundStitch
		{
			get
			{
				if (_backgroundStitch == null)
				{
					_backgroundStitch = (CFloat) CR2WTypeManager.Create("Float", "backgroundStitch", cr2w, this);
				}
				return _backgroundStitch;
			}
			set
			{
				if (_backgroundStitch == value)
				{
					return;
				}
				_backgroundStitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("drawDistance")] 
		public CUInt32 DrawDistance
		{
			get
			{
				if (_drawDistance == null)
				{
					_drawDistance = (CUInt32) CR2WTypeManager.Create("Uint32", "drawDistance", cr2w, this);
				}
				return _drawDistance;
			}
			set
			{
				if (_drawDistance == value)
				{
					return;
				}
				_drawDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("carDistanceOfView")] 
		public CInt32 CarDistanceOfView
		{
			get
			{
				if (_carDistanceOfView == null)
				{
					_carDistanceOfView = (CInt32) CR2WTypeManager.Create("Int32", "carDistanceOfView", cr2w, this);
				}
				return _carDistanceOfView;
			}
			set
			{
				if (_carDistanceOfView == value)
				{
					return;
				}
				_carDistanceOfView = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("colorBlindDrawDistance")] 
		public CUInt32 ColorBlindDrawDistance
		{
			get
			{
				if (_colorBlindDrawDistance == null)
				{
					_colorBlindDrawDistance = (CUInt32) CR2WTypeManager.Create("Uint32", "colorBlindDrawDistance", cr2w, this);
				}
				return _colorBlindDrawDistance;
			}
			set
			{
				if (_colorBlindDrawDistance == value)
				{
					return;
				}
				_colorBlindDrawDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("segmentDetails")] 
		public CUInt32 SegmentDetails
		{
			get
			{
				if (_segmentDetails == null)
				{
					_segmentDetails = (CUInt32) CR2WTypeManager.Create("Uint32", "segmentDetails", cr2w, this);
				}
				return _segmentDetails;
			}
			set
			{
				if (_segmentDetails == value)
				{
					return;
				}
				_segmentDetails = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("segmentLength")] 
		public CFloat SegmentLength
		{
			get
			{
				if (_segmentLength == null)
				{
					_segmentLength = (CFloat) CR2WTypeManager.Create("Float", "segmentLength", cr2w, this);
				}
				return _segmentLength;
			}
			set
			{
				if (_segmentLength == value)
				{
					return;
				}
				_segmentLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("roadWidth")] 
		public CFloat RoadWidth
		{
			get
			{
				if (_roadWidth == null)
				{
					_roadWidth = (CFloat) CR2WTypeManager.Create("Float", "roadWidth", cr2w, this);
				}
				return _roadWidth;
			}
			set
			{
				if (_roadWidth == value)
				{
					return;
				}
				_roadWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("backgroundSpeed")] 
		public CFloat BackgroundSpeed
		{
			get
			{
				if (_backgroundSpeed == null)
				{
					_backgroundSpeed = (CFloat) CR2WTypeManager.Create("Float", "backgroundSpeed", cr2w, this);
				}
				return _backgroundSpeed;
			}
			set
			{
				if (_backgroundSpeed == value)
				{
					return;
				}
				_backgroundSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("cameraFov")] 
		public CFloat CameraFov
		{
			get
			{
				if (_cameraFov == null)
				{
					_cameraFov = (CFloat) CR2WTypeManager.Create("Float", "cameraFov", cr2w, this);
				}
				return _cameraFov;
			}
			set
			{
				if (_cameraFov == value)
				{
					return;
				}
				_cameraFov = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("cameraHeight")] 
		public CFloat CameraHeight
		{
			get
			{
				if (_cameraHeight == null)
				{
					_cameraHeight = (CFloat) CR2WTypeManager.Create("Float", "cameraHeight", cr2w, this);
				}
				return _cameraHeight;
			}
			set
			{
				if (_cameraHeight == value)
				{
					return;
				}
				_cameraHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get
			{
				if (_startTime == null)
				{
					_startTime = (CFloat) CR2WTypeManager.Create("Float", "startTime", cr2w, this);
				}
				return _startTime;
			}
			set
			{
				if (_startTime == value)
				{
					return;
				}
				_startTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("defaultMaxSpeed")] 
		public CFloat DefaultMaxSpeed
		{
			get
			{
				if (_defaultMaxSpeed == null)
				{
					_defaultMaxSpeed = (CFloat) CR2WTypeManager.Create("Float", "defaultMaxSpeed", cr2w, this);
				}
				return _defaultMaxSpeed;
			}
			set
			{
				if (_defaultMaxSpeed == value)
				{
					return;
				}
				_defaultMaxSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("nitroMaxSpeed")] 
		public CFloat NitroMaxSpeed
		{
			get
			{
				if (_nitroMaxSpeed == null)
				{
					_nitroMaxSpeed = (CFloat) CR2WTypeManager.Create("Float", "nitroMaxSpeed", cr2w, this);
				}
				return _nitroMaxSpeed;
			}
			set
			{
				if (_nitroMaxSpeed == value)
				{
					return;
				}
				_nitroMaxSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("acceleration")] 
		public CFloat Acceleration
		{
			get
			{
				if (_acceleration == null)
				{
					_acceleration = (CFloat) CR2WTypeManager.Create("Float", "acceleration", cr2w, this);
				}
				return _acceleration;
			}
			set
			{
				if (_acceleration == value)
				{
					return;
				}
				_acceleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("breaking")] 
		public CFloat Breaking
		{
			get
			{
				if (_breaking == null)
				{
					_breaking = (CFloat) CR2WTypeManager.Create("Float", "breaking", cr2w, this);
				}
				return _breaking;
			}
			set
			{
				if (_breaking == value)
				{
					return;
				}
				_breaking = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("deceleration")] 
		public CFloat Deceleration
		{
			get
			{
				if (_deceleration == null)
				{
					_deceleration = (CFloat) CR2WTypeManager.Create("Float", "deceleration", cr2w, this);
				}
				return _deceleration;
			}
			set
			{
				if (_deceleration == value)
				{
					return;
				}
				_deceleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("offRoadLimit")] 
		public CFloat OffRoadLimit
		{
			get
			{
				if (_offRoadLimit == null)
				{
					_offRoadLimit = (CFloat) CR2WTypeManager.Create("Float", "offRoadLimit", cr2w, this);
				}
				return _offRoadLimit;
			}
			set
			{
				if (_offRoadLimit == value)
				{
					return;
				}
				_offRoadLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("offRoadDeceleration")] 
		public CFloat OffRoadDeceleration
		{
			get
			{
				if (_offRoadDeceleration == null)
				{
					_offRoadDeceleration = (CFloat) CR2WTypeManager.Create("Float", "offRoadDeceleration", cr2w, this);
				}
				return _offRoadDeceleration;
			}
			set
			{
				if (_offRoadDeceleration == value)
				{
					return;
				}
				_offRoadDeceleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("centrifugalForce")] 
		public CFloat CentrifugalForce
		{
			get
			{
				if (_centrifugalForce == null)
				{
					_centrifugalForce = (CFloat) CR2WTypeManager.Create("Float", "centrifugalForce", cr2w, this);
				}
				return _centrifugalForce;
			}
			set
			{
				if (_centrifugalForce == value)
				{
					return;
				}
				_centrifugalForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("playerSegmentOffset")] 
		public CInt32 PlayerSegmentOffset
		{
			get
			{
				if (_playerSegmentOffset == null)
				{
					_playerSegmentOffset = (CInt32) CR2WTypeManager.Create("Int32", "playerSegmentOffset", cr2w, this);
				}
				return _playerSegmentOffset;
			}
			set
			{
				if (_playerSegmentOffset == value)
				{
					return;
				}
				_playerSegmentOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("timeLeftText")] 
		public inkTextWidgetReference TimeLeftText
		{
			get
			{
				if (_timeLeftText == null)
				{
					_timeLeftText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "timeLeftText", cr2w, this);
				}
				return _timeLeftText;
			}
			set
			{
				if (_timeLeftText == value)
				{
					return;
				}
				_timeLeftText = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("scoreText")] 
		public inkTextWidgetReference ScoreText
		{
			get
			{
				if (_scoreText == null)
				{
					_scoreText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "scoreText", cr2w, this);
				}
				return _scoreText;
			}
			set
			{
				if (_scoreText == value)
				{
					return;
				}
				_scoreText = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("speedText")] 
		public inkTextWidgetReference SpeedText
		{
			get
			{
				if (_speedText == null)
				{
					_speedText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "speedText", cr2w, this);
				}
				return _speedText;
			}
			set
			{
				if (_speedText == value)
				{
					return;
				}
				_speedText = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("notificationText")] 
		public inkTextWidgetReference NotificationText
		{
			get
			{
				if (_notificationText == null)
				{
					_notificationText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "notificationText", cr2w, this);
				}
				return _notificationText;
			}
			set
			{
				if (_notificationText == value)
				{
					return;
				}
				_notificationText = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("notificationAnimationName")] 
		public CName NotificationAnimationName
		{
			get
			{
				if (_notificationAnimationName == null)
				{
					_notificationAnimationName = (CName) CR2WTypeManager.Create("CName", "notificationAnimationName", cr2w, this);
				}
				return _notificationAnimationName;
			}
			set
			{
				if (_notificationAnimationName == value)
				{
					return;
				}
				_notificationAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("speedCoeficient")] 
		public CFloat SpeedCoeficient
		{
			get
			{
				if (_speedCoeficient == null)
				{
					_speedCoeficient = (CFloat) CR2WTypeManager.Create("Float", "speedCoeficient", cr2w, this);
				}
				return _speedCoeficient;
			}
			set
			{
				if (_speedCoeficient == value)
				{
					return;
				}
				_speedCoeficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("currentNotificationAnimation")] 
		public CHandle<inkanimProxy> CurrentNotificationAnimation
		{
			get
			{
				if (_currentNotificationAnimation == null)
				{
					_currentNotificationAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "currentNotificationAnimation", cr2w, this);
				}
				return _currentNotificationAnimation;
			}
			set
			{
				if (_currentNotificationAnimation == value)
				{
					return;
				}
				_currentNotificationAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("lastTime")] 
		public CInt32 LastTime
		{
			get
			{
				if (_lastTime == null)
				{
					_lastTime = (CInt32) CR2WTypeManager.Create("Int32", "lastTime", cr2w, this);
				}
				return _lastTime;
			}
			set
			{
				if (_lastTime == value)
				{
					return;
				}
				_lastTime = value;
				PropertySet(this);
			}
		}

		public gameuiQuadRacerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

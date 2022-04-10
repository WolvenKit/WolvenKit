using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiQuadRacerLogicController : gameuiSideScrollerMiniGameLogicController
	{
		[Ordinal(10)] 
		[RED("endgameDelay")] 
		public CFloat EndgameDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("baseMultiplicatorScale")] 
		public CFloat BaseMultiplicatorScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("skyWidget")] 
		public inkWidgetReference SkyWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("road")] 
		public CArray<gameuiRoadEditorSegment> Road
		{
			get => GetPropertyValue<CArray<gameuiRoadEditorSegment>>();
			set => SetPropertyValue<CArray<gameuiRoadEditorSegment>>(value);
		}

		[Ordinal(14)] 
		[RED("checkpointLibraryName")] 
		public CName CheckpointLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("roadLibraryName")] 
		public CName RoadLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("backgroundLibraryName")] 
		public CName BackgroundLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("timeToPassCheckpoint")] 
		public CFloat TimeToPassCheckpoint
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("scorePerMeter")] 
		public CInt32 ScorePerMeter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("scorePerExtraSecond")] 
		public CInt32 ScorePerExtraSecond
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("bonusTime")] 
		public CFloat BonusTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("backgroundStitch")] 
		public CFloat BackgroundStitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("drawDistance")] 
		public CUInt32 DrawDistance
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(23)] 
		[RED("carDistanceOfView")] 
		public CInt32 CarDistanceOfView
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("colorBlindDrawDistance")] 
		public CUInt32 ColorBlindDrawDistance
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(25)] 
		[RED("segmentDetails")] 
		public CUInt32 SegmentDetails
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(26)] 
		[RED("segmentLength")] 
		public CFloat SegmentLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("roadWidth")] 
		public CFloat RoadWidth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("backgroundSpeed")] 
		public CFloat BackgroundSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("cameraFov")] 
		public CFloat CameraFov
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("cameraHeight")] 
		public CFloat CameraHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("defaultMaxSpeed")] 
		public CFloat DefaultMaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("nitroMaxSpeed")] 
		public CFloat NitroMaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("acceleration")] 
		public CFloat Acceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("breaking")] 
		public CFloat Breaking
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("deceleration")] 
		public CFloat Deceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("offRoadLimit")] 
		public CFloat OffRoadLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("offRoadDeceleration")] 
		public CFloat OffRoadDeceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("centrifugalForce")] 
		public CFloat CentrifugalForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(40)] 
		[RED("playerSegmentOffset")] 
		public CInt32 PlayerSegmentOffset
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(41)] 
		[RED("timeLeftText")] 
		public inkTextWidgetReference TimeLeftText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("scoreText")] 
		public inkTextWidgetReference ScoreText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("speedText")] 
		public inkTextWidgetReference SpeedText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("notificationText")] 
		public inkTextWidgetReference NotificationText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("notificationAnimationName")] 
		public CName NotificationAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(46)] 
		[RED("speedCoeficient")] 
		public CFloat SpeedCoeficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
		[RED("currentNotificationAnimation")] 
		public CHandle<inkanimProxy> CurrentNotificationAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(48)] 
		[RED("lastTime")] 
		public CInt32 LastTime
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiQuadRacerLogicController()
		{
			SkyWidget = new();
			Road = new();
			SegmentDetails = 1;
			CameraFov = 80.000000F;
			CameraHeight = 1000.000000F;
			TimeLeftText = new();
			ScoreText = new();
			SpeedText = new();
			NotificationText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class hudTurretController : gameuiHUDGameController
	{
		private inkTextWidgetReference _date;
		private inkTextWidgetReference _timer;
		private inkTextWidgetReference _cameraID;
		private inkTextWidgetReference _healthStatus;
		private inkTextWidgetReference _messageText;
		private inkTextWidgetReference _pitchFluff;
		private inkTextWidgetReference _yawFluff;
		private inkWidgetReference _leftPart;
		private inkWidgetReference _rightPart;
		private CFloat _offsetLeft;
		private CFloat _offsetRight;
		private GameTime _currentTime;
		private CWeakHandle<gameIBlackboard> _bbPlayerStats;
		private CHandle<redCallbackObject> _bbPlayerEventId;
		private CInt32 _currentHealth;
		private CInt32 _previousHealth;
		private CInt32 _maximumHealth;
		private CWeakHandle<gameObject> _playerObject;
		private CWeakHandle<gameObject> _playerPuppet;
		private ScriptGameInstance _gameInstance;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(9)] 
		[RED("Date")] 
		public inkTextWidgetReference Date
		{
			get => GetProperty(ref _date);
			set => SetProperty(ref _date, value);
		}

		[Ordinal(10)] 
		[RED("Timer")] 
		public inkTextWidgetReference Timer
		{
			get => GetProperty(ref _timer);
			set => SetProperty(ref _timer, value);
		}

		[Ordinal(11)] 
		[RED("CameraID")] 
		public inkTextWidgetReference CameraID
		{
			get => GetProperty(ref _cameraID);
			set => SetProperty(ref _cameraID, value);
		}

		[Ordinal(12)] 
		[RED("healthStatus")] 
		public inkTextWidgetReference HealthStatus
		{
			get => GetProperty(ref _healthStatus);
			set => SetProperty(ref _healthStatus, value);
		}

		[Ordinal(13)] 
		[RED("MessageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetProperty(ref _messageText);
			set => SetProperty(ref _messageText, value);
		}

		[Ordinal(14)] 
		[RED("pitchFluff")] 
		public inkTextWidgetReference PitchFluff
		{
			get => GetProperty(ref _pitchFluff);
			set => SetProperty(ref _pitchFluff, value);
		}

		[Ordinal(15)] 
		[RED("yawFluff")] 
		public inkTextWidgetReference YawFluff
		{
			get => GetProperty(ref _yawFluff);
			set => SetProperty(ref _yawFluff, value);
		}

		[Ordinal(16)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(17)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(18)] 
		[RED("offsetLeft")] 
		public CFloat OffsetLeft
		{
			get => GetProperty(ref _offsetLeft);
			set => SetProperty(ref _offsetLeft, value);
		}

		[Ordinal(19)] 
		[RED("offsetRight")] 
		public CFloat OffsetRight
		{
			get => GetProperty(ref _offsetRight);
			set => SetProperty(ref _offsetRight, value);
		}

		[Ordinal(20)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get => GetProperty(ref _currentTime);
			set => SetProperty(ref _currentTime, value);
		}

		[Ordinal(21)] 
		[RED("bbPlayerStats")] 
		public CWeakHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetProperty(ref _bbPlayerStats);
			set => SetProperty(ref _bbPlayerStats, value);
		}

		[Ordinal(22)] 
		[RED("bbPlayerEventId")] 
		public CHandle<redCallbackObject> BbPlayerEventId
		{
			get => GetProperty(ref _bbPlayerEventId);
			set => SetProperty(ref _bbPlayerEventId, value);
		}

		[Ordinal(23)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(24)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get => GetProperty(ref _previousHealth);
			set => SetProperty(ref _previousHealth, value);
		}

		[Ordinal(25)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetProperty(ref _maximumHealth);
			set => SetProperty(ref _maximumHealth, value);
		}

		[Ordinal(26)] 
		[RED("playerObject")] 
		public CWeakHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}

		[Ordinal(27)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(28)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(29)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		public hudTurretController()
		{
			_offsetLeft = -838.000000F;
			_offsetRight = 1495.000000F;
		}
	}
}

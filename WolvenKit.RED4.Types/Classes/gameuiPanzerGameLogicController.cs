using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPanzerGameLogicController : gameuiSideScrollerMiniGameLogicControllerAdvanced
	{
		private CFloat _gameOverDelay;
		private CName _mainMenuLibraryName;
		private CName _scoreboardLibraryName;
		private CName _panelsLayer;
		private CName _gameLayer;
		private CName _cloudsLayer;
		private CName _backgroundLibraryName;
		private CArray<CName> _cloudsLibraryNames;
		private CFloat _minCloudSpawnInterval;
		private CFloat _maxCloudSpawnInterval;
		private CFloat _minCloudSpeed;
		private CFloat _maxCloudSpeed;
		private inkTextWidgetReference _scoreCounter;
		private inkTextWidgetReference _livesCounter;
		private CName _moveUpKey;
		private CName _moveDownKey;
		private CName _moveLeftKey;
		private CName _moveRightKey;
		private CName _shootKey;
		private CName _backKey;
		private CName _submitKey;
		private CFloat _axisDeadZone;
		private CName _moveXAxis;
		private CName _moveYAxis;
		private CName _shootAxis;
		private CName _droneLibraryName;
		private CFloat _minDroneSpawnInterval;
		private CFloat _maxDroneSpawnInterval;
		private CName _avLibraryName;
		private CFloat _minAvSpawnInterval;
		private CFloat _maxAvSpawnInterval;

		[Ordinal(9)] 
		[RED("gameOverDelay")] 
		public CFloat GameOverDelay
		{
			get => GetProperty(ref _gameOverDelay);
			set => SetProperty(ref _gameOverDelay, value);
		}

		[Ordinal(10)] 
		[RED("mainMenuLibraryName")] 
		public CName MainMenuLibraryName
		{
			get => GetProperty(ref _mainMenuLibraryName);
			set => SetProperty(ref _mainMenuLibraryName, value);
		}

		[Ordinal(11)] 
		[RED("scoreboardLibraryName")] 
		public CName ScoreboardLibraryName
		{
			get => GetProperty(ref _scoreboardLibraryName);
			set => SetProperty(ref _scoreboardLibraryName, value);
		}

		[Ordinal(12)] 
		[RED("panelsLayer")] 
		public CName PanelsLayer
		{
			get => GetProperty(ref _panelsLayer);
			set => SetProperty(ref _panelsLayer, value);
		}

		[Ordinal(13)] 
		[RED("gameLayer")] 
		public CName GameLayer
		{
			get => GetProperty(ref _gameLayer);
			set => SetProperty(ref _gameLayer, value);
		}

		[Ordinal(14)] 
		[RED("cloudsLayer")] 
		public CName CloudsLayer
		{
			get => GetProperty(ref _cloudsLayer);
			set => SetProperty(ref _cloudsLayer, value);
		}

		[Ordinal(15)] 
		[RED("backgroundLibraryName")] 
		public CName BackgroundLibraryName
		{
			get => GetProperty(ref _backgroundLibraryName);
			set => SetProperty(ref _backgroundLibraryName, value);
		}

		[Ordinal(16)] 
		[RED("cloudsLibraryNames")] 
		public CArray<CName> CloudsLibraryNames
		{
			get => GetProperty(ref _cloudsLibraryNames);
			set => SetProperty(ref _cloudsLibraryNames, value);
		}

		[Ordinal(17)] 
		[RED("minCloudSpawnInterval")] 
		public CFloat MinCloudSpawnInterval
		{
			get => GetProperty(ref _minCloudSpawnInterval);
			set => SetProperty(ref _minCloudSpawnInterval, value);
		}

		[Ordinal(18)] 
		[RED("maxCloudSpawnInterval")] 
		public CFloat MaxCloudSpawnInterval
		{
			get => GetProperty(ref _maxCloudSpawnInterval);
			set => SetProperty(ref _maxCloudSpawnInterval, value);
		}

		[Ordinal(19)] 
		[RED("minCloudSpeed")] 
		public CFloat MinCloudSpeed
		{
			get => GetProperty(ref _minCloudSpeed);
			set => SetProperty(ref _minCloudSpeed, value);
		}

		[Ordinal(20)] 
		[RED("maxCloudSpeed")] 
		public CFloat MaxCloudSpeed
		{
			get => GetProperty(ref _maxCloudSpeed);
			set => SetProperty(ref _maxCloudSpeed, value);
		}

		[Ordinal(21)] 
		[RED("scoreCounter")] 
		public inkTextWidgetReference ScoreCounter
		{
			get => GetProperty(ref _scoreCounter);
			set => SetProperty(ref _scoreCounter, value);
		}

		[Ordinal(22)] 
		[RED("livesCounter")] 
		public inkTextWidgetReference LivesCounter
		{
			get => GetProperty(ref _livesCounter);
			set => SetProperty(ref _livesCounter, value);
		}

		[Ordinal(23)] 
		[RED("moveUpKey")] 
		public CName MoveUpKey
		{
			get => GetProperty(ref _moveUpKey);
			set => SetProperty(ref _moveUpKey, value);
		}

		[Ordinal(24)] 
		[RED("moveDownKey")] 
		public CName MoveDownKey
		{
			get => GetProperty(ref _moveDownKey);
			set => SetProperty(ref _moveDownKey, value);
		}

		[Ordinal(25)] 
		[RED("moveLeftKey")] 
		public CName MoveLeftKey
		{
			get => GetProperty(ref _moveLeftKey);
			set => SetProperty(ref _moveLeftKey, value);
		}

		[Ordinal(26)] 
		[RED("moveRightKey")] 
		public CName MoveRightKey
		{
			get => GetProperty(ref _moveRightKey);
			set => SetProperty(ref _moveRightKey, value);
		}

		[Ordinal(27)] 
		[RED("shootKey")] 
		public CName ShootKey
		{
			get => GetProperty(ref _shootKey);
			set => SetProperty(ref _shootKey, value);
		}

		[Ordinal(28)] 
		[RED("backKey")] 
		public CName BackKey
		{
			get => GetProperty(ref _backKey);
			set => SetProperty(ref _backKey, value);
		}

		[Ordinal(29)] 
		[RED("submitKey")] 
		public CName SubmitKey
		{
			get => GetProperty(ref _submitKey);
			set => SetProperty(ref _submitKey, value);
		}

		[Ordinal(30)] 
		[RED("axisDeadZone")] 
		public CFloat AxisDeadZone
		{
			get => GetProperty(ref _axisDeadZone);
			set => SetProperty(ref _axisDeadZone, value);
		}

		[Ordinal(31)] 
		[RED("moveXAxis")] 
		public CName MoveXAxis
		{
			get => GetProperty(ref _moveXAxis);
			set => SetProperty(ref _moveXAxis, value);
		}

		[Ordinal(32)] 
		[RED("moveYAxis")] 
		public CName MoveYAxis
		{
			get => GetProperty(ref _moveYAxis);
			set => SetProperty(ref _moveYAxis, value);
		}

		[Ordinal(33)] 
		[RED("shootAxis")] 
		public CName ShootAxis
		{
			get => GetProperty(ref _shootAxis);
			set => SetProperty(ref _shootAxis, value);
		}

		[Ordinal(34)] 
		[RED("droneLibraryName")] 
		public CName DroneLibraryName
		{
			get => GetProperty(ref _droneLibraryName);
			set => SetProperty(ref _droneLibraryName, value);
		}

		[Ordinal(35)] 
		[RED("minDroneSpawnInterval")] 
		public CFloat MinDroneSpawnInterval
		{
			get => GetProperty(ref _minDroneSpawnInterval);
			set => SetProperty(ref _minDroneSpawnInterval, value);
		}

		[Ordinal(36)] 
		[RED("maxDroneSpawnInterval")] 
		public CFloat MaxDroneSpawnInterval
		{
			get => GetProperty(ref _maxDroneSpawnInterval);
			set => SetProperty(ref _maxDroneSpawnInterval, value);
		}

		[Ordinal(37)] 
		[RED("avLibraryName")] 
		public CName AvLibraryName
		{
			get => GetProperty(ref _avLibraryName);
			set => SetProperty(ref _avLibraryName, value);
		}

		[Ordinal(38)] 
		[RED("minAvSpawnInterval")] 
		public CFloat MinAvSpawnInterval
		{
			get => GetProperty(ref _minAvSpawnInterval);
			set => SetProperty(ref _minAvSpawnInterval, value);
		}

		[Ordinal(39)] 
		[RED("maxAvSpawnInterval")] 
		public CFloat MaxAvSpawnInterval
		{
			get => GetProperty(ref _maxAvSpawnInterval);
			set => SetProperty(ref _maxAvSpawnInterval, value);
		}

		public gameuiPanzerGameLogicController()
		{
			_gameOverDelay = 2.000000F;
			_moveUpKey = "CameraStepPitchUp";
			_moveDownKey = "CameraStepPitchDown";
			_moveLeftKey = "CameraStepYawLeft";
			_moveRightKey = "CameraStepYawRight";
			_shootKey = "CameraStepUp";
			_backKey = "CameraStepDown";
			_submitKey = "click";
			_axisDeadZone = 0.050000F;
			_moveXAxis = "left_stick_x";
			_moveYAxis = "left_stick_y";
			_shootAxis = "right_trigger";
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPanzerHUDGameController : gameuiHUDGameController
	{
		private CWeakHandle<vehicleBaseObject> _vehicle;
		private CHandle<VehicleComponentPS> _vehiclePS;
		private inkTextWidgetReference _date;
		private inkTextWidgetReference _timer;
		private inkTextWidgetReference _healthStatus;
		private inkWidgetReference _healthBar;
		private CFloat _rightStickX;
		private CFloat _rightStickY;
		private inkCanvasWidgetReference _leanAngleValue;
		private inkCanvasWidgetReference _coriRotation;
		private inkCanvasWidgetReference _compassRotation;
		private inkCanvasWidgetReference _cori_S;
		private inkCanvasWidgetReference _cori_M;
		private inkImageWidgetReference _trimmerArrow;
		private inkTextWidgetReference _speedValue;
		private inkTextWidgetReference _rPMValue;
		private CWeakHandle<gameIBlackboard> _scanBlackboard;
		private CWeakHandle<gameIBlackboard> _psmBlackboard;
		private CHandle<redCallbackObject> _pSM_BBID;
		private CWeakHandle<inkCompoundWidget> _root;
		private CFloat _currentZoom;
		private GameTime _currentTime;
		private CWeakHandle<gameIBlackboard> _vehicleBlackboard;
		private CWeakHandle<gameIBlackboard> _activeVehicleUIBlackboard;
		private CHandle<redCallbackObject> _vehicleBBStateConectionId;
		private CHandle<redCallbackObject> _speedBBConnectionId;
		private CHandle<redCallbackObject> _gearBBConnectionId;
		private CHandle<redCallbackObject> _tppBBConnectionId;
		private CHandle<redCallbackObject> _rpmValueBBConnectionId;
		private CHandle<redCallbackObject> _leanAngleBBConnectionId;
		private CHandle<redCallbackObject> _playerStateBBConnectionId;
		private CHandle<redCallbackObject> _isTargetingFriendlyConnectionId;
		private CWeakHandle<gameIBlackboard> _bbPlayerStats;
		private CHandle<redCallbackObject> _bbPlayerEventId;
		private CInt32 _currentHealth;
		private CInt32 _previousHealth;
		private CInt32 _maximumHealth;
		private CFloat _quickhacksMemoryPercent;
		private CWeakHandle<gameObject> _playerObject;
		private CWeakHandle<gameIBlackboard> _weaponBlackboard;
		private CHandle<redCallbackObject> _weaponParamsListenerId;
		private CArray<TargetIndicatorEntry> _targetIndicators;
		private inkCompoundWidgetReference _targetHolder;
		private CName _targetWidgetLibraryName;
		private CInt32 _targetWidgetPoolSize;

		[Ordinal(9)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(10)] 
		[RED("vehiclePS")] 
		public CHandle<VehicleComponentPS> VehiclePS
		{
			get => GetProperty(ref _vehiclePS);
			set => SetProperty(ref _vehiclePS, value);
		}

		[Ordinal(11)] 
		[RED("Date")] 
		public inkTextWidgetReference Date
		{
			get => GetProperty(ref _date);
			set => SetProperty(ref _date, value);
		}

		[Ordinal(12)] 
		[RED("Timer")] 
		public inkTextWidgetReference Timer
		{
			get => GetProperty(ref _timer);
			set => SetProperty(ref _timer, value);
		}

		[Ordinal(13)] 
		[RED("healthStatus")] 
		public inkTextWidgetReference HealthStatus
		{
			get => GetProperty(ref _healthStatus);
			set => SetProperty(ref _healthStatus, value);
		}

		[Ordinal(14)] 
		[RED("healthBar")] 
		public inkWidgetReference HealthBar
		{
			get => GetProperty(ref _healthBar);
			set => SetProperty(ref _healthBar, value);
		}

		[Ordinal(15)] 
		[RED("rightStickX")] 
		public CFloat RightStickX
		{
			get => GetProperty(ref _rightStickX);
			set => SetProperty(ref _rightStickX, value);
		}

		[Ordinal(16)] 
		[RED("rightStickY")] 
		public CFloat RightStickY
		{
			get => GetProperty(ref _rightStickY);
			set => SetProperty(ref _rightStickY, value);
		}

		[Ordinal(17)] 
		[RED("LeanAngleValue")] 
		public inkCanvasWidgetReference LeanAngleValue
		{
			get => GetProperty(ref _leanAngleValue);
			set => SetProperty(ref _leanAngleValue, value);
		}

		[Ordinal(18)] 
		[RED("CoriRotation")] 
		public inkCanvasWidgetReference CoriRotation
		{
			get => GetProperty(ref _coriRotation);
			set => SetProperty(ref _coriRotation, value);
		}

		[Ordinal(19)] 
		[RED("CompassRotation")] 
		public inkCanvasWidgetReference CompassRotation
		{
			get => GetProperty(ref _compassRotation);
			set => SetProperty(ref _compassRotation, value);
		}

		[Ordinal(20)] 
		[RED("Cori_S")] 
		public inkCanvasWidgetReference Cori_S
		{
			get => GetProperty(ref _cori_S);
			set => SetProperty(ref _cori_S, value);
		}

		[Ordinal(21)] 
		[RED("Cori_M")] 
		public inkCanvasWidgetReference Cori_M
		{
			get => GetProperty(ref _cori_M);
			set => SetProperty(ref _cori_M, value);
		}

		[Ordinal(22)] 
		[RED("trimmerArrow")] 
		public inkImageWidgetReference TrimmerArrow
		{
			get => GetProperty(ref _trimmerArrow);
			set => SetProperty(ref _trimmerArrow, value);
		}

		[Ordinal(23)] 
		[RED("SpeedValue")] 
		public inkTextWidgetReference SpeedValue
		{
			get => GetProperty(ref _speedValue);
			set => SetProperty(ref _speedValue, value);
		}

		[Ordinal(24)] 
		[RED("RPMValue")] 
		public inkTextWidgetReference RPMValue
		{
			get => GetProperty(ref _rPMValue);
			set => SetProperty(ref _rPMValue, value);
		}

		[Ordinal(25)] 
		[RED("scanBlackboard")] 
		public CWeakHandle<gameIBlackboard> ScanBlackboard
		{
			get => GetProperty(ref _scanBlackboard);
			set => SetProperty(ref _scanBlackboard, value);
		}

		[Ordinal(26)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(27)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetProperty(ref _pSM_BBID);
			set => SetProperty(ref _pSM_BBID, value);
		}

		[Ordinal(28)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(29)] 
		[RED("currentZoom")] 
		public CFloat CurrentZoom
		{
			get => GetProperty(ref _currentZoom);
			set => SetProperty(ref _currentZoom, value);
		}

		[Ordinal(30)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get => GetProperty(ref _currentTime);
			set => SetProperty(ref _currentTime, value);
		}

		[Ordinal(31)] 
		[RED("vehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetProperty(ref _vehicleBlackboard);
			set => SetProperty(ref _vehicleBlackboard, value);
		}

		[Ordinal(32)] 
		[RED("activeVehicleUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get => GetProperty(ref _activeVehicleUIBlackboard);
			set => SetProperty(ref _activeVehicleUIBlackboard, value);
		}

		[Ordinal(33)] 
		[RED("vehicleBBStateConectionId")] 
		public CHandle<redCallbackObject> VehicleBBStateConectionId
		{
			get => GetProperty(ref _vehicleBBStateConectionId);
			set => SetProperty(ref _vehicleBBStateConectionId, value);
		}

		[Ordinal(34)] 
		[RED("speedBBConnectionId")] 
		public CHandle<redCallbackObject> SpeedBBConnectionId
		{
			get => GetProperty(ref _speedBBConnectionId);
			set => SetProperty(ref _speedBBConnectionId, value);
		}

		[Ordinal(35)] 
		[RED("gearBBConnectionId")] 
		public CHandle<redCallbackObject> GearBBConnectionId
		{
			get => GetProperty(ref _gearBBConnectionId);
			set => SetProperty(ref _gearBBConnectionId, value);
		}

		[Ordinal(36)] 
		[RED("tppBBConnectionId")] 
		public CHandle<redCallbackObject> TppBBConnectionId
		{
			get => GetProperty(ref _tppBBConnectionId);
			set => SetProperty(ref _tppBBConnectionId, value);
		}

		[Ordinal(37)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetProperty(ref _rpmValueBBConnectionId);
			set => SetProperty(ref _rpmValueBBConnectionId, value);
		}

		[Ordinal(38)] 
		[RED("leanAngleBBConnectionId")] 
		public CHandle<redCallbackObject> LeanAngleBBConnectionId
		{
			get => GetProperty(ref _leanAngleBBConnectionId);
			set => SetProperty(ref _leanAngleBBConnectionId, value);
		}

		[Ordinal(39)] 
		[RED("playerStateBBConnectionId")] 
		public CHandle<redCallbackObject> PlayerStateBBConnectionId
		{
			get => GetProperty(ref _playerStateBBConnectionId);
			set => SetProperty(ref _playerStateBBConnectionId, value);
		}

		[Ordinal(40)] 
		[RED("isTargetingFriendlyConnectionId")] 
		public CHandle<redCallbackObject> IsTargetingFriendlyConnectionId
		{
			get => GetProperty(ref _isTargetingFriendlyConnectionId);
			set => SetProperty(ref _isTargetingFriendlyConnectionId, value);
		}

		[Ordinal(41)] 
		[RED("bbPlayerStats")] 
		public CWeakHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetProperty(ref _bbPlayerStats);
			set => SetProperty(ref _bbPlayerStats, value);
		}

		[Ordinal(42)] 
		[RED("bbPlayerEventId")] 
		public CHandle<redCallbackObject> BbPlayerEventId
		{
			get => GetProperty(ref _bbPlayerEventId);
			set => SetProperty(ref _bbPlayerEventId, value);
		}

		[Ordinal(43)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(44)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get => GetProperty(ref _previousHealth);
			set => SetProperty(ref _previousHealth, value);
		}

		[Ordinal(45)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetProperty(ref _maximumHealth);
			set => SetProperty(ref _maximumHealth, value);
		}

		[Ordinal(46)] 
		[RED("quickhacksMemoryPercent")] 
		public CFloat QuickhacksMemoryPercent
		{
			get => GetProperty(ref _quickhacksMemoryPercent);
			set => SetProperty(ref _quickhacksMemoryPercent, value);
		}

		[Ordinal(47)] 
		[RED("playerObject")] 
		public CWeakHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}

		[Ordinal(48)] 
		[RED("weaponBlackboard")] 
		public CWeakHandle<gameIBlackboard> WeaponBlackboard
		{
			get => GetProperty(ref _weaponBlackboard);
			set => SetProperty(ref _weaponBlackboard, value);
		}

		[Ordinal(49)] 
		[RED("weaponParamsListenerId")] 
		public CHandle<redCallbackObject> WeaponParamsListenerId
		{
			get => GetProperty(ref _weaponParamsListenerId);
			set => SetProperty(ref _weaponParamsListenerId, value);
		}

		[Ordinal(50)] 
		[RED("targetIndicators")] 
		public CArray<TargetIndicatorEntry> TargetIndicators
		{
			get => GetProperty(ref _targetIndicators);
			set => SetProperty(ref _targetIndicators, value);
		}

		[Ordinal(51)] 
		[RED("targetHolder")] 
		public inkCompoundWidgetReference TargetHolder
		{
			get => GetProperty(ref _targetHolder);
			set => SetProperty(ref _targetHolder, value);
		}

		[Ordinal(52)] 
		[RED("targetWidgetLibraryName")] 
		public CName TargetWidgetLibraryName
		{
			get => GetProperty(ref _targetWidgetLibraryName);
			set => SetProperty(ref _targetWidgetLibraryName, value);
		}

		[Ordinal(53)] 
		[RED("targetWidgetPoolSize")] 
		public CInt32 TargetWidgetPoolSize
		{
			get => GetProperty(ref _targetWidgetPoolSize);
			set => SetProperty(ref _targetWidgetPoolSize, value);
		}
	}
}

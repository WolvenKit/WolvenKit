using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerHUDGameController : gameuiHUDGameController
	{
		private wCHandle<vehicleBaseObject> _vehicle;
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
		private wCHandle<gameIBlackboard> _scanBlackboard;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private CUInt32 _pSM_BBID;
		private wCHandle<inkCompoundWidget> _root;
		private CFloat _currentZoom;
		private GameTime _currentTime;
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private wCHandle<gameIBlackboard> _activeVehicleUIBlackboard;
		private CUInt32 _vehicleBBStateConectionId;
		private CUInt32 _speedBBConnectionId;
		private CUInt32 _gearBBConnectionId;
		private CUInt32 _tppBBConnectionId;
		private CUInt32 _rpmValueBBConnectionId;
		private CUInt32 _leanAngleBBConnectionId;
		private CUInt32 _playerStateBBConnectionId;
		private CUInt32 _isTargetingFriendlyConnectionId;
		private CHandle<gameIBlackboard> _bbPlayerStats;
		private CUInt32 _bbPlayerEventId;
		private CInt32 _currentHealth;
		private CInt32 _previousHealth;
		private CInt32 _maximumHealth;
		private CFloat _quickhacksMemoryPercent;
		private wCHandle<gameObject> _playerObject;
		private wCHandle<gameIBlackboard> _weaponBlackboard;
		private CUInt32 _weaponParamsListenerId;
		private CArray<TargetIndicatorEntry> _targetIndicators;
		private inkCompoundWidgetReference _targetHolder;
		private CName _targetWidgetLibraryName;
		private CInt32 _targetWidgetPoolSize;

		[Ordinal(9)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
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
		public wCHandle<gameIBlackboard> ScanBlackboard
		{
			get => GetProperty(ref _scanBlackboard);
			set => SetProperty(ref _scanBlackboard, value);
		}

		[Ordinal(26)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(27)] 
		[RED("PSM_BBID")] 
		public CUInt32 PSM_BBID
		{
			get => GetProperty(ref _pSM_BBID);
			set => SetProperty(ref _pSM_BBID, value);
		}

		[Ordinal(28)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
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
		public wCHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetProperty(ref _vehicleBlackboard);
			set => SetProperty(ref _vehicleBlackboard, value);
		}

		[Ordinal(32)] 
		[RED("activeVehicleUIBlackboard")] 
		public wCHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get => GetProperty(ref _activeVehicleUIBlackboard);
			set => SetProperty(ref _activeVehicleUIBlackboard, value);
		}

		[Ordinal(33)] 
		[RED("vehicleBBStateConectionId")] 
		public CUInt32 VehicleBBStateConectionId
		{
			get => GetProperty(ref _vehicleBBStateConectionId);
			set => SetProperty(ref _vehicleBBStateConectionId, value);
		}

		[Ordinal(34)] 
		[RED("speedBBConnectionId")] 
		public CUInt32 SpeedBBConnectionId
		{
			get => GetProperty(ref _speedBBConnectionId);
			set => SetProperty(ref _speedBBConnectionId, value);
		}

		[Ordinal(35)] 
		[RED("gearBBConnectionId")] 
		public CUInt32 GearBBConnectionId
		{
			get => GetProperty(ref _gearBBConnectionId);
			set => SetProperty(ref _gearBBConnectionId, value);
		}

		[Ordinal(36)] 
		[RED("tppBBConnectionId")] 
		public CUInt32 TppBBConnectionId
		{
			get => GetProperty(ref _tppBBConnectionId);
			set => SetProperty(ref _tppBBConnectionId, value);
		}

		[Ordinal(37)] 
		[RED("rpmValueBBConnectionId")] 
		public CUInt32 RpmValueBBConnectionId
		{
			get => GetProperty(ref _rpmValueBBConnectionId);
			set => SetProperty(ref _rpmValueBBConnectionId, value);
		}

		[Ordinal(38)] 
		[RED("leanAngleBBConnectionId")] 
		public CUInt32 LeanAngleBBConnectionId
		{
			get => GetProperty(ref _leanAngleBBConnectionId);
			set => SetProperty(ref _leanAngleBBConnectionId, value);
		}

		[Ordinal(39)] 
		[RED("playerStateBBConnectionId")] 
		public CUInt32 PlayerStateBBConnectionId
		{
			get => GetProperty(ref _playerStateBBConnectionId);
			set => SetProperty(ref _playerStateBBConnectionId, value);
		}

		[Ordinal(40)] 
		[RED("isTargetingFriendlyConnectionId")] 
		public CUInt32 IsTargetingFriendlyConnectionId
		{
			get => GetProperty(ref _isTargetingFriendlyConnectionId);
			set => SetProperty(ref _isTargetingFriendlyConnectionId, value);
		}

		[Ordinal(41)] 
		[RED("bbPlayerStats")] 
		public CHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetProperty(ref _bbPlayerStats);
			set => SetProperty(ref _bbPlayerStats, value);
		}

		[Ordinal(42)] 
		[RED("bbPlayerEventId")] 
		public CUInt32 BbPlayerEventId
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
		public wCHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}

		[Ordinal(48)] 
		[RED("weaponBlackboard")] 
		public wCHandle<gameIBlackboard> WeaponBlackboard
		{
			get => GetProperty(ref _weaponBlackboard);
			set => SetProperty(ref _weaponBlackboard, value);
		}

		[Ordinal(49)] 
		[RED("weaponParamsListenerId")] 
		public CUInt32 WeaponParamsListenerId
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

		public gameuiPanzerHUDGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

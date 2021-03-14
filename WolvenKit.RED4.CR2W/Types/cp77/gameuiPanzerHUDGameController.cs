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
			get
			{
				if (_vehicle == null)
				{
					_vehicle = (wCHandle<vehicleBaseObject>) CR2WTypeManager.Create("whandle:vehicleBaseObject", "vehicle", cr2w, this);
				}
				return _vehicle;
			}
			set
			{
				if (_vehicle == value)
				{
					return;
				}
				_vehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("vehiclePS")] 
		public CHandle<VehicleComponentPS> VehiclePS
		{
			get
			{
				if (_vehiclePS == null)
				{
					_vehiclePS = (CHandle<VehicleComponentPS>) CR2WTypeManager.Create("handle:VehicleComponentPS", "vehiclePS", cr2w, this);
				}
				return _vehiclePS;
			}
			set
			{
				if (_vehiclePS == value)
				{
					return;
				}
				_vehiclePS = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("healthStatus")] 
		public inkTextWidgetReference HealthStatus
		{
			get
			{
				if (_healthStatus == null)
				{
					_healthStatus = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "healthStatus", cr2w, this);
				}
				return _healthStatus;
			}
			set
			{
				if (_healthStatus == value)
				{
					return;
				}
				_healthStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("healthBar")] 
		public inkWidgetReference HealthBar
		{
			get
			{
				if (_healthBar == null)
				{
					_healthBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "healthBar", cr2w, this);
				}
				return _healthBar;
			}
			set
			{
				if (_healthBar == value)
				{
					return;
				}
				_healthBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("rightStickX")] 
		public CFloat RightStickX
		{
			get
			{
				if (_rightStickX == null)
				{
					_rightStickX = (CFloat) CR2WTypeManager.Create("Float", "rightStickX", cr2w, this);
				}
				return _rightStickX;
			}
			set
			{
				if (_rightStickX == value)
				{
					return;
				}
				_rightStickX = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("rightStickY")] 
		public CFloat RightStickY
		{
			get
			{
				if (_rightStickY == null)
				{
					_rightStickY = (CFloat) CR2WTypeManager.Create("Float", "rightStickY", cr2w, this);
				}
				return _rightStickY;
			}
			set
			{
				if (_rightStickY == value)
				{
					return;
				}
				_rightStickY = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("LeanAngleValue")] 
		public inkCanvasWidgetReference LeanAngleValue
		{
			get
			{
				if (_leanAngleValue == null)
				{
					_leanAngleValue = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "LeanAngleValue", cr2w, this);
				}
				return _leanAngleValue;
			}
			set
			{
				if (_leanAngleValue == value)
				{
					return;
				}
				_leanAngleValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("CoriRotation")] 
		public inkCanvasWidgetReference CoriRotation
		{
			get
			{
				if (_coriRotation == null)
				{
					_coriRotation = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "CoriRotation", cr2w, this);
				}
				return _coriRotation;
			}
			set
			{
				if (_coriRotation == value)
				{
					return;
				}
				_coriRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("CompassRotation")] 
		public inkCanvasWidgetReference CompassRotation
		{
			get
			{
				if (_compassRotation == null)
				{
					_compassRotation = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "CompassRotation", cr2w, this);
				}
				return _compassRotation;
			}
			set
			{
				if (_compassRotation == value)
				{
					return;
				}
				_compassRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("Cori_S")] 
		public inkCanvasWidgetReference Cori_S
		{
			get
			{
				if (_cori_S == null)
				{
					_cori_S = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "Cori_S", cr2w, this);
				}
				return _cori_S;
			}
			set
			{
				if (_cori_S == value)
				{
					return;
				}
				_cori_S = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("Cori_M")] 
		public inkCanvasWidgetReference Cori_M
		{
			get
			{
				if (_cori_M == null)
				{
					_cori_M = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "Cori_M", cr2w, this);
				}
				return _cori_M;
			}
			set
			{
				if (_cori_M == value)
				{
					return;
				}
				_cori_M = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("trimmerArrow")] 
		public inkImageWidgetReference TrimmerArrow
		{
			get
			{
				if (_trimmerArrow == null)
				{
					_trimmerArrow = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "trimmerArrow", cr2w, this);
				}
				return _trimmerArrow;
			}
			set
			{
				if (_trimmerArrow == value)
				{
					return;
				}
				_trimmerArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("SpeedValue")] 
		public inkTextWidgetReference SpeedValue
		{
			get
			{
				if (_speedValue == null)
				{
					_speedValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "SpeedValue", cr2w, this);
				}
				return _speedValue;
			}
			set
			{
				if (_speedValue == value)
				{
					return;
				}
				_speedValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("RPMValue")] 
		public inkTextWidgetReference RPMValue
		{
			get
			{
				if (_rPMValue == null)
				{
					_rPMValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "RPMValue", cr2w, this);
				}
				return _rPMValue;
			}
			set
			{
				if (_rPMValue == value)
				{
					return;
				}
				_rPMValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("scanBlackboard")] 
		public wCHandle<gameIBlackboard> ScanBlackboard
		{
			get
			{
				if (_scanBlackboard == null)
				{
					_scanBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "scanBlackboard", cr2w, this);
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

		[Ordinal(26)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get
			{
				if (_psmBlackboard == null)
				{
					_psmBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "psmBlackboard", cr2w, this);
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

		[Ordinal(27)] 
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

		[Ordinal(28)] 
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

		[Ordinal(29)] 
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

		[Ordinal(30)] 
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

		[Ordinal(31)] 
		[RED("vehicleBlackboard")] 
		public wCHandle<gameIBlackboard> VehicleBlackboard
		{
			get
			{
				if (_vehicleBlackboard == null)
				{
					_vehicleBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "vehicleBlackboard", cr2w, this);
				}
				return _vehicleBlackboard;
			}
			set
			{
				if (_vehicleBlackboard == value)
				{
					return;
				}
				_vehicleBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("activeVehicleUIBlackboard")] 
		public wCHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get
			{
				if (_activeVehicleUIBlackboard == null)
				{
					_activeVehicleUIBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "activeVehicleUIBlackboard", cr2w, this);
				}
				return _activeVehicleUIBlackboard;
			}
			set
			{
				if (_activeVehicleUIBlackboard == value)
				{
					return;
				}
				_activeVehicleUIBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("vehicleBBStateConectionId")] 
		public CUInt32 VehicleBBStateConectionId
		{
			get
			{
				if (_vehicleBBStateConectionId == null)
				{
					_vehicleBBStateConectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleBBStateConectionId", cr2w, this);
				}
				return _vehicleBBStateConectionId;
			}
			set
			{
				if (_vehicleBBStateConectionId == value)
				{
					return;
				}
				_vehicleBBStateConectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("speedBBConnectionId")] 
		public CUInt32 SpeedBBConnectionId
		{
			get
			{
				if (_speedBBConnectionId == null)
				{
					_speedBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "speedBBConnectionId", cr2w, this);
				}
				return _speedBBConnectionId;
			}
			set
			{
				if (_speedBBConnectionId == value)
				{
					return;
				}
				_speedBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("gearBBConnectionId")] 
		public CUInt32 GearBBConnectionId
		{
			get
			{
				if (_gearBBConnectionId == null)
				{
					_gearBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "gearBBConnectionId", cr2w, this);
				}
				return _gearBBConnectionId;
			}
			set
			{
				if (_gearBBConnectionId == value)
				{
					return;
				}
				_gearBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("tppBBConnectionId")] 
		public CUInt32 TppBBConnectionId
		{
			get
			{
				if (_tppBBConnectionId == null)
				{
					_tppBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "tppBBConnectionId", cr2w, this);
				}
				return _tppBBConnectionId;
			}
			set
			{
				if (_tppBBConnectionId == value)
				{
					return;
				}
				_tppBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("rpmValueBBConnectionId")] 
		public CUInt32 RpmValueBBConnectionId
		{
			get
			{
				if (_rpmValueBBConnectionId == null)
				{
					_rpmValueBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "rpmValueBBConnectionId", cr2w, this);
				}
				return _rpmValueBBConnectionId;
			}
			set
			{
				if (_rpmValueBBConnectionId == value)
				{
					return;
				}
				_rpmValueBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("leanAngleBBConnectionId")] 
		public CUInt32 LeanAngleBBConnectionId
		{
			get
			{
				if (_leanAngleBBConnectionId == null)
				{
					_leanAngleBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "leanAngleBBConnectionId", cr2w, this);
				}
				return _leanAngleBBConnectionId;
			}
			set
			{
				if (_leanAngleBBConnectionId == value)
				{
					return;
				}
				_leanAngleBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("playerStateBBConnectionId")] 
		public CUInt32 PlayerStateBBConnectionId
		{
			get
			{
				if (_playerStateBBConnectionId == null)
				{
					_playerStateBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "playerStateBBConnectionId", cr2w, this);
				}
				return _playerStateBBConnectionId;
			}
			set
			{
				if (_playerStateBBConnectionId == value)
				{
					return;
				}
				_playerStateBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("isTargetingFriendlyConnectionId")] 
		public CUInt32 IsTargetingFriendlyConnectionId
		{
			get
			{
				if (_isTargetingFriendlyConnectionId == null)
				{
					_isTargetingFriendlyConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "isTargetingFriendlyConnectionId", cr2w, this);
				}
				return _isTargetingFriendlyConnectionId;
			}
			set
			{
				if (_isTargetingFriendlyConnectionId == value)
				{
					return;
				}
				_isTargetingFriendlyConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("bbPlayerStats")] 
		public CHandle<gameIBlackboard> BbPlayerStats
		{
			get
			{
				if (_bbPlayerStats == null)
				{
					_bbPlayerStats = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbPlayerStats", cr2w, this);
				}
				return _bbPlayerStats;
			}
			set
			{
				if (_bbPlayerStats == value)
				{
					return;
				}
				_bbPlayerStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("bbPlayerEventId")] 
		public CUInt32 BbPlayerEventId
		{
			get
			{
				if (_bbPlayerEventId == null)
				{
					_bbPlayerEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbPlayerEventId", cr2w, this);
				}
				return _bbPlayerEventId;
			}
			set
			{
				if (_bbPlayerEventId == value)
				{
					return;
				}
				_bbPlayerEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get
			{
				if (_currentHealth == null)
				{
					_currentHealth = (CInt32) CR2WTypeManager.Create("Int32", "currentHealth", cr2w, this);
				}
				return _currentHealth;
			}
			set
			{
				if (_currentHealth == value)
				{
					return;
				}
				_currentHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get
			{
				if (_previousHealth == null)
				{
					_previousHealth = (CInt32) CR2WTypeManager.Create("Int32", "previousHealth", cr2w, this);
				}
				return _previousHealth;
			}
			set
			{
				if (_previousHealth == value)
				{
					return;
				}
				_previousHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get
			{
				if (_maximumHealth == null)
				{
					_maximumHealth = (CInt32) CR2WTypeManager.Create("Int32", "maximumHealth", cr2w, this);
				}
				return _maximumHealth;
			}
			set
			{
				if (_maximumHealth == value)
				{
					return;
				}
				_maximumHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("quickhacksMemoryPercent")] 
		public CFloat QuickhacksMemoryPercent
		{
			get
			{
				if (_quickhacksMemoryPercent == null)
				{
					_quickhacksMemoryPercent = (CFloat) CR2WTypeManager.Create("Float", "quickhacksMemoryPercent", cr2w, this);
				}
				return _quickhacksMemoryPercent;
			}
			set
			{
				if (_quickhacksMemoryPercent == value)
				{
					return;
				}
				_quickhacksMemoryPercent = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("playerObject")] 
		public wCHandle<gameObject> PlayerObject
		{
			get
			{
				if (_playerObject == null)
				{
					_playerObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerObject", cr2w, this);
				}
				return _playerObject;
			}
			set
			{
				if (_playerObject == value)
				{
					return;
				}
				_playerObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("weaponBlackboard")] 
		public wCHandle<gameIBlackboard> WeaponBlackboard
		{
			get
			{
				if (_weaponBlackboard == null)
				{
					_weaponBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "weaponBlackboard", cr2w, this);
				}
				return _weaponBlackboard;
			}
			set
			{
				if (_weaponBlackboard == value)
				{
					return;
				}
				_weaponBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("weaponParamsListenerId")] 
		public CUInt32 WeaponParamsListenerId
		{
			get
			{
				if (_weaponParamsListenerId == null)
				{
					_weaponParamsListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "weaponParamsListenerId", cr2w, this);
				}
				return _weaponParamsListenerId;
			}
			set
			{
				if (_weaponParamsListenerId == value)
				{
					return;
				}
				_weaponParamsListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("targetIndicators")] 
		public CArray<TargetIndicatorEntry> TargetIndicators
		{
			get
			{
				if (_targetIndicators == null)
				{
					_targetIndicators = (CArray<TargetIndicatorEntry>) CR2WTypeManager.Create("array:TargetIndicatorEntry", "targetIndicators", cr2w, this);
				}
				return _targetIndicators;
			}
			set
			{
				if (_targetIndicators == value)
				{
					return;
				}
				_targetIndicators = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("targetHolder")] 
		public inkCompoundWidgetReference TargetHolder
		{
			get
			{
				if (_targetHolder == null)
				{
					_targetHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "targetHolder", cr2w, this);
				}
				return _targetHolder;
			}
			set
			{
				if (_targetHolder == value)
				{
					return;
				}
				_targetHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("targetWidgetLibraryName")] 
		public CName TargetWidgetLibraryName
		{
			get
			{
				if (_targetWidgetLibraryName == null)
				{
					_targetWidgetLibraryName = (CName) CR2WTypeManager.Create("CName", "targetWidgetLibraryName", cr2w, this);
				}
				return _targetWidgetLibraryName;
			}
			set
			{
				if (_targetWidgetLibraryName == value)
				{
					return;
				}
				_targetWidgetLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("targetWidgetPoolSize")] 
		public CInt32 TargetWidgetPoolSize
		{
			get
			{
				if (_targetWidgetPoolSize == null)
				{
					_targetWidgetPoolSize = (CInt32) CR2WTypeManager.Create("Int32", "targetWidgetPoolSize", cr2w, this);
				}
				return _targetWidgetPoolSize;
			}
			set
			{
				if (_targetWidgetPoolSize == value)
				{
					return;
				}
				_targetWidgetPoolSize = value;
				PropertySet(this);
			}
		}

		public gameuiPanzerHUDGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

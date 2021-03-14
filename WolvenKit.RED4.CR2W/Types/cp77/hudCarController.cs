using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudCarController : gameuiHUDGameController
	{
		private inkTextWidgetReference _speedValue;
		private CArray<inkImageWidgetReference> _rPMChunks;
		private CHandle<gameIBlackboard> _psmBlackboard;
		private CUInt32 _pSM_BBID;
		private CFloat _currentZoom;
		private GameTime _currentTime;
		private wCHandle<gameIBlackboard> _activeVehicleUIBlackboard;
		private CUInt32 _vehicleBBStateConectionId;
		private CUInt32 _speedBBConnectionId;
		private CUInt32 _gearBBConnectionId;
		private CUInt32 _tppBBConnectionId;
		private CUInt32 _rpmValueBBConnectionId;
		private CUInt32 _leanAngleBBConnectionId;
		private CUInt32 _playerStateBBConnectionId;
		private CInt32 _activeChunks;
		private wCHandle<vehicleBaseObject> _activeVehicle;
		private CBool _driver;

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("RPMChunks")] 
		public CArray<inkImageWidgetReference> RPMChunks
		{
			get
			{
				if (_rPMChunks == null)
				{
					_rPMChunks = (CArray<inkImageWidgetReference>) CR2WTypeManager.Create("array:inkImageWidgetReference", "RPMChunks", cr2w, this);
				}
				return _rPMChunks;
			}
			set
			{
				if (_rPMChunks == value)
				{
					return;
				}
				_rPMChunks = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("psmBlackboard")] 
		public CHandle<gameIBlackboard> PsmBlackboard
		{
			get
			{
				if (_psmBlackboard == null)
				{
					_psmBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "psmBlackboard", cr2w, this);
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
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

		[Ordinal(21)] 
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

		[Ordinal(22)] 
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

		[Ordinal(23)] 
		[RED("activeChunks")] 
		public CInt32 ActiveChunks
		{
			get
			{
				if (_activeChunks == null)
				{
					_activeChunks = (CInt32) CR2WTypeManager.Create("Int32", "activeChunks", cr2w, this);
				}
				return _activeChunks;
			}
			set
			{
				if (_activeChunks == value)
				{
					return;
				}
				_activeChunks = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("activeVehicle")] 
		public wCHandle<vehicleBaseObject> ActiveVehicle
		{
			get
			{
				if (_activeVehicle == null)
				{
					_activeVehicle = (wCHandle<vehicleBaseObject>) CR2WTypeManager.Create("whandle:vehicleBaseObject", "activeVehicle", cr2w, this);
				}
				return _activeVehicle;
			}
			set
			{
				if (_activeVehicle == value)
				{
					return;
				}
				_activeVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("driver")] 
		public CBool Driver
		{
			get
			{
				if (_driver == null)
				{
					_driver = (CBool) CR2WTypeManager.Create("Bool", "driver", cr2w, this);
				}
				return _driver;
			}
			set
			{
				if (_driver == value)
				{
					return;
				}
				_driver = value;
				PropertySet(this);
			}
		}

		public hudCarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

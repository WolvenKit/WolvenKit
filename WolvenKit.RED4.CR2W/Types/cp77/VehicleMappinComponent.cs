using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleMappinComponent : IScriptable
	{
		private wCHandle<QuestMappinController> _questMappinController;
		private wCHandle<gamemappinsVehicleMappin> _vehicleMappin;
		private wCHandle<vehicleBaseObject> _vehicle;
		private entEntityID _vehicleEntityID;
		private CBool _playerMounted;
		private CBool _vehicleEnRoute;
		private gameDelayID _scheduleDiscreteModeDelayID;
		private gameDelayID _invalidDelayID;
		private CBool _init;
		private CHandle<VehicleSummonDataDef> _vehicleSummonDataDef;
		private CHandle<gameIBlackboard> _vehicleSummonDataBB;
		private CUInt32 _vehicleSummonStateCallback;
		private CHandle<UI_ActiveVehicleDataDef> _uiActiveVehicleDataDef;
		private CHandle<gameIBlackboard> _uiActiveVehicleDataBB;
		private CUInt32 _vehPlayerStateDataCallback;

		[Ordinal(0)] 
		[RED("questMappinController")] 
		public wCHandle<QuestMappinController> QuestMappinController
		{
			get
			{
				if (_questMappinController == null)
				{
					_questMappinController = (wCHandle<QuestMappinController>) CR2WTypeManager.Create("whandle:QuestMappinController", "questMappinController", cr2w, this);
				}
				return _questMappinController;
			}
			set
			{
				if (_questMappinController == value)
				{
					return;
				}
				_questMappinController = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vehicleMappin")] 
		public wCHandle<gamemappinsVehicleMappin> VehicleMappin
		{
			get
			{
				if (_vehicleMappin == null)
				{
					_vehicleMappin = (wCHandle<gamemappinsVehicleMappin>) CR2WTypeManager.Create("whandle:gamemappinsVehicleMappin", "vehicleMappin", cr2w, this);
				}
				return _vehicleMappin;
			}
			set
			{
				if (_vehicleMappin == value)
				{
					return;
				}
				_vehicleMappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("vehicleEntityID")] 
		public entEntityID VehicleEntityID
		{
			get
			{
				if (_vehicleEntityID == null)
				{
					_vehicleEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "vehicleEntityID", cr2w, this);
				}
				return _vehicleEntityID;
			}
			set
			{
				if (_vehicleEntityID == value)
				{
					return;
				}
				_vehicleEntityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playerMounted")] 
		public CBool PlayerMounted
		{
			get
			{
				if (_playerMounted == null)
				{
					_playerMounted = (CBool) CR2WTypeManager.Create("Bool", "playerMounted", cr2w, this);
				}
				return _playerMounted;
			}
			set
			{
				if (_playerMounted == value)
				{
					return;
				}
				_playerMounted = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("vehicleEnRoute")] 
		public CBool VehicleEnRoute
		{
			get
			{
				if (_vehicleEnRoute == null)
				{
					_vehicleEnRoute = (CBool) CR2WTypeManager.Create("Bool", "vehicleEnRoute", cr2w, this);
				}
				return _vehicleEnRoute;
			}
			set
			{
				if (_vehicleEnRoute == value)
				{
					return;
				}
				_vehicleEnRoute = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("scheduleDiscreteModeDelayID")] 
		public gameDelayID ScheduleDiscreteModeDelayID
		{
			get
			{
				if (_scheduleDiscreteModeDelayID == null)
				{
					_scheduleDiscreteModeDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "scheduleDiscreteModeDelayID", cr2w, this);
				}
				return _scheduleDiscreteModeDelayID;
			}
			set
			{
				if (_scheduleDiscreteModeDelayID == value)
				{
					return;
				}
				_scheduleDiscreteModeDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("invalidDelayID")] 
		public gameDelayID InvalidDelayID
		{
			get
			{
				if (_invalidDelayID == null)
				{
					_invalidDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "invalidDelayID", cr2w, this);
				}
				return _invalidDelayID;
			}
			set
			{
				if (_invalidDelayID == value)
				{
					return;
				}
				_invalidDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("init")] 
		public CBool Init
		{
			get
			{
				if (_init == null)
				{
					_init = (CBool) CR2WTypeManager.Create("Bool", "init", cr2w, this);
				}
				return _init;
			}
			set
			{
				if (_init == value)
				{
					return;
				}
				_init = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get
			{
				if (_vehicleSummonDataDef == null)
				{
					_vehicleSummonDataDef = (CHandle<VehicleSummonDataDef>) CR2WTypeManager.Create("handle:VehicleSummonDataDef", "vehicleSummonDataDef", cr2w, this);
				}
				return _vehicleSummonDataDef;
			}
			set
			{
				if (_vehicleSummonDataDef == value)
				{
					return;
				}
				_vehicleSummonDataDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("vehicleSummonDataBB")] 
		public CHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get
			{
				if (_vehicleSummonDataBB == null)
				{
					_vehicleSummonDataBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "vehicleSummonDataBB", cr2w, this);
				}
				return _vehicleSummonDataBB;
			}
			set
			{
				if (_vehicleSummonDataBB == value)
				{
					return;
				}
				_vehicleSummonDataBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("vehicleSummonStateCallback")] 
		public CUInt32 VehicleSummonStateCallback
		{
			get
			{
				if (_vehicleSummonStateCallback == null)
				{
					_vehicleSummonStateCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleSummonStateCallback", cr2w, this);
				}
				return _vehicleSummonStateCallback;
			}
			set
			{
				if (_vehicleSummonStateCallback == value)
				{
					return;
				}
				_vehicleSummonStateCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("uiActiveVehicleDataDef")] 
		public CHandle<UI_ActiveVehicleDataDef> UiActiveVehicleDataDef
		{
			get
			{
				if (_uiActiveVehicleDataDef == null)
				{
					_uiActiveVehicleDataDef = (CHandle<UI_ActiveVehicleDataDef>) CR2WTypeManager.Create("handle:UI_ActiveVehicleDataDef", "uiActiveVehicleDataDef", cr2w, this);
				}
				return _uiActiveVehicleDataDef;
			}
			set
			{
				if (_uiActiveVehicleDataDef == value)
				{
					return;
				}
				_uiActiveVehicleDataDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("uiActiveVehicleDataBB")] 
		public CHandle<gameIBlackboard> UiActiveVehicleDataBB
		{
			get
			{
				if (_uiActiveVehicleDataBB == null)
				{
					_uiActiveVehicleDataBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiActiveVehicleDataBB", cr2w, this);
				}
				return _uiActiveVehicleDataBB;
			}
			set
			{
				if (_uiActiveVehicleDataBB == value)
				{
					return;
				}
				_uiActiveVehicleDataBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("vehPlayerStateDataCallback")] 
		public CUInt32 VehPlayerStateDataCallback
		{
			get
			{
				if (_vehPlayerStateDataCallback == null)
				{
					_vehPlayerStateDataCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "vehPlayerStateDataCallback", cr2w, this);
				}
				return _vehPlayerStateDataCallback;
			}
			set
			{
				if (_vehPlayerStateDataCallback == value)
				{
					return;
				}
				_vehPlayerStateDataCallback = value;
				PropertySet(this);
			}
		}

		public VehicleMappinComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

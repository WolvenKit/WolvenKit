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
		private wCHandle<gameIBlackboard> _vehicleSummonDataBB;
		private CHandle<redCallbackObject> _vehicleSummonStateCallback;
		private CHandle<UI_ActiveVehicleDataDef> _uiActiveVehicleDataDef;
		private wCHandle<gameIBlackboard> _uiActiveVehicleDataBB;
		private CHandle<redCallbackObject> _vehPlayerStateDataCallback;

		[Ordinal(0)] 
		[RED("questMappinController")] 
		public wCHandle<QuestMappinController> QuestMappinController
		{
			get => GetProperty(ref _questMappinController);
			set => SetProperty(ref _questMappinController, value);
		}

		[Ordinal(1)] 
		[RED("vehicleMappin")] 
		public wCHandle<gamemappinsVehicleMappin> VehicleMappin
		{
			get => GetProperty(ref _vehicleMappin);
			set => SetProperty(ref _vehicleMappin, value);
		}

		[Ordinal(2)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(3)] 
		[RED("vehicleEntityID")] 
		public entEntityID VehicleEntityID
		{
			get => GetProperty(ref _vehicleEntityID);
			set => SetProperty(ref _vehicleEntityID, value);
		}

		[Ordinal(4)] 
		[RED("playerMounted")] 
		public CBool PlayerMounted
		{
			get => GetProperty(ref _playerMounted);
			set => SetProperty(ref _playerMounted, value);
		}

		[Ordinal(5)] 
		[RED("vehicleEnRoute")] 
		public CBool VehicleEnRoute
		{
			get => GetProperty(ref _vehicleEnRoute);
			set => SetProperty(ref _vehicleEnRoute, value);
		}

		[Ordinal(6)] 
		[RED("scheduleDiscreteModeDelayID")] 
		public gameDelayID ScheduleDiscreteModeDelayID
		{
			get => GetProperty(ref _scheduleDiscreteModeDelayID);
			set => SetProperty(ref _scheduleDiscreteModeDelayID, value);
		}

		[Ordinal(7)] 
		[RED("invalidDelayID")] 
		public gameDelayID InvalidDelayID
		{
			get => GetProperty(ref _invalidDelayID);
			set => SetProperty(ref _invalidDelayID, value);
		}

		[Ordinal(8)] 
		[RED("init")] 
		public CBool Init
		{
			get => GetProperty(ref _init);
			set => SetProperty(ref _init, value);
		}

		[Ordinal(9)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get => GetProperty(ref _vehicleSummonDataDef);
			set => SetProperty(ref _vehicleSummonDataDef, value);
		}

		[Ordinal(10)] 
		[RED("vehicleSummonDataBB")] 
		public wCHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get => GetProperty(ref _vehicleSummonDataBB);
			set => SetProperty(ref _vehicleSummonDataBB, value);
		}

		[Ordinal(11)] 
		[RED("vehicleSummonStateCallback")] 
		public CHandle<redCallbackObject> VehicleSummonStateCallback
		{
			get => GetProperty(ref _vehicleSummonStateCallback);
			set => SetProperty(ref _vehicleSummonStateCallback, value);
		}

		[Ordinal(12)] 
		[RED("uiActiveVehicleDataDef")] 
		public CHandle<UI_ActiveVehicleDataDef> UiActiveVehicleDataDef
		{
			get => GetProperty(ref _uiActiveVehicleDataDef);
			set => SetProperty(ref _uiActiveVehicleDataDef, value);
		}

		[Ordinal(13)] 
		[RED("uiActiveVehicleDataBB")] 
		public wCHandle<gameIBlackboard> UiActiveVehicleDataBB
		{
			get => GetProperty(ref _uiActiveVehicleDataBB);
			set => SetProperty(ref _uiActiveVehicleDataBB, value);
		}

		[Ordinal(14)] 
		[RED("vehPlayerStateDataCallback")] 
		public CHandle<redCallbackObject> VehPlayerStateDataCallback
		{
			get => GetProperty(ref _vehPlayerStateDataCallback);
			set => SetProperty(ref _vehPlayerStateDataCallback, value);
		}

		public VehicleMappinComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

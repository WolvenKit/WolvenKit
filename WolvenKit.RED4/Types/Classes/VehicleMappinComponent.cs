using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleMappinComponent : IScriptable
	{
		[Ordinal(0)] 
		[RED("questMappinController")] 
		public CWeakHandle<QuestMappinController> QuestMappinController
		{
			get => GetPropertyValue<CWeakHandle<QuestMappinController>>();
			set => SetPropertyValue<CWeakHandle<QuestMappinController>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleMappin")] 
		public CWeakHandle<gamemappinsVehicleMappin> VehicleMappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsVehicleMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsVehicleMappin>>(value);
		}

		[Ordinal(2)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(3)] 
		[RED("vehicleEntityID")] 
		public entEntityID VehicleEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(4)] 
		[RED("playerMounted")] 
		public CBool PlayerMounted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("vehicleEnRoute")] 
		public CBool VehicleEnRoute
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("scheduleDiscreteModeDelayID")] 
		public gameDelayID ScheduleDiscreteModeDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(7)] 
		[RED("invalidDelayID")] 
		public gameDelayID InvalidDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(8)] 
		[RED("init")] 
		public CBool Init
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get => GetPropertyValue<CHandle<VehicleSummonDataDef>>();
			set => SetPropertyValue<CHandle<VehicleSummonDataDef>>(value);
		}

		[Ordinal(10)] 
		[RED("vehicleSummonDataBB")] 
		public CWeakHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("vehicleSummonStateCallback")] 
		public CHandle<redCallbackObject> VehicleSummonStateCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("uiActiveVehicleDataDef")] 
		public CHandle<UI_ActiveVehicleDataDef> UiActiveVehicleDataDef
		{
			get => GetPropertyValue<CHandle<UI_ActiveVehicleDataDef>>();
			set => SetPropertyValue<CHandle<UI_ActiveVehicleDataDef>>(value);
		}

		[Ordinal(13)] 
		[RED("uiActiveVehicleDataBB")] 
		public CWeakHandle<gameIBlackboard> UiActiveVehicleDataBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(14)] 
		[RED("vehPlayerStateDataCallback")] 
		public CHandle<redCallbackObject> VehPlayerStateDataCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public VehicleMappinComponent()
		{
			VehicleEntityID = new();
			ScheduleDiscreteModeDelayID = new();
			InvalidDelayID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

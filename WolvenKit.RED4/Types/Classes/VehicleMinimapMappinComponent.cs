using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleMinimapMappinComponent : IScriptable
	{
		[Ordinal(0)] 
		[RED("minimapPOIMappinController")] 
		public CWeakHandle<MinimapPOIMappinController> MinimapPOIMappinController
		{
			get => GetPropertyValue<CWeakHandle<MinimapPOIMappinController>>();
			set => SetPropertyValue<CWeakHandle<MinimapPOIMappinController>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(2)] 
		[RED("uiVehicleBB")] 
		public CWeakHandle<gameIBlackboard> UiVehicleBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(3)] 
		[RED("vehicleBBDef")] 
		public CHandle<VehicleDef> VehicleBBDef
		{
			get => GetPropertyValue<CHandle<VehicleDef>>();
			set => SetPropertyValue<CHandle<VehicleDef>>(value);
		}

		[Ordinal(4)] 
		[RED("deleteAnimCallback")] 
		public CHandle<redCallbackObject> DeleteAnimCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("destroyMappinOnAnimEnd")] 
		public CBool DestroyMappinOnAnimEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("vehicleIsLatestSummoned")] 
		public CBool VehicleIsLatestSummoned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("vehicleEntityID")] 
		public entEntityID VehicleEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(8)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get => GetPropertyValue<CHandle<VehicleSummonDataDef>>();
			set => SetPropertyValue<CHandle<VehicleSummonDataDef>>(value);
		}

		[Ordinal(9)] 
		[RED("vehicleSummonDataBB")] 
		public CWeakHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(10)] 
		[RED("vehicleSummonStateCallback")] 
		public CHandle<redCallbackObject> VehicleSummonStateCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public VehicleMinimapMappinComponent()
		{
			VehicleEntityID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleMinimapMappinComponent : IScriptable
	{
		private CWeakHandle<MinimapPOIMappinController> _minimapPOIMappinController;
		private CBool _vehicleIsLatestSummoned;
		private entEntityID _vehicleEntityID;
		private CHandle<VehicleSummonDataDef> _vehicleSummonDataDef;
		private CWeakHandle<gameIBlackboard> _vehicleSummonDataBB;
		private CHandle<redCallbackObject> _vehicleSummonStateCallback;

		[Ordinal(0)] 
		[RED("minimapPOIMappinController")] 
		public CWeakHandle<MinimapPOIMappinController> MinimapPOIMappinController
		{
			get => GetProperty(ref _minimapPOIMappinController);
			set => SetProperty(ref _minimapPOIMappinController, value);
		}

		[Ordinal(1)] 
		[RED("vehicleIsLatestSummoned")] 
		public CBool VehicleIsLatestSummoned
		{
			get => GetProperty(ref _vehicleIsLatestSummoned);
			set => SetProperty(ref _vehicleIsLatestSummoned, value);
		}

		[Ordinal(2)] 
		[RED("vehicleEntityID")] 
		public entEntityID VehicleEntityID
		{
			get => GetProperty(ref _vehicleEntityID);
			set => SetProperty(ref _vehicleEntityID, value);
		}

		[Ordinal(3)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get => GetProperty(ref _vehicleSummonDataDef);
			set => SetProperty(ref _vehicleSummonDataDef, value);
		}

		[Ordinal(4)] 
		[RED("vehicleSummonDataBB")] 
		public CWeakHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get => GetProperty(ref _vehicleSummonDataBB);
			set => SetProperty(ref _vehicleSummonDataBB, value);
		}

		[Ordinal(5)] 
		[RED("vehicleSummonStateCallback")] 
		public CHandle<redCallbackObject> VehicleSummonStateCallback
		{
			get => GetProperty(ref _vehicleSummonStateCallback);
			set => SetProperty(ref _vehicleSummonStateCallback, value);
		}
	}
}

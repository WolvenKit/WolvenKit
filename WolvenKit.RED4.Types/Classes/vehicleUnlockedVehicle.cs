using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleUnlockedVehicle : RedBaseClass
	{
		private vehicleGarageVehicleID _vehicleID;
		private CFloat _health;

		[Ordinal(0)] 
		[RED("vehicleID")] 
		public vehicleGarageVehicleID VehicleID
		{
			get => GetProperty(ref _vehicleID);
			set => SetProperty(ref _vehicleID, value);
		}

		[Ordinal(1)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetProperty(ref _health);
			set => SetProperty(ref _health, value);
		}
	}
}

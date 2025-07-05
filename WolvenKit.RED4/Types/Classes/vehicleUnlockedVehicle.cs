using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleUnlockedVehicle : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("vehicleID")] 
		public vehicleGarageVehicleID VehicleID
		{
			get => GetPropertyValue<vehicleGarageVehicleID>();
			set => SetPropertyValue<vehicleGarageVehicleID>(value);
		}

		[Ordinal(1)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleUnlockedVehicle()
		{
			VehicleID = new vehicleGarageVehicleID();
			Health = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

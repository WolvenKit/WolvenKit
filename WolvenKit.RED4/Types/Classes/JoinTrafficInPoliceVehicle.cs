using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JoinTrafficInPoliceVehicle : AIVehicleTaskAbstract
	{
		[Ordinal(0)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(1)] 
		[RED("panicDrivingCmd")] 
		public CHandle<AIVehiclePanicCommand> PanicDrivingCmd
		{
			get => GetPropertyValue<CHandle<AIVehiclePanicCommand>>();
			set => SetPropertyValue<CHandle<AIVehiclePanicCommand>>(value);
		}

		public JoinTrafficInPoliceVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

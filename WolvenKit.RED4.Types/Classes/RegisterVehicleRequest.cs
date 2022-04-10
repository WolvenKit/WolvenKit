using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterVehicleRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		public RegisterVehicleRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

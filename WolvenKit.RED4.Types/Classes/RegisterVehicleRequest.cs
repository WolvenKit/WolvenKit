using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterVehicleRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}
	}
}

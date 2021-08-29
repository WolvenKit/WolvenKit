using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterVehicleRequest : gameScriptableSystemRequest
	{
		private CWeakHandle<vehicleBaseObject> _vehicle;

		[Ordinal(0)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}
	}
}

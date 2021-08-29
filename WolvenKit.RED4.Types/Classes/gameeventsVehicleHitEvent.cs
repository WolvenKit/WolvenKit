using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsVehicleHitEvent : gameeventsHitEvent
	{
		private Vector4 _vehicleVelocity;
		private Vector4 _preyVelocity;

		[Ordinal(12)] 
		[RED("vehicleVelocity")] 
		public Vector4 VehicleVelocity
		{
			get => GetProperty(ref _vehicleVelocity);
			set => SetProperty(ref _vehicleVelocity, value);
		}

		[Ordinal(13)] 
		[RED("preyVelocity")] 
		public Vector4 PreyVelocity
		{
			get => GetProperty(ref _preyVelocity);
			set => SetProperty(ref _preyVelocity, value);
		}
	}
}

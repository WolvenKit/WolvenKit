using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsVehicleHitEvent : gameeventsHitEvent
	{
		[Ordinal(12)] 
		[RED("vehicleVelocity")] 
		public Vector4 VehicleVelocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(13)] 
		[RED("preyVelocity")] 
		public Vector4 PreyVelocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameeventsVehicleHitEvent()
		{
			VehicleVelocity = new Vector4();
			PreyVelocity = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

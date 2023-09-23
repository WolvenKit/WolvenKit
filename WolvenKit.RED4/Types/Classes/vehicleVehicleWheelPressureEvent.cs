using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleWheelPressureEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("contactPoint")] 
		public Vector3 ContactPoint
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("impulse")] 
		public Vector3 Impulse
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public vehicleVehicleWheelPressureEvent()
		{
			ContactPoint = new Vector3();
			Impulse = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

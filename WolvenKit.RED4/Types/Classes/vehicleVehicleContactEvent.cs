using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleContactEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("otherVehicle")] 
		public CWeakHandle<gameObject> OtherVehicle
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public vehicleVehicleContactEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

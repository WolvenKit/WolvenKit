using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleSetVehicleLostControlEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleSetVehicleLostControlEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

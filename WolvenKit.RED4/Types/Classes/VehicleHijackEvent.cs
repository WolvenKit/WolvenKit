using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleHijackEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("driverAllowedToGetAggressive")] 
		public CBool DriverAllowedToGetAggressive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleHijackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

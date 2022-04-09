using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleAirtime_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("seconds")] 
		public CFloat Seconds
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questVehicleAirtime_ConditionType()
		{
			Seconds = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

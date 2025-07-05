using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleTemperatureSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rpmThreshold")] 
		public CFloat RpmThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("timeToActivateTemperature")] 
		public CFloat TimeToActivateTemperature
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("cooldownTime")] 
		public CFloat CooldownTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioVehicleTemperatureSettings()
		{
			RpmThreshold = 3.000000F;
			TimeToActivateTemperature = 8.000000F;
			CooldownTime = 10.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

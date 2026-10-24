using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleAudioMultipliersEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("multipliers")] 
		public audioVehicleMultipliers Multipliers
		{
			get => GetPropertyValue<audioVehicleMultipliers>();
			set => SetPropertyValue<audioVehicleMultipliers>(value);
		}

		public vehicleVehicleAudioMultipliersEvent()
		{
			Multipliers = new audioVehicleMultipliers();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

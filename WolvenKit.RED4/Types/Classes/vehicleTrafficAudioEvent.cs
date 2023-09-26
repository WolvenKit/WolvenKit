using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleTrafficAudioEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("audioAction")] 
		public CEnum<audioTrafficVehicleAudioAction> AudioAction
		{
			get => GetPropertyValue<CEnum<audioTrafficVehicleAudioAction>>();
			set => SetPropertyValue<CEnum<audioTrafficVehicleAudioAction>>(value);
		}

		public vehicleTrafficAudioEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

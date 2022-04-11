using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleAudioEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<vehicleAudioEventAction> Action
		{
			get => GetPropertyValue<CEnum<vehicleAudioEventAction>>();
			set => SetPropertyValue<CEnum<vehicleAudioEventAction>>(value);
		}

		public vehicleAudioEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

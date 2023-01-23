using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeSound : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("events")] 
		public CArray<audioMeleeEvent> Events
		{
			get => GetPropertyValue<CArray<audioMeleeEvent>>();
			set => SetPropertyValue<CArray<audioMeleeEvent>>(value);
		}

		public audioMeleeSound()
		{
			Events = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

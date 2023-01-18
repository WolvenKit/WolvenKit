using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayStimEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("stimEvent")] 
		public CHandle<senseStimuliEvent> StimEvent
		{
			get => GetPropertyValue<CHandle<senseStimuliEvent>>();
			set => SetPropertyValue<CHandle<senseStimuliEvent>>(value);
		}

		public DelayStimEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

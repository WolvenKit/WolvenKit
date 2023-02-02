using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayReactionToMissingPassengersEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("stimEvent")] 
		public CHandle<senseStimuliEvent> StimEvent
		{
			get => GetPropertyValue<CHandle<senseStimuliEvent>>();
			set => SetPropertyValue<CHandle<senseStimuliEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("delayedAlready")] 
		public CBool DelayedAlready
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DelayReactionToMissingPassengersEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

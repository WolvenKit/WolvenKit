using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HandleReactionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("fearPhase")] 
		public CInt32 FearPhase
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("stimEvent")] 
		public CHandle<senseStimuliEvent> StimEvent
		{
			get => GetPropertyValue<CHandle<senseStimuliEvent>>();
			set => SetPropertyValue<CHandle<senseStimuliEvent>>(value);
		}

		public HandleReactionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

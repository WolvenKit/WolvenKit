using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickSlotsReadyEvents : QuickSlotsEvents
	{
		[Ordinal(0)] 
		[RED("shouldSendEvent")] 
		public CBool ShouldSendEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("timePressed")] 
		public CFloat TimePressed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public QuickSlotsReadyEvents()
		{
			ShouldSendEvent = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

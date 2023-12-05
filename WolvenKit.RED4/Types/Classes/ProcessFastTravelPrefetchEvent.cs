using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProcessFastTravelPrefetchEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("destinationRef")] 
		public NodeRef DestinationRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public ProcessFastTravelPrefetchEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

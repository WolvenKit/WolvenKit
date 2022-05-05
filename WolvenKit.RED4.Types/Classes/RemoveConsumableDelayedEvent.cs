using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveConsumableDelayedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("consumeAction")] 
		public CHandle<ConsumeAction> ConsumeAction
		{
			get => GetPropertyValue<CHandle<ConsumeAction>>();
			set => SetPropertyValue<CHandle<ConsumeAction>>(value);
		}

		public RemoveConsumableDelayedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

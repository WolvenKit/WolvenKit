using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConnectionEndedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("togglePersonalLinkAction")] 
		public CHandle<TogglePersonalLink> TogglePersonalLinkAction
		{
			get => GetPropertyValue<CHandle<TogglePersonalLink>>();
			set => SetPropertyValue<CHandle<TogglePersonalLink>>(value);
		}

		public ConnectionEndedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

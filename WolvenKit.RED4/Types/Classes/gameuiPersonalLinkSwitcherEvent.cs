using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPersonalLinkSwitcherEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isAdvanced")] 
		public CBool IsAdvanced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiPersonalLinkSwitcherEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

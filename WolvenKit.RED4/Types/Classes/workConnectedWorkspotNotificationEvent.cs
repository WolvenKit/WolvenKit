using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workConnectedWorkspotNotificationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("evtName")] 
		public CName EvtName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public workConnectedWorkspotNotificationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

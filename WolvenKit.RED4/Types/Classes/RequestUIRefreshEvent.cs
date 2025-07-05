using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestUIRefreshEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("requester")] 
		public gamePersistentID Requester
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(1)] 
		[RED("context")] 
		public CName Context
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public RequestUIRefreshEvent()
		{
			Requester = new gamePersistentID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestBreadCrumbBarUpdateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("requester")] 
		public gamePersistentID Requester
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(1)] 
		[RED("breadCrumbData")] 
		public SBreadCrumbUpdateData BreadCrumbData
		{
			get => GetPropertyValue<SBreadCrumbUpdateData>();
			set => SetPropertyValue<SBreadCrumbUpdateData>(value);
		}

		public RequestBreadCrumbBarUpdateEvent()
		{
			Requester = new gamePersistentID();
			BreadCrumbData = new SBreadCrumbUpdateData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

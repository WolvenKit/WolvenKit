using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MessengerContactsVirtualNestedListController : VirtualNestedListController
	{
		[Ordinal(14)] 
		[RED("currentDataView")] 
		public CWeakHandle<MessengerContactDataView> CurrentDataView
		{
			get => GetPropertyValue<CWeakHandle<MessengerContactDataView>>();
			set => SetPropertyValue<CWeakHandle<MessengerContactDataView>>(value);
		}

		public MessengerContactsVirtualNestedListController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SocialPanelContactsList : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("ListItemName")] 
		public CName ListItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("ItemsRoot")] 
		public inkBasePanelWidgetReference ItemsRoot
		{
			get => GetPropertyValue<inkBasePanelWidgetReference>();
			set => SetPropertyValue<inkBasePanelWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("ItemsList")] 
		public CArray<CWeakHandle<SocialPanelContactsListItem>> ItemsList
		{
			get => GetPropertyValue<CArray<CWeakHandle<SocialPanelContactsListItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<SocialPanelContactsListItem>>>(value);
		}

		[Ordinal(4)] 
		[RED("CurrentContactHash")] 
		public CInt32 CurrentContactHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("LastClickedContact")] 
		public CWeakHandle<gameJournalContact> LastClickedContact
		{
			get => GetPropertyValue<CWeakHandle<gameJournalContact>>();
			set => SetPropertyValue<CWeakHandle<gameJournalContact>>(value);
		}

		public SocialPanelContactsList()
		{
			ListItemName = "contactsListItem";
			ItemsRoot = new();
			ItemsList = new();
			CurrentContactHash = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

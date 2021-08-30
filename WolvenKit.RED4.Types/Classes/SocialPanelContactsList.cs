using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SocialPanelContactsList : inkWidgetLogicController
	{
		private CName _listItemName;
		private inkBasePanelWidgetReference _itemsRoot;
		private CArray<CWeakHandle<SocialPanelContactsListItem>> _itemsList;
		private CInt32 _currentContactHash;
		private CWeakHandle<gameJournalContact> _lastClickedContact;

		[Ordinal(1)] 
		[RED("ListItemName")] 
		public CName ListItemName
		{
			get => GetProperty(ref _listItemName);
			set => SetProperty(ref _listItemName, value);
		}

		[Ordinal(2)] 
		[RED("ItemsRoot")] 
		public inkBasePanelWidgetReference ItemsRoot
		{
			get => GetProperty(ref _itemsRoot);
			set => SetProperty(ref _itemsRoot, value);
		}

		[Ordinal(3)] 
		[RED("ItemsList")] 
		public CArray<CWeakHandle<SocialPanelContactsListItem>> ItemsList
		{
			get => GetProperty(ref _itemsList);
			set => SetProperty(ref _itemsList, value);
		}

		[Ordinal(4)] 
		[RED("CurrentContactHash")] 
		public CInt32 CurrentContactHash
		{
			get => GetProperty(ref _currentContactHash);
			set => SetProperty(ref _currentContactHash, value);
		}

		[Ordinal(5)] 
		[RED("LastClickedContact")] 
		public CWeakHandle<gameJournalContact> LastClickedContact
		{
			get => GetProperty(ref _lastClickedContact);
			set => SetProperty(ref _lastClickedContact, value);
		}

		public SocialPanelContactsList()
		{
			_listItemName = "contactsListItem";
			_currentContactHash = -1;
		}
	}
}

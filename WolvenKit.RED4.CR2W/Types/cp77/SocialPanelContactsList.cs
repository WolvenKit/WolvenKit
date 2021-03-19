using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactsList : inkWidgetLogicController
	{
		private CName _listItemName;
		private inkBasePanelWidgetReference _itemsRoot;
		private CArray<wCHandle<SocialPanelContactsListItem>> _itemsList;
		private CInt32 _currentContactHash;
		private wCHandle<gameJournalContact> _lastClickedContact;

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
		public CArray<wCHandle<SocialPanelContactsListItem>> ItemsList
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
		public wCHandle<gameJournalContact> LastClickedContact
		{
			get => GetProperty(ref _lastClickedContact);
			set => SetProperty(ref _lastClickedContact, value);
		}

		public SocialPanelContactsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

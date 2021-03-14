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
			get
			{
				if (_listItemName == null)
				{
					_listItemName = (CName) CR2WTypeManager.Create("CName", "ListItemName", cr2w, this);
				}
				return _listItemName;
			}
			set
			{
				if (_listItemName == value)
				{
					return;
				}
				_listItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ItemsRoot")] 
		public inkBasePanelWidgetReference ItemsRoot
		{
			get
			{
				if (_itemsRoot == null)
				{
					_itemsRoot = (inkBasePanelWidgetReference) CR2WTypeManager.Create("inkBasePanelWidgetReference", "ItemsRoot", cr2w, this);
				}
				return _itemsRoot;
			}
			set
			{
				if (_itemsRoot == value)
				{
					return;
				}
				_itemsRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ItemsList")] 
		public CArray<wCHandle<SocialPanelContactsListItem>> ItemsList
		{
			get
			{
				if (_itemsList == null)
				{
					_itemsList = (CArray<wCHandle<SocialPanelContactsListItem>>) CR2WTypeManager.Create("array:whandle:SocialPanelContactsListItem", "ItemsList", cr2w, this);
				}
				return _itemsList;
			}
			set
			{
				if (_itemsList == value)
				{
					return;
				}
				_itemsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("CurrentContactHash")] 
		public CInt32 CurrentContactHash
		{
			get
			{
				if (_currentContactHash == null)
				{
					_currentContactHash = (CInt32) CR2WTypeManager.Create("Int32", "CurrentContactHash", cr2w, this);
				}
				return _currentContactHash;
			}
			set
			{
				if (_currentContactHash == value)
				{
					return;
				}
				_currentContactHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("LastClickedContact")] 
		public wCHandle<gameJournalContact> LastClickedContact
		{
			get
			{
				if (_lastClickedContact == null)
				{
					_lastClickedContact = (wCHandle<gameJournalContact>) CR2WTypeManager.Create("whandle:gameJournalContact", "LastClickedContact", cr2w, this);
				}
				return _lastClickedContact;
			}
			set
			{
				if (_lastClickedContact == value)
				{
					return;
				}
				_lastClickedContact = value;
				PropertySet(this);
			}
		}

		public SocialPanelContactsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

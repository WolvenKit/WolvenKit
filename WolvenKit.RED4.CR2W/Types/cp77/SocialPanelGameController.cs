using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SocialPanelGameController : gameuiMenuGameController
	{
		private inkWidgetReference _socialPanelContactsListRef;
		private inkWidgetReference _socialPanelContactsDetailsRef;
		private wCHandle<SocialPanelContactsList> _contactsList;
		private wCHandle<SocialPanelContactsDetails> _contactDetails;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<gameJournalManager> _journalMgr;

		[Ordinal(3)] 
		[RED("SocialPanelContactsListRef")] 
		public inkWidgetReference SocialPanelContactsListRef
		{
			get
			{
				if (_socialPanelContactsListRef == null)
				{
					_socialPanelContactsListRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "SocialPanelContactsListRef", cr2w, this);
				}
				return _socialPanelContactsListRef;
			}
			set
			{
				if (_socialPanelContactsListRef == value)
				{
					return;
				}
				_socialPanelContactsListRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("SocialPanelContactsDetailsRef")] 
		public inkWidgetReference SocialPanelContactsDetailsRef
		{
			get
			{
				if (_socialPanelContactsDetailsRef == null)
				{
					_socialPanelContactsDetailsRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "SocialPanelContactsDetailsRef", cr2w, this);
				}
				return _socialPanelContactsDetailsRef;
			}
			set
			{
				if (_socialPanelContactsDetailsRef == value)
				{
					return;
				}
				_socialPanelContactsDetailsRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ContactsList")] 
		public wCHandle<SocialPanelContactsList> ContactsList
		{
			get
			{
				if (_contactsList == null)
				{
					_contactsList = (wCHandle<SocialPanelContactsList>) CR2WTypeManager.Create("whandle:SocialPanelContactsList", "ContactsList", cr2w, this);
				}
				return _contactsList;
			}
			set
			{
				if (_contactsList == value)
				{
					return;
				}
				_contactsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ContactDetails")] 
		public wCHandle<SocialPanelContactsDetails> ContactDetails
		{
			get
			{
				if (_contactDetails == null)
				{
					_contactDetails = (wCHandle<SocialPanelContactsDetails>) CR2WTypeManager.Create("whandle:SocialPanelContactsDetails", "ContactDetails", cr2w, this);
				}
				return _contactDetails;
			}
			set
			{
				if (_contactDetails == value)
				{
					return;
				}
				_contactDetails = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "RootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("JournalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get
			{
				if (_journalMgr == null)
				{
					_journalMgr = (wCHandle<gameJournalManager>) CR2WTypeManager.Create("whandle:gameJournalManager", "JournalMgr", cr2w, this);
				}
				return _journalMgr;
			}
			set
			{
				if (_journalMgr == value)
				{
					return;
				}
				_journalMgr = value;
				PropertySet(this);
			}
		}

		public SocialPanelGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

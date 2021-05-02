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
			get => GetProperty(ref _socialPanelContactsListRef);
			set => SetProperty(ref _socialPanelContactsListRef, value);
		}

		[Ordinal(4)] 
		[RED("SocialPanelContactsDetailsRef")] 
		public inkWidgetReference SocialPanelContactsDetailsRef
		{
			get => GetProperty(ref _socialPanelContactsDetailsRef);
			set => SetProperty(ref _socialPanelContactsDetailsRef, value);
		}

		[Ordinal(5)] 
		[RED("ContactsList")] 
		public wCHandle<SocialPanelContactsList> ContactsList
		{
			get => GetProperty(ref _contactsList);
			set => SetProperty(ref _contactsList, value);
		}

		[Ordinal(6)] 
		[RED("ContactDetails")] 
		public wCHandle<SocialPanelContactsDetails> ContactDetails
		{
			get => GetProperty(ref _contactDetails);
			set => SetProperty(ref _contactDetails, value);
		}

		[Ordinal(7)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(8)] 
		[RED("JournalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		public SocialPanelGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

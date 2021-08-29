using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SocialPanelGameController : gameuiMenuGameController
	{
		private inkWidgetReference _socialPanelContactsListRef;
		private inkWidgetReference _socialPanelContactsDetailsRef;
		private CWeakHandle<SocialPanelContactsList> _contactsList;
		private CWeakHandle<SocialPanelContactsDetails> _contactDetails;
		private CWeakHandle<inkWidget> _rootWidget;
		private CWeakHandle<gameJournalManager> _journalMgr;

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
		public CWeakHandle<SocialPanelContactsList> ContactsList
		{
			get => GetProperty(ref _contactsList);
			set => SetProperty(ref _contactsList, value);
		}

		[Ordinal(6)] 
		[RED("ContactDetails")] 
		public CWeakHandle<SocialPanelContactsDetails> ContactDetails
		{
			get => GetProperty(ref _contactDetails);
			set => SetProperty(ref _contactDetails, value);
		}

		[Ordinal(7)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(8)] 
		[RED("JournalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}
	}
}

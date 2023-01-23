using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SocialPanelGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("SocialPanelContactsListRef")] 
		public inkWidgetReference SocialPanelContactsListRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("SocialPanelContactsDetailsRef")] 
		public inkWidgetReference SocialPanelContactsDetailsRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("ContactsList")] 
		public CWeakHandle<SocialPanelContactsList> ContactsList
		{
			get => GetPropertyValue<CWeakHandle<SocialPanelContactsList>>();
			set => SetPropertyValue<CWeakHandle<SocialPanelContactsList>>(value);
		}

		[Ordinal(6)] 
		[RED("ContactDetails")] 
		public CWeakHandle<SocialPanelContactsDetails> ContactDetails
		{
			get => GetPropertyValue<CWeakHandle<SocialPanelContactsDetails>>();
			set => SetPropertyValue<CWeakHandle<SocialPanelContactsDetails>>(value);
		}

		[Ordinal(7)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("JournalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		public SocialPanelGameController()
		{
			SocialPanelContactsListRef = new();
			SocialPanelContactsDetailsRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

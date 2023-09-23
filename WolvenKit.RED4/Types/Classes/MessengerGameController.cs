using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MessengerGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("contactsRef")] 
		public inkWidgetReference ContactsRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("dialogRef")] 
		public inkWidgetReference DialogRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(7)] 
		[RED("dialogController")] 
		public CWeakHandle<MessengerDialogViewController> DialogController
		{
			get => GetPropertyValue<CWeakHandle<MessengerDialogViewController>>();
			set => SetPropertyValue<CWeakHandle<MessengerDialogViewController>>(value);
		}

		[Ordinal(8)] 
		[RED("listController")] 
		public CWeakHandle<SimpleMessengerContactsVirtualListController> ListController
		{
			get => GetPropertyValue<CWeakHandle<SimpleMessengerContactsVirtualListController>>();
			set => SetPropertyValue<CWeakHandle<SimpleMessengerContactsVirtualListController>>(value);
		}

		[Ordinal(9)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(10)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(11)] 
		[RED("activeData")] 
		public CHandle<MessengerContactSyncData> ActiveData
		{
			get => GetPropertyValue<CHandle<MessengerContactSyncData>>();
			set => SetPropertyValue<CHandle<MessengerContactSyncData>>(value);
		}

		public MessengerGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

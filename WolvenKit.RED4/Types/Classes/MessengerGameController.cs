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
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(8)] 
		[RED("dialogController")] 
		public CWeakHandle<MessengerDialogViewController> DialogController
		{
			get => GetPropertyValue<CWeakHandle<MessengerDialogViewController>>();
			set => SetPropertyValue<CWeakHandle<MessengerDialogViewController>>(value);
		}

		[Ordinal(9)] 
		[RED("listController")] 
		public CWeakHandle<MessengerContactsVirtualNestedListController> ListController
		{
			get => GetPropertyValue<CWeakHandle<MessengerContactsVirtualNestedListController>>();
			set => SetPropertyValue<CWeakHandle<MessengerContactsVirtualNestedListController>>(value);
		}

		[Ordinal(10)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(11)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(12)] 
		[RED("activeData")] 
		public CHandle<MessengerContactSyncData> ActiveData
		{
			get => GetPropertyValue<CHandle<MessengerContactSyncData>>();
			set => SetPropertyValue<CHandle<MessengerContactSyncData>>(value);
		}

		public MessengerGameController()
		{
			ButtonHintsManagerRef = new inkWidgetReference();
			ContactsRef = new inkWidgetReference();
			DialogRef = new inkWidgetReference();
			VirtualList = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

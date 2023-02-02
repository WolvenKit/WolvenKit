using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MessengerDialogViewController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("messagesList")] 
		public inkCompoundWidgetReference MessagesList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("choicesList")] 
		public inkCompoundWidgetReference ChoicesList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("replayFluff")] 
		public inkCompoundWidgetReference ReplayFluff
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("messagesListController")] 
		public CWeakHandle<JournalEntriesListController> MessagesListController
		{
			get => GetPropertyValue<CWeakHandle<JournalEntriesListController>>();
			set => SetPropertyValue<CWeakHandle<JournalEntriesListController>>(value);
		}

		[Ordinal(5)] 
		[RED("choicesListController")] 
		public CWeakHandle<JournalEntriesListController> ChoicesListController
		{
			get => GetPropertyValue<CWeakHandle<JournalEntriesListController>>();
			set => SetPropertyValue<CWeakHandle<JournalEntriesListController>>(value);
		}

		[Ordinal(6)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(7)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(8)] 
		[RED("replyOptions")] 
		public CArray<CWeakHandle<gameJournalEntry>> ReplyOptions
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>(value);
		}

		[Ordinal(9)] 
		[RED("messages")] 
		public CArray<CWeakHandle<gameJournalEntry>> Messages
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>(value);
		}

		[Ordinal(10)] 
		[RED("parentEntry")] 
		public CWeakHandle<gameJournalEntry> ParentEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(11)] 
		[RED("singleThreadMode")] 
		public CBool SingleThreadMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("newMessageAninmProxy")] 
		public CHandle<inkanimProxy> NewMessageAninmProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public MessengerDialogViewController()
		{
			MessagesList = new();
			ChoicesList = new();
			ReplayFluff = new();
			ReplyOptions = new();
			Messages = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

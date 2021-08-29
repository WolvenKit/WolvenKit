using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MessengerDialogViewController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _messagesList;
		private inkCompoundWidgetReference _choicesList;
		private inkCompoundWidgetReference _replayFluff;
		private CWeakHandle<JournalEntriesListController> _messagesListController;
		private CWeakHandle<JournalEntriesListController> _choicesListController;
		private CWeakHandle<inkScrollController> _scrollController;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CArray<CWeakHandle<gameJournalEntry>> _replyOptions;
		private CArray<CWeakHandle<gameJournalEntry>> _messages;
		private CWeakHandle<gameJournalEntry> _parentEntry;
		private CBool _singleThreadMode;
		private CHandle<inkanimProxy> _newMessageAninmProxy;

		[Ordinal(1)] 
		[RED("messagesList")] 
		public inkCompoundWidgetReference MessagesList
		{
			get => GetProperty(ref _messagesList);
			set => SetProperty(ref _messagesList, value);
		}

		[Ordinal(2)] 
		[RED("choicesList")] 
		public inkCompoundWidgetReference ChoicesList
		{
			get => GetProperty(ref _choicesList);
			set => SetProperty(ref _choicesList, value);
		}

		[Ordinal(3)] 
		[RED("replayFluff")] 
		public inkCompoundWidgetReference ReplayFluff
		{
			get => GetProperty(ref _replayFluff);
			set => SetProperty(ref _replayFluff, value);
		}

		[Ordinal(4)] 
		[RED("messagesListController")] 
		public CWeakHandle<JournalEntriesListController> MessagesListController
		{
			get => GetProperty(ref _messagesListController);
			set => SetProperty(ref _messagesListController, value);
		}

		[Ordinal(5)] 
		[RED("choicesListController")] 
		public CWeakHandle<JournalEntriesListController> ChoicesListController
		{
			get => GetProperty(ref _choicesListController);
			set => SetProperty(ref _choicesListController, value);
		}

		[Ordinal(6)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetProperty(ref _scrollController);
			set => SetProperty(ref _scrollController, value);
		}

		[Ordinal(7)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(8)] 
		[RED("replyOptions")] 
		public CArray<CWeakHandle<gameJournalEntry>> ReplyOptions
		{
			get => GetProperty(ref _replyOptions);
			set => SetProperty(ref _replyOptions, value);
		}

		[Ordinal(9)] 
		[RED("messages")] 
		public CArray<CWeakHandle<gameJournalEntry>> Messages
		{
			get => GetProperty(ref _messages);
			set => SetProperty(ref _messages, value);
		}

		[Ordinal(10)] 
		[RED("parentEntry")] 
		public CWeakHandle<gameJournalEntry> ParentEntry
		{
			get => GetProperty(ref _parentEntry);
			set => SetProperty(ref _parentEntry, value);
		}

		[Ordinal(11)] 
		[RED("singleThreadMode")] 
		public CBool SingleThreadMode
		{
			get => GetProperty(ref _singleThreadMode);
			set => SetProperty(ref _singleThreadMode, value);
		}

		[Ordinal(12)] 
		[RED("newMessageAninmProxy")] 
		public CHandle<inkanimProxy> NewMessageAninmProxy
		{
			get => GetProperty(ref _newMessageAninmProxy);
			set => SetProperty(ref _newMessageAninmProxy, value);
		}
	}
}

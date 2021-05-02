using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessengerDialogViewController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _messagesList;
		private inkCompoundWidgetReference _choicesList;
		private inkCompoundWidgetReference _replayFluff;
		private wCHandle<JournalEntriesListController> _messagesListController;
		private wCHandle<JournalEntriesListController> _choicesListController;
		private wCHandle<inkScrollController> _scrollController;
		private wCHandle<gameJournalManager> _journalManager;
		private CArray<wCHandle<gameJournalEntry>> _replyOptions;
		private CArray<wCHandle<gameJournalEntry>> _messages;
		private wCHandle<gameJournalEntry> _parentEntry;
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
		public wCHandle<JournalEntriesListController> MessagesListController
		{
			get => GetProperty(ref _messagesListController);
			set => SetProperty(ref _messagesListController, value);
		}

		[Ordinal(5)] 
		[RED("choicesListController")] 
		public wCHandle<JournalEntriesListController> ChoicesListController
		{
			get => GetProperty(ref _choicesListController);
			set => SetProperty(ref _choicesListController, value);
		}

		[Ordinal(6)] 
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get => GetProperty(ref _scrollController);
			set => SetProperty(ref _scrollController, value);
		}

		[Ordinal(7)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(8)] 
		[RED("replyOptions")] 
		public CArray<wCHandle<gameJournalEntry>> ReplyOptions
		{
			get => GetProperty(ref _replyOptions);
			set => SetProperty(ref _replyOptions, value);
		}

		[Ordinal(9)] 
		[RED("messages")] 
		public CArray<wCHandle<gameJournalEntry>> Messages
		{
			get => GetProperty(ref _messages);
			set => SetProperty(ref _messages, value);
		}

		[Ordinal(10)] 
		[RED("parentEntry")] 
		public wCHandle<gameJournalEntry> ParentEntry
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

		public MessengerDialogViewController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

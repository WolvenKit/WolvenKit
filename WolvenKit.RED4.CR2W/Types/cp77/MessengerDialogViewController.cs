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
			get
			{
				if (_messagesList == null)
				{
					_messagesList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "messagesList", cr2w, this);
				}
				return _messagesList;
			}
			set
			{
				if (_messagesList == value)
				{
					return;
				}
				_messagesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("choicesList")] 
		public inkCompoundWidgetReference ChoicesList
		{
			get
			{
				if (_choicesList == null)
				{
					_choicesList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "choicesList", cr2w, this);
				}
				return _choicesList;
			}
			set
			{
				if (_choicesList == value)
				{
					return;
				}
				_choicesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("replayFluff")] 
		public inkCompoundWidgetReference ReplayFluff
		{
			get
			{
				if (_replayFluff == null)
				{
					_replayFluff = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "replayFluff", cr2w, this);
				}
				return _replayFluff;
			}
			set
			{
				if (_replayFluff == value)
				{
					return;
				}
				_replayFluff = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("messagesListController")] 
		public wCHandle<JournalEntriesListController> MessagesListController
		{
			get
			{
				if (_messagesListController == null)
				{
					_messagesListController = (wCHandle<JournalEntriesListController>) CR2WTypeManager.Create("whandle:JournalEntriesListController", "messagesListController", cr2w, this);
				}
				return _messagesListController;
			}
			set
			{
				if (_messagesListController == value)
				{
					return;
				}
				_messagesListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("choicesListController")] 
		public wCHandle<JournalEntriesListController> ChoicesListController
		{
			get
			{
				if (_choicesListController == null)
				{
					_choicesListController = (wCHandle<JournalEntriesListController>) CR2WTypeManager.Create("whandle:JournalEntriesListController", "choicesListController", cr2w, this);
				}
				return _choicesListController;
			}
			set
			{
				if (_choicesListController == value)
				{
					return;
				}
				_choicesListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get
			{
				if (_scrollController == null)
				{
					_scrollController = (wCHandle<inkScrollController>) CR2WTypeManager.Create("whandle:inkScrollController", "scrollController", cr2w, this);
				}
				return _scrollController;
			}
			set
			{
				if (_scrollController == value)
				{
					return;
				}
				_scrollController = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get
			{
				if (_journalManager == null)
				{
					_journalManager = (wCHandle<gameJournalManager>) CR2WTypeManager.Create("whandle:gameJournalManager", "journalManager", cr2w, this);
				}
				return _journalManager;
			}
			set
			{
				if (_journalManager == value)
				{
					return;
				}
				_journalManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("replyOptions")] 
		public CArray<wCHandle<gameJournalEntry>> ReplyOptions
		{
			get
			{
				if (_replyOptions == null)
				{
					_replyOptions = (CArray<wCHandle<gameJournalEntry>>) CR2WTypeManager.Create("array:whandle:gameJournalEntry", "replyOptions", cr2w, this);
				}
				return _replyOptions;
			}
			set
			{
				if (_replyOptions == value)
				{
					return;
				}
				_replyOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("messages")] 
		public CArray<wCHandle<gameJournalEntry>> Messages
		{
			get
			{
				if (_messages == null)
				{
					_messages = (CArray<wCHandle<gameJournalEntry>>) CR2WTypeManager.Create("array:whandle:gameJournalEntry", "messages", cr2w, this);
				}
				return _messages;
			}
			set
			{
				if (_messages == value)
				{
					return;
				}
				_messages = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("parentEntry")] 
		public wCHandle<gameJournalEntry> ParentEntry
		{
			get
			{
				if (_parentEntry == null)
				{
					_parentEntry = (wCHandle<gameJournalEntry>) CR2WTypeManager.Create("whandle:gameJournalEntry", "parentEntry", cr2w, this);
				}
				return _parentEntry;
			}
			set
			{
				if (_parentEntry == value)
				{
					return;
				}
				_parentEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("singleThreadMode")] 
		public CBool SingleThreadMode
		{
			get
			{
				if (_singleThreadMode == null)
				{
					_singleThreadMode = (CBool) CR2WTypeManager.Create("Bool", "singleThreadMode", cr2w, this);
				}
				return _singleThreadMode;
			}
			set
			{
				if (_singleThreadMode == value)
				{
					return;
				}
				_singleThreadMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("newMessageAninmProxy")] 
		public CHandle<inkanimProxy> NewMessageAninmProxy
		{
			get
			{
				if (_newMessageAninmProxy == null)
				{
					_newMessageAninmProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "newMessageAninmProxy", cr2w, this);
				}
				return _newMessageAninmProxy;
			}
			set
			{
				if (_newMessageAninmProxy == value)
				{
					return;
				}
				_newMessageAninmProxy = value;
				PropertySet(this);
			}
		}

		public MessengerDialogViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

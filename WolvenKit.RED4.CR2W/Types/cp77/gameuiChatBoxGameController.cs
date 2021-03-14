using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiChatBoxGameController : gameuiHUDGameController
	{
		private wCHandle<gamePuppetBase> _player;
		private CUInt32 _chatBoxBlackboardId;
		private inkWidgetReference _chatBox;
		private inkTextInputWidgetReference _enteredText;
		private CBool _chatBoxOpen;
		private CArray<wCHandle<inkWidget>> _recentChatsShown;
		private wCHandle<inkVerticalPanelWidget> _recentContainer;
		private wCHandle<inkVerticalPanelWidget> _historyContainer;
		private CArray<gameuiChatBoxText> _chatHistory;
		private CInt32 _lastChatId;
		private CInt32 _maxChatsDisplayed;
		private CInt32 _maxChatHistory;

		[Ordinal(9)] 
		[RED("player")] 
		public wCHandle<gamePuppetBase> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gamePuppetBase>) CR2WTypeManager.Create("whandle:gamePuppetBase", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("chatBoxBlackboardId")] 
		public CUInt32 ChatBoxBlackboardId
		{
			get
			{
				if (_chatBoxBlackboardId == null)
				{
					_chatBoxBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "chatBoxBlackboardId", cr2w, this);
				}
				return _chatBoxBlackboardId;
			}
			set
			{
				if (_chatBoxBlackboardId == value)
				{
					return;
				}
				_chatBoxBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("chatBox")] 
		public inkWidgetReference ChatBox
		{
			get
			{
				if (_chatBox == null)
				{
					_chatBox = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "chatBox", cr2w, this);
				}
				return _chatBox;
			}
			set
			{
				if (_chatBox == value)
				{
					return;
				}
				_chatBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("enteredText")] 
		public inkTextInputWidgetReference EnteredText
		{
			get
			{
				if (_enteredText == null)
				{
					_enteredText = (inkTextInputWidgetReference) CR2WTypeManager.Create("inkTextInputWidgetReference", "enteredText", cr2w, this);
				}
				return _enteredText;
			}
			set
			{
				if (_enteredText == value)
				{
					return;
				}
				_enteredText = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("chatBoxOpen")] 
		public CBool ChatBoxOpen
		{
			get
			{
				if (_chatBoxOpen == null)
				{
					_chatBoxOpen = (CBool) CR2WTypeManager.Create("Bool", "chatBoxOpen", cr2w, this);
				}
				return _chatBoxOpen;
			}
			set
			{
				if (_chatBoxOpen == value)
				{
					return;
				}
				_chatBoxOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("recentChatsShown")] 
		public CArray<wCHandle<inkWidget>> RecentChatsShown
		{
			get
			{
				if (_recentChatsShown == null)
				{
					_recentChatsShown = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "recentChatsShown", cr2w, this);
				}
				return _recentChatsShown;
			}
			set
			{
				if (_recentChatsShown == value)
				{
					return;
				}
				_recentChatsShown = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("recentContainer")] 
		public wCHandle<inkVerticalPanelWidget> RecentContainer
		{
			get
			{
				if (_recentContainer == null)
				{
					_recentContainer = (wCHandle<inkVerticalPanelWidget>) CR2WTypeManager.Create("whandle:inkVerticalPanelWidget", "recentContainer", cr2w, this);
				}
				return _recentContainer;
			}
			set
			{
				if (_recentContainer == value)
				{
					return;
				}
				_recentContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("historyContainer")] 
		public wCHandle<inkVerticalPanelWidget> HistoryContainer
		{
			get
			{
				if (_historyContainer == null)
				{
					_historyContainer = (wCHandle<inkVerticalPanelWidget>) CR2WTypeManager.Create("whandle:inkVerticalPanelWidget", "historyContainer", cr2w, this);
				}
				return _historyContainer;
			}
			set
			{
				if (_historyContainer == value)
				{
					return;
				}
				_historyContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("chatHistory")] 
		public CArray<gameuiChatBoxText> ChatHistory
		{
			get
			{
				if (_chatHistory == null)
				{
					_chatHistory = (CArray<gameuiChatBoxText>) CR2WTypeManager.Create("array:gameuiChatBoxText", "chatHistory", cr2w, this);
				}
				return _chatHistory;
			}
			set
			{
				if (_chatHistory == value)
				{
					return;
				}
				_chatHistory = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("lastChatId")] 
		public CInt32 LastChatId
		{
			get
			{
				if (_lastChatId == null)
				{
					_lastChatId = (CInt32) CR2WTypeManager.Create("Int32", "lastChatId", cr2w, this);
				}
				return _lastChatId;
			}
			set
			{
				if (_lastChatId == value)
				{
					return;
				}
				_lastChatId = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("maxChatsDisplayed")] 
		public CInt32 MaxChatsDisplayed
		{
			get
			{
				if (_maxChatsDisplayed == null)
				{
					_maxChatsDisplayed = (CInt32) CR2WTypeManager.Create("Int32", "maxChatsDisplayed", cr2w, this);
				}
				return _maxChatsDisplayed;
			}
			set
			{
				if (_maxChatsDisplayed == value)
				{
					return;
				}
				_maxChatsDisplayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("maxChatHistory")] 
		public CInt32 MaxChatHistory
		{
			get
			{
				if (_maxChatHistory == null)
				{
					_maxChatHistory = (CInt32) CR2WTypeManager.Create("Int32", "maxChatHistory", cr2w, this);
				}
				return _maxChatHistory;
			}
			set
			{
				if (_maxChatHistory == value)
				{
					return;
				}
				_maxChatHistory = value;
				PropertySet(this);
			}
		}

		public gameuiChatBoxGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiChatBoxGameController : gameuiHUDGameController
	{
		private CWeakHandle<gamePuppetBase> _player;
		private CHandle<redCallbackObject> _chatBoxBlackboardId;
		private inkWidgetReference _chatBox;
		private inkTextInputWidgetReference _enteredText;
		private CBool _chatBoxOpen;
		private CArray<CWeakHandle<inkWidget>> _recentChatsShown;
		private CWeakHandle<inkVerticalPanelWidget> _recentContainer;
		private CWeakHandle<inkVerticalPanelWidget> _historyContainer;
		private CArray<gameuiChatBoxText> _chatHistory;
		private CInt32 _lastChatId;
		private CInt32 _maxChatsDisplayed;
		private CInt32 _maxChatHistory;

		[Ordinal(9)] 
		[RED("player")] 
		public CWeakHandle<gamePuppetBase> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(10)] 
		[RED("chatBoxBlackboardId")] 
		public CHandle<redCallbackObject> ChatBoxBlackboardId
		{
			get => GetProperty(ref _chatBoxBlackboardId);
			set => SetProperty(ref _chatBoxBlackboardId, value);
		}

		[Ordinal(11)] 
		[RED("chatBox")] 
		public inkWidgetReference ChatBox
		{
			get => GetProperty(ref _chatBox);
			set => SetProperty(ref _chatBox, value);
		}

		[Ordinal(12)] 
		[RED("enteredText")] 
		public inkTextInputWidgetReference EnteredText
		{
			get => GetProperty(ref _enteredText);
			set => SetProperty(ref _enteredText, value);
		}

		[Ordinal(13)] 
		[RED("chatBoxOpen")] 
		public CBool ChatBoxOpen
		{
			get => GetProperty(ref _chatBoxOpen);
			set => SetProperty(ref _chatBoxOpen, value);
		}

		[Ordinal(14)] 
		[RED("recentChatsShown")] 
		public CArray<CWeakHandle<inkWidget>> RecentChatsShown
		{
			get => GetProperty(ref _recentChatsShown);
			set => SetProperty(ref _recentChatsShown, value);
		}

		[Ordinal(15)] 
		[RED("recentContainer")] 
		public CWeakHandle<inkVerticalPanelWidget> RecentContainer
		{
			get => GetProperty(ref _recentContainer);
			set => SetProperty(ref _recentContainer, value);
		}

		[Ordinal(16)] 
		[RED("historyContainer")] 
		public CWeakHandle<inkVerticalPanelWidget> HistoryContainer
		{
			get => GetProperty(ref _historyContainer);
			set => SetProperty(ref _historyContainer, value);
		}

		[Ordinal(17)] 
		[RED("chatHistory")] 
		public CArray<gameuiChatBoxText> ChatHistory
		{
			get => GetProperty(ref _chatHistory);
			set => SetProperty(ref _chatHistory, value);
		}

		[Ordinal(18)] 
		[RED("lastChatId")] 
		public CInt32 LastChatId
		{
			get => GetProperty(ref _lastChatId);
			set => SetProperty(ref _lastChatId, value);
		}

		[Ordinal(19)] 
		[RED("maxChatsDisplayed")] 
		public CInt32 MaxChatsDisplayed
		{
			get => GetProperty(ref _maxChatsDisplayed);
			set => SetProperty(ref _maxChatsDisplayed, value);
		}

		[Ordinal(20)] 
		[RED("maxChatHistory")] 
		public CInt32 MaxChatHistory
		{
			get => GetProperty(ref _maxChatHistory);
			set => SetProperty(ref _maxChatHistory, value);
		}

		public gameuiChatBoxGameController()
		{
			_maxChatsDisplayed = 7;
			_maxChatHistory = 100;
		}
	}
}

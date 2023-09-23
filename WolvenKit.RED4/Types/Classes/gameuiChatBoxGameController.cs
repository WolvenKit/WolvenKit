using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiChatBoxGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("player")] 
		public CWeakHandle<gamePuppetBase> Player
		{
			get => GetPropertyValue<CWeakHandle<gamePuppetBase>>();
			set => SetPropertyValue<CWeakHandle<gamePuppetBase>>(value);
		}

		[Ordinal(10)] 
		[RED("chatBoxBlackboardId")] 
		public CHandle<redCallbackObject> ChatBoxBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("chatBox")] 
		public inkWidgetReference ChatBox
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("enteredText")] 
		public inkTextInputWidgetReference EnteredText
		{
			get => GetPropertyValue<inkTextInputWidgetReference>();
			set => SetPropertyValue<inkTextInputWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("chatBoxOpen")] 
		public CBool ChatBoxOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("recentChatsShown")] 
		public CArray<CWeakHandle<inkWidget>> RecentChatsShown
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(15)] 
		[RED("recentContainer")] 
		public CWeakHandle<inkVerticalPanelWidget> RecentContainer
		{
			get => GetPropertyValue<CWeakHandle<inkVerticalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVerticalPanelWidget>>(value);
		}

		[Ordinal(16)] 
		[RED("historyContainer")] 
		public CWeakHandle<inkVerticalPanelWidget> HistoryContainer
		{
			get => GetPropertyValue<CWeakHandle<inkVerticalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVerticalPanelWidget>>(value);
		}

		[Ordinal(17)] 
		[RED("chatHistory")] 
		public CArray<gameuiChatBoxText> ChatHistory
		{
			get => GetPropertyValue<CArray<gameuiChatBoxText>>();
			set => SetPropertyValue<CArray<gameuiChatBoxText>>(value);
		}

		[Ordinal(18)] 
		[RED("lastChatId")] 
		public CInt32 LastChatId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("maxChatsDisplayed")] 
		public CInt32 MaxChatsDisplayed
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("maxChatHistory")] 
		public CInt32 MaxChatHistory
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiChatBoxGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

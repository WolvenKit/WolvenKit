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
		[RED("typingFluff")] 
		public inkWidgetReference TypingFluff
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("typingIndicator")] 
		public inkWidgetReference TypingIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("messagesListController")] 
		public CWeakHandle<JournalEntriesListController> MessagesListController
		{
			get => GetPropertyValue<CWeakHandle<JournalEntriesListController>>();
			set => SetPropertyValue<CWeakHandle<JournalEntriesListController>>(value);
		}

		[Ordinal(7)] 
		[RED("choicesListController")] 
		public CWeakHandle<JournalEntriesListController> ChoicesListController
		{
			get => GetPropertyValue<CWeakHandle<JournalEntriesListController>>();
			set => SetPropertyValue<CWeakHandle<JournalEntriesListController>>(value);
		}

		[Ordinal(8)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(9)] 
		[RED("typingIndicatorController")] 
		public CWeakHandle<MessengerTypingIndicator> TypingIndicatorController
		{
			get => GetPropertyValue<CWeakHandle<MessengerTypingIndicator>>();
			set => SetPropertyValue<CWeakHandle<MessengerTypingIndicator>>(value);
		}

		[Ordinal(10)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(11)] 
		[RED("playerObject")] 
		public CWeakHandle<gameObject> PlayerObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(12)] 
		[RED("delaySystem")] 
		public CWeakHandle<gameDelaySystem> DelaySystem
		{
			get => GetPropertyValue<CWeakHandle<gameDelaySystem>>();
			set => SetPropertyValue<CWeakHandle<gameDelaySystem>>(value);
		}

		[Ordinal(13)] 
		[RED("delayedTypingCallbackId")] 
		public gameDelayID DelayedTypingCallbackId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(14)] 
		[RED("replyOptions")] 
		public CArray<CWeakHandle<gameJournalEntry>> ReplyOptions
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>(value);
		}

		[Ordinal(15)] 
		[RED("messages")] 
		public CArray<CWeakHandle<gameJournalEntry>> Messages
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>(value);
		}

		[Ordinal(16)] 
		[RED("parentEntry")] 
		public CWeakHandle<gameJournalEntry> ParentEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(17)] 
		[RED("parentHash")] 
		public CInt32 ParentHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("typingAnimProxy")] 
		public CHandle<inkanimProxy> TypingAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("delayTypingAnimProxy")] 
		public CHandle<inkanimProxy> DelayTypingAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(20)] 
		[RED("singleThreadMode")] 
		public CBool SingleThreadMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("hasFocus")] 
		public CBool HasFocus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("audioSystem")] 
		public CWeakHandle<gameGameAudioSystem> AudioSystem
		{
			get => GetPropertyValue<CWeakHandle<gameGameAudioSystem>>();
			set => SetPropertyValue<CWeakHandle<gameGameAudioSystem>>(value);
		}

		[Ordinal(23)] 
		[RED("minimumTypingDelay")] 
		public CFloat MinimumTypingDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("breakingTypingAnimProxy")] 
		public CHandle<inkanimProxy> BreakingTypingAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public MessengerDialogViewController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

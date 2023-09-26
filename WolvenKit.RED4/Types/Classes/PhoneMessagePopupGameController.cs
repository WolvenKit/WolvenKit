using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneMessagePopupGameController : gameuiNewPhoneRelatedGameController
	{
		[Ordinal(3)] 
		[RED("content")] 
		public inkWidgetReference Content
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("avatarImage")] 
		public inkImageWidgetReference AvatarImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("menuBackgrouns")] 
		public inkWidgetReference MenuBackgrouns
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("hintsContainer")] 
		public inkWidgetReference HintsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("hintTrack")] 
		public inkWidgetReference HintTrack
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("hintClose")] 
		public inkWidgetReference HintClose
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("hintReply")] 
		public inkWidgetReference HintReply
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("scrollReply")] 
		public inkWidgetReference ScrollReply
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("hintMessenger")] 
		public inkWidgetReference HintMessenger
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("hintCall")] 
		public inkWidgetReference HintCall
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("scrollSlider")] 
		public inkWidgetReference ScrollSlider
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("contactsPath")] 
		public inkWidgetReference ContactsPath
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("messagesPath")] 
		public inkWidgetReference MessagesPath
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(18)] 
		[RED("blackboardDef")] 
		public CHandle<UI_ComDeviceDef> BlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_ComDeviceDef>>();
			set => SetPropertyValue<CHandle<UI_ComDeviceDef>>(value);
		}

		[Ordinal(19)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(20)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(21)] 
		[RED("journalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(22)] 
		[RED("phoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetPropertyValue<CWeakHandle<PhoneSystem>>();
			set => SetPropertyValue<CWeakHandle<PhoneSystem>>(value);
		}

		[Ordinal(23)] 
		[RED("data")] 
		public CHandle<JournalNotificationData> Data
		{
			get => GetPropertyValue<CHandle<JournalNotificationData>>();
			set => SetPropertyValue<CHandle<JournalNotificationData>>(value);
		}

		[Ordinal(24)] 
		[RED("entry")] 
		public CWeakHandle<gameJournalPhoneMessage> Entry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalPhoneMessage>>();
			set => SetPropertyValue<CWeakHandle<gameJournalPhoneMessage>>(value);
		}

		[Ordinal(25)] 
		[RED("contactEntry")] 
		public CWeakHandle<gameJournalContact> ContactEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalContact>>();
			set => SetPropertyValue<CWeakHandle<gameJournalContact>>(value);
		}

		[Ordinal(26)] 
		[RED("attachment")] 
		public CWeakHandle<gameJournalEntry> Attachment
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(27)] 
		[RED("attachmentState")] 
		public CEnum<gameJournalEntryState> AttachmentState
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(28)] 
		[RED("attachmentHash")] 
		public CUInt32 AttachmentHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(29)] 
		[RED("activeEntry")] 
		public CWeakHandle<gameJournalEntry> ActiveEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(30)] 
		[RED("dialogViewController")] 
		public CWeakHandle<MessengerDialogViewController> DialogViewController
		{
			get => GetPropertyValue<CWeakHandle<MessengerDialogViewController>>();
			set => SetPropertyValue<CWeakHandle<MessengerDialogViewController>>(value);
		}

		[Ordinal(31)] 
		[RED("journalEntryHash")] 
		public CInt32 JournalEntryHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(32)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(33)] 
		[RED("isFocused")] 
		public CBool IsFocused
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("isHubVisiale")] 
		public CBool IsHubVisiale
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PhoneMessagePopupGameController()
		{
			Content = new inkWidgetReference();
			Title = new inkTextWidgetReference();
			AvatarImage = new inkImageWidgetReference();
			MenuBackgrouns = new inkWidgetReference();
			HintsContainer = new inkWidgetReference();
			HintTrack = new inkWidgetReference();
			HintClose = new inkWidgetReference();
			HintReply = new inkWidgetReference();
			ScrollReply = new inkWidgetReference();
			HintMessenger = new inkWidgetReference();
			HintCall = new inkWidgetReference();
			ScrollSlider = new inkWidgetReference();
			ContactsPath = new inkWidgetReference();
			MessagesPath = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

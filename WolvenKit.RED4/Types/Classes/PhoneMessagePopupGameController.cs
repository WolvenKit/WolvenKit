using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneMessagePopupGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("content")] 
		public inkWidgetReference Content
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("avatarImage")] 
		public inkImageWidgetReference AvatarImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("menuBackgrouns")] 
		public inkWidgetReference MenuBackgrouns
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("hintTrack")] 
		public inkWidgetReference HintTrack
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("hintClose")] 
		public inkWidgetReference HintClose
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("hintReply")] 
		public inkWidgetReference HintReply
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("hintMessenger")] 
		public inkWidgetReference HintMessenger
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("blackboardDef")] 
		public CHandle<UI_ComDeviceDef> BlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_ComDeviceDef>>();
			set => SetPropertyValue<CHandle<UI_ComDeviceDef>>(value);
		}

		[Ordinal(12)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(13)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(14)] 
		[RED("journalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(15)] 
		[RED("data")] 
		public CHandle<JournalNotificationData> Data
		{
			get => GetPropertyValue<CHandle<JournalNotificationData>>();
			set => SetPropertyValue<CHandle<JournalNotificationData>>(value);
		}

		[Ordinal(16)] 
		[RED("entry")] 
		public CWeakHandle<gameJournalPhoneMessage> Entry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalPhoneMessage>>();
			set => SetPropertyValue<CWeakHandle<gameJournalPhoneMessage>>(value);
		}

		[Ordinal(17)] 
		[RED("contactEntry")] 
		public CWeakHandle<gameJournalContact> ContactEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalContact>>();
			set => SetPropertyValue<CWeakHandle<gameJournalContact>>(value);
		}

		[Ordinal(18)] 
		[RED("attachment")] 
		public CWeakHandle<gameJournalEntry> Attachment
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(19)] 
		[RED("attachmentState")] 
		public CEnum<gameJournalEntryState> AttachmentState
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(20)] 
		[RED("attachmentHash")] 
		public CUInt32 AttachmentHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(21)] 
		[RED("activeEntry")] 
		public CWeakHandle<gameJournalEntry> ActiveEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(22)] 
		[RED("dialogViewController")] 
		public CWeakHandle<MessengerDialogViewController> DialogViewController
		{
			get => GetPropertyValue<CWeakHandle<MessengerDialogViewController>>();
			set => SetPropertyValue<CWeakHandle<MessengerDialogViewController>>(value);
		}

		[Ordinal(23)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public PhoneMessagePopupGameController()
		{
			Content = new();
			Title = new();
			AvatarImage = new();
			MenuBackgrouns = new();
			HintTrack = new();
			HintClose = new();
			HintReply = new();
			HintMessenger = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ContactData : IScriptable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("localizedPreview")] 
		public CString LocalizedPreview
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("avatarID")] 
		public TweakDBID AvatarID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("questRelated")] 
		public CBool QuestRelated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("hasQuestImportantReply")] 
		public CBool HasQuestImportantReply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("hasMessages")] 
		public CBool HasMessages
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("unreadMessegeCount")] 
		public CInt32 UnreadMessegeCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("unreadMessages")] 
		public CArray<CInt32> UnreadMessages
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(9)] 
		[RED("playerCanReply")] 
		public CBool PlayerCanReply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("playerIsLastSender")] 
		public CBool PlayerIsLastSender
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("lastMesssagePreview")] 
		public CString LastMesssagePreview
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(12)] 
		[RED("activeDataSync")] 
		public CWeakHandle<MessengerContactSyncData> ActiveDataSync
		{
			get => GetPropertyValue<CWeakHandle<MessengerContactSyncData>>();
			set => SetPropertyValue<CWeakHandle<MessengerContactSyncData>>(value);
		}

		[Ordinal(13)] 
		[RED("threadsCount")] 
		public CInt32 ThreadsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("timeStamp")] 
		public GameTime TimeStamp
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(15)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("conversationHash")] 
		public CInt32 ConversationHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("type")] 
		public CEnum<MessengerContactType> Type
		{
			get => GetPropertyValue<CEnum<MessengerContactType>>();
			set => SetPropertyValue<CEnum<MessengerContactType>>(value);
		}

		[Ordinal(18)] 
		[RED("hasValidTitle")] 
		public CBool HasValidTitle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("isCallable")] 
		public CBool IsCallable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("contactId")] 
		public CString ContactId
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(21)] 
		[RED("messagesCount")] 
		public CInt32 MessagesCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(22)] 
		[RED("repliesCount")] 
		public CInt32 RepliesCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ContactData()
		{
			UnreadMessages = new();
			TimeStamp = new GameTime();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

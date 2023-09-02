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
		[RED("avatarID")] 
		public TweakDBID AvatarID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("questRelated")] 
		public CBool QuestRelated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("hasMessages")] 
		public CBool HasMessages
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("unreadMessegeCount")] 
		public CInt32 UnreadMessegeCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("unreadMessages")] 
		public CArray<CInt32> UnreadMessages
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(7)] 
		[RED("playerCanReply")] 
		public CBool PlayerCanReply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("playerIsLastSender")] 
		public CBool PlayerIsLastSender
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("lastMesssagePreview")] 
		public CString LastMesssagePreview
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("activeDataSync")] 
		public CWeakHandle<MessengerContactSyncData> ActiveDataSync
		{
			get => GetPropertyValue<CWeakHandle<MessengerContactSyncData>>();
			set => SetPropertyValue<CWeakHandle<MessengerContactSyncData>>(value);
		}

		[Ordinal(11)] 
		[RED("threadsCount")] 
		public CInt32 ThreadsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("timeStamp")] 
		public GameTime TimeStamp
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(13)] 
		[RED("hash")] 
		public CInt32 Hash
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

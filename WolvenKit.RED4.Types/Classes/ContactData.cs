using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ContactData : IScriptable
	{
		private CString _id;
		private CString _localizedName;
		private TweakDBID _avatarID;
		private CBool _questRelated;
		private CBool _hasMessages;
		private CInt32 _unreadMessegeCount;
		private CArray<CInt32> _unreadMessages;
		private CBool _playerCanReply;
		private CBool _playerIsLastSender;
		private CString _lastMesssagePreview;
		private CWeakHandle<MessengerContactSyncData> _activeDataSync;
		private CInt32 _threadsCount;
		private GameTime _timeStamp;
		private CInt32 _hash;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		[Ordinal(2)] 
		[RED("avatarID")] 
		public TweakDBID AvatarID
		{
			get => GetProperty(ref _avatarID);
			set => SetProperty(ref _avatarID, value);
		}

		[Ordinal(3)] 
		[RED("questRelated")] 
		public CBool QuestRelated
		{
			get => GetProperty(ref _questRelated);
			set => SetProperty(ref _questRelated, value);
		}

		[Ordinal(4)] 
		[RED("hasMessages")] 
		public CBool HasMessages
		{
			get => GetProperty(ref _hasMessages);
			set => SetProperty(ref _hasMessages, value);
		}

		[Ordinal(5)] 
		[RED("unreadMessegeCount")] 
		public CInt32 UnreadMessegeCount
		{
			get => GetProperty(ref _unreadMessegeCount);
			set => SetProperty(ref _unreadMessegeCount, value);
		}

		[Ordinal(6)] 
		[RED("unreadMessages")] 
		public CArray<CInt32> UnreadMessages
		{
			get => GetProperty(ref _unreadMessages);
			set => SetProperty(ref _unreadMessages, value);
		}

		[Ordinal(7)] 
		[RED("playerCanReply")] 
		public CBool PlayerCanReply
		{
			get => GetProperty(ref _playerCanReply);
			set => SetProperty(ref _playerCanReply, value);
		}

		[Ordinal(8)] 
		[RED("playerIsLastSender")] 
		public CBool PlayerIsLastSender
		{
			get => GetProperty(ref _playerIsLastSender);
			set => SetProperty(ref _playerIsLastSender, value);
		}

		[Ordinal(9)] 
		[RED("lastMesssagePreview")] 
		public CString LastMesssagePreview
		{
			get => GetProperty(ref _lastMesssagePreview);
			set => SetProperty(ref _lastMesssagePreview, value);
		}

		[Ordinal(10)] 
		[RED("activeDataSync")] 
		public CWeakHandle<MessengerContactSyncData> ActiveDataSync
		{
			get => GetProperty(ref _activeDataSync);
			set => SetProperty(ref _activeDataSync, value);
		}

		[Ordinal(11)] 
		[RED("threadsCount")] 
		public CInt32 ThreadsCount
		{
			get => GetProperty(ref _threadsCount);
			set => SetProperty(ref _threadsCount, value);
		}

		[Ordinal(12)] 
		[RED("timeStamp")] 
		public GameTime TimeStamp
		{
			get => GetProperty(ref _timeStamp);
			set => SetProperty(ref _timeStamp, value);
		}

		[Ordinal(13)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}
	}
}

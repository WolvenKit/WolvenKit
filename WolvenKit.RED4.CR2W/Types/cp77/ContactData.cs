using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ContactData : IScriptable
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
		private wCHandle<MessengerContactSyncData> _activeDataSync;
		private CInt32 _threadsCount;
		private GameTime _timeStamp;
		private CInt32 _hash;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CString) CR2WTypeManager.Create("String", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get
			{
				if (_localizedName == null)
				{
					_localizedName = (CString) CR2WTypeManager.Create("String", "localizedName", cr2w, this);
				}
				return _localizedName;
			}
			set
			{
				if (_localizedName == value)
				{
					return;
				}
				_localizedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("avatarID")] 
		public TweakDBID AvatarID
		{
			get
			{
				if (_avatarID == null)
				{
					_avatarID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "avatarID", cr2w, this);
				}
				return _avatarID;
			}
			set
			{
				if (_avatarID == value)
				{
					return;
				}
				_avatarID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("questRelated")] 
		public CBool QuestRelated
		{
			get
			{
				if (_questRelated == null)
				{
					_questRelated = (CBool) CR2WTypeManager.Create("Bool", "questRelated", cr2w, this);
				}
				return _questRelated;
			}
			set
			{
				if (_questRelated == value)
				{
					return;
				}
				_questRelated = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hasMessages")] 
		public CBool HasMessages
		{
			get
			{
				if (_hasMessages == null)
				{
					_hasMessages = (CBool) CR2WTypeManager.Create("Bool", "hasMessages", cr2w, this);
				}
				return _hasMessages;
			}
			set
			{
				if (_hasMessages == value)
				{
					return;
				}
				_hasMessages = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("unreadMessegeCount")] 
		public CInt32 UnreadMessegeCount
		{
			get
			{
				if (_unreadMessegeCount == null)
				{
					_unreadMessegeCount = (CInt32) CR2WTypeManager.Create("Int32", "unreadMessegeCount", cr2w, this);
				}
				return _unreadMessegeCount;
			}
			set
			{
				if (_unreadMessegeCount == value)
				{
					return;
				}
				_unreadMessegeCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("unreadMessages")] 
		public CArray<CInt32> UnreadMessages
		{
			get
			{
				if (_unreadMessages == null)
				{
					_unreadMessages = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "unreadMessages", cr2w, this);
				}
				return _unreadMessages;
			}
			set
			{
				if (_unreadMessages == value)
				{
					return;
				}
				_unreadMessages = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playerCanReply")] 
		public CBool PlayerCanReply
		{
			get
			{
				if (_playerCanReply == null)
				{
					_playerCanReply = (CBool) CR2WTypeManager.Create("Bool", "playerCanReply", cr2w, this);
				}
				return _playerCanReply;
			}
			set
			{
				if (_playerCanReply == value)
				{
					return;
				}
				_playerCanReply = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("playerIsLastSender")] 
		public CBool PlayerIsLastSender
		{
			get
			{
				if (_playerIsLastSender == null)
				{
					_playerIsLastSender = (CBool) CR2WTypeManager.Create("Bool", "playerIsLastSender", cr2w, this);
				}
				return _playerIsLastSender;
			}
			set
			{
				if (_playerIsLastSender == value)
				{
					return;
				}
				_playerIsLastSender = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lastMesssagePreview")] 
		public CString LastMesssagePreview
		{
			get
			{
				if (_lastMesssagePreview == null)
				{
					_lastMesssagePreview = (CString) CR2WTypeManager.Create("String", "lastMesssagePreview", cr2w, this);
				}
				return _lastMesssagePreview;
			}
			set
			{
				if (_lastMesssagePreview == value)
				{
					return;
				}
				_lastMesssagePreview = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("activeDataSync")] 
		public wCHandle<MessengerContactSyncData> ActiveDataSync
		{
			get
			{
				if (_activeDataSync == null)
				{
					_activeDataSync = (wCHandle<MessengerContactSyncData>) CR2WTypeManager.Create("whandle:MessengerContactSyncData", "activeDataSync", cr2w, this);
				}
				return _activeDataSync;
			}
			set
			{
				if (_activeDataSync == value)
				{
					return;
				}
				_activeDataSync = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("threadsCount")] 
		public CInt32 ThreadsCount
		{
			get
			{
				if (_threadsCount == null)
				{
					_threadsCount = (CInt32) CR2WTypeManager.Create("Int32", "threadsCount", cr2w, this);
				}
				return _threadsCount;
			}
			set
			{
				if (_threadsCount == value)
				{
					return;
				}
				_threadsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("timeStamp")] 
		public GameTime TimeStamp
		{
			get
			{
				if (_timeStamp == null)
				{
					_timeStamp = (GameTime) CR2WTypeManager.Create("GameTime", "timeStamp", cr2w, this);
				}
				return _timeStamp;
			}
			set
			{
				if (_timeStamp == value)
				{
					return;
				}
				_timeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get
			{
				if (_hash == null)
				{
					_hash = (CInt32) CR2WTypeManager.Create("Int32", "hash", cr2w, this);
				}
				return _hash;
			}
			set
			{
				if (_hash == value)
				{
					return;
				}
				_hash = value;
				PropertySet(this);
			}
		}

		public ContactData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

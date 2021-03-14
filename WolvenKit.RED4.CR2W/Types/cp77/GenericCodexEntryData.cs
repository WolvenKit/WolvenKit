using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericCodexEntryData : IScriptable
	{
		private CInt32 _hash;
		private CString _title;
		private CString _description;
		private TweakDBID _imageId;
		private CInt32 _counter;
		private GameTime _timeStamp;
		private CBool _isNew;
		private CArray<CInt32> _newEntries;
		private gameItemID _itemID;
		private wCHandle<CodexListSyncData> _activeDataSync;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get
			{
				if (_imageId == null)
				{
					_imageId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "imageId", cr2w, this);
				}
				return _imageId;
			}
			set
			{
				if (_imageId == value)
				{
					return;
				}
				_imageId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get
			{
				if (_counter == null)
				{
					_counter = (CInt32) CR2WTypeManager.Create("Int32", "counter", cr2w, this);
				}
				return _counter;
			}
			set
			{
				if (_counter == value)
				{
					return;
				}
				_counter = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get
			{
				if (_isNew == null)
				{
					_isNew = (CBool) CR2WTypeManager.Create("Bool", "isNew", cr2w, this);
				}
				return _isNew;
			}
			set
			{
				if (_isNew == value)
				{
					return;
				}
				_isNew = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("newEntries")] 
		public CArray<CInt32> NewEntries
		{
			get
			{
				if (_newEntries == null)
				{
					_newEntries = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "newEntries", cr2w, this);
				}
				return _newEntries;
			}
			set
			{
				if (_newEntries == value)
				{
					return;
				}
				_newEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("activeDataSync")] 
		public wCHandle<CodexListSyncData> ActiveDataSync
		{
			get
			{
				if (_activeDataSync == null)
				{
					_activeDataSync = (wCHandle<CodexListSyncData>) CR2WTypeManager.Create("whandle:CodexListSyncData", "activeDataSync", cr2w, this);
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

		public GenericCodexEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

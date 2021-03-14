using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCollectedNotificationViewData : gameuiGenericNotificationViewData
	{
		private CHandle<gameJournalOnscreen> _entry;
		private CBool _isCrypted;
		private gameItemID _itemID;
		private CString _shardTitle;

		[Ordinal(5)] 
		[RED("entry")] 
		public CHandle<gameJournalOnscreen> Entry
		{
			get
			{
				if (_entry == null)
				{
					_entry = (CHandle<gameJournalOnscreen>) CR2WTypeManager.Create("handle:gameJournalOnscreen", "entry", cr2w, this);
				}
				return _entry;
			}
			set
			{
				if (_entry == value)
				{
					return;
				}
				_entry = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isCrypted")] 
		public CBool IsCrypted
		{
			get
			{
				if (_isCrypted == null)
				{
					_isCrypted = (CBool) CR2WTypeManager.Create("Bool", "isCrypted", cr2w, this);
				}
				return _isCrypted;
			}
			set
			{
				if (_isCrypted == value)
				{
					return;
				}
				_isCrypted = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("shardTitle")] 
		public CString ShardTitle
		{
			get
			{
				if (_shardTitle == null)
				{
					_shardTitle = (CString) CR2WTypeManager.Create("String", "shardTitle", cr2w, this);
				}
				return _shardTitle;
			}
			set
			{
				if (_shardTitle == value)
				{
					return;
				}
				_shardTitle = value;
				PropertySet(this);
			}
		}

		public ShardCollectedNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

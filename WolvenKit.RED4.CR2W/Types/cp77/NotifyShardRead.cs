using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NotifyShardRead : redEvent
	{
		private CHandle<gameJournalOnscreen> _entry;
		private CString _title;
		private CString _text;
		private CBool _isCrypted;
		private gameItemID _itemID;

		[Ordinal(0)] 
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
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		public NotifyShardRead(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

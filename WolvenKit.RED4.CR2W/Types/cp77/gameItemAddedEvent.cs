using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemAddedEvent : redEvent
	{
		private gameItemID _itemID;
		private CHandle<gameItemData> _itemData;
		private CInt32 _currentQuantity;
		private CBool _flaggedAsSilent;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("itemData")] 
		public CHandle<gameItemData> ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (CHandle<gameItemData>) CR2WTypeManager.Create("handle:gameItemData", "itemData", cr2w, this);
				}
				return _itemData;
			}
			set
			{
				if (_itemData == value)
				{
					return;
				}
				_itemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("currentQuantity")] 
		public CInt32 CurrentQuantity
		{
			get
			{
				if (_currentQuantity == null)
				{
					_currentQuantity = (CInt32) CR2WTypeManager.Create("Int32", "currentQuantity", cr2w, this);
				}
				return _currentQuantity;
			}
			set
			{
				if (_currentQuantity == value)
				{
					return;
				}
				_currentQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("flaggedAsSilent")] 
		public CBool FlaggedAsSilent
		{
			get
			{
				if (_flaggedAsSilent == null)
				{
					_flaggedAsSilent = (CBool) CR2WTypeManager.Create("Bool", "flaggedAsSilent", cr2w, this);
				}
				return _flaggedAsSilent;
			}
			set
			{
				if (_flaggedAsSilent == value)
				{
					return;
				}
				_flaggedAsSilent = value;
				PropertySet(this);
			}
		}

		public gameItemAddedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

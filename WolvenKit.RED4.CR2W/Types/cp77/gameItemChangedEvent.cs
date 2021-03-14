using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemChangedEvent : redEvent
	{
		private gameItemID _itemID;
		private CHandle<gameItemData> _itemData;
		private CInt32 _difference;
		private CInt32 _currentQuantity;

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
		[RED("difference")] 
		public CInt32 Difference
		{
			get
			{
				if (_difference == null)
				{
					_difference = (CInt32) CR2WTypeManager.Create("Int32", "difference", cr2w, this);
				}
				return _difference;
			}
			set
			{
				if (_difference == value)
				{
					return;
				}
				_difference = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public gameItemChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInventorySlotInfo : CVariable
	{
		private TweakDBID _itemCategory;
		private gameItemID _itemId;
		private CUInt32 _quantity;

		[Ordinal(0)] 
		[RED("itemCategory")] 
		public TweakDBID ItemCategory
		{
			get
			{
				if (_itemCategory == null)
				{
					_itemCategory = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemCategory", cr2w, this);
				}
				return _itemCategory;
			}
			set
			{
				if (_itemCategory == value)
				{
					return;
				}
				_itemCategory = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("quantity")] 
		public CUInt32 Quantity
		{
			get
			{
				if (_quantity == null)
				{
					_quantity = (CUInt32) CR2WTypeManager.Create("Uint32", "quantity", cr2w, this);
				}
				return _quantity;
			}
			set
			{
				if (_quantity == value)
				{
					return;
				}
				_quantity = value;
				PropertySet(this);
			}
		}

		public gameMuppetInventorySlotInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

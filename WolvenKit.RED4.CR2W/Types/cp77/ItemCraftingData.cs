using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCraftingData : IScriptable
	{
		private InventoryItemData _inventoryItem;
		private CBool _isCraftable;

		[Ordinal(0)] 
		[RED("inventoryItem")] 
		public InventoryItemData InventoryItem
		{
			get
			{
				if (_inventoryItem == null)
				{
					_inventoryItem = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "inventoryItem", cr2w, this);
				}
				return _inventoryItem;
			}
			set
			{
				if (_inventoryItem == value)
				{
					return;
				}
				_inventoryItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get
			{
				if (_isCraftable == null)
				{
					_isCraftable = (CBool) CR2WTypeManager.Create("Bool", "isCraftable", cr2w, this);
				}
				return _isCraftable;
			}
			set
			{
				if (_isCraftable == value)
				{
					return;
				}
				_isCraftable = value;
				PropertySet(this);
			}
		}

		public ItemCraftingData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

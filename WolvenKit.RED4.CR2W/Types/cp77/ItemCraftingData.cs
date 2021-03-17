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
			get => GetProperty(ref _inventoryItem);
			set => SetProperty(ref _inventoryItem, value);
		}

		[Ordinal(1)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get => GetProperty(ref _isCraftable);
			set => SetProperty(ref _isCraftable, value);
		}

		public ItemCraftingData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

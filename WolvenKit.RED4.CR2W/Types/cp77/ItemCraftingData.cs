using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCraftingData : IScriptable
	{
		private InventoryItemData _inventoryItem;
		private CBool _isUpgradable;
		private CBool _isNew;
		private CBool _isSelected;

		[Ordinal(0)] 
		[RED("inventoryItem")] 
		public InventoryItemData InventoryItem
		{
			get => GetProperty(ref _inventoryItem);
			set => SetProperty(ref _inventoryItem, value);
		}

		[Ordinal(1)] 
		[RED("isUpgradable")] 
		public CBool IsUpgradable
		{
			get => GetProperty(ref _isUpgradable);
			set => SetProperty(ref _isUpgradable, value);
		}

		[Ordinal(2)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}

		[Ordinal(3)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}

		public ItemCraftingData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

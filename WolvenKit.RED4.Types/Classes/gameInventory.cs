using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventory : gameComponent
	{
		private CBool _saveInventory;
		private CEnum<gameSharedInventoryTag> _inventoryTag;
		private CBool _noInitialization;

		[Ordinal(4)] 
		[RED("saveInventory")] 
		public CBool SaveInventory
		{
			get => GetProperty(ref _saveInventory);
			set => SetProperty(ref _saveInventory, value);
		}

		[Ordinal(5)] 
		[RED("inventoryTag")] 
		public CEnum<gameSharedInventoryTag> InventoryTag
		{
			get => GetProperty(ref _inventoryTag);
			set => SetProperty(ref _inventoryTag, value);
		}

		[Ordinal(6)] 
		[RED("noInitialization")] 
		public CBool NoInitialization
		{
			get => GetProperty(ref _noInitialization);
			set => SetProperty(ref _noInitialization, value);
		}
	}
}

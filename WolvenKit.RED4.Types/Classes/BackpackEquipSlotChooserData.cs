using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BackpackEquipSlotChooserData : inkGameNotificationData
	{
		private InventoryItemData _item;
		private CHandle<InventoryDataManagerV2> _inventoryManager;

		[Ordinal(6)] 
		[RED("item")] 
		public InventoryItemData Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(7)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}
	}
}

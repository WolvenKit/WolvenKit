using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryGenericItemChooser : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _itemContainer;
		private inkWidgetReference _slotsCategory;
		private inkWidgetReference _slotsRootContainer;
		private inkTextWidgetReference _slotsRootLabel;
		private inkCompoundWidgetReference _slotsContainer;
		private CWeakHandle<PlayerPuppet> _player;
		private CHandle<InventoryDataManagerV2> _inventoryDataManager;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CWeakHandle<InventoryItemDisplayController> _itemDisplay;
		private CInt32 _slotIndex;
		private CWeakHandle<InventoryItemDisplayController> _selectedItem;
		private CWeakHandle<gameuiTooltipsManager> _tooltipsManager;

		[Ordinal(1)] 
		[RED("itemContainer")] 
		public inkCompoundWidgetReference ItemContainer
		{
			get => GetProperty(ref _itemContainer);
			set => SetProperty(ref _itemContainer, value);
		}

		[Ordinal(2)] 
		[RED("slotsCategory")] 
		public inkWidgetReference SlotsCategory
		{
			get => GetProperty(ref _slotsCategory);
			set => SetProperty(ref _slotsCategory, value);
		}

		[Ordinal(3)] 
		[RED("slotsRootContainer")] 
		public inkWidgetReference SlotsRootContainer
		{
			get => GetProperty(ref _slotsRootContainer);
			set => SetProperty(ref _slotsRootContainer, value);
		}

		[Ordinal(4)] 
		[RED("slotsRootLabel")] 
		public inkTextWidgetReference SlotsRootLabel
		{
			get => GetProperty(ref _slotsRootLabel);
			set => SetProperty(ref _slotsRootLabel, value);
		}

		[Ordinal(5)] 
		[RED("slotsContainer")] 
		public inkCompoundWidgetReference SlotsContainer
		{
			get => GetProperty(ref _slotsContainer);
			set => SetProperty(ref _slotsContainer, value);
		}

		[Ordinal(6)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(7)] 
		[RED("inventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get => GetProperty(ref _inventoryDataManager);
			set => SetProperty(ref _inventoryDataManager, value);
		}

		[Ordinal(8)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(9)] 
		[RED("itemDisplay")] 
		public CWeakHandle<InventoryItemDisplayController> ItemDisplay
		{
			get => GetProperty(ref _itemDisplay);
			set => SetProperty(ref _itemDisplay, value);
		}

		[Ordinal(10)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(11)] 
		[RED("selectedItem")] 
		public CWeakHandle<InventoryItemDisplayController> SelectedItem
		{
			get => GetProperty(ref _selectedItem);
			set => SetProperty(ref _selectedItem, value);
		}

		[Ordinal(12)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}
	}
}

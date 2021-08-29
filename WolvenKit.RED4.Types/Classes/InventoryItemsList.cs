using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemsList : inkWidgetLogicController
	{
		private CName _inventoryItemName;
		private inkCompoundWidgetReference _itemsLayoutRef;
		private CArray<CHandle<ATooltipData>> _tooltipsData;
		private CWeakHandle<gameObject> _itemsOwner;
		private CWeakHandle<inkCompoundWidget> _itemsLayout;
		private CArray<CWeakHandle<inkWidget>> _inventoryItems;
		private CBool _isDevice;
		private CHandle<InventoryDataManagerV2> _inventoryManager;

		[Ordinal(1)] 
		[RED("InventoryItemName")] 
		public CName InventoryItemName
		{
			get => GetProperty(ref _inventoryItemName);
			set => SetProperty(ref _inventoryItemName, value);
		}

		[Ordinal(2)] 
		[RED("ItemsLayoutRef")] 
		public inkCompoundWidgetReference ItemsLayoutRef
		{
			get => GetProperty(ref _itemsLayoutRef);
			set => SetProperty(ref _itemsLayoutRef, value);
		}

		[Ordinal(3)] 
		[RED("TooltipsData")] 
		public CArray<CHandle<ATooltipData>> TooltipsData
		{
			get => GetProperty(ref _tooltipsData);
			set => SetProperty(ref _tooltipsData, value);
		}

		[Ordinal(4)] 
		[RED("ItemsOwner")] 
		public CWeakHandle<gameObject> ItemsOwner
		{
			get => GetProperty(ref _itemsOwner);
			set => SetProperty(ref _itemsOwner, value);
		}

		[Ordinal(5)] 
		[RED("ItemsLayout")] 
		public CWeakHandle<inkCompoundWidget> ItemsLayout
		{
			get => GetProperty(ref _itemsLayout);
			set => SetProperty(ref _itemsLayout, value);
		}

		[Ordinal(6)] 
		[RED("InventoryItems")] 
		public CArray<CWeakHandle<inkWidget>> InventoryItems
		{
			get => GetProperty(ref _inventoryItems);
			set => SetProperty(ref _inventoryItems, value);
		}

		[Ordinal(7)] 
		[RED("IsDevice")] 
		public CBool IsDevice
		{
			get => GetProperty(ref _isDevice);
			set => SetProperty(ref _isDevice, value);
		}

		[Ordinal(8)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}
	}
}

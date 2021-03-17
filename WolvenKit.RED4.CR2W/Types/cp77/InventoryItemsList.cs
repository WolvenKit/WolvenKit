using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemsList : inkWidgetLogicController
	{
		private CName _inventoryItemName;
		private inkCompoundWidgetReference _itemsLayoutRef;
		private CArray<CHandle<ATooltipData>> _tooltipsData;
		private wCHandle<gameObject> _itemsOwner;
		private wCHandle<inkCompoundWidget> _itemsLayout;
		private CArray<wCHandle<inkWidget>> _inventoryItems;
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
		public wCHandle<gameObject> ItemsOwner
		{
			get => GetProperty(ref _itemsOwner);
			set => SetProperty(ref _itemsOwner, value);
		}

		[Ordinal(5)] 
		[RED("ItemsLayout")] 
		public wCHandle<inkCompoundWidget> ItemsLayout
		{
			get => GetProperty(ref _itemsLayout);
			set => SetProperty(ref _itemsLayout, value);
		}

		[Ordinal(6)] 
		[RED("InventoryItems")] 
		public CArray<wCHandle<inkWidget>> InventoryItems
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

		public InventoryItemsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

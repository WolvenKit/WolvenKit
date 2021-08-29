using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryCyberwareItemChooser : InventoryGenericItemChooser
	{
		private inkCompoundWidgetReference _leftSlotsContainer;
		private inkCompoundWidgetReference _rightSlotsContainer;
		private InventoryItemData _itemData;
		private CArray<InventoryItemData> _itemDatas;

		[Ordinal(13)] 
		[RED("leftSlotsContainer")] 
		public inkCompoundWidgetReference LeftSlotsContainer
		{
			get => GetProperty(ref _leftSlotsContainer);
			set => SetProperty(ref _leftSlotsContainer, value);
		}

		[Ordinal(14)] 
		[RED("rightSlotsContainer")] 
		public inkCompoundWidgetReference RightSlotsContainer
		{
			get => GetProperty(ref _rightSlotsContainer);
			set => SetProperty(ref _rightSlotsContainer, value);
		}

		[Ordinal(15)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(16)] 
		[RED("itemDatas")] 
		public CArray<InventoryItemData> ItemDatas
		{
			get => GetProperty(ref _itemDatas);
			set => SetProperty(ref _itemDatas, value);
		}
	}
}

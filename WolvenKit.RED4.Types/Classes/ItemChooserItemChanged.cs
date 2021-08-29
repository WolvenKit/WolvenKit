using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemChooserItemChanged : redEvent
	{
		private InventoryItemData _itemData;
		private CEnum<gamedataEquipmentArea> _itemEquipmentArea;
		private CInt32 _slotIndex;
		private TweakDBID _slotID;

		[Ordinal(0)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(1)] 
		[RED("itemEquipmentArea")] 
		public CEnum<gamedataEquipmentArea> ItemEquipmentArea
		{
			get => GetProperty(ref _itemEquipmentArea);
			set => SetProperty(ref _itemEquipmentArea, value);
		}

		[Ordinal(2)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(3)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}
	}
}

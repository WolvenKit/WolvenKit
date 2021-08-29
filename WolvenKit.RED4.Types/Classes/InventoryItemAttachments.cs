using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemAttachments : RedBaseClass
	{
		private TweakDBID _slotID;
		private InventoryItemData _itemData;
		private CString _slotName;
		private CEnum<gameInventoryItemAttachmentType> _slotType;

		[Ordinal(0)] 
		[RED("SlotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("ItemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(2)] 
		[RED("SlotName")] 
		public CString SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(3)] 
		[RED("SlotType")] 
		public CEnum<gameInventoryItemAttachmentType> SlotType
		{
			get => GetProperty(ref _slotType);
			set => SetProperty(ref _slotType, value);
		}
	}
}

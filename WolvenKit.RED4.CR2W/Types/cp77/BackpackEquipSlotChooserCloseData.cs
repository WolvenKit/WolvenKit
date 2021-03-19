using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackEquipSlotChooserCloseData : inkGameNotificationData
	{
		private CBool _confirm;
		private InventoryItemData _itemData;
		private CInt32 _slotIndex;

		[Ordinal(6)] 
		[RED("confirm")] 
		public CBool Confirm
		{
			get => GetProperty(ref _confirm);
			set => SetProperty(ref _confirm, value);
		}

		[Ordinal(7)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(8)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		public BackpackEquipSlotChooserCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

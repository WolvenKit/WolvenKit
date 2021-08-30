using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEquipRequest : gamePlayerScriptableSystemRequest
	{
		private gameItemID _itemID;
		private CInt32 _slotIndex;
		private CBool _addToInventory;
		private CBool _equipToCurrentActiveSlot;

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(2)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(3)] 
		[RED("addToInventory")] 
		public CBool AddToInventory
		{
			get => GetProperty(ref _addToInventory);
			set => SetProperty(ref _addToInventory, value);
		}

		[Ordinal(4)] 
		[RED("equipToCurrentActiveSlot")] 
		public CBool EquipToCurrentActiveSlot
		{
			get => GetProperty(ref _equipToCurrentActiveSlot);
			set => SetProperty(ref _equipToCurrentActiveSlot, value);
		}

		public gameEquipRequest()
		{
			_slotIndex = -1;
		}
	}
}

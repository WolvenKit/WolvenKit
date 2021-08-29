using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CacheItemEquippedToHandsEvent : redEvent
	{
		private gameItemID _itemID;
		private CEnum<EHandEquipSlot> _slot;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("slot")] 
		public CEnum<EHandEquipSlot> Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}
	}
}

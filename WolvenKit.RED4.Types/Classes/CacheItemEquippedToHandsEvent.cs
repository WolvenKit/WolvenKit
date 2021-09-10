using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CacheItemEquippedToHandsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("slot")] 
		public CEnum<EHandEquipSlot> Slot
		{
			get => GetPropertyValue<CEnum<EHandEquipSlot>>();
			set => SetPropertyValue<CEnum<EHandEquipSlot>>(value);
		}

		public CacheItemEquippedToHandsEvent()
		{
			ItemID = new();
		}
	}
}

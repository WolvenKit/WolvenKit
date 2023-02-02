using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetInventoryState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slots")] 
		public CArray<gameMuppetInventorySlotInfo> Slots
		{
			get => GetPropertyValue<CArray<gameMuppetInventorySlotInfo>>();
			set => SetPropertyValue<CArray<gameMuppetInventorySlotInfo>>(value);
		}

		[Ordinal(1)] 
		[RED("activeSlot")] 
		public CInt32 ActiveSlot
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameMuppetInventoryState()
		{
			Slots = new();
			ActiveSlot = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

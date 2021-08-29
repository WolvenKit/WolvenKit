using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInventoryState : RedBaseClass
	{
		private CArray<gameMuppetInventorySlotInfo> _slots;
		private CInt32 _activeSlot;

		[Ordinal(0)] 
		[RED("slots")] 
		public CArray<gameMuppetInventorySlotInfo> Slots
		{
			get => GetProperty(ref _slots);
			set => SetProperty(ref _slots, value);
		}

		[Ordinal(1)] 
		[RED("activeSlot")] 
		public CInt32 ActiveSlot
		{
			get => GetProperty(ref _activeSlot);
			set => SetProperty(ref _activeSlot, value);
		}
	}
}

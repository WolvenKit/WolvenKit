using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entSlotComponent : entIPlacedComponent
	{
		private CArray<entSlot> _slots;
		private CArray<entFallbackSlot> _fallbackSlots;

		[Ordinal(5)] 
		[RED("slots")] 
		public CArray<entSlot> Slots
		{
			get => GetProperty(ref _slots);
			set => SetProperty(ref _slots, value);
		}

		[Ordinal(6)] 
		[RED("fallbackSlots")] 
		public CArray<entFallbackSlot> FallbackSlots
		{
			get => GetProperty(ref _fallbackSlots);
			set => SetProperty(ref _fallbackSlots, value);
		}
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entSlotComponent : entIPlacedComponent
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

		public entSlotComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInventoryState : CVariable
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

		public gameMuppetInventoryState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

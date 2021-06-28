using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsHoldEvents : QuickSlotsEvents
	{
		private CEnum<EDPadSlot> _holdDirection;

		[Ordinal(0)] 
		[RED("holdDirection")] 
		public CEnum<EDPadSlot> HoldDirection
		{
			get => GetProperty(ref _holdDirection);
			set => SetProperty(ref _holdDirection, value);
		}

		public QuickSlotsHoldEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickWheelStartUIStructure : CVariable
	{
		private CArray<QuickSlotCommand> _wheelItems;
		private CEnum<EDPadSlot> _dpadSlot;

		[Ordinal(0)] 
		[RED("WheelItems")] 
		public CArray<QuickSlotCommand> WheelItems
		{
			get => GetProperty(ref _wheelItems);
			set => SetProperty(ref _wheelItems, value);
		}

		[Ordinal(1)] 
		[RED("dpadSlot")] 
		public CEnum<EDPadSlot> DpadSlot
		{
			get => GetProperty(ref _dpadSlot);
			set => SetProperty(ref _dpadSlot, value);
		}

		public QuickWheelStartUIStructure(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

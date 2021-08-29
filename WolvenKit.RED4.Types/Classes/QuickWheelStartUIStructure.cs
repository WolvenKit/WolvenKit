using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickWheelStartUIStructure : RedBaseClass
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
	}
}

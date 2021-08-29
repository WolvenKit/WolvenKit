using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotButtonHoldStartEvent : redEvent
	{
		private CEnum<EDPadSlot> _dPadItemDirection;

		[Ordinal(0)] 
		[RED("dPadItemDirection")] 
		public CEnum<EDPadSlot> DPadItemDirection
		{
			get => GetProperty(ref _dPadItemDirection);
			set => SetProperty(ref _dPadItemDirection, value);
		}
	}
}

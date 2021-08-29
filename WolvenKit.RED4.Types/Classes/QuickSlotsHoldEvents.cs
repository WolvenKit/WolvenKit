using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotsHoldEvents : QuickSlotsEvents
	{
		private CEnum<EDPadSlot> _holdDirection;

		[Ordinal(0)] 
		[RED("holdDirection")] 
		public CEnum<EDPadSlot> HoldDirection
		{
			get => GetProperty(ref _holdDirection);
			set => SetProperty(ref _holdDirection, value);
		}
	}
}

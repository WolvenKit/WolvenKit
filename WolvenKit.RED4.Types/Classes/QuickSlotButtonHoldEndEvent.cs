using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotButtonHoldEndEvent : redEvent
	{
		private CEnum<EDPadSlot> _dPadItemDirection;
		private CFloat _rightStickAngle;
		private CBool _tryExecuteCommand;

		[Ordinal(0)] 
		[RED("dPadItemDirection")] 
		public CEnum<EDPadSlot> DPadItemDirection
		{
			get => GetProperty(ref _dPadItemDirection);
			set => SetProperty(ref _dPadItemDirection, value);
		}

		[Ordinal(1)] 
		[RED("rightStickAngle")] 
		public CFloat RightStickAngle
		{
			get => GetProperty(ref _rightStickAngle);
			set => SetProperty(ref _rightStickAngle, value);
		}

		[Ordinal(2)] 
		[RED("tryExecuteCommand")] 
		public CBool TryExecuteCommand
		{
			get => GetProperty(ref _tryExecuteCommand);
			set => SetProperty(ref _tryExecuteCommand, value);
		}
	}
}

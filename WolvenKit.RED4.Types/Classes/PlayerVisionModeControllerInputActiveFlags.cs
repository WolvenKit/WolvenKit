using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerVisionModeControllerInputActiveFlags : RedBaseClass
	{
		private CBool _buttonHold;
		private CBool _buttonToggle;

		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CBool ButtonHold
		{
			get => GetProperty(ref _buttonHold);
			set => SetProperty(ref _buttonHold, value);
		}

		[Ordinal(1)] 
		[RED("buttonToggle")] 
		public CBool ButtonToggle
		{
			get => GetProperty(ref _buttonToggle);
			set => SetProperty(ref _buttonToggle, value);
		}
	}
}

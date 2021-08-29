using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerVisionModeControllerOtherVars : RedBaseClass
	{
		private CBool _enabledByToggle;
		private CBool _active;
		private CBool _toggledDuringHold;

		[Ordinal(0)] 
		[RED("enabledByToggle")] 
		public CBool EnabledByToggle
		{
			get => GetProperty(ref _enabledByToggle);
			set => SetProperty(ref _enabledByToggle, value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(2)] 
		[RED("toggledDuringHold")] 
		public CBool ToggledDuringHold
		{
			get => GetProperty(ref _toggledDuringHold);
			set => SetProperty(ref _toggledDuringHold, value);
		}
	}
}

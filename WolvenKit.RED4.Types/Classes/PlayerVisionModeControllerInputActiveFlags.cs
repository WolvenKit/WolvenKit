using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerVisionModeControllerInputActiveFlags : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CBool ButtonHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("buttonToggle")] 
		public CBool ButtonToggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}

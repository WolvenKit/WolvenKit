using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerVisionModeControllerOtherVars : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enabledByToggle")] 
		public CBool EnabledByToggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("toggledDuringHold")] 
		public CBool ToggledDuringHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerVisionModeControllerOtherVars()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

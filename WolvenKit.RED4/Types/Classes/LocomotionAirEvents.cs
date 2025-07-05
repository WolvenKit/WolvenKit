using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class LocomotionAirEvents : LocomotionEventsTransition
	{
		[Ordinal(6)] 
		[RED("maxSuperheroFallHeight")] 
		public CBool MaxSuperheroFallHeight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("updateInputToggles")] 
		public CBool UpdateInputToggles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("resetFallingParametersOnExit")] 
		public CBool ResetFallingParametersOnExit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LocomotionAirEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

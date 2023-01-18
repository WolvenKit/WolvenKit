using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_PlayerLocomotionStateMachine : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("inAirState")] 
		public CBool InAirState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_PlayerLocomotionStateMachine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

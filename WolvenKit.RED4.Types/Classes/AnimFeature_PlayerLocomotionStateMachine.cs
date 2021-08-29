using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_PlayerLocomotionStateMachine : animAnimFeature
	{
		private CBool _inAirState;

		[Ordinal(0)] 
		[RED("inAirState")] 
		public CBool InAirState
		{
			get => GetProperty(ref _inAirState);
			set => SetProperty(ref _inAirState, value);
		}
	}
}

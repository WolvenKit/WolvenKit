using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entLookAtAddEvent : entAnimTargetAddEvent
	{
		[Ordinal(2)] 
		[RED("outLookAtRef")] 
		public animLookAtRef OutLookAtRef
		{
			get => GetPropertyValue<animLookAtRef>();
			set => SetPropertyValue<animLookAtRef>(value);
		}

		[Ordinal(3)] 
		[RED("request")] 
		public animLookAtRequest Request
		{
			get => GetPropertyValue<animLookAtRequest>();
			set => SetPropertyValue<animLookAtRequest>(value);
		}

		public entLookAtAddEvent()
		{
			BodyPart = "Eyes";
			OutLookAtRef = new() { Id = -1 };
			Request = new() { TransitionSpeed = 60.000000F, OutTransitionSpeed = 60.000000F, FollowingSpeedFactorOverride = -1.000000F, Limits = new() { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 360.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 180.000000F }, AdditionalParts = new(0) };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

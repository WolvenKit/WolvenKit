using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtRequestForPart : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CName BodyPart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("request")] 
		public animLookAtRequest Request
		{
			get => GetPropertyValue<animLookAtRequest>();
			set => SetPropertyValue<animLookAtRequest>(value);
		}

		[Ordinal(2)] 
		[RED("attachLeftHandToRightHand")] 
		public CInt32 AttachLeftHandToRightHand
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("attachRightHandToLeftHand")] 
		public CInt32 AttachRightHandToLeftHand
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animLookAtRequestForPart()
		{
			BodyPart = "Eyes";
			Request = new animLookAtRequest { TransitionSpeed = 60.000000F, OutTransitionSpeed = 60.000000F, FollowingSpeedFactorOverride = -1.000000F, Limits = new animLookAtLimits { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 360.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 180.000000F }, AdditionalParts = new(0) };
			AttachLeftHandToRightHand = -1;
			AttachRightHandToLeftHand = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

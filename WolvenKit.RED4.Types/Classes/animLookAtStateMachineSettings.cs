using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtStateMachineSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("partAlias")] 
		public CName PartAlias
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("sphereAttachmentBone")] 
		public CName SphereAttachmentBone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("sphereRadius")] 
		public CFloat SphereRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("followingSpeedFactor")] 
		public CFloat FollowingSpeedFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("followingSpeedByAngleCurve")] 
		public CLegacySingleChannelCurve<CFloat> FollowingSpeedByAngleCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("enableFloatTrack")] 
		public CName EnableFloatTrack
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("eyesOverrideFloatTrack")] 
		public CName EyesOverrideFloatTrack
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("transitionSpeedMultiplier")] 
		public CFloat TransitionSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("blendWeightPowFactor")] 
		public CFloat BlendWeightPowFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("coneLimitReached")] 
		public CName ConeLimitReached
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("allowToBlendBehindBack")] 
		public CBool AllowToBlendBehindBack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animLookAtStateMachineSettings()
		{
			FollowingSpeedFactor = 1.000000F;
			EyesOverrideFloatTrack = "pla_force_enable_eyes";
			TransitionSpeedMultiplier = 1.000000F;
			BlendWeightPowFactor = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

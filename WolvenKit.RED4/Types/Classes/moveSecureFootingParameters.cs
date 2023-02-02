using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class moveSecureFootingParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("unsecureCollisionFilterName")] 
		public CName UnsecureCollisionFilterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("maxVerticalDistanceForCentreRaycast")] 
		public CFloat MaxVerticalDistanceForCentreRaycast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("maxAngularDistanceForOtherRaycasts")] 
		public CFloat MaxAngularDistanceForOtherRaycasts
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("standingMinNumberOfRaycasts")] 
		public CUInt32 StandingMinNumberOfRaycasts
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("standingMinCollisionHorizontalDistance")] 
		public CFloat StandingMinCollisionHorizontalDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("fallingMinNumberOfRaycasts")] 
		public CUInt32 FallingMinNumberOfRaycasts
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("fallingMinCollisionHorizontalDistance")] 
		public CFloat FallingMinCollisionHorizontalDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("maxStaticGroundFactor")] 
		public CFloat MaxStaticGroundFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("needsCentreRaycast")] 
		public CBool NeedsCentreRaycast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("minVelocityForFalling")] 
		public CFloat MinVelocityForFalling
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("slopeCurveName")] 
		public CName SlopeCurveName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public moveSecureFootingParameters()
		{
			UnsecureCollisionFilterName = "World Static";
			MaxVerticalDistanceForCentreRaycast = 0.300000F;
			MaxAngularDistanceForOtherRaycasts = 30.000000F;
			StandingMinNumberOfRaycasts = 3;
			StandingMinCollisionHorizontalDistance = 0.100000F;
			FallingMinNumberOfRaycasts = 3;
			FallingMinCollisionHorizontalDistance = 0.100000F;
			MaxStaticGroundFactor = -1.000000F;
			NeedsCentreRaycast = true;
			MinVelocityForFalling = -0.500000F;
			SlopeCurveName = "slope_curve";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

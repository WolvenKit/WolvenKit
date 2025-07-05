using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FanSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetPropertyValue<CEnum<EAnimationType>>();
			set => SetPropertyValue<CEnum<EAnimationType>>(value);
		}

		[Ordinal(1)] 
		[RED("rotateClockwise")] 
		public CBool RotateClockwise
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("randomizeBladesSpeed")] 
		public CBool RandomizeBladesSpeed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("timeToMaxRotation")] 
		public CFloat TimeToMaxRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public FanSetup()
		{
			RotateClockwise = true;
			MaxRotationSpeed = 150.000000F;
			TimeToMaxRotation = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

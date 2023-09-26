using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Fan : BasicDistractionDevice
	{
		[Ordinal(106)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetPropertyValue<CEnum<EAnimationType>>();
			set => SetPropertyValue<CEnum<EAnimationType>>(value);
		}

		[Ordinal(107)] 
		[RED("rotateClockwise")] 
		public CBool RotateClockwise
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("randomizeBladesSpeed")] 
		public CBool RandomizeBladesSpeed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(110)] 
		[RED("timeToMaxRotation")] 
		public CFloat TimeToMaxRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(111)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RotatingObject> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_RotatingObject>>();
			set => SetPropertyValue<CHandle<AnimFeature_RotatingObject>>(value);
		}

		[Ordinal(112)] 
		[RED("updateComp")] 
		public CHandle<UpdateComponent> UpdateComp
		{
			get => GetPropertyValue<CHandle<UpdateComponent>>();
			set => SetPropertyValue<CHandle<UpdateComponent>>(value);
		}

		public Fan()
		{
			ControllerTypeName = "FanController";
			RotateClockwise = true;
			MaxRotationSpeed = 150.000000F;
			TimeToMaxRotation = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

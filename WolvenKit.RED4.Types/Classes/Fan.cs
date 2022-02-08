using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Fan : BasicDistractionDevice
	{
		[Ordinal(103)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetPropertyValue<CEnum<EAnimationType>>();
			set => SetPropertyValue<CEnum<EAnimationType>>(value);
		}

		[Ordinal(104)] 
		[RED("rotateClockwise")] 
		public CBool RotateClockwise
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("randomizeBladesSpeed")] 
		public CBool RandomizeBladesSpeed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(106)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(107)] 
		[RED("timeToMaxRotation")] 
		public CFloat TimeToMaxRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(108)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RotatingObject> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_RotatingObject>>();
			set => SetPropertyValue<CHandle<AnimFeature_RotatingObject>>(value);
		}

		[Ordinal(109)] 
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
		}
	}
}

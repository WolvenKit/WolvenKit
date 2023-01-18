using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseAnimatedDevice : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(95)] 
		[RED("closingSpeed")] 
		public CFloat ClosingSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(96)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		[Ordinal(97)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RoadBlock> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_RoadBlock>>();
			set => SetPropertyValue<CHandle<AnimFeature_RoadBlock>>(value);
		}

		[Ordinal(98)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetPropertyValue<CEnum<EAnimationType>>();
			set => SetPropertyValue<CEnum<EAnimationType>>(value);
		}

		public BaseAnimatedDevice()
		{
			ControllerTypeName = "BaseAnimatedDeviceController";
			OpeningSpeed = 2.000000F;
			ClosingSpeed = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

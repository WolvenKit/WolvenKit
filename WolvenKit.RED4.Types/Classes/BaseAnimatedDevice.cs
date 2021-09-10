using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseAnimatedDevice : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(98)] 
		[RED("closingSpeed")] 
		public CFloat ClosingSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(99)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		[Ordinal(100)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RoadBlock> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_RoadBlock>>();
			set => SetPropertyValue<CHandle<AnimFeature_RoadBlock>>(value);
		}

		[Ordinal(101)] 
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
		}
	}
}

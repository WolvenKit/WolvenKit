using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RoboticArms : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("workSFX")] 
		public CName WorkSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(99)] 
		[RED("distractSFX")] 
		public CName DistractSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(100)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		[Ordinal(101)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RoboticArm> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_RoboticArm>>();
			set => SetPropertyValue<CHandle<AnimFeature_RoboticArm>>(value);
		}

		public RoboticArms()
		{
			ControllerTypeName = "RoboticArmsController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

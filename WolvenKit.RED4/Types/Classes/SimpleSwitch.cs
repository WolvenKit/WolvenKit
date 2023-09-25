using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleSwitch : InteractiveMasterDevice
	{
		[Ordinal(98)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetPropertyValue<CEnum<EAnimationType>>();
			set => SetPropertyValue<CEnum<EAnimationType>>(value);
		}

		[Ordinal(99)] 
		[RED("animationSpeed")] 
		public CFloat AnimationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SimpleSwitch()
		{
			ControllerTypeName = "SimpleSwitchController";
			DeviceState = Enums.EDeviceStatus.ON;
			AnimationSpeed = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceIndustrialArm : ActivatedDeviceTrap
	{
		[Ordinal(96)] 
		[RED("loopAnimation")] 
		public CEnum<EIndustrialArmAnimations> LoopAnimation
		{
			get => GetPropertyValue<CEnum<EIndustrialArmAnimations>>();
			set => SetPropertyValue<CEnum<EIndustrialArmAnimations>>(value);
		}

		public ActivatedDeviceIndustrialArm()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

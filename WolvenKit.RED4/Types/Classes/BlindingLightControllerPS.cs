using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BlindingLightControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(113)] 
		[RED("reflectorSFX")] 
		public ReflectorSFX ReflectorSFX
		{
			get => GetPropertyValue<ReflectorSFX>();
			set => SetPropertyValue<ReflectorSFX>(value);
		}

		public BlindingLightControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

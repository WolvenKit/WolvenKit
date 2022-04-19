using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BlindingLightControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(109)] 
		[RED("reflectorSFX")] 
		public ReflectorSFX ReflectorSFX
		{
			get => GetPropertyValue<ReflectorSFX>();
			set => SetPropertyValue<ReflectorSFX>(value);
		}

		public BlindingLightControllerPS()
		{
			DeviceName = "LocKey#168";
			TweakDBRecord = 83448043739;
			TweakDBDescriptionRecord = 137244048802;
			ReflectorSFX = new() { Distraction = "dev_reflector_distraction", TurnOn = "dev_reflector_turn_on_loop", TurnOff = "dev_reflector_turn_on_loop_stop" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

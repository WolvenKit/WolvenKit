using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RetractableAdControllerPS : BaseAnimatedDeviceControllerPS
	{
		[Ordinal(112)] 
		[RED("isControlled")] 
		public CBool IsControlled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RetractableAdControllerPS()
		{
			DeviceName = "LocKey#196";
			TweakDBRecord = "Devices.RoadBlock";
			TweakDBDescriptionRecord = "device_descriptions.RoadBlock";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

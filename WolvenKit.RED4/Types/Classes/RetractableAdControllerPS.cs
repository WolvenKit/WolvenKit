using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RetractableAdControllerPS : BaseAnimatedDeviceControllerPS
	{
		[Ordinal(109)] 
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
			TweakDBDescriptionRecord = 127230302630;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

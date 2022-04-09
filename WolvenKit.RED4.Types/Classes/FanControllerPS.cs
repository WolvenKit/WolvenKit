using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FanControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(109)] 
		[RED("fanSetup")] 
		public FanSetup FanSetup
		{
			get => GetPropertyValue<FanSetup>();
			set => SetPropertyValue<FanSetup>(value);
		}

		public FanControllerPS()
		{
			DeviceName = "LocKey#94";
			TweakDBRecord = 50613090354;
			TweakDBDescriptionRecord = 102801160369;
			FanSetup = new() { RotateClockwise = true, MaxRotationSpeed = 150.000000F, TimeToMaxRotation = 3.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public partial class ConfessionBoothControllerPS : BasicDistractionDeviceControllerPS
	{
		public ConfessionBoothControllerPS()
		{
			DeviceName = "LocKey#1942";
			TweakDBRecord = 102833522601;
			TweakDBDescriptionRecord = 152595250458;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

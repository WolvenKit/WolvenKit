
namespace WolvenKit.RED4.Types
{
	public partial class MovableWallScreenControllerPS : DoorControllerPS
	{
		public MovableWallScreenControllerPS()
		{
			TweakDBRecord = "Devices.HoloFeeder";
			TweakDBDescriptionRecord = "device_descriptions.HoloFeeder";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

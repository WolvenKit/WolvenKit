
namespace WolvenKit.RED4.Types
{
	public partial class SmartWindowControllerPS : ComputerControllerPS
	{
		public SmartWindowControllerPS()
		{
			DeviceName = "LocKey#110";
			TweakDBRecord = "Devices.SmartWindow";
			TweakDBDescriptionRecord = 133880141476;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

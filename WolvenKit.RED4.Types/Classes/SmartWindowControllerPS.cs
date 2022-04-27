
namespace WolvenKit.RED4.Types
{
	public partial class SmartWindowControllerPS : ComputerControllerPS
	{
		public SmartWindowControllerPS()
		{
			DeviceName = "LocKey#110";
			TweakDBRecord = 84597355485;
			TweakDBDescriptionRecord = 133880141476;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

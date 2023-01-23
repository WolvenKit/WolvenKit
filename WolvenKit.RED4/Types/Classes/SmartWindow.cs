
namespace WolvenKit.RED4.Types
{
	public partial class SmartWindow : Computer
	{
		public SmartWindow()
		{
			ControllerTypeName = "SmartWindowController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

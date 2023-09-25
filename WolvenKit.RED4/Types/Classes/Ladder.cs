
namespace WolvenKit.RED4.Types
{
	public partial class Ladder : InteractiveDevice
	{
		public Ladder()
		{
			ControllerTypeName = "LadderController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public partial class Coder : BasicDistractionDevice
	{
		public Coder()
		{
			ControllerTypeName = "CoderController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

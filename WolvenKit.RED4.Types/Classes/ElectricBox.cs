
namespace WolvenKit.RED4.Types
{
	public partial class ElectricBox : InteractiveMasterDevice
	{
		public ElectricBox()
		{
			ControllerTypeName = "ElectricBoxController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public partial class AIVehicleCoversComponent : entIComponent
	{
		public AIVehicleCoversComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

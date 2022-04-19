
namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleMountableComponent : gamemountingMountableComponent
	{
		public vehicleVehicleMountableComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

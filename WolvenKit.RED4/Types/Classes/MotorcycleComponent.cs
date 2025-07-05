
namespace WolvenKit.RED4.Types
{
	public partial class MotorcycleComponent : VehicleComponent
	{
		public MotorcycleComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

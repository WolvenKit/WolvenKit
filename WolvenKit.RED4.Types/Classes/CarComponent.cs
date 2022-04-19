
namespace WolvenKit.RED4.Types
{
	public partial class CarComponent : VehicleComponent
	{
		public CarComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

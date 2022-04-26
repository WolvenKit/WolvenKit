
namespace WolvenKit.RED4.Types
{
	public partial class InVehicleDecorator : AIVehicleTaskAbstract
	{
		public InVehicleDecorator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

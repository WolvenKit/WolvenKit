
namespace WolvenKit.RED4.Types
{
	public partial class TrafficZebra : TrafficLight
	{
		public TrafficZebra()
		{
			ControllerTypeName = "TrafficZebraController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public partial class Toilet : InteractiveDevice
	{
		public Toilet()
		{
			ControllerTypeName = "ToiletController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

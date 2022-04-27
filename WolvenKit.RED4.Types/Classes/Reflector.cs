
namespace WolvenKit.RED4.Types
{
	public partial class Reflector : BlindingLight
	{
		public Reflector()
		{
			ControllerTypeName = "ReflectorController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

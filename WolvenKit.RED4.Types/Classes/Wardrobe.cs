
namespace WolvenKit.RED4.Types
{
	public partial class Wardrobe : InteractiveDevice
	{
		public Wardrobe()
		{
			ControllerTypeName = "WardrobeController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

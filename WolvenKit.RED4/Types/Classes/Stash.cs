
namespace WolvenKit.RED4.Types
{
	public partial class Stash : InteractiveDevice
	{
		public Stash()
		{
			ControllerTypeName = "StashController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

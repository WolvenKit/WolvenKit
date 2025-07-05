
namespace WolvenKit.RED4.Types
{
	public partial class Fuse : InteractiveMasterDevice
	{
		public Fuse()
		{
			ControllerTypeName = "FuseController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public partial class C4 : ExplosiveDevice
	{
		public C4()
		{
			ControllerTypeName = "C4Controller";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

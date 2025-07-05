
namespace WolvenKit.RED4.Types
{
	public partial class BraindanceModule : HUDModule
	{
		public BraindanceModule()
		{
			InstancesList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

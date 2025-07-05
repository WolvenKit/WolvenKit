
namespace WolvenKit.RED4.Types
{
	public partial class IconsModule : HUDModule
	{
		public IconsModule()
		{
			InstancesList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

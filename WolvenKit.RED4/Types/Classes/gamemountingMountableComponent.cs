
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamemountingMountableComponent : entIComponent
	{
		public gamemountingMountableComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

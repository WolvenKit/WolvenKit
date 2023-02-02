
namespace WolvenKit.RED4.Types
{
	public partial class ProjectileTickEvent : gameTickableEvent
	{
		public ProjectileTickEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

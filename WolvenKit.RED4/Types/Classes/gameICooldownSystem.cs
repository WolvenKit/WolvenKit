
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameICooldownSystem : gameIGameSystem
	{
		public gameICooldownSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

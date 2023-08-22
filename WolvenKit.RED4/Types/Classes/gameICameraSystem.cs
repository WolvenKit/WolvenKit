
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameICameraSystem : gameIGameSystem
	{
		public gameICameraSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

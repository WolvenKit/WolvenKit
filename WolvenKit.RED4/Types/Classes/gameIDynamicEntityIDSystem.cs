
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDynamicEntityIDSystem : gameIGameSystem
	{
		public gameIDynamicEntityIDSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

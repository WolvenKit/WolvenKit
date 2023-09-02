
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIEffectorSystem : gameIGameSystem
	{
		public gameIEffectorSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

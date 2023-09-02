
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIISafeAreaManager : gameIGameSystem
	{
		public AIISafeAreaManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

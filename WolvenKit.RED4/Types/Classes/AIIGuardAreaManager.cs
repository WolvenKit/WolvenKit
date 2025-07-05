
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIIGuardAreaManager : gameIGameSystem
	{
		public AIIGuardAreaManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

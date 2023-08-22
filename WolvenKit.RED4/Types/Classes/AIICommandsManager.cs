
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIICommandsManager : gameIGameSystem
	{
		public AIICommandsManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

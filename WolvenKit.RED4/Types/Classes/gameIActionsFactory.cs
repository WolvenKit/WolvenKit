
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIActionsFactory : gameIGameSystem
	{
		public gameIActionsFactory()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

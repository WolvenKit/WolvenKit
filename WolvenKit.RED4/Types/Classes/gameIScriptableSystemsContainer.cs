
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIScriptableSystemsContainer : gameIGameSystem
	{
		public gameIScriptableSystemsContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

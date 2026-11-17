
namespace WolvenKit.RED4.Types
{
	public partial class gameScriptableServiceContainer : gameIGameSystem
	{
		public gameScriptableServiceContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

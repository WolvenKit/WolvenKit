
namespace WolvenKit.RED4.Types
{
	public partial class gameIScriptableSystemsContainer : gameIGameSystem
	{
		public gameIScriptableSystemsContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

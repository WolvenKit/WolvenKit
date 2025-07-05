
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIAIDirectorSystem : gameIGameSystem
	{
		public gameIAIDirectorSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

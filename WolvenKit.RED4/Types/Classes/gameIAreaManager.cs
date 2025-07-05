
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIAreaManager : gameIGameSystem
	{
		public gameIAreaManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

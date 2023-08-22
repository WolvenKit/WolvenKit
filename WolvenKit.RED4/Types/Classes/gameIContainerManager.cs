
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIContainerManager : gameIGameSystem
	{
		public gameIContainerManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

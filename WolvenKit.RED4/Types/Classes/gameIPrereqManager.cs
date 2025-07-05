
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIPrereqManager : gameIGameSystem
	{
		public gameIPrereqManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

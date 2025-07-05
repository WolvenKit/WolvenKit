
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIBlackboardSystem : gameIGameSystem
	{
		public gameIBlackboardSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

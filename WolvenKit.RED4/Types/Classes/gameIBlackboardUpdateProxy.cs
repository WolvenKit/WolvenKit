
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIBlackboardUpdateProxy : gameIGameSystem
	{
		public gameIBlackboardUpdateProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

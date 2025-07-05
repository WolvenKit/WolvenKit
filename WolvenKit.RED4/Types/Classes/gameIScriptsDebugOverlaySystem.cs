
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIScriptsDebugOverlaySystem : gameIGameSystem
	{
		public gameIScriptsDebugOverlaySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

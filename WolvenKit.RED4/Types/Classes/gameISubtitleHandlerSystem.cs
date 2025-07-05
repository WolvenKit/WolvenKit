
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameISubtitleHandlerSystem : gameIGameSystem
	{
		public gameISubtitleHandlerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

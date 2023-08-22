
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIGameAudioSystem : gameIGameSystem
	{
		public gameIGameAudioSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

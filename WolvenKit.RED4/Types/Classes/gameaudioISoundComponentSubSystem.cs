
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameaudioISoundComponentSubSystem : gameaudioIAudioSubSystem
	{
		public gameaudioISoundComponentSubSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

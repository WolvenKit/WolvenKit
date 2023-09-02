
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameaudioIAudioSubSystem : IScriptable
	{
		public gameaudioIAudioSubSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public abstract partial class audioScriptableAudioInterface : IScriptable
	{
		public audioScriptableAudioInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public abstract partial class audioCustomEmitterMetadata : audioAudioMetadata
	{
		public audioCustomEmitterMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

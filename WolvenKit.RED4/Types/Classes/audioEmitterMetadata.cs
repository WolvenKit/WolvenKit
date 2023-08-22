
namespace WolvenKit.RED4.Types
{
	public abstract partial class audioEmitterMetadata : audioAudioMetadata
	{
		public audioEmitterMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

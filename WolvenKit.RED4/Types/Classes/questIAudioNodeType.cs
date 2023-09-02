
namespace WolvenKit.RED4.Types
{
	public abstract partial class questIAudioNodeType : ISerializable
	{
		public questIAudioNodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

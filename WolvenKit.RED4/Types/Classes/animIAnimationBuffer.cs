
namespace WolvenKit.RED4.Types
{
	public abstract partial class animIAnimationBuffer : ISerializable
	{
		public animIAnimationBuffer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

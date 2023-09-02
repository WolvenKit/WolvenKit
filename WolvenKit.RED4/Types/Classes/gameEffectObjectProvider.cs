
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEffectObjectProvider : gameEffectNode
	{
		public gameEffectObjectProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

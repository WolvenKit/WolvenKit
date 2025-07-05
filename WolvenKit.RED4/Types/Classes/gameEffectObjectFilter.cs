
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEffectObjectFilter : gameEffectNode
	{
		public gameEffectObjectFilter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEffectObjectGroupFilter : gameEffectObjectFilter
	{
		public gameEffectObjectGroupFilter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

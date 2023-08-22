
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEffectObjectSingleFilter : gameEffectObjectFilter
	{
		public gameEffectObjectSingleFilter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

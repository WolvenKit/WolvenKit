
namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_NoInstigatorIfPlayerControlled : gameEffectObjectSingleFilter
	{
		public gameEffectObjectFilter_NoInstigatorIfPlayerControlled()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

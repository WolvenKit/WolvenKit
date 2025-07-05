
namespace WolvenKit.RED4.Types
{
	public abstract partial class LookAtPresetBaseDecisions : DefaultTransition
	{
		public LookAtPresetBaseDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

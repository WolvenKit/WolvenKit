
namespace WolvenKit.RED4.Types
{
	public abstract partial class CombatGadgetTransitions : DefaultTransition
	{
		public CombatGadgetTransitions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

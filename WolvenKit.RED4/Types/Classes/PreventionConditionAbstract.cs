
namespace WolvenKit.RED4.Types
{
	public abstract partial class PreventionConditionAbstract : AIbehaviorconditionScript
	{
		public PreventionConditionAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

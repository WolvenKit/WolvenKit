
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIVehicleConditionAbstract : AIbehaviorconditionScript
	{
		public AIVehicleConditionAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

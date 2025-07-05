
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIVehicleTaskAbstract : AIbehaviortaskScript
	{
		public AIVehicleTaskAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

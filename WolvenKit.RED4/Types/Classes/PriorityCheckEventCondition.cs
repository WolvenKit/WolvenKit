
namespace WolvenKit.RED4.Types
{
	public partial class PriorityCheckEventCondition : AISignalCondition
	{
		public PriorityCheckEventCondition()
		{
			RequiredFlags = new();
			ConsumesSignal = true;
			ExecutingSignal = new AIGateSignal();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

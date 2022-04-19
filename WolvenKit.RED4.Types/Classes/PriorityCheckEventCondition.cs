
namespace WolvenKit.RED4.Types
{
	public partial class PriorityCheckEventCondition : AISignalCondition
	{
		public PriorityCheckEventCondition()
		{
			RequiredFlags = new();
			ConsumesSignal = true;
			ExecutingSignal = new() { Tags = new(0), Priority = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

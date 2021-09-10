
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PriorityCheckEventCondition : AISignalCondition
	{

		public PriorityCheckEventCondition()
		{
			RequiredFlags = new();
			ConsumesSignal = true;
			ExecutingSignal = new() { Tags = new(0), Priority = 1.000000F };
		}
	}
}

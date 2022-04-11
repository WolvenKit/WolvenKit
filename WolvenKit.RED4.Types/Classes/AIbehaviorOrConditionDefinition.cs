
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorOrConditionDefinition : AIbehaviorCompositeConditionDefinition
	{

		public AIbehaviorOrConditionDefinition()
		{
			Conditions = new();
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorUnaryConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("child")] 
		public CHandle<AIbehaviorConditionDefinition> Child
		{
			get => GetPropertyValue<CHandle<AIbehaviorConditionDefinition>>();
			set => SetPropertyValue<CHandle<AIbehaviorConditionDefinition>>(value);
		}
	}
}

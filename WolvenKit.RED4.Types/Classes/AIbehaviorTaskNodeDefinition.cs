using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorTaskNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("task")] 
		public CHandle<AIbehaviorTaskDefinition> Task
		{
			get => GetPropertyValue<CHandle<AIbehaviorTaskDefinition>>();
			set => SetPropertyValue<CHandle<AIbehaviorTaskDefinition>>(value);
		}

		public AIbehaviorTaskNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

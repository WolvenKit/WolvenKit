using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIInterruptionHandlerBehaviorDefinition : AIInterruptionHandlerDefinition
	{
		[Ordinal(2)] 
		[RED("ai")] 
		public CHandle<LibTreeINodeDefinition> Ai
		{
			get => GetPropertyValue<CHandle<LibTreeINodeDefinition>>();
			set => SetPropertyValue<CHandle<LibTreeINodeDefinition>>(value);
		}

		[Ordinal(3)] 
		[RED("parallelActivation")] 
		public CBool ParallelActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("parallelExecution")] 
		public CBool ParallelExecution
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("blockInterruption")] 
		public CBool BlockInterruption
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIInterruptionHandlerBehaviorDefinition()
		{
			Signal = new() { Importance = Enums.AIEInterruptionImportance.Casual };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

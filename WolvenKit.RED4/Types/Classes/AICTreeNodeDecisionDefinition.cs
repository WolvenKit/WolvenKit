using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeDecisionDefinition : AICTreeNodeCompositeDefinition
	{
		[Ordinal(0)] 
		[RED("child")] 
		public CHandle<LibTreeINodeDefinition> Child
		{
			get => GetPropertyValue<CHandle<LibTreeINodeDefinition>>();
			set => SetPropertyValue<CHandle<LibTreeINodeDefinition>>(value);
		}

		[Ordinal(1)] 
		[RED("expressions")] 
		public CArray<CHandle<LibTreeINodeDefinition>> Expressions
		{
			get => GetPropertyValue<CArray<CHandle<LibTreeINodeDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<LibTreeINodeDefinition>>>(value);
		}

		[Ordinal(2)] 
		[RED("interruption")] 
		public AIInterruptionSignal Interruption
		{
			get => GetPropertyValue<AIInterruptionSignal>();
			set => SetPropertyValue<AIInterruptionSignal>(value);
		}

		public AICTreeNodeDecisionDefinition()
		{
			Expressions = new();
			Interruption = new AIInterruptionSignal { Importance = Enums.AIEInterruptionImportance.Rush };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

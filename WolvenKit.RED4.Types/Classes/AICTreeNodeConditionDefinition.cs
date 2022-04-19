using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeConditionDefinition : AICTreeNodeCompositeDefinition
	{
		[Ordinal(0)] 
		[RED("expressions")] 
		public CArray<CHandle<LibTreeINodeDefinition>> Expressions
		{
			get => GetPropertyValue<CArray<CHandle<LibTreeINodeDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<LibTreeINodeDefinition>>>(value);
		}

		[Ordinal(1)] 
		[RED("trueBranch")] 
		public CHandle<LibTreeINodeDefinition> TrueBranch
		{
			get => GetPropertyValue<CHandle<LibTreeINodeDefinition>>();
			set => SetPropertyValue<CHandle<LibTreeINodeDefinition>>(value);
		}

		[Ordinal(2)] 
		[RED("falseBranch")] 
		public CHandle<LibTreeINodeDefinition> FalseBranch
		{
			get => GetPropertyValue<CHandle<LibTreeINodeDefinition>>();
			set => SetPropertyValue<CHandle<LibTreeINodeDefinition>>(value);
		}

		[Ordinal(3)] 
		[RED("reevaluateOnExecution")] 
		public CBool ReevaluateOnExecution
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AICTreeNodeConditionDefinition()
		{
			Expressions = new();
			ReevaluateOnExecution = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

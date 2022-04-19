using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorIfElseNodeDefinition : AIbehaviorCompositeTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<AIbehaviorExpressionSocket> Condition
		{
			get => GetPropertyValue<CHandle<AIbehaviorExpressionSocket>>();
			set => SetPropertyValue<CHandle<AIbehaviorExpressionSocket>>(value);
		}

		public AIbehaviorIfElseNodeDefinition()
		{
			Children = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

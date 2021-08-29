using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorIfElseNodeDefinition : AIbehaviorCompositeTreeNodeDefinition
	{
		private CHandle<AIbehaviorExpressionSocket> _condition;

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<AIbehaviorExpressionSocket> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}
	}
}

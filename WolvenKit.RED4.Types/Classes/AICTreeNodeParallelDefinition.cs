using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeParallelDefinition : AICTreeNodeChildrenListDefinition
	{
		[Ordinal(1)] 
		[RED("forwardChildrenCompleteness")] 
		public CBool ForwardChildrenCompleteness
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AICTreeNodeParallelDefinition()
		{
			ForwardChildrenCompleteness = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

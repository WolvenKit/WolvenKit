using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}

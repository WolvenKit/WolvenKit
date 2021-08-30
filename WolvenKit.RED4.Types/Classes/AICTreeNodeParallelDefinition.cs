using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeParallelDefinition : AICTreeNodeChildrenListDefinition
	{
		private CBool _forwardChildrenCompleteness;

		[Ordinal(1)] 
		[RED("forwardChildrenCompleteness")] 
		public CBool ForwardChildrenCompleteness
		{
			get => GetProperty(ref _forwardChildrenCompleteness);
			set => SetProperty(ref _forwardChildrenCompleteness, value);
		}

		public AICTreeNodeParallelDefinition()
		{
			_forwardChildrenCompleteness = true;
		}
	}
}

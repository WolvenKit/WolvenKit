using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorSubtreeDefinition : AIbehaviorNestedTreeDefinition
	{
		private CHandle<AIbehaviorParameterizedBehavior> _tree;

		[Ordinal(2)] 
		[RED("tree")] 
		public CHandle<AIbehaviorParameterizedBehavior> Tree
		{
			get => GetProperty(ref _tree);
			set => SetProperty(ref _tree, value);
		}
	}
}

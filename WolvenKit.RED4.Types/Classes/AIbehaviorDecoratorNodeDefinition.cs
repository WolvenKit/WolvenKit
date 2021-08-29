using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorDecoratorNodeDefinition : AIbehaviorTreeNodeDefinition
	{
		private CHandle<AIbehaviorTreeNodeDefinition> _child;

		[Ordinal(0)] 
		[RED("child")] 
		public CHandle<AIbehaviorTreeNodeDefinition> Child
		{
			get => GetProperty(ref _child);
			set => SetProperty(ref _child, value);
		}
	}
}

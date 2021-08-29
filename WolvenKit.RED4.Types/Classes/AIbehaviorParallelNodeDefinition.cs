using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorParallelNodeDefinition : AIbehaviorCompositeTreeNodeDefinition
	{
		private CEnum<AIbehaviorParallelNodeWaitFor> _waitFor;

		[Ordinal(1)] 
		[RED("waitFor")] 
		public CEnum<AIbehaviorParallelNodeWaitFor> WaitFor
		{
			get => GetProperty(ref _waitFor);
			set => SetProperty(ref _waitFor, value);
		}
	}
}

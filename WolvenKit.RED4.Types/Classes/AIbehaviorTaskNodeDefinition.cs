using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorTaskNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIbehaviorTaskDefinition> _task;

		[Ordinal(1)] 
		[RED("task")] 
		public CHandle<AIbehaviorTaskDefinition> Task
		{
			get => GetProperty(ref _task);
			set => SetProperty(ref _task, value);
		}
	}
}

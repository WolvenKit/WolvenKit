using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTaskNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIbehaviorTaskDefinition> _task;

		[Ordinal(1)] 
		[RED("task")] 
		public CHandle<AIbehaviorTaskDefinition> Task
		{
			get => GetProperty(ref _task);
			set => SetProperty(ref _task, value);
		}

		public AIbehaviorTaskNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

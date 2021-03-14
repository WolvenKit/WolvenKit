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
			get
			{
				if (_task == null)
				{
					_task = (CHandle<AIbehaviorTaskDefinition>) CR2WTypeManager.Create("handle:AIbehaviorTaskDefinition", "task", cr2w, this);
				}
				return _task;
			}
			set
			{
				if (_task == value)
				{
					return;
				}
				_task = value;
				PropertySet(this);
			}
		}

		public AIbehaviorTaskNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

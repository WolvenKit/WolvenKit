using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPassiveConditionNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIbehaviorPassiveConditionDefinition> _condition;
		private CEnum<AIbehaviorCompletionStatus> _resultIfFailed;

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<AIbehaviorPassiveConditionDefinition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(2)] 
		[RED("resultIfFailed")] 
		public CEnum<AIbehaviorCompletionStatus> ResultIfFailed
		{
			get => GetProperty(ref _resultIfFailed);
			set => SetProperty(ref _resultIfFailed, value);
		}

		public AIbehaviorPassiveConditionNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

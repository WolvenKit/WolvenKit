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
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<AIbehaviorPassiveConditionDefinition>) CR2WTypeManager.Create("handle:AIbehaviorPassiveConditionDefinition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("resultIfFailed")] 
		public CEnum<AIbehaviorCompletionStatus> ResultIfFailed
		{
			get
			{
				if (_resultIfFailed == null)
				{
					_resultIfFailed = (CEnum<AIbehaviorCompletionStatus>) CR2WTypeManager.Create("AIbehaviorCompletionStatus", "resultIfFailed", cr2w, this);
				}
				return _resultIfFailed;
			}
			set
			{
				if (_resultIfFailed == value)
				{
					return;
				}
				_resultIfFailed = value;
				PropertySet(this);
			}
		}

		public AIbehaviorPassiveConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

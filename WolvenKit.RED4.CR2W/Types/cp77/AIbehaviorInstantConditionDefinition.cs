using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorInstantConditionDefinition : ISerializable
	{
		private CHandle<AIbehaviorConditionDefinition> _condition;

		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<AIbehaviorConditionDefinition> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<AIbehaviorConditionDefinition>) CR2WTypeManager.Create("handle:AIbehaviorConditionDefinition", "condition", cr2w, this);
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

		public AIbehaviorInstantConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

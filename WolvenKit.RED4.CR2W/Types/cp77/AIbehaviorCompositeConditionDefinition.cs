using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCompositeConditionDefinition : AIbehaviorConditionDefinition
	{
		private CArray<CHandle<AIbehaviorConditionDefinition>> _conditions;

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<AIbehaviorConditionDefinition>> Conditions
		{
			get
			{
				if (_conditions == null)
				{
					_conditions = (CArray<CHandle<AIbehaviorConditionDefinition>>) CR2WTypeManager.Create("array:handle:AIbehaviorConditionDefinition", "conditions", cr2w, this);
				}
				return _conditions;
			}
			set
			{
				if (_conditions == value)
				{
					return;
				}
				_conditions = value;
				PropertySet(this);
			}
		}

		public AIbehaviorCompositeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

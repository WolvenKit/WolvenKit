using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LogicalCondition : workIScriptedCondition
	{
		private CEnum<WorkspotConditionOperators> _operation;
		private CArray<CHandle<workIScriptedCondition>> _conditions;

		[Ordinal(0)] 
		[RED("operation")] 
		public CEnum<WorkspotConditionOperators> Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (CEnum<WorkspotConditionOperators>) CR2WTypeManager.Create("WorkspotConditionOperators", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<workIScriptedCondition>> Conditions
		{
			get
			{
				if (_conditions == null)
				{
					_conditions = (CArray<CHandle<workIScriptedCondition>>) CR2WTypeManager.Create("array:handle:workIScriptedCondition", "conditions", cr2w, this);
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

		public LogicalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConditionData : CVariable
	{
		private CEnum<ELogicOperator> _conditionOperator;
		private CArray<Condition> _requirementList;

		[Ordinal(0)] 
		[RED("conditionOperator")] 
		public CEnum<ELogicOperator> ConditionOperator
		{
			get
			{
				if (_conditionOperator == null)
				{
					_conditionOperator = (CEnum<ELogicOperator>) CR2WTypeManager.Create("ELogicOperator", "conditionOperator", cr2w, this);
				}
				return _conditionOperator;
			}
			set
			{
				if (_conditionOperator == value)
				{
					return;
				}
				_conditionOperator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requirementList")] 
		public CArray<Condition> RequirementList
		{
			get
			{
				if (_requirementList == null)
				{
					_requirementList = (CArray<Condition>) CR2WTypeManager.Create("array:Condition", "requirementList", cr2w, this);
				}
				return _requirementList;
			}
			set
			{
				if (_requirementList == value)
				{
					return;
				}
				_requirementList = value;
				PropertySet(this);
			}
		}

		public ConditionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

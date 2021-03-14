using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConditionGroupData : CVariable
	{
		private CArray<CHandle<GameplayConditionBase>> _conditions;
		private CEnum<ELogicOperator> _logicOperator;

		[Ordinal(0)] 
		[RED("conditions")] 
		public CArray<CHandle<GameplayConditionBase>> Conditions
		{
			get
			{
				if (_conditions == null)
				{
					_conditions = (CArray<CHandle<GameplayConditionBase>>) CR2WTypeManager.Create("array:handle:GameplayConditionBase", "conditions", cr2w, this);
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

		[Ordinal(1)] 
		[RED("logicOperator")] 
		public CEnum<ELogicOperator> LogicOperator
		{
			get
			{
				if (_logicOperator == null)
				{
					_logicOperator = (CEnum<ELogicOperator>) CR2WTypeManager.Create("ELogicOperator", "logicOperator", cr2w, this);
				}
				return _logicOperator;
			}
			set
			{
				if (_logicOperator == value)
				{
					return;
				}
				_logicOperator = value;
				PropertySet(this);
			}
		}

		public ConditionGroupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

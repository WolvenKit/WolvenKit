using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayConditionContainer : IScriptable
	{
		private CEnum<ELogicOperator> _logicOperator;
		private CArray<ConditionGroupData> _conditionGroups;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("conditionGroups")] 
		public CArray<ConditionGroupData> ConditionGroups
		{
			get
			{
				if (_conditionGroups == null)
				{
					_conditionGroups = (CArray<ConditionGroupData>) CR2WTypeManager.Create("array:ConditionGroupData", "conditionGroups", cr2w, this);
				}
				return _conditionGroups;
			}
			set
			{
				if (_conditionGroups == value)
				{
					return;
				}
				_conditionGroups = value;
				PropertySet(this);
			}
		}

		public GameplayConditionContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

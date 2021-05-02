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
			get => GetProperty(ref _conditionOperator);
			set => SetProperty(ref _conditionOperator, value);
		}

		[Ordinal(1)] 
		[RED("requirementList")] 
		public CArray<Condition> RequirementList
		{
			get => GetProperty(ref _requirementList);
			set => SetProperty(ref _requirementList, value);
		}

		public ConditionData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

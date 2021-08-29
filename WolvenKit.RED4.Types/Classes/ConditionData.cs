using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConditionData : RedBaseClass
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
	}
}

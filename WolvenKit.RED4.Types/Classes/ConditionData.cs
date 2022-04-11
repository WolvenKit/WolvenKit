using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConditionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("conditionOperator")] 
		public CEnum<ELogicOperator> ConditionOperator
		{
			get => GetPropertyValue<CEnum<ELogicOperator>>();
			set => SetPropertyValue<CEnum<ELogicOperator>>(value);
		}

		[Ordinal(1)] 
		[RED("requirementList")] 
		public CArray<Condition> RequirementList
		{
			get => GetPropertyValue<CArray<Condition>>();
			set => SetPropertyValue<CArray<Condition>>(value);
		}

		public ConditionData()
		{
			RequirementList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

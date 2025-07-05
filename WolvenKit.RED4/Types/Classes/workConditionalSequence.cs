using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workConditionalSequence : workSequence
	{
		[Ordinal(8)] 
		[RED("multipleConditionOperator")] 
		public CEnum<workLogicalOperation> MultipleConditionOperator
		{
			get => GetPropertyValue<CEnum<workLogicalOperation>>();
			set => SetPropertyValue<CEnum<workLogicalOperation>>(value);
		}

		[Ordinal(9)] 
		[RED("conditionList")] 
		public CArray<CHandle<workIWorkspotCondition>> ConditionList
		{
			get => GetPropertyValue<CArray<CHandle<workIWorkspotCondition>>>();
			set => SetPropertyValue<CArray<CHandle<workIWorkspotCondition>>>(value);
		}

		public workConditionalSequence()
		{
			ConditionList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

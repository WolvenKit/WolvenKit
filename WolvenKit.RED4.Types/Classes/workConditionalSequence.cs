using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workConditionalSequence : workSequence
	{
		private CEnum<workLogicalOperation> _multipleConditionOperator;
		private CArray<CHandle<workIWorkspotCondition>> _conditionList;

		[Ordinal(7)] 
		[RED("multipleConditionOperator")] 
		public CEnum<workLogicalOperation> MultipleConditionOperator
		{
			get => GetProperty(ref _multipleConditionOperator);
			set => SetProperty(ref _multipleConditionOperator, value);
		}

		[Ordinal(8)] 
		[RED("conditionList")] 
		public CArray<CHandle<workIWorkspotCondition>> ConditionList
		{
			get => GetProperty(ref _conditionList);
			set => SetProperty(ref _conditionList, value);
		}
	}
}

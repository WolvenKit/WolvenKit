using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVarVsVarComparison_ConditionType : questIFactsDBConditionType
	{
		private CString _factName1;
		private CString _factName2;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("factName1")] 
		public CString FactName1
		{
			get => GetProperty(ref _factName1);
			set => SetProperty(ref _factName1, value);
		}

		[Ordinal(1)] 
		[RED("factName2")] 
		public CString FactName2
		{
			get => GetProperty(ref _factName2);
			set => SetProperty(ref _factName2, value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}
	}
}

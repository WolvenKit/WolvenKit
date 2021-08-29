using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questDistanceVsDistanceComparison_ConditionType : questIDistanceConditionType
	{
		private CHandle<questObjectDistance> _distanceDefinition1;
		private CHandle<questObjectDistance> _distanceDefinition2;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("distanceDefinition1")] 
		public CHandle<questObjectDistance> DistanceDefinition1
		{
			get => GetProperty(ref _distanceDefinition1);
			set => SetProperty(ref _distanceDefinition1, value);
		}

		[Ordinal(1)] 
		[RED("distanceDefinition2")] 
		public CHandle<questObjectDistance> DistanceDefinition2
		{
			get => GetProperty(ref _distanceDefinition2);
			set => SetProperty(ref _distanceDefinition2, value);
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

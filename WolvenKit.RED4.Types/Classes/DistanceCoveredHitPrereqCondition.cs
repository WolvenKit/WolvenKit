using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DistanceCoveredHitPrereqCondition : BaseHitPrereqCondition
	{
		private CFloat _distanceRequired;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(1)] 
		[RED("distanceRequired")] 
		public CFloat DistanceRequired
		{
			get => GetProperty(ref _distanceRequired);
			set => SetProperty(ref _distanceRequired, value);
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

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitDistanceCoveredPrereq : GenericHitPrereq
	{
		private CFloat _distanceRequired;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(5)] 
		[RED("distanceRequired")] 
		public CFloat DistanceRequired
		{
			get => GetProperty(ref _distanceRequired);
			set => SetProperty(ref _distanceRequired, value);
		}

		[Ordinal(6)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}
	}
}

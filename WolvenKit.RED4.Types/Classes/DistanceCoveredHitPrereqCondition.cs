using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DistanceCoveredHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] 
		[RED("distanceRequired")] 
		public CFloat DistanceRequired
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}
	}
}

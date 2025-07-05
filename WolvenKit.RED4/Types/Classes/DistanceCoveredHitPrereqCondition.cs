using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DistanceCoveredHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("distanceRequired")] 
		public CFloat DistanceRequired
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		public DistanceCoveredHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

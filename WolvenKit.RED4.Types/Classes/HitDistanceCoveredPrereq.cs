using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitDistanceCoveredPrereq : GenericHitPrereq
	{
		[Ordinal(5)] 
		[RED("distanceRequired")] 
		public CFloat DistanceRequired
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		public HitDistanceCoveredPrereq()
		{
			IsSync = true;
		}
	}
}

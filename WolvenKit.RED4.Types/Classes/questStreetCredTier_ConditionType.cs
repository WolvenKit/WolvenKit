using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questStreetCredTier_ConditionType : questIStatsConditionType
	{
		private TweakDBID _tierID;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("tierID")] 
		public TweakDBID TierID
		{
			get => GetProperty(ref _tierID);
			set => SetProperty(ref _tierID, value);
		}

		[Ordinal(1)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}
	}
}

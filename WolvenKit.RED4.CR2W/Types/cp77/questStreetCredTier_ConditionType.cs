using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStreetCredTier_ConditionType : questIStatsConditionType
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

		public questStreetCredTier_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questStreetCredTier_ConditionType : questIStatsConditionType
	{
		[Ordinal(0)]  [RED("tierID")] public TweakDBID TierID { get; set; }
		[Ordinal(1)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }

		public questStreetCredTier_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

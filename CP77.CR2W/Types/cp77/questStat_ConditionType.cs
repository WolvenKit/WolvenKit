using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questStat_ConditionType : questIStatsConditionType
	{
		[Ordinal(0)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)]  [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(2)]  [RED("value")] public CFloat Value { get; set; }
		[Ordinal(3)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(4)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }

		public questStat_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

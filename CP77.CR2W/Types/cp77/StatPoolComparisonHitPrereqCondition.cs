using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatPoolComparisonHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)]  [RED("comparisonSource")] public CName ComparisonSource { get; set; }
		[Ordinal(2)]  [RED("comparisonTarget")] public CName ComparisonTarget { get; set; }
		[Ordinal(3)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(4)]  [RED("statPoolToCompare")] public CEnum<gamedataStatPoolType> StatPoolToCompare { get; set; }

		public StatPoolComparisonHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DistanceCoveredHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)]  [RED("distanceRequired")] public CFloat DistanceRequired { get; set; }
		[Ordinal(2)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }

		public DistanceCoveredHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

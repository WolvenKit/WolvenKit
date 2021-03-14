using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] [RED("valueToCheck")] public CFloat ValueToCheck { get; set; }
		[Ordinal(2)] [RED("objectToCheck")] public CName ObjectToCheck { get; set; }
		[Ordinal(3)] [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(4)] [RED("statPoolToCompare")] public CEnum<gamedataStatPoolType> StatPoolToCompare { get; set; }

		public StatPoolHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

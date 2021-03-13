using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }
		[Ordinal(1)] [RED("valueToCheck")] public CFloat ValueToCheck { get; set; }
		[Ordinal(2)] [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(3)] [RED("skipOnApply")] public CBool SkipOnApply { get; set; }
		[Ordinal(4)] [RED("comparePercentage")] public CBool ComparePercentage { get; set; }

		public StatPoolPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCreationPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("fireAndForget")] public CBool FireAndForget { get; set; }
		[Ordinal(1)] [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(2)] [RED("valueToCheck")] public CFloat ValueToCheck { get; set; }
		[Ordinal(3)] [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }

		public ItemCreationPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

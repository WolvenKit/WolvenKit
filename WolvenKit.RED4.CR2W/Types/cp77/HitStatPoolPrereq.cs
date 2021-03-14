using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitStatPoolPrereq : GenericHitPrereq
	{
		[Ordinal(5)] [RED("valueToCheck")] public CFloat ValueToCheck { get; set; }
		[Ordinal(6)] [RED("objectToCheck")] public CString ObjectToCheck { get; set; }
		[Ordinal(7)] [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(8)] [RED("statPoolToCompare")] public CEnum<gamedataStatPoolType> StatPoolToCompare { get; set; }

		public HitStatPoolPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

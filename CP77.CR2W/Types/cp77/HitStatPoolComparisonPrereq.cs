using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HitStatPoolComparisonPrereq : GenericHitPrereq
	{
		[Ordinal(0)]  [RED("comparisonSource")] public CString ComparisonSource { get; set; }
		[Ordinal(1)]  [RED("comparisonTarget")] public CString ComparisonTarget { get; set; }
		[Ordinal(2)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(3)]  [RED("statPoolToCompare")] public CEnum<gamedataStatPoolType> StatPoolToCompare { get; set; }

		public HitStatPoolComparisonPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

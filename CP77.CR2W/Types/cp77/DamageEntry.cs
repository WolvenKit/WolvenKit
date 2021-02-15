using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DamageEntry : CVariable
	{
		[Ordinal(0)] [RED("damageInfo")] public gameuiDamageInfo DamageInfo { get; set; }
		[Ordinal(1)] [RED("damageOverTimeInfo")] public gameuiDamageInfo DamageOverTimeInfo { get; set; }
		[Ordinal(2)] [RED("hasDamageInfo")] public CBool HasDamageInfo { get; set; }
		[Ordinal(3)] [RED("hasDamageOverTimeInfo")] public CBool HasDamageOverTimeInfo { get; set; }
		[Ordinal(4)] [RED("oneInstance")] public CBool OneInstance { get; set; }
		[Ordinal(5)] [RED("oneDotInstance")] public CBool OneDotInstance { get; set; }
		[Ordinal(6)] [RED("hasDotAccumulator")] public CBool HasDotAccumulator { get; set; }

		public DamageEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

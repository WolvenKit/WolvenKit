using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitDamageOverTimePrereq : GenericHitPrereq
	{
		[Ordinal(0)]  [RED("dotType")] public CEnum<gamedataStatusEffectType> DotType { get; set; }

		public HitDamageOverTimePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

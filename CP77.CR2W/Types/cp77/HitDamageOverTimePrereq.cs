using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HitDamageOverTimePrereq : GenericHitPrereq
	{
		[Ordinal(0)]  [RED("dotType")] public CEnum<gamedataStatusEffectType> DotType { get; set; }

		public HitDamageOverTimePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

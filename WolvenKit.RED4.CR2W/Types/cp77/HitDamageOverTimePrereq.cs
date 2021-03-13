using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitDamageOverTimePrereq : GenericHitPrereq
	{
		[Ordinal(5)] [RED("dotType")] public CEnum<gamedataStatusEffectType> DotType { get; set; }

		public HitDamageOverTimePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

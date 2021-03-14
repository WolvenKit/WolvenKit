using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageTypePrereq : GenericHitPrereq
	{
		[Ordinal(5)] [RED("damageType")] public CEnum<gamedataDamageType> DamageType { get; set; }

		public DamageTypePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

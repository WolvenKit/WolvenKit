using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatusEffectManagerComponent : AIMandatoryComponents
	{
		[Ordinal(5)] [RED("weaponDropedInWounded")] public CBool WeaponDropedInWounded { get; set; }

		public StatusEffectManagerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

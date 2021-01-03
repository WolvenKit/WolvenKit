using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatusEffectManagerComponent : AIMandatoryComponents
	{
		[Ordinal(0)]  [RED("weaponDropedInWounded")] public CBool WeaponDropedInWounded { get; set; }

		public StatusEffectManagerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AddWeapon : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("weapon")] public CEnum<EquipmentPriority> Weapon { get; set; }

		public AddWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

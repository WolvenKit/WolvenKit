using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_SwitchWeapon : questCombatNodeParams
	{
		[Ordinal(0)]  [RED("mode")] public CEnum<questSwitchWeaponModes> Mode { get; set; }

		public questCombatNodeParams_SwitchWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

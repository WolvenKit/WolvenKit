using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_SwitchWeapon : questCombatNodeParams
	{
		[Ordinal(0)] [RED("mode")] public CEnum<questSwitchWeaponModes> Mode { get; set; }

		public questCombatNodeParams_SwitchWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EquipSecondaryWeaponCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] [RED("command")] public wCHandle<AISwitchToSecondaryWeaponCommand> Command { get; set; }
		[Ordinal(1)] [RED("unEquip")] public CBool UnEquip { get; set; }

		public EquipSecondaryWeaponCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

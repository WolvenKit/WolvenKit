using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EquipPrimaryWeaponCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)]  [RED("command")] public wCHandle<AISwitchToPrimaryWeaponCommand> Command { get; set; }
		[Ordinal(1)]  [RED("unEquip")] public CBool UnEquip { get; set; }

		public EquipPrimaryWeaponCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

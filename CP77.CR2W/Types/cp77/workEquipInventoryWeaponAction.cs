using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workEquipInventoryWeaponAction : workIWorkspotItemAction
	{
		[Ordinal(0)]  [RED("fallbackItem")] public TweakDBID FallbackItem { get; set; }
		[Ordinal(1)]  [RED("fallbackSlot")] public TweakDBID FallbackSlot { get; set; }
		[Ordinal(2)]  [RED("keepEquippedAfterExit")] public CBool KeepEquippedAfterExit { get; set; }
		[Ordinal(3)]  [RED("weaponType")] public CEnum<workWeaponType> WeaponType { get; set; }

		public workEquipInventoryWeaponAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

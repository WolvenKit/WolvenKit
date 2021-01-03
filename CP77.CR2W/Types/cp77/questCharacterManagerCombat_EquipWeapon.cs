using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_EquipWeapon : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)]  [RED("equip")] public CBool Equip { get; set; }
		[Ordinal(1)]  [RED("equipLastWeapon")] public CBool EquipLastWeapon { get; set; }
		[Ordinal(2)]  [RED("forceFirstEquip")] public CBool ForceFirstEquip { get; set; }
		[Ordinal(3)]  [RED("ignoreStateMachine")] public CBool IgnoreStateMachine { get; set; }
		[Ordinal(4)]  [RED("instant")] public CBool Instant { get; set; }
		[Ordinal(5)]  [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(6)]  [RED("weaponID")] public TweakDBID WeaponID { get; set; }

		public questCharacterManagerCombat_EquipWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

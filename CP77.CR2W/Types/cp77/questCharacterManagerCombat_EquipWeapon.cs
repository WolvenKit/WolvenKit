using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_EquipWeapon : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] [RED("equip")] public CBool Equip { get; set; }
		[Ordinal(1)] [RED("weaponID")] public TweakDBID WeaponID { get; set; }
		[Ordinal(2)] [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(3)] [RED("equipLastWeapon")] public CBool EquipLastWeapon { get; set; }
		[Ordinal(4)] [RED("forceFirstEquip")] public CBool ForceFirstEquip { get; set; }
		[Ordinal(5)] [RED("instant")] public CBool Instant { get; set; }
		[Ordinal(6)] [RED("ignoreStateMachine")] public CBool IgnoreStateMachine { get; set; }

		public questCharacterManagerCombat_EquipWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

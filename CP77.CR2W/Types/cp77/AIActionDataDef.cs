using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIActionDataDef : AIBlackboardDef
	{
		[Ordinal(0)] [RED("ownerMeleeAttackBlockedCount")] public gamebbScriptID_Int32 OwnerMeleeAttackBlockedCount { get; set; }
		[Ordinal(1)] [RED("ownerMeleeAttackParriedCount")] public gamebbScriptID_Int32 OwnerMeleeAttackParriedCount { get; set; }
		[Ordinal(2)] [RED("ownerMeleeAttackDodgedCount")] public gamebbScriptID_Int32 OwnerMeleeAttackDodgedCount { get; set; }
		[Ordinal(3)] [RED("ownerLastAttackTimeStamp")] public gamebbScriptID_Float OwnerLastAttackTimeStamp { get; set; }
		[Ordinal(4)] [RED("ownerLastAttackName")] public gamebbScriptID_CName OwnerLastAttackName { get; set; }
		[Ordinal(5)] [RED("ownerCurrentAnimVariationSet")] public gamebbScriptID_Bool OwnerCurrentAnimVariationSet { get; set; }
		[Ordinal(6)] [RED("ownerLastAnimVariation")] public gamebbScriptID_Int32 OwnerLastAnimVariation { get; set; }
		[Ordinal(7)] [RED("ownerItemsToEquip")] public gamebbScriptID_Variant OwnerItemsToEquip { get; set; }
		[Ordinal(8)] [RED("ownerItemsUnequipped")] public gamebbScriptID_Variant OwnerItemsUnequipped { get; set; }
		[Ordinal(9)] [RED("ownerItemsForceUnequipped")] public gamebbScriptID_Variant OwnerItemsForceUnequipped { get; set; }
		[Ordinal(10)] [RED("ownerLastEquippedItems")] public gamebbScriptID_Variant OwnerLastEquippedItems { get; set; }
		[Ordinal(11)] [RED("ownerLastUnequipTimestamp")] public gamebbScriptID_Float OwnerLastUnequipTimestamp { get; set; }
		[Ordinal(12)] [RED("ownerEquipItemTime")] public gamebbScriptID_Float OwnerEquipItemTime { get; set; }
		[Ordinal(13)] [RED("ownerEquipDuration")] public gamebbScriptID_Float OwnerEquipDuration { get; set; }
		[Ordinal(14)] [RED("dropItemOnUnequip")] public gamebbScriptID_Bool DropItemOnUnequip { get; set; }
		[Ordinal(15)] [RED("archetypeEffectorsApplied")] public gamebbScriptID_Bool ArchetypeEffectorsApplied { get; set; }
		[Ordinal(16)] [RED("ownerTimeDilation")] public gamebbScriptID_Float OwnerTimeDilation { get; set; }
		[Ordinal(17)] [RED("operationHasBeenProcessed")] public gamebbScriptID_Bool OperationHasBeenProcessed { get; set; }
		[Ordinal(18)] [RED("weaponTrailInitialised")] public gamebbScriptID_Bool WeaponTrailInitialised { get; set; }
		[Ordinal(19)] [RED("weaponTrailAborted")] public gamebbScriptID_Bool WeaponTrailAborted { get; set; }
		[Ordinal(20)] [RED("netrunner")] public gamebbScriptID_Variant Netrunner { get; set; }
		[Ordinal(21)] [RED("netrunnerProxy")] public gamebbScriptID_Variant NetrunnerProxy { get; set; }
		[Ordinal(22)] [RED("netrunnerTarget")] public gamebbScriptID_Variant NetrunnerTarget { get; set; }

		public AIActionDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

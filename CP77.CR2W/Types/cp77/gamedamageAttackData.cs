using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedamageAttackData : IScriptable
	{
		[Ordinal(0)] [RED("attackType")] public CEnum<gamedataAttackType> AttackType { get; set; }
		[Ordinal(1)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(2)] [RED("source")] public wCHandle<gameObject> Source { get; set; }
		[Ordinal(3)] [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }
		[Ordinal(4)] [RED("attackDefinition")] public CHandle<gameIAttack> AttackDefinition { get; set; }
		[Ordinal(5)] [RED("attackPosition")] public Vector4 AttackPosition { get; set; }
		[Ordinal(6)] [RED("weaponCharge")] public CFloat WeaponCharge { get; set; }
		[Ordinal(7)] [RED("numRicochetBounces")] public CInt32 NumRicochetBounces { get; set; }
		[Ordinal(8)] [RED("flags")] public CArray<SHitFlag> Flags { get; set; }
		[Ordinal(9)] [RED("statusEffects")] public CArray<SHitStatusEffect> StatusEffects { get; set; }
		[Ordinal(10)] [RED("hitType")] public CEnum<gameuiHitType> HitType { get; set; }
		[Ordinal(11)] [RED("vehicleImpactForce")] public CFloat VehicleImpactForce { get; set; }
		[Ordinal(12)] [RED("additionalCritChance")] public CFloat AdditionalCritChance { get; set; }

		public gamedamageAttackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameweaponObject : gameItemObject
	{
		[Ordinal(33)]  [RED("effect")] public rRef<gameEffectSet> Effect { get; set; }
		[Ordinal(34)]  [RED("hasOverheat")] public CBool HasOverheat { get; set; }
		[Ordinal(35)]  [RED("overheatEffectBlackboard")] public CHandle<worldEffectBlackboard> OverheatEffectBlackboard { get; set; }
		[Ordinal(36)]  [RED("overheatListener")] public CHandle<OverheatStatListener> OverheatListener { get; set; }
		[Ordinal(37)]  [RED("overheatDelaySent")] public CBool OverheatDelaySent { get; set; }
		[Ordinal(38)]  [RED("chargeEffectBlackboard")] public CHandle<worldEffectBlackboard> ChargeEffectBlackboard { get; set; }
		[Ordinal(39)]  [RED("chargeStatListener")] public CHandle<WeaponChargeStatListener> ChargeStatListener { get; set; }
		[Ordinal(40)]  [RED("meleeHitEffectBlackboard")] public CHandle<worldEffectBlackboard> MeleeHitEffectBlackboard { get; set; }
		[Ordinal(41)]  [RED("meleeHitEffectValue")] public CFloat MeleeHitEffectValue { get; set; }
		[Ordinal(42)]  [RED("damageTypeListener")] public CHandle<DamageStatListener> DamageTypeListener { get; set; }
		[Ordinal(43)]  [RED("trailName")] public CString TrailName { get; set; }
		[Ordinal(44)]  [RED("maxChargeThreshold")] public CFloat MaxChargeThreshold { get; set; }
		[Ordinal(45)]  [RED("lowAmmoEffectActive")] public CBool LowAmmoEffectActive { get; set; }
		[Ordinal(46)]  [RED("AIBlackboard")] public CHandle<gameIBlackboard> AIBlackboard { get; set; }

		public gameweaponObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponObject : gameItemObject
	{
		[Ordinal(43)] [RED("effect")] public rRef<gameEffectSet> Effect { get; set; }
		[Ordinal(44)] [RED("hasOverheat")] public CBool HasOverheat { get; set; }
		[Ordinal(45)] [RED("overheatEffectBlackboard")] public CHandle<worldEffectBlackboard> OverheatEffectBlackboard { get; set; }
		[Ordinal(46)] [RED("overheatListener")] public CHandle<OverheatStatListener> OverheatListener { get; set; }
		[Ordinal(47)] [RED("overheatDelaySent")] public CBool OverheatDelaySent { get; set; }
		[Ordinal(48)] [RED("chargeEffectBlackboard")] public CHandle<worldEffectBlackboard> ChargeEffectBlackboard { get; set; }
		[Ordinal(49)] [RED("chargeStatListener")] public CHandle<WeaponChargeStatListener> ChargeStatListener { get; set; }
		[Ordinal(50)] [RED("meleeHitEffectBlackboard")] public CHandle<worldEffectBlackboard> MeleeHitEffectBlackboard { get; set; }
		[Ordinal(51)] [RED("meleeHitEffectValue")] public CFloat MeleeHitEffectValue { get; set; }
		[Ordinal(52)] [RED("damageTypeListener")] public CHandle<DamageStatListener> DamageTypeListener { get; set; }
		[Ordinal(53)] [RED("trailName")] public CString TrailName { get; set; }
		[Ordinal(54)] [RED("maxChargeThreshold")] public CFloat MaxChargeThreshold { get; set; }
		[Ordinal(55)] [RED("lowAmmoEffectActive")] public CBool LowAmmoEffectActive { get; set; }
		[Ordinal(56)] [RED("AIBlackboard")] public CHandle<gameIBlackboard> AIBlackboard { get; set; }

		public gameweaponObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

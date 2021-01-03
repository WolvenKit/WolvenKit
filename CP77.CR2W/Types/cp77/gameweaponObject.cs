using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameweaponObject : gameItemObject
	{
		[Ordinal(0)]  [RED("AIBlackboard")] public CHandle<gameIBlackboard> AIBlackboard { get; set; }
		[Ordinal(1)]  [RED("chargeEffectBlackboard")] public CHandle<worldEffectBlackboard> ChargeEffectBlackboard { get; set; }
		[Ordinal(2)]  [RED("chargeStatListener")] public CHandle<WeaponChargeStatListener> ChargeStatListener { get; set; }
		[Ordinal(3)]  [RED("damageTypeListener")] public CHandle<DamageStatListener> DamageTypeListener { get; set; }
		[Ordinal(4)]  [RED("effect")] public rRef<gameEffectSet> Effect { get; set; }
		[Ordinal(5)]  [RED("hasOverheat")] public CBool HasOverheat { get; set; }
		[Ordinal(6)]  [RED("lowAmmoEffectActive")] public CBool LowAmmoEffectActive { get; set; }
		[Ordinal(7)]  [RED("maxChargeThreshold")] public CFloat MaxChargeThreshold { get; set; }
		[Ordinal(8)]  [RED("meleeHitEffectBlackboard")] public CHandle<worldEffectBlackboard> MeleeHitEffectBlackboard { get; set; }
		[Ordinal(9)]  [RED("meleeHitEffectValue")] public CFloat MeleeHitEffectValue { get; set; }
		[Ordinal(10)]  [RED("overheatDelaySent")] public CBool OverheatDelaySent { get; set; }
		[Ordinal(11)]  [RED("overheatEffectBlackboard")] public CHandle<worldEffectBlackboard> OverheatEffectBlackboard { get; set; }
		[Ordinal(12)]  [RED("overheatListener")] public CHandle<OverheatStatListener> OverheatListener { get; set; }
		[Ordinal(13)]  [RED("trailName")] public CString TrailName { get; set; }

		public gameweaponObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

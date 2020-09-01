using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DamageAction : CDamageData
	{
		[Ordinal(0)] [RED("("dmgInfos", 2,0)] 		public CArray<SRawDamage> DmgInfos { get; set;}

		[Ordinal(0)] [RED("("effectInfos", 2,0)] 		public CArray<SEffectInfo> EffectInfos { get; set;}

		[Ordinal(0)] [RED("("cannotReturnDamage")] 		public CBool CannotReturnDamage { get; set;}

		[Ordinal(0)] [RED("("isPointResistIgnored")] 		public CBool IsPointResistIgnored { get; set;}

		[Ordinal(0)] [RED("("canPlayHitParticle")] 		public CBool CanPlayHitParticle { get; set;}

		[Ordinal(0)] [RED("("hitAnimationPlayType")] 		public CEnum<EActionHitAnim> HitAnimationPlayType { get; set;}

		[Ordinal(0)] [RED("("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[Ordinal(0)] [RED("("buffSourceName")] 		public CString BuffSourceName { get; set;}

		[Ordinal(0)] [RED("("canBeParried")] 		public CBool CanBeParried { get; set;}

		[Ordinal(0)] [RED("("canBeDodged")] 		public CBool CanBeDodged { get; set;}

		[Ordinal(0)] [RED("("hitFX")] 		public CName HitFX { get; set;}

		[Ordinal(0)] [RED("("hitBackFX")] 		public CName HitBackFX { get; set;}

		[Ordinal(0)] [RED("("hitParriedFX")] 		public CName HitParriedFX { get; set;}

		[Ordinal(0)] [RED("("hitBackParriedFX")] 		public CName HitBackParriedFX { get; set;}

		[Ordinal(0)] [RED("("powerStatType")] 		public CEnum<ECharacterPowerStats> PowerStatType { get; set;}

		[Ordinal(0)] [RED("("swingType")] 		public CEnum<EAttackSwingType> SwingType { get; set;}

		[Ordinal(0)] [RED("("swingDirection")] 		public CEnum<EAttackSwingDirection> SwingDirection { get; set;}

		[Ordinal(0)] [RED("("signSkill")] 		public CEnum<ESkill> SignSkill { get; set;}

		[Ordinal(0)] [RED("("isDodged")] 		public CBool IsDodged { get; set;}

		[Ordinal(0)] [RED("("shouldProcessBuffsIfNoDamage")] 		public CBool ShouldProcessBuffsIfNoDamage { get; set;}

		[Ordinal(0)] [RED("("ignoreImmortalityMode")] 		public CBool IgnoreImmortalityMode { get; set;}

		[Ordinal(0)] [RED("("dealtFireDamage")] 		public CBool DealtFireDamage { get; set;}

		[Ordinal(0)] [RED("("isHeadShot")] 		public CBool IsHeadShot { get; set;}

		[Ordinal(0)] [RED("("killedBySingleHit")] 		public CBool KilledBySingleHit { get; set;}

		[Ordinal(0)] [RED("("ignoreArmor")] 		public CBool IgnoreArmor { get; set;}

		[Ordinal(0)] [RED("("supressHitSounds")] 		public CBool SupressHitSounds { get; set;}

		[Ordinal(0)] [RED("("dealtDamage")] 		public CBool DealtDamage { get; set;}

		[Ordinal(0)] [RED("("endsQuen")] 		public CBool EndsQuen { get; set;}

		[Ordinal(0)] [RED("("armorReducedDamageToZero")] 		public CBool ArmorReducedDamageToZero { get; set;}

		[Ordinal(0)] [RED("("underwaterDisplayDamageHack")] 		public CBool UnderwaterDisplayDamageHack { get; set;}

		[Ordinal(0)] [RED("("parryStagger")] 		public CBool ParryStagger { get; set;}

		[Ordinal(0)] [RED("("bouncedArrow")] 		public CBool BouncedArrow { get; set;}

		[Ordinal(0)] [RED("("forceExplosionDismemberment")] 		public CBool ForceExplosionDismemberment { get; set;}

		[Ordinal(0)] [RED("("isCriticalHit")] 		public CBool IsCriticalHit { get; set;}

		[Ordinal(0)] [RED("("instantKill")] 		public CBool InstantKill { get; set;}

		[Ordinal(0)] [RED("("instantKillFloater")] 		public CBool InstantKillFloater { get; set;}

		[Ordinal(0)] [RED("("instantKillCooldownIgnore")] 		public CBool InstantKillCooldownIgnore { get; set;}

		[Ordinal(0)] [RED("("wasFrozen")] 		public CBool WasFrozen { get; set;}

		[Ordinal(0)] [RED("("mutation4Triggered")] 		public CBool Mutation4Triggered { get; set;}

		[Ordinal(0)] [RED("("didReturnDamageToAttacker")] 		public CBool DidReturnDamageToAttacker { get; set;}

		[Ordinal(0)] [RED("("DOTdt")] 		public CFloat DOTdt { get; set;}

		[Ordinal(0)] [RED("("isActionRanged")] 		public CBool IsActionRanged { get; set;}

		[Ordinal(0)] [RED("("isActionWitcherSign")] 		public CBool IsActionWitcherSign { get; set;}

		[Ordinal(0)] [RED("("isActionEnvironment")] 		public CBool IsActionEnvironment { get; set;}

		public W3DamageAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DamageAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
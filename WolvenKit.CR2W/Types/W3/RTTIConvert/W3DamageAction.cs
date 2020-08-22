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
		[RED("dmgInfos", 2,0)] 		public CArray<SRawDamage> DmgInfos { get; set;}

		[RED("effectInfos", 2,0)] 		public CArray<SEffectInfo> EffectInfos { get; set;}

		[RED("cannotReturnDamage")] 		public CBool CannotReturnDamage { get; set;}

		[RED("isPointResistIgnored")] 		public CBool IsPointResistIgnored { get; set;}

		[RED("canPlayHitParticle")] 		public CBool CanPlayHitParticle { get; set;}

		[RED("hitAnimationPlayType")] 		public CEnum<EActionHitAnim> HitAnimationPlayType { get; set;}

		[RED("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[RED("buffSourceName")] 		public CString BuffSourceName { get; set;}

		[RED("canBeParried")] 		public CBool CanBeParried { get; set;}

		[RED("canBeDodged")] 		public CBool CanBeDodged { get; set;}

		[RED("hitFX")] 		public CName HitFX { get; set;}

		[RED("hitBackFX")] 		public CName HitBackFX { get; set;}

		[RED("hitParriedFX")] 		public CName HitParriedFX { get; set;}

		[RED("hitBackParriedFX")] 		public CName HitBackParriedFX { get; set;}

		[RED("powerStatType")] 		public CEnum<ECharacterPowerStats> PowerStatType { get; set;}

		[RED("swingType")] 		public CEnum<EAttackSwingType> SwingType { get; set;}

		[RED("swingDirection")] 		public CEnum<EAttackSwingDirection> SwingDirection { get; set;}

		[RED("signSkill")] 		public CEnum<ESkill> SignSkill { get; set;}

		[RED("isDodged")] 		public CBool IsDodged { get; set;}

		[RED("shouldProcessBuffsIfNoDamage")] 		public CBool ShouldProcessBuffsIfNoDamage { get; set;}

		[RED("ignoreImmortalityMode")] 		public CBool IgnoreImmortalityMode { get; set;}

		[RED("dealtFireDamage")] 		public CBool DealtFireDamage { get; set;}

		[RED("isHeadShot")] 		public CBool IsHeadShot { get; set;}

		[RED("killedBySingleHit")] 		public CBool KilledBySingleHit { get; set;}

		[RED("ignoreArmor")] 		public CBool IgnoreArmor { get; set;}

		[RED("supressHitSounds")] 		public CBool SupressHitSounds { get; set;}

		[RED("dealtDamage")] 		public CBool DealtDamage { get; set;}

		[RED("endsQuen")] 		public CBool EndsQuen { get; set;}

		[RED("armorReducedDamageToZero")] 		public CBool ArmorReducedDamageToZero { get; set;}

		[RED("underwaterDisplayDamageHack")] 		public CBool UnderwaterDisplayDamageHack { get; set;}

		[RED("parryStagger")] 		public CBool ParryStagger { get; set;}

		[RED("bouncedArrow")] 		public CBool BouncedArrow { get; set;}

		[RED("forceExplosionDismemberment")] 		public CBool ForceExplosionDismemberment { get; set;}

		[RED("isCriticalHit")] 		public CBool IsCriticalHit { get; set;}

		[RED("instantKill")] 		public CBool InstantKill { get; set;}

		[RED("instantKillFloater")] 		public CBool InstantKillFloater { get; set;}

		[RED("instantKillCooldownIgnore")] 		public CBool InstantKillCooldownIgnore { get; set;}

		[RED("wasFrozen")] 		public CBool WasFrozen { get; set;}

		[RED("mutation4Triggered")] 		public CBool Mutation4Triggered { get; set;}

		[RED("didReturnDamageToAttacker")] 		public CBool DidReturnDamageToAttacker { get; set;}

		[RED("DOTdt")] 		public CFloat DOTdt { get; set;}

		[RED("isActionRanged")] 		public CBool IsActionRanged { get; set;}

		[RED("isActionWitcherSign")] 		public CBool IsActionWitcherSign { get; set;}

		[RED("isActionEnvironment")] 		public CBool IsActionEnvironment { get; set;}

		public W3DamageAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DamageAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
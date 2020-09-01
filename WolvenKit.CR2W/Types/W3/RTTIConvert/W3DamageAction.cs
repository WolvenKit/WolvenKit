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
		[Ordinal(1)] [RED("("dmgInfos", 2,0)] 		public CArray<SRawDamage> DmgInfos { get; set;}

		[Ordinal(2)] [RED("("effectInfos", 2,0)] 		public CArray<SEffectInfo> EffectInfos { get; set;}

		[Ordinal(3)] [RED("("cannotReturnDamage")] 		public CBool CannotReturnDamage { get; set;}

		[Ordinal(4)] [RED("("isPointResistIgnored")] 		public CBool IsPointResistIgnored { get; set;}

		[Ordinal(5)] [RED("("canPlayHitParticle")] 		public CBool CanPlayHitParticle { get; set;}

		[Ordinal(6)] [RED("("hitAnimationPlayType")] 		public CEnum<EActionHitAnim> HitAnimationPlayType { get; set;}

		[Ordinal(7)] [RED("("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[Ordinal(8)] [RED("("buffSourceName")] 		public CString BuffSourceName { get; set;}

		[Ordinal(9)] [RED("("canBeParried")] 		public CBool CanBeParried { get; set;}

		[Ordinal(10)] [RED("("canBeDodged")] 		public CBool CanBeDodged { get; set;}

		[Ordinal(11)] [RED("("hitFX")] 		public CName HitFX { get; set;}

		[Ordinal(12)] [RED("("hitBackFX")] 		public CName HitBackFX { get; set;}

		[Ordinal(13)] [RED("("hitParriedFX")] 		public CName HitParriedFX { get; set;}

		[Ordinal(14)] [RED("("hitBackParriedFX")] 		public CName HitBackParriedFX { get; set;}

		[Ordinal(15)] [RED("("powerStatType")] 		public CEnum<ECharacterPowerStats> PowerStatType { get; set;}

		[Ordinal(16)] [RED("("swingType")] 		public CEnum<EAttackSwingType> SwingType { get; set;}

		[Ordinal(17)] [RED("("swingDirection")] 		public CEnum<EAttackSwingDirection> SwingDirection { get; set;}

		[Ordinal(18)] [RED("("signSkill")] 		public CEnum<ESkill> SignSkill { get; set;}

		[Ordinal(19)] [RED("("isDodged")] 		public CBool IsDodged { get; set;}

		[Ordinal(20)] [RED("("shouldProcessBuffsIfNoDamage")] 		public CBool ShouldProcessBuffsIfNoDamage { get; set;}

		[Ordinal(21)] [RED("("ignoreImmortalityMode")] 		public CBool IgnoreImmortalityMode { get; set;}

		[Ordinal(22)] [RED("("dealtFireDamage")] 		public CBool DealtFireDamage { get; set;}

		[Ordinal(23)] [RED("("isHeadShot")] 		public CBool IsHeadShot { get; set;}

		[Ordinal(24)] [RED("("killedBySingleHit")] 		public CBool KilledBySingleHit { get; set;}

		[Ordinal(25)] [RED("("ignoreArmor")] 		public CBool IgnoreArmor { get; set;}

		[Ordinal(26)] [RED("("supressHitSounds")] 		public CBool SupressHitSounds { get; set;}

		[Ordinal(27)] [RED("("dealtDamage")] 		public CBool DealtDamage { get; set;}

		[Ordinal(28)] [RED("("endsQuen")] 		public CBool EndsQuen { get; set;}

		[Ordinal(29)] [RED("("armorReducedDamageToZero")] 		public CBool ArmorReducedDamageToZero { get; set;}

		[Ordinal(30)] [RED("("underwaterDisplayDamageHack")] 		public CBool UnderwaterDisplayDamageHack { get; set;}

		[Ordinal(31)] [RED("("parryStagger")] 		public CBool ParryStagger { get; set;}

		[Ordinal(32)] [RED("("bouncedArrow")] 		public CBool BouncedArrow { get; set;}

		[Ordinal(33)] [RED("("forceExplosionDismemberment")] 		public CBool ForceExplosionDismemberment { get; set;}

		[Ordinal(34)] [RED("("isCriticalHit")] 		public CBool IsCriticalHit { get; set;}

		[Ordinal(35)] [RED("("instantKill")] 		public CBool InstantKill { get; set;}

		[Ordinal(36)] [RED("("instantKillFloater")] 		public CBool InstantKillFloater { get; set;}

		[Ordinal(37)] [RED("("instantKillCooldownIgnore")] 		public CBool InstantKillCooldownIgnore { get; set;}

		[Ordinal(38)] [RED("("wasFrozen")] 		public CBool WasFrozen { get; set;}

		[Ordinal(39)] [RED("("mutation4Triggered")] 		public CBool Mutation4Triggered { get; set;}

		[Ordinal(40)] [RED("("didReturnDamageToAttacker")] 		public CBool DidReturnDamageToAttacker { get; set;}

		[Ordinal(41)] [RED("("DOTdt")] 		public CFloat DOTdt { get; set;}

		[Ordinal(42)] [RED("("isActionRanged")] 		public CBool IsActionRanged { get; set;}

		[Ordinal(43)] [RED("("isActionWitcherSign")] 		public CBool IsActionWitcherSign { get; set;}

		[Ordinal(44)] [RED("("isActionEnvironment")] 		public CBool IsActionEnvironment { get; set;}

		public W3DamageAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DamageAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
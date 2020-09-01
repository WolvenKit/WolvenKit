using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WitchBoilingWaterObstacle : W3DurationObstacle
	{
		[Ordinal(0)] [RED("("applyDebuffType")] 		public CEnum<EEffectType> ApplyDebuffType { get; set;}

		[Ordinal(0)] [RED("("debuffDuration")] 		public CFloat DebuffDuration { get; set;}

		[Ordinal(0)] [RED("("simpleDamageAction")] 		public CBool SimpleDamageAction { get; set;}

		[Ordinal(0)] [RED("("damageValue")] 		public CFloat DamageValue { get; set;}

		[Ordinal(0)] [RED("("allowDmgValueOverrideFromXML")] 		public CBool AllowDmgValueOverrideFromXML { get; set;}

		[Ordinal(0)] [RED("("attackDelay")] 		public CFloat AttackDelay { get; set;}

		[Ordinal(0)] [RED("("attackRadius")] 		public CFloat AttackRadius { get; set;}

		[Ordinal(0)] [RED("("increaseRadiusDelta")] 		public CFloat IncreaseRadiusDelta { get; set;}

		[Ordinal(0)] [RED("("ignoreVictimWithTag")] 		public CName IgnoreVictimWithTag { get; set;}

		[Ordinal(0)] [RED("("preAttackEffectName")] 		public CName PreAttackEffectName { get; set;}

		[Ordinal(0)] [RED("("attackEffectName")] 		public CName AttackEffectName { get; set;}

		[Ordinal(0)] [RED("("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[Ordinal(0)] [RED("("loopedAttack")] 		public CBool LoopedAttack { get; set;}

		[Ordinal(0)] [RED("("playAttackEffectOnlyWhenHit")] 		public CBool PlayAttackEffectOnlyWhenHit { get; set;}

		[Ordinal(0)] [RED("("useSeperateAttackEffectEntity")] 		public CHandle<CEntityTemplate> UseSeperateAttackEffectEntity { get; set;}

		[Ordinal(0)] [RED("("onAttackEffectCameraShakeStrength")] 		public CFloat OnAttackEffectCameraShakeStrength { get; set;}

		[Ordinal(0)] [RED("("onHitCameraShakeStrength")] 		public CFloat OnHitCameraShakeStrength { get; set;}

		[Ordinal(0)] [RED("("fxEntity")] 		public CHandle<CEntity> FxEntity { get; set;}

		[Ordinal(0)] [RED("("summoner")] 		public CHandle<CActor> Summoner { get; set;}

		[Ordinal(0)] [RED("("params")] 		public SCustomEffectParams Params { get; set;}

		[Ordinal(0)] [RED("("effectComponent")] 		public CHandle<CComponent> EffectComponent { get; set;}

		public W3WitchBoilingWaterObstacle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3WitchBoilingWaterObstacle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
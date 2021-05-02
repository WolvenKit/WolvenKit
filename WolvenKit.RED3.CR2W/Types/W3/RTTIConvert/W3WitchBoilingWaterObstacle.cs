using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WitchBoilingWaterObstacle : W3DurationObstacle
	{
		[Ordinal(1)] [RED("applyDebuffType")] 		public CEnum<EEffectType> ApplyDebuffType { get; set;}

		[Ordinal(2)] [RED("debuffDuration")] 		public CFloat DebuffDuration { get; set;}

		[Ordinal(3)] [RED("simpleDamageAction")] 		public CBool SimpleDamageAction { get; set;}

		[Ordinal(4)] [RED("damageValue")] 		public CFloat DamageValue { get; set;}

		[Ordinal(5)] [RED("allowDmgValueOverrideFromXML")] 		public CBool AllowDmgValueOverrideFromXML { get; set;}

		[Ordinal(6)] [RED("attackDelay")] 		public CFloat AttackDelay { get; set;}

		[Ordinal(7)] [RED("attackRadius")] 		public CFloat AttackRadius { get; set;}

		[Ordinal(8)] [RED("increaseRadiusDelta")] 		public CFloat IncreaseRadiusDelta { get; set;}

		[Ordinal(9)] [RED("ignoreVictimWithTag")] 		public CName IgnoreVictimWithTag { get; set;}

		[Ordinal(10)] [RED("preAttackEffectName")] 		public CName PreAttackEffectName { get; set;}

		[Ordinal(11)] [RED("attackEffectName")] 		public CName AttackEffectName { get; set;}

		[Ordinal(12)] [RED("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[Ordinal(13)] [RED("loopedAttack")] 		public CBool LoopedAttack { get; set;}

		[Ordinal(14)] [RED("playAttackEffectOnlyWhenHit")] 		public CBool PlayAttackEffectOnlyWhenHit { get; set;}

		[Ordinal(15)] [RED("useSeperateAttackEffectEntity")] 		public CHandle<CEntityTemplate> UseSeperateAttackEffectEntity { get; set;}

		[Ordinal(16)] [RED("onAttackEffectCameraShakeStrength")] 		public CFloat OnAttackEffectCameraShakeStrength { get; set;}

		[Ordinal(17)] [RED("onHitCameraShakeStrength")] 		public CFloat OnHitCameraShakeStrength { get; set;}

		[Ordinal(18)] [RED("fxEntity")] 		public CHandle<CEntity> FxEntity { get; set;}

		[Ordinal(19)] [RED("summoner")] 		public CHandle<CActor> Summoner { get; set;}

		[Ordinal(20)] [RED("params")] 		public SCustomEffectParams Params { get; set;}

		[Ordinal(21)] [RED("effectComponent")] 		public CHandle<CComponent> EffectComponent { get; set;}

		public W3WitchBoilingWaterObstacle(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3WitchBoilingWaterObstacle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
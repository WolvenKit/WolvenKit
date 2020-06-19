using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WitchBoilingWaterObstacle : W3DurationObstacle
	{
		[RED("applyDebuffType")] 		public CEnum<EEffectType> ApplyDebuffType { get; set;}

		[RED("debuffDuration")] 		public CFloat DebuffDuration { get; set;}

		[RED("simpleDamageAction")] 		public CBool SimpleDamageAction { get; set;}

		[RED("damageValue")] 		public CFloat DamageValue { get; set;}

		[RED("allowDmgValueOverrideFromXML")] 		public CBool AllowDmgValueOverrideFromXML { get; set;}

		[RED("attackDelay")] 		public CFloat AttackDelay { get; set;}

		[RED("attackRadius")] 		public CFloat AttackRadius { get; set;}

		[RED("increaseRadiusDelta")] 		public CFloat IncreaseRadiusDelta { get; set;}

		[RED("ignoreVictimWithTag")] 		public CName IgnoreVictimWithTag { get; set;}

		[RED("preAttackEffectName")] 		public CName PreAttackEffectName { get; set;}

		[RED("attackEffectName")] 		public CName AttackEffectName { get; set;}

		[RED("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[RED("loopedAttack")] 		public CBool LoopedAttack { get; set;}

		[RED("playAttackEffectOnlyWhenHit")] 		public CBool PlayAttackEffectOnlyWhenHit { get; set;}

		[RED("useSeperateAttackEffectEntity")] 		public CHandle<CEntityTemplate> UseSeperateAttackEffectEntity { get; set;}

		[RED("onAttackEffectCameraShakeStrength")] 		public CFloat OnAttackEffectCameraShakeStrength { get; set;}

		[RED("onHitCameraShakeStrength")] 		public CFloat OnHitCameraShakeStrength { get; set;}

		public W3WitchBoilingWaterObstacle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3WitchBoilingWaterObstacle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
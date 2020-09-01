using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskAttackDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(1)] [RED("("attackType")] 		public CEnum<EAttackType> AttackType { get; set;}

		[Ordinal(2)] [RED("("stopTaskAfterDealingDmg")] 		public CBool StopTaskAfterDealingDmg { get; set;}

		[Ordinal(3)] [RED("("setAttackEndVarOnStopTask")] 		public CBool SetAttackEndVarOnStopTask { get; set;}

		[Ordinal(4)] [RED("("useDirectionalAttacks")] 		public CBool UseDirectionalAttacks { get; set;}

		[Ordinal(5)] [RED("("fxOnDamageInstigated")] 		public CName FxOnDamageInstigated { get; set;}

		[Ordinal(6)] [RED("("fxOnDamageVictim")] 		public CName FxOnDamageVictim { get; set;}

		[Ordinal(7)] [RED("("soundEventOnDamageInstigated")] 		public CName SoundEventOnDamageInstigated { get; set;}

		[Ordinal(8)] [RED("("soundEventOnDamageVictim")] 		public CName SoundEventOnDamageVictim { get; set;}

		[Ordinal(9)] [RED("("applyFXCooldown")] 		public CFloat ApplyFXCooldown { get; set;}

		[Ordinal(10)] [RED("("behVarNameOnDeactivation")] 		public CName BehVarNameOnDeactivation { get; set;}

		[Ordinal(11)] [RED("("behVarValueOnDeactivation")] 		public CFloat BehVarValueOnDeactivation { get; set;}

		[Ordinal(12)] [RED("("stopAllEfectsOnDeactivation")] 		public CBool StopAllEfectsOnDeactivation { get; set;}

		[Ordinal(13)] [RED("("slideToTargetOnAnimEvent")] 		public CBool SlideToTargetOnAnimEvent { get; set;}

		[Ordinal(14)] [RED("("slideToTargetMaximumDistance")] 		public CFloat SlideToTargetMaximumDistance { get; set;}

		[Ordinal(15)] [RED("("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(16)] [RED("("useActionBlend")] 		public CBool UseActionBlend { get; set;}

		[Ordinal(17)] [RED("("attackParameter")] 		public CBehTreeValInt AttackParameter { get; set;}

		[Ordinal(18)] [RED("("applyEffectInAttackRange")] 		public CName ApplyEffectInAttackRange { get; set;}

		[Ordinal(19)] [RED("("hitDestructablesInAttackRange")] 		public CBool HitDestructablesInAttackRange { get; set;}

		[Ordinal(20)] [RED("("applyEffectType")] 		public CEnum<EEffectType> ApplyEffectType { get; set;}

		[Ordinal(21)] [RED("("applyEffectTypeArray", 2,0)] 		public CArray<CEnum<EEffectType>> ApplyEffectTypeArray { get; set;}

		[Ordinal(22)] [RED("("stopTaskOnCustomItemCollision")] 		public CBool StopTaskOnCustomItemCollision { get; set;}

		[Ordinal(23)] [RED("("spawnSparksFxOnCustomItemCollision")] 		public CName SpawnSparksFxOnCustomItemCollision { get; set;}

		[Ordinal(24)] [RED("("resourceNameOfSparksFxEntity")] 		public CName ResourceNameOfSparksFxEntity { get; set;}

		[Ordinal(25)] [RED("("customEffectDuration")] 		public CFloat CustomEffectDuration { get; set;}

		[Ordinal(26)] [RED("("customEffectValue")] 		public CFloat CustomEffectValue { get; set;}

		[Ordinal(27)] [RED("("customEffectPercentValue")] 		public CFloat CustomEffectPercentValue { get; set;}

		[Ordinal(28)] [RED("("unavailableWhenInvisibleTarget")] 		public CBool UnavailableWhenInvisibleTarget { get; set;}

		public CBTTaskAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
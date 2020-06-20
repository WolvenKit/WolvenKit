using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskAttackDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[RED("attackType")] 		public CEnum<EAttackType> AttackType { get; set;}

		[RED("stopTaskAfterDealingDmg")] 		public CBool StopTaskAfterDealingDmg { get; set;}

		[RED("setAttackEndVarOnStopTask")] 		public CBool SetAttackEndVarOnStopTask { get; set;}

		[RED("useDirectionalAttacks")] 		public CBool UseDirectionalAttacks { get; set;}

		[RED("fxOnDamageInstigated")] 		public CName FxOnDamageInstigated { get; set;}

		[RED("fxOnDamageVictim")] 		public CName FxOnDamageVictim { get; set;}

		[RED("soundEventOnDamageInstigated")] 		public CName SoundEventOnDamageInstigated { get; set;}

		[RED("soundEventOnDamageVictim")] 		public CName SoundEventOnDamageVictim { get; set;}

		[RED("applyFXCooldown")] 		public CFloat ApplyFXCooldown { get; set;}

		[RED("behVarNameOnDeactivation")] 		public CName BehVarNameOnDeactivation { get; set;}

		[RED("behVarValueOnDeactivation")] 		public CFloat BehVarValueOnDeactivation { get; set;}

		[RED("stopAllEfectsOnDeactivation")] 		public CBool StopAllEfectsOnDeactivation { get; set;}

		[RED("slideToTargetOnAnimEvent")] 		public CBool SlideToTargetOnAnimEvent { get; set;}

		[RED("slideToTargetMaximumDistance")] 		public CFloat SlideToTargetMaximumDistance { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("useActionBlend")] 		public CBool UseActionBlend { get; set;}

		[RED("attackParameter")] 		public CBehTreeValInt AttackParameter { get; set;}

		[RED("applyEffectInAttackRange")] 		public CName ApplyEffectInAttackRange { get; set;}

		[RED("hitDestructablesInAttackRange")] 		public CBool HitDestructablesInAttackRange { get; set;}

		[RED("applyEffectType")] 		public CEnum<EEffectType> ApplyEffectType { get; set;}

		[RED("applyEffectTypeArray", 2,0)] 		public CArray<CEnum<EEffectType>> ApplyEffectTypeArray { get; set;}

		[RED("stopTaskOnCustomItemCollision")] 		public CBool StopTaskOnCustomItemCollision { get; set;}

		[RED("spawnSparksFxOnCustomItemCollision")] 		public CName SpawnSparksFxOnCustomItemCollision { get; set;}

		[RED("resourceNameOfSparksFxEntity")] 		public CName ResourceNameOfSparksFxEntity { get; set;}

		[RED("customEffectDuration")] 		public CFloat CustomEffectDuration { get; set;}

		[RED("customEffectValue")] 		public CFloat CustomEffectValue { get; set;}

		[RED("customEffectPercentValue")] 		public CFloat CustomEffectPercentValue { get; set;}

		[RED("unavailableWhenInvisibleTarget")] 		public CBool UnavailableWhenInvisibleTarget { get; set;}

		public CBTTaskAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
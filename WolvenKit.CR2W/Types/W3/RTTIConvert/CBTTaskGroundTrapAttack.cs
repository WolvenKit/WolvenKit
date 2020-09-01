using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskGroundTrapAttack : CBTTaskAttack
	{
		[Ordinal(0)] [RED("("allowDamageSelf")] 		public CBool AllowDamageSelf { get; set;}

		[Ordinal(0)] [RED("("guaranteeSelfHitChance")] 		public CFloat GuaranteeSelfHitChance { get; set;}

		[Ordinal(0)] [RED("("randomizePosition")] 		public CBool RandomizePosition { get; set;}

		[Ordinal(0)] [RED("("guaranteeTargetHitChance")] 		public CFloat GuaranteeTargetHitChance { get; set;}

		[Ordinal(0)] [RED("("guaranteeToHitEntityWithTag")] 		public CFloat GuaranteeToHitEntityWithTag { get; set;}

		[Ordinal(0)] [RED("("entityTag")] 		public CName EntityTag { get; set;}

		[Ordinal(0)] [RED("("preferTargetsInCameraFrame")] 		public CBool PreferTargetsInCameraFrame { get; set;}

		[Ordinal(0)] [RED("("navigationSafeSpotRadius")] 		public CFloat NavigationSafeSpotRadius { get; set;}

		[Ordinal(0)] [RED("("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[Ordinal(0)] [RED("("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[Ordinal(0)] [RED("("camShakeStrength")] 		public CFloat CamShakeStrength { get; set;}

		[Ordinal(0)] [RED("("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("affectEnemiesInRange")] 		public CFloat AffectEnemiesInRange { get; set;}

		[Ordinal(0)] [RED("("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[Ordinal(0)] [RED("("delayDamage")] 		public CFloat DelayDamage { get; set;}

		[Ordinal(0)] [RED("("debuffType")] 		public CEnum<EEffectType> DebuffType { get; set;}

		[Ordinal(0)] [RED("("raiseEventOnDamageNPC")] 		public CName RaiseEventOnDamageNPC { get; set;}

		[Ordinal(0)] [RED("("debuffDuration")] 		public CFloat DebuffDuration { get; set;}

		[Ordinal(0)] [RED("("trapResourceName")] 		public CName TrapResourceName { get; set;}

		[Ordinal(0)] [RED("("playFxOnTrapSpawn")] 		public CName PlayFxOnTrapSpawn { get; set;}

		[Ordinal(0)] [RED("("playFxDamage")] 		public CName PlayFxDamage { get; set;}

		[Ordinal(0)] [RED("("delayDamageFx")] 		public CFloat DelayDamageFx { get; set;}

		[Ordinal(0)] [RED("("playFxOnDamageVictim")] 		public CName PlayFxOnDamageVictim { get; set;}

		[Ordinal(0)] [RED("("completeAfterMain")] 		public CBool CompleteAfterMain { get; set;}

		[Ordinal(0)] [RED("("onActivateFromTaskAttack")] 		public CBool OnActivateFromTaskAttack { get; set;}

		[Ordinal(0)] [RED("("m_trapEntity")] 		public CHandle<CEntityTemplate> M_trapEntity { get; set;}

		[Ordinal(0)] [RED("("m_trap")] 		public CHandle<CGameplayEntity> M_trap { get; set;}

		[Ordinal(0)] [RED("("m_activated")] 		public CBool M_activated { get; set;}

		[Ordinal(0)] [RED("("guaranteedHit")] 		public CBool GuaranteedHit { get; set;}

		public CBTTaskGroundTrapAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskGroundTrapAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
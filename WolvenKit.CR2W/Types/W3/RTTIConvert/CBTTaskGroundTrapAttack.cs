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
		[RED("allowDamageSelf")] 		public CBool AllowDamageSelf { get; set;}

		[RED("guaranteeSelfHitChance")] 		public CFloat GuaranteeSelfHitChance { get; set;}

		[RED("randomizePosition")] 		public CBool RandomizePosition { get; set;}

		[RED("guaranteeTargetHitChance")] 		public CFloat GuaranteeTargetHitChance { get; set;}

		[RED("guaranteeToHitEntityWithTag")] 		public CFloat GuaranteeToHitEntityWithTag { get; set;}

		[RED("entityTag")] 		public CName EntityTag { get; set;}

		[RED("preferTargetsInCameraFrame")] 		public CBool PreferTargetsInCameraFrame { get; set;}

		[RED("navigationSafeSpotRadius")] 		public CFloat NavigationSafeSpotRadius { get; set;}

		[RED("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[RED("camShakeStrength")] 		public CFloat CamShakeStrength { get; set;}

		[RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[RED("affectEnemiesInRange")] 		public CFloat AffectEnemiesInRange { get; set;}

		[RED("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[RED("delayDamage")] 		public CFloat DelayDamage { get; set;}

		[RED("debuffType")] 		public CEnum<EEffectType> DebuffType { get; set;}

		[RED("raiseEventOnDamageNPC")] 		public CName RaiseEventOnDamageNPC { get; set;}

		[RED("debuffDuration")] 		public CFloat DebuffDuration { get; set;}

		[RED("trapResourceName")] 		public CName TrapResourceName { get; set;}

		[RED("playFxOnTrapSpawn")] 		public CName PlayFxOnTrapSpawn { get; set;}

		[RED("playFxDamage")] 		public CName PlayFxDamage { get; set;}

		[RED("delayDamageFx")] 		public CFloat DelayDamageFx { get; set;}

		[RED("playFxOnDamageVictim")] 		public CName PlayFxOnDamageVictim { get; set;}

		[RED("completeAfterMain")] 		public CBool CompleteAfterMain { get; set;}

		[RED("onActivateFromTaskAttack")] 		public CBool OnActivateFromTaskAttack { get; set;}

		[RED("m_trapEntity")] 		public CHandle<CEntityTemplate> M_trapEntity { get; set;}

		[RED("m_trap")] 		public CHandle<CGameplayEntity> M_trap { get; set;}

		[RED("m_activated")] 		public CBool M_activated { get; set;}

		[RED("guaranteedHit")] 		public CBool GuaranteedHit { get; set;}

		public CBTTaskGroundTrapAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskGroundTrapAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
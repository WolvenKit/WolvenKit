using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskGroundTrapAttack : CBTTaskAttack
	{
		[Ordinal(1)] [RED("allowDamageSelf")] 		public CBool AllowDamageSelf { get; set;}

		[Ordinal(2)] [RED("guaranteeSelfHitChance")] 		public CFloat GuaranteeSelfHitChance { get; set;}

		[Ordinal(3)] [RED("randomizePosition")] 		public CBool RandomizePosition { get; set;}

		[Ordinal(4)] [RED("guaranteeTargetHitChance")] 		public CFloat GuaranteeTargetHitChance { get; set;}

		[Ordinal(5)] [RED("guaranteeToHitEntityWithTag")] 		public CFloat GuaranteeToHitEntityWithTag { get; set;}

		[Ordinal(6)] [RED("entityTag")] 		public CName EntityTag { get; set;}

		[Ordinal(7)] [RED("preferTargetsInCameraFrame")] 		public CBool PreferTargetsInCameraFrame { get; set;}

		[Ordinal(8)] [RED("navigationSafeSpotRadius")] 		public CFloat NavigationSafeSpotRadius { get; set;}

		[Ordinal(9)] [RED("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[Ordinal(10)] [RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[Ordinal(11)] [RED("camShakeStrength")] 		public CFloat CamShakeStrength { get; set;}

		[Ordinal(12)] [RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[Ordinal(13)] [RED("affectEnemiesInRange")] 		public CFloat AffectEnemiesInRange { get; set;}

		[Ordinal(14)] [RED("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[Ordinal(15)] [RED("delayDamage")] 		public CFloat DelayDamage { get; set;}

		[Ordinal(16)] [RED("debuffType")] 		public CEnum<EEffectType> DebuffType { get; set;}

		[Ordinal(17)] [RED("raiseEventOnDamageNPC")] 		public CName RaiseEventOnDamageNPC { get; set;}

		[Ordinal(18)] [RED("debuffDuration")] 		public CFloat DebuffDuration { get; set;}

		[Ordinal(19)] [RED("trapResourceName")] 		public CName TrapResourceName { get; set;}

		[Ordinal(20)] [RED("playFxOnTrapSpawn")] 		public CName PlayFxOnTrapSpawn { get; set;}

		[Ordinal(21)] [RED("playFxDamage")] 		public CName PlayFxDamage { get; set;}

		[Ordinal(22)] [RED("delayDamageFx")] 		public CFloat DelayDamageFx { get; set;}

		[Ordinal(23)] [RED("playFxOnDamageVictim")] 		public CName PlayFxOnDamageVictim { get; set;}

		[Ordinal(24)] [RED("completeAfterMain")] 		public CBool CompleteAfterMain { get; set;}

		[Ordinal(25)] [RED("onActivateFromTaskAttack")] 		public CBool OnActivateFromTaskAttack { get; set;}

		[Ordinal(26)] [RED("m_trapEntity")] 		public CHandle<CEntityTemplate> M_trapEntity { get; set;}

		[Ordinal(27)] [RED("m_trap")] 		public CHandle<CGameplayEntity> M_trap { get; set;}

		[Ordinal(28)] [RED("m_activated")] 		public CBool M_activated { get; set;}

		[Ordinal(29)] [RED("guaranteedHit")] 		public CBool GuaranteedHit { get; set;}

		public CBTTaskGroundTrapAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskGroundTrapAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
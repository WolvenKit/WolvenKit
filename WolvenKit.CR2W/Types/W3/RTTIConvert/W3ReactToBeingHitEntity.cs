using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ReactToBeingHitEntity : CGameplayEntity
	{
		[RED("reactsToSwords")] 		public CBool ReactsToSwords { get; set;}

		[RED("reactsToBolts")] 		public CBool ReactsToBolts { get; set;}

		[RED("deactivateOnHit")] 		public CBool DeactivateOnHit { get; set;}

		[RED("dealDamage")] 		public CBool DealDamage { get; set;}

		[RED("debuffType")] 		public CEnum<EEffectType> DebuffType { get; set;}

		[RED("debuffDuration")] 		public CFloat DebuffDuration { get; set;}

		[RED("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[RED("killOnHpBelowPerc")] 		public CFloat KillOnHpBelowPerc { get; set;}

		[RED("setBehVarOnKill")] 		public CName SetBehVarOnKill { get; set;}

		[RED("behVarValue")] 		public CFloat BehVarValue { get; set;}

		[RED("gameplayEventOnAttacker")] 		public CName GameplayEventOnAttacker { get; set;}

		[RED("effectOnActivation")] 		public CName EffectOnActivation { get; set;}

		[RED("durationEffect")] 		public CName DurationEffect { get; set;}

		[RED("effectOnHit")] 		public CName EffectOnHit { get; set;}

		[RED("effectOnHitVictim")] 		public CName EffectOnHitVictim { get; set;}

		[RED("activeDuration")] 		public CFloat ActiveDuration { get; set;}

		[RED("active")] 		public CBool Active { get; set;}

		[RED("attributeName")] 		public CName AttributeName { get; set;}

		public W3ReactToBeingHitEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ReactToBeingHitEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
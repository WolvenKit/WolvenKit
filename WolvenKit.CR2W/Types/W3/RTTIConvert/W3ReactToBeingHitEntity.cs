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
		[Ordinal(0)] [RED("("reactsToSwords")] 		public CBool ReactsToSwords { get; set;}

		[Ordinal(0)] [RED("("reactsToBolts")] 		public CBool ReactsToBolts { get; set;}

		[Ordinal(0)] [RED("("deactivateOnHit")] 		public CBool DeactivateOnHit { get; set;}

		[Ordinal(0)] [RED("("dealDamage")] 		public CBool DealDamage { get; set;}

		[Ordinal(0)] [RED("("debuffType")] 		public CEnum<EEffectType> DebuffType { get; set;}

		[Ordinal(0)] [RED("("debuffDuration")] 		public CFloat DebuffDuration { get; set;}

		[Ordinal(0)] [RED("("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[Ordinal(0)] [RED("("killOnHpBelowPerc")] 		public CFloat KillOnHpBelowPerc { get; set;}

		[Ordinal(0)] [RED("("setBehVarOnKill")] 		public CName SetBehVarOnKill { get; set;}

		[Ordinal(0)] [RED("("behVarValue")] 		public CFloat BehVarValue { get; set;}

		[Ordinal(0)] [RED("("gameplayEventOnAttacker")] 		public CName GameplayEventOnAttacker { get; set;}

		[Ordinal(0)] [RED("("effectOnActivation")] 		public CName EffectOnActivation { get; set;}

		[Ordinal(0)] [RED("("durationEffect")] 		public CName DurationEffect { get; set;}

		[Ordinal(0)] [RED("("effectOnHit")] 		public CName EffectOnHit { get; set;}

		[Ordinal(0)] [RED("("effectOnHitVictim")] 		public CName EffectOnHitVictim { get; set;}

		[Ordinal(0)] [RED("("activeDuration")] 		public CFloat ActiveDuration { get; set;}

		[Ordinal(0)] [RED("("active")] 		public CBool Active { get; set;}

		[Ordinal(0)] [RED("("attributeName")] 		public CName AttributeName { get; set;}

		public W3ReactToBeingHitEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ReactToBeingHitEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ReactToBeingHitEntity : CGameplayEntity
	{
		[Ordinal(1)] [RED("reactsToSwords")] 		public CBool ReactsToSwords { get; set;}

		[Ordinal(2)] [RED("reactsToBolts")] 		public CBool ReactsToBolts { get; set;}

		[Ordinal(3)] [RED("deactivateOnHit")] 		public CBool DeactivateOnHit { get; set;}

		[Ordinal(4)] [RED("dealDamage")] 		public CBool DealDamage { get; set;}

		[Ordinal(5)] [RED("debuffType")] 		public CEnum<EEffectType> DebuffType { get; set;}

		[Ordinal(6)] [RED("debuffDuration")] 		public CFloat DebuffDuration { get; set;}

		[Ordinal(7)] [RED("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[Ordinal(8)] [RED("killOnHpBelowPerc")] 		public CFloat KillOnHpBelowPerc { get; set;}

		[Ordinal(9)] [RED("setBehVarOnKill")] 		public CName SetBehVarOnKill { get; set;}

		[Ordinal(10)] [RED("behVarValue")] 		public CFloat BehVarValue { get; set;}

		[Ordinal(11)] [RED("gameplayEventOnAttacker")] 		public CName GameplayEventOnAttacker { get; set;}

		[Ordinal(12)] [RED("effectOnActivation")] 		public CName EffectOnActivation { get; set;}

		[Ordinal(13)] [RED("durationEffect")] 		public CName DurationEffect { get; set;}

		[Ordinal(14)] [RED("effectOnHit")] 		public CName EffectOnHit { get; set;}

		[Ordinal(15)] [RED("effectOnHitVictim")] 		public CName EffectOnHitVictim { get; set;}

		[Ordinal(16)] [RED("activeDuration")] 		public CFloat ActiveDuration { get; set;}

		[Ordinal(17)] [RED("active")] 		public CBool Active { get; set;}

		[Ordinal(18)] [RED("attributeName")] 		public CName AttributeName { get; set;}

		public W3ReactToBeingHitEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LightEntityDamaging : CLightEntitySimple
	{
		[Ordinal(1)] [RED("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[Ordinal(2)] [RED("damagePerSec")] 		public CFloat DamagePerSec { get; set;}

		[Ordinal(3)] [RED("appliesBurning")] 		public CBool AppliesBurning { get; set;}

		[Ordinal(4)] [RED("area")] 		public CHandle<CTriggerAreaComponent> Area { get; set;}

		[Ordinal(5)] [RED("entitiesInRange", 2,0)] 		public CArray<CHandle<CGameplayEntity>> EntitiesInRange { get; set;}

		[Ordinal(6)] [RED("entitiesInRangeEnterTime", 2,0)] 		public CArray<EngineTime> EntitiesInRangeEnterTime { get; set;}

		[Ordinal(7)] [RED("buffDamageVal")] 		public SAbilityAttributeValue BuffDamageVal { get; set;}

		[Ordinal(8)] [RED("damageDealingEnabled")] 		public CBool DamageDealingEnabled { get; set;}

		[Ordinal(9)] [RED("buffParams")] 		public SCustomEffectParams BuffParams { get; set;}

		[Ordinal(10)] [RED("spawned")] 		public CBool Spawned { get; set;}

		[Ordinal(11)] [RED("FIRE_DAMAGE_FX")] 		public CName FIRE_DAMAGE_FX { get; set;}

		public W3LightEntityDamaging(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LightEntityDamaging(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
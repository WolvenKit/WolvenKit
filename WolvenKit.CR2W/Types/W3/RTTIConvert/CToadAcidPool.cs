using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CToadAcidPool : CInteractiveEntity
	{
		[Ordinal(1)] [RED("poisonDamage")] 		public SAbilityAttributeValue PoisonDamage { get; set;}

		[Ordinal(2)] [RED("fxOnSpawn")] 		public CName FxOnSpawn { get; set;}

		[Ordinal(3)] [RED("immunityFact")] 		public CString ImmunityFact { get; set;}

		[Ordinal(4)] [RED("despawnTimer")] 		public CFloat DespawnTimer { get; set;}

		[Ordinal(5)] [RED("damageVal")] 		public CFloat DamageVal { get; set;}

		[Ordinal(6)] [RED("explosionRange")] 		public CFloat ExplosionRange { get; set;}

		[Ordinal(7)] [RED("destroyTimer")] 		public CFloat DestroyTimer { get; set;}

		[Ordinal(8)] [RED("settled")] 		public CBool Settled { get; set;}

		[Ordinal(9)] [RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		[Ordinal(10)] [RED("victims", 2,0)] 		public CArray<CHandle<CActor>> Victims { get; set;}

		[Ordinal(11)] [RED("poisonArea")] 		public CHandle<CTriggerAreaComponent> PoisonArea { get; set;}

		[Ordinal(12)] [RED("buffParams")] 		public SCustomEffectParams BuffParams { get; set;}

		[Ordinal(13)] [RED("damage")] 		public CHandle<W3DamageAction> Damage { get; set;}

		[Ordinal(14)] [RED("entitiesInRange", 2,0)] 		public CArray<CHandle<CGameplayEntity>> EntitiesInRange { get; set;}

		[Ordinal(15)] [RED("targetEntity")] 		public CHandle<CActor> TargetEntity { get; set;}

		[Ordinal(16)] [RED("fxStartTime")] 		public CFloat FxStartTime { get; set;}

		[Ordinal(17)] [RED("hasExploded")] 		public CBool HasExploded { get; set;}

		public CToadAcidPool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CToadAcidPool(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
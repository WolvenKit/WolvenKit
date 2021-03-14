using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DamageAreaTrigger : CEntity
	{
		[Ordinal(1)] [RED("onlyAffectsPlayer")] 		public CBool OnlyAffectsPlayer { get; set;}

		[Ordinal(2)] [RED("activateOnce")] 		public CBool ActivateOnce { get; set;}

		[Ordinal(3)] [RED("checkTag")] 		public CBool CheckTag { get; set;}

		[Ordinal(4)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(5)] [RED("actorTag")] 		public CName ActorTag { get; set;}

		[Ordinal(6)] [RED("excludedActorsTags", 2,0)] 		public CArray<CName> ExcludedActorsTags { get; set;}

		[Ordinal(7)] [RED("damage")] 		public CFloat Damage { get; set;}

		[Ordinal(8)] [RED("useDamageFromXML")] 		public CName UseDamageFromXML { get; set;}

		[Ordinal(9)] [RED("damageFromFXDelay")] 		public CFloat DamageFromFXDelay { get; set;}

		[Ordinal(10)] [RED("areaRadius")] 		public CFloat AreaRadius { get; set;}

		[Ordinal(11)] [RED("attackInterval")] 		public CFloat AttackInterval { get; set;}

		[Ordinal(12)] [RED("preAttackDuration")] 		public CFloat PreAttackDuration { get; set;}

		[Ordinal(13)] [RED("externalFXEntityTag")] 		public CName ExternalFXEntityTag { get; set;}

		[Ordinal(14)] [RED("externalFXName")] 		public CName ExternalFXName { get; set;}

		[Ordinal(15)] [RED("attackFX")] 		public CName AttackFX { get; set;}

		[Ordinal(16)] [RED("preAttackFX")] 		public CName PreAttackFX { get; set;}

		[Ordinal(17)] [RED("attackFXEntity")] 		public CHandle<CEntityTemplate> AttackFXEntity { get; set;}

		[Ordinal(18)] [RED("soundFX")] 		public CString SoundFX { get; set;}

		[Ordinal(19)] [RED("immunityFact")] 		public CString ImmunityFact { get; set;}

		[Ordinal(20)] [RED("damageType")] 		public CEnum<ETriggeredDamageType> DamageType { get; set;}

		[Ordinal(21)] [RED("action")] 		public CHandle<W3DamageAction> Action { get; set;}

		[Ordinal(22)] [RED("affectedEntity")] 		public CHandle<CEntity> AffectedEntity { get; set;}

		[Ordinal(23)] [RED("fxEntity")] 		public CHandle<CEntity> FxEntity { get; set;}

		[Ordinal(24)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(25)] [RED("dummyGameplayEntity")] 		public CHandle<CGameplayEntity> DummyGameplayEntity { get; set;}

		[Ordinal(26)] [RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		[Ordinal(27)] [RED("externalFXEntity")] 		public CHandle<CEntity> ExternalFXEntity { get; set;}

		[Ordinal(28)] [RED("pos")] 		public Vector Pos { get; set;}

		public W3DamageAreaTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DamageAreaTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
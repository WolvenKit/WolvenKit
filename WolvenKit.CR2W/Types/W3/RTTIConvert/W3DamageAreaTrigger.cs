using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DamageAreaTrigger : CEntity
	{
		[Ordinal(0)] [RED("("onlyAffectsPlayer")] 		public CBool OnlyAffectsPlayer { get; set;}

		[Ordinal(0)] [RED("("activateOnce")] 		public CBool ActivateOnce { get; set;}

		[Ordinal(0)] [RED("("checkTag")] 		public CBool CheckTag { get; set;}

		[Ordinal(0)] [RED("("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(0)] [RED("("actorTag")] 		public CName ActorTag { get; set;}

		[Ordinal(0)] [RED("("excludedActorsTags", 2,0)] 		public CArray<CName> ExcludedActorsTags { get; set;}

		[Ordinal(0)] [RED("("damage")] 		public CFloat Damage { get; set;}

		[Ordinal(0)] [RED("("useDamageFromXML")] 		public CName UseDamageFromXML { get; set;}

		[Ordinal(0)] [RED("("damageFromFXDelay")] 		public CFloat DamageFromFXDelay { get; set;}

		[Ordinal(0)] [RED("("areaRadius")] 		public CFloat AreaRadius { get; set;}

		[Ordinal(0)] [RED("("attackInterval")] 		public CFloat AttackInterval { get; set;}

		[Ordinal(0)] [RED("("preAttackDuration")] 		public CFloat PreAttackDuration { get; set;}

		[Ordinal(0)] [RED("("externalFXEntityTag")] 		public CName ExternalFXEntityTag { get; set;}

		[Ordinal(0)] [RED("("externalFXName")] 		public CName ExternalFXName { get; set;}

		[Ordinal(0)] [RED("("attackFX")] 		public CName AttackFX { get; set;}

		[Ordinal(0)] [RED("("preAttackFX")] 		public CName PreAttackFX { get; set;}

		[Ordinal(0)] [RED("("attackFXEntity")] 		public CHandle<CEntityTemplate> AttackFXEntity { get; set;}

		[Ordinal(0)] [RED("("soundFX")] 		public CString SoundFX { get; set;}

		[Ordinal(0)] [RED("("immunityFact")] 		public CString ImmunityFact { get; set;}

		[Ordinal(0)] [RED("("damageType")] 		public CEnum<ETriggeredDamageType> DamageType { get; set;}

		[Ordinal(0)] [RED("("action")] 		public CHandle<W3DamageAction> Action { get; set;}

		[Ordinal(0)] [RED("("affectedEntity")] 		public CHandle<CEntity> AffectedEntity { get; set;}

		[Ordinal(0)] [RED("("fxEntity")] 		public CHandle<CEntity> FxEntity { get; set;}

		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("dummyGameplayEntity")] 		public CHandle<CGameplayEntity> DummyGameplayEntity { get; set;}

		[Ordinal(0)] [RED("("victim")] 		public CHandle<CActor> Victim { get; set;}

		[Ordinal(0)] [RED("("externalFXEntity")] 		public CHandle<CEntity> ExternalFXEntity { get; set;}

		[Ordinal(0)] [RED("("pos")] 		public Vector Pos { get; set;}

		public W3DamageAreaTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DamageAreaTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
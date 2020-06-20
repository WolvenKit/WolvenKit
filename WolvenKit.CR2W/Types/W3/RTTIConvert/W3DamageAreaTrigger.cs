using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DamageAreaTrigger : CEntity
	{
		[RED("onlyAffectsPlayer")] 		public CBool OnlyAffectsPlayer { get; set;}

		[RED("activateOnce")] 		public CBool ActivateOnce { get; set;}

		[RED("checkTag")] 		public CBool CheckTag { get; set;}

		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[RED("actorTag")] 		public CName ActorTag { get; set;}

		[RED("excludedActorsTags", 2,0)] 		public CArray<CName> ExcludedActorsTags { get; set;}

		[RED("damage")] 		public CFloat Damage { get; set;}

		[RED("useDamageFromXML")] 		public CName UseDamageFromXML { get; set;}

		[RED("damageFromFXDelay")] 		public CFloat DamageFromFXDelay { get; set;}

		[RED("areaRadius")] 		public CFloat AreaRadius { get; set;}

		[RED("attackInterval")] 		public CFloat AttackInterval { get; set;}

		[RED("preAttackDuration")] 		public CFloat PreAttackDuration { get; set;}

		[RED("externalFXEntityTag")] 		public CName ExternalFXEntityTag { get; set;}

		[RED("externalFXName")] 		public CName ExternalFXName { get; set;}

		[RED("attackFX")] 		public CName AttackFX { get; set;}

		[RED("preAttackFX")] 		public CName PreAttackFX { get; set;}

		[RED("attackFXEntity")] 		public CHandle<CEntityTemplate> AttackFXEntity { get; set;}

		[RED("soundFX")] 		public CString SoundFX { get; set;}

		[RED("immunityFact")] 		public CString ImmunityFact { get; set;}

		[RED("damageType")] 		public CEnum<ETriggeredDamageType> DamageType { get; set;}

		public W3DamageAreaTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DamageAreaTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
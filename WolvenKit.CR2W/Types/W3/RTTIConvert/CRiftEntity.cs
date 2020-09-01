using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CRiftEntity : CInteractiveEntity
	{
		[Ordinal(0)] [RED("linkingMode")] 		public CBool LinkingMode { get; set;}

		[Ordinal(0)] [RED("controlledEncounter")] 		public EntityHandle ControlledEncounter { get; set;}

		[Ordinal(0)] [RED("controlledEncounterTag")] 		public CName ControlledEncounterTag { get; set;}

		[Ordinal(0)] [RED("activationDelay")] 		public CFloat ActivationDelay { get; set;}

		[Ordinal(0)] [RED("closeAfter")] 		public CFloat CloseAfter { get; set;}

		[Ordinal(0)] [RED("canBeDisabled")] 		public CBool CanBeDisabled { get; set;}

		[Ordinal(0)] [RED("damageVal")] 		public SAbilityAttributeValue DamageVal { get; set;}

		[Ordinal(0)] [RED("factSetAfterRiftWasDisabled")] 		public CString FactSetAfterRiftWasDisabled { get; set;}

		[Ordinal(0)] [RED("isIntact")] 		public CBool IsIntact { get; set;}

		[Ordinal(0)] [RED("currState")] 		public CName CurrState { get; set;}

		[Ordinal(0)] [RED("encounter")] 		public CHandle<CEncounter> Encounter { get; set;}

		[Ordinal(0)] [RED("coldArea")] 		public CHandle<CTriggerAreaComponent> ColdArea { get; set;}

		[Ordinal(0)] [RED("entitiesInRange", 2,0)] 		public CArray<CHandle<CActor>> EntitiesInRange { get; set;}

		[Ordinal(0)] [RED("isEncounterEnabled")] 		public CBool IsEncounterEnabled { get; set;}

		[Ordinal(0)] [RED("buffParams")] 		public SCustomEffectParams BuffParams { get; set;}

		[Ordinal(0)] [RED("spawnCounter")] 		public CInt32 SpawnCounter { get; set;}

		[Ordinal(0)] [RED("encounterSpawnLimit")] 		public CInt32 EncounterSpawnLimit { get; set;}

		[Ordinal(0)] [RED("collisionEntityTemplate")] 		public CHandle<CEntityTemplate> CollisionEntityTemplate { get; set;}

		[Ordinal(0)] [RED("collisionEntity")] 		public CHandle<CEntity> CollisionEntity { get; set;}

		public CRiftEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CRiftEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
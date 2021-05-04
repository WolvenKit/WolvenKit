using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CRiftEntity : CInteractiveEntity
	{
		[Ordinal(1)] [RED("linkingMode")] 		public CBool LinkingMode { get; set;}

		[Ordinal(2)] [RED("controlledEncounter")] 		public EntityHandle ControlledEncounter { get; set;}

		[Ordinal(3)] [RED("controlledEncounterTag")] 		public CName ControlledEncounterTag { get; set;}

		[Ordinal(4)] [RED("activationDelay")] 		public CFloat ActivationDelay { get; set;}

		[Ordinal(5)] [RED("closeAfter")] 		public CFloat CloseAfter { get; set;}

		[Ordinal(6)] [RED("canBeDisabled")] 		public CBool CanBeDisabled { get; set;}

		[Ordinal(7)] [RED("damageVal")] 		public SAbilityAttributeValue DamageVal { get; set;}

		[Ordinal(8)] [RED("factSetAfterRiftWasDisabled")] 		public CString FactSetAfterRiftWasDisabled { get; set;}

		[Ordinal(9)] [RED("isIntact")] 		public CBool IsIntact { get; set;}

		[Ordinal(10)] [RED("currState")] 		public CName CurrState { get; set;}

		[Ordinal(11)] [RED("encounter")] 		public CHandle<CEncounter> Encounter { get; set;}

		[Ordinal(12)] [RED("coldArea")] 		public CHandle<CTriggerAreaComponent> ColdArea { get; set;}

		[Ordinal(13)] [RED("entitiesInRange", 2,0)] 		public CArray<CHandle<CActor>> EntitiesInRange { get; set;}

		[Ordinal(14)] [RED("isEncounterEnabled")] 		public CBool IsEncounterEnabled { get; set;}

		[Ordinal(15)] [RED("buffParams")] 		public SCustomEffectParams BuffParams { get; set;}

		[Ordinal(16)] [RED("spawnCounter")] 		public CInt32 SpawnCounter { get; set;}

		[Ordinal(17)] [RED("encounterSpawnLimit")] 		public CInt32 EncounterSpawnLimit { get; set;}

		[Ordinal(18)] [RED("collisionEntityTemplate")] 		public CHandle<CEntityTemplate> CollisionEntityTemplate { get; set;}

		[Ordinal(19)] [RED("collisionEntity")] 		public CHandle<CEntity> CollisionEntity { get; set;}

		public CRiftEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
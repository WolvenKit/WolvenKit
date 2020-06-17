using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEncounter : CGameplayEntity
	{
		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("ignoreAreaTrigger")] 		public CBool IgnoreAreaTrigger { get; set;}

		[RED("fullRespawnScheduled")] 		public CBool FullRespawnScheduled { get; set;}

		[RED("spawnTree")] 		public CPtr<ISpawnTreeBranch> SpawnTree { get; set;}

		[RED("creatureDefinition", 2,0)] 		public CArray<CPtr<CEncounterCreatureDefinition>> CreatureDefinition { get; set;}

		[RED("encounterParameters")] 		public CHandle<CEncounterParameters> EncounterParameters { get; set;}

		[RED("spawnArea")] 		public EntityHandle SpawnArea { get; set;}

		[RED("fullRespawnDelay")] 		public GameTime FullRespawnDelay { get; set;}

		[RED("isFullRespawnTimeInGameTime")] 		public CBool IsFullRespawnTimeInGameTime { get; set;}

		[RED("fullRespawnTime")] 		public GameTime FullRespawnTime { get; set;}

		[RED("wasRaining")] 		public CBool WasRaining { get; set;}

		[RED("conditionRetestTimeout")] 		public CFloat ConditionRetestTimeout { get; set;}

		[RED("defaultImmediateDespawnConfiguration")] 		public SSpawnTreeDespawnConfiguration DefaultImmediateDespawnConfiguration { get; set;}

		[RED("spawnTreeType")] 		public ESpawnTreeType SpawnTreeType { get; set;}

		[RED("dataManager")] 		public CHandle<CEncounterDataManager> DataManager { get; set;}

		public CEncounter(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEncounter(cr2w);

	}
}
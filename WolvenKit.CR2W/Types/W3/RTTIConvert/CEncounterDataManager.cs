using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEncounterDataManager : IScriptable
	{
		[Ordinal(0)] [RED("("resetOnFullRespawn")] 		public CBool ResetOnFullRespawn { get; set;}

		[Ordinal(0)] [RED("("disabledCreaturesGroups", 2,0)] 		public CArray<CreaturesGroupDef> DisabledCreaturesGroups { get; set;}

		[Ordinal(0)] [RED("("killedCreatures")] 		public CInt32 KilledCreatures { get; set;}

		[Ordinal(0)] [RED("("currentlySpawnedCreatures")] 		public CInt32 CurrentlySpawnedCreatures { get; set;}

		[Ordinal(0)] [RED("("spawnedCreatures")] 		public CInt32 SpawnedCreatures { get; set;}

		[Ordinal(0)] [RED("("lostCreatures")] 		public CInt32 LostCreatures { get; set;}

		[Ordinal(0)] [RED("("killedCreaturesByEntry", 2,0)] 		public CArray<CreatureCounterDef> KilledCreaturesByEntry { get; set;}

		[Ordinal(0)] [RED("("currentlySpawnedCreaturesByEntry", 2,0)] 		public CArray<CreatureCounterDef> CurrentlySpawnedCreaturesByEntry { get; set;}

		[Ordinal(0)] [RED("("spawnedCreaturesByEntry", 2,0)] 		public CArray<CreatureCounterDef> SpawnedCreaturesByEntry { get; set;}

		[Ordinal(0)] [RED("("lostCreaturesByEntry", 2,0)] 		public CArray<CreatureCounterDef> LostCreaturesByEntry { get; set;}

		[Ordinal(0)] [RED("("disbledMonitors", 2,0)] 		public CArray<CHandle<ISpawnTreeSpawnMonitorInitializer>> DisbledMonitors { get; set;}

		[Ordinal(0)] [RED("("ownerTasksToPerform", 2,0)] 		public CArray<SOwnerEncounterTaskParams> OwnerTasksToPerform { get; set;}

		[Ordinal(0)] [RED("("externalTasksToPerform", 2,0)] 		public CArray<SExternalEncounterTaskParams> ExternalTasksToPerform { get; set;}

		public CEncounterDataManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEncounterDataManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
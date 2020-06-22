using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSummonCreaturesOnSpots : IBehTreeTask
	{
		[RED("entityToSpawn")] 		public CHandle<CEntityTemplate> EntityToSpawn { get; set;}

		[RED("summonOnAnimEvent")] 		public CName SummonOnAnimEvent { get; set;}

		[RED("spotTag")] 		public CName SpotTag { get; set;}

		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("maxSpawnQuantity")] 		public CInt32 MaxSpawnQuantity { get; set;}

		[RED("betweenSpawnDelay")] 		public SRangeF BetweenSpawnDelay { get; set;}

		[RED("completeAfterSpawn")] 		public CBool CompleteAfterSpawn { get; set;}

		[RED("spawnAreaCenter")] 		public CEnum<ETargetName> SpawnAreaCenter { get; set;}

		[RED("minDistanceFromSpawner")] 		public CFloat MinDistanceFromSpawner { get; set;}

		[RED("spawnBehVarName")] 		public CName SpawnBehVarName { get; set;}

		[RED("spawnBehVar")] 		public CFloat SpawnBehVar { get; set;}

		[RED("shouldForceBehaviorOnSpawn")] 		public CBool ShouldForceBehaviorOnSpawn { get; set;}

		[RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		[RED("m_AllSpots", 2,0)] 		public CArray<CHandle<CNode>> M_AllSpots { get; set;}

		[RED("m_CreateEntityHelper")] 		public CHandle<CCreateEntityHelper> M_CreateEntityHelper { get; set;}

		[RED("m_WaitingToSpawn")] 		public CBool M_WaitingToSpawn { get; set;}

		[RED("m_IsSpawned")] 		public CBool M_IsSpawned { get; set;}

		public BTTaskSummonCreaturesOnSpots(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskSummonCreaturesOnSpots(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
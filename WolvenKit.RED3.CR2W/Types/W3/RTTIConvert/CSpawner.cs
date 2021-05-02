using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawner : CEntity
	{
		[Ordinal(1)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(2)] [RED("count")] 		public CInt32 Count { get; set;}

		[Ordinal(3)] [RED("immortalityMode")] 		public CEnum<EActorImmortalityMode> ImmortalityMode { get; set;}

		[Ordinal(4)] [RED("attitudeOverride")] 		public CBool AttitudeOverride { get; set;}

		[Ordinal(5)] [RED("attitudeToPlayer")] 		public CEnum<EAIAttitude> AttitudeToPlayer { get; set;}

		[Ordinal(6)] [RED("hostileSpawnerTag")] 		public CName HostileSpawnerTag { get; set;}

		[Ordinal(7)] [RED("spawnTags", 2,0)] 		public CArray<CName> SpawnTags { get; set;}

		[Ordinal(8)] [RED("respawn")] 		public CBool Respawn { get; set;}

		[Ordinal(9)] [RED("respawnDelay")] 		public CFloat RespawnDelay { get; set;}

		[Ordinal(10)] [RED("initialHealth")] 		public CInt32 InitialHealth { get; set;}

		[Ordinal(11)] [RED("spawnAnimation")] 		public CEnum<EExplorationMode> SpawnAnimation { get; set;}

		[Ordinal(12)] [RED("spawnedNPCs", 2,0)] 		public CArray<CHandle<CNewNPC>> SpawnedNPCs { get; set;}

		[Ordinal(13)] [RED("respawnTime", 2,0)] 		public CArray<EngineTime> RespawnTime { get; set;}

		[Ordinal(14)] [RED("respawnNeeded", 2,0)] 		public CArray<CBool> RespawnNeeded { get; set;}

		public CSpawner(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
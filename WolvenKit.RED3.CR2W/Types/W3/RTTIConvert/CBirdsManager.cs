using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBirdsManager : CGameplayEntity
	{
		[Ordinal(1)] [RED("birdsSpawnPointsTag")] 		public CName BirdsSpawnPointsTag { get; set;}

		[Ordinal(2)] [RED("birdType")] 		public CEnum<EBirdType> BirdType { get; set;}

		[Ordinal(3)] [RED("spawnRange")] 		public CFloat SpawnRange { get; set;}

		[Ordinal(4)] [RED("customBirdTemplate")] 		public CHandle<CEntityTemplate> CustomBirdTemplate { get; set;}

		[Ordinal(5)] [RED("respawnDelay")] 		public CFloat RespawnDelay { get; set;}

		[Ordinal(6)] [RED("respawnMinDistance")] 		public CFloat RespawnMinDistance { get; set;}

		[Ordinal(7)] [RED("spawnOnlyInsideBirdsArea")] 		public CBool SpawnOnlyInsideBirdsArea { get; set;}

		[Ordinal(8)] [RED("disableSnapToCollisions")] 		public CBool DisableSnapToCollisions { get; set;}

		[Ordinal(9)] [RED("birdSpawnpoints", 2,0)] 		public CArray<SBirdSpawnpoint> BirdSpawnpoints { get; set;}

		[Ordinal(10)] [RED("shouldBirdsFly")] 		public CBool ShouldBirdsFly { get; set;}

		[Ordinal(11)] [RED("despawnTime")] 		public CFloat DespawnTime { get; set;}

		[Ordinal(12)] [RED("wasEverVisible")] 		public CBool WasEverVisible { get; set;}

		[Ordinal(13)] [RED("birdArea")] 		public CHandle<CTriggerAreaComponent> BirdArea { get; set;}

		[Ordinal(14)] [RED("birdTemplate")] 		public CHandle<CEntityTemplate> BirdTemplate { get; set;}

		public CBirdsManager(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBirdsManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
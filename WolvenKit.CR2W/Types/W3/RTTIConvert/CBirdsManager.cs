using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBirdsManager : CGameplayEntity
	{
		[RED("birdsSpawnPointsTag")] 		public CName BirdsSpawnPointsTag { get; set;}

		[RED("birdType")] 		public CEnum<EBirdType> BirdType { get; set;}

		[RED("spawnRange")] 		public CFloat SpawnRange { get; set;}

		[RED("customBirdTemplate")] 		public CHandle<CEntityTemplate> CustomBirdTemplate { get; set;}

		[RED("respawnDelay")] 		public CFloat RespawnDelay { get; set;}

		[RED("respawnMinDistance")] 		public CFloat RespawnMinDistance { get; set;}

		[RED("spawnOnlyInsideBirdsArea")] 		public CBool SpawnOnlyInsideBirdsArea { get; set;}

		[RED("disableSnapToCollisions")] 		public CBool DisableSnapToCollisions { get; set;}

		public CBirdsManager(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBirdsManager(cr2w);

	}
}
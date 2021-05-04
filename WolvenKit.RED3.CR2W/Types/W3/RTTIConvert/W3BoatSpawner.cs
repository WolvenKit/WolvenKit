using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BoatSpawner : CGameplayEntity
	{
		[Ordinal(1)] [RED("spawnedBoat")] 		public EntityHandle SpawnedBoat { get; set;}

		[Ordinal(2)] [RED("respawnDistance")] 		public CFloat RespawnDistance { get; set;}

		[Ordinal(3)] [RED("isAttemptingBoatSpawn")] 		public CBool IsAttemptingBoatSpawn { get; set;}

		public W3BoatSpawner(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
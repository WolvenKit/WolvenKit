using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnMultipleEntitiesAttack : CBTTaskSpawnEntityAttack
	{
		[Ordinal(1)] [RED("numberToSpawn")] 		public CInt32 NumberToSpawn { get; set;}

		[Ordinal(2)] [RED("numberOfCircles")] 		public CInt32 NumberOfCircles { get; set;}

		[Ordinal(3)] [RED("randomnessInCircles")] 		public CFloat RandomnessInCircles { get; set;}

		[Ordinal(4)] [RED("useRandomSpaceBetweenSpawns")] 		public CBool UseRandomSpaceBetweenSpawns { get; set;}

		[Ordinal(5)] [RED("spawnRadiusMin")] 		public CFloat SpawnRadiusMin { get; set;}

		[Ordinal(6)] [RED("spawnRadiusMax")] 		public CFloat SpawnRadiusMax { get; set;}

		[Ordinal(7)] [RED("spawnEntityRadius")] 		public CFloat SpawnEntityRadius { get; set;}

		[Ordinal(8)] [RED("spawnPositionPattern")] 		public CEnum<ESpawnPositionPattern> SpawnPositionPattern { get; set;}

		[Ordinal(9)] [RED("spawnRotation")] 		public CEnum<ESpawnRotation> SpawnRotation { get; set;}

		[Ordinal(10)] [RED("leaveOpenSpaceForDodge")] 		public CBool LeaveOpenSpaceForDodge { get; set;}

		[Ordinal(11)] [RED("spawnInRandomOrder")] 		public CBool SpawnInRandomOrder { get; set;}

		[Ordinal(12)] [RED("delayBetweenSpawn")] 		public CFloat DelayBetweenSpawn { get; set;}

		[Ordinal(13)] [RED("spawnOnGround")] 		public CBool SpawnOnGround { get; set;}

		[Ordinal(14)] [RED("m_dodgeDistance")] 		public CFloat M_dodgeDistance { get; set;}

		[Ordinal(15)] [RED("m_dodgeSafeAreaRadius")] 		public CFloat M_dodgeSafeAreaRadius { get; set;}

		[Ordinal(16)] [RED("m_shouldSpawn")] 		public CBool M_shouldSpawn { get; set;}

		[Ordinal(17)] [RED("m_entitiesSpawned")] 		public CInt32 M_entitiesSpawned { get; set;}

		[Ordinal(18)] [RED("m_canComplete")] 		public CBool M_canComplete { get; set;}

		public CBTTaskSpawnMultipleEntitiesAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnMultipleEntitiesAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
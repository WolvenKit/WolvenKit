using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnMultipleEntitiesAttackDef : CBTTaskSpawnEntityAttackDef
	{
		[RED("numberToSpawn")] 		public CInt32 NumberToSpawn { get; set;}

		[RED("numberOfCircles")] 		public CInt32 NumberOfCircles { get; set;}

		[RED("spawnPositionPattern")] 		public CEnum<ESpawnPositionPattern> SpawnPositionPattern { get; set;}

		[RED("randomnessInCircles")] 		public CFloat RandomnessInCircles { get; set;}

		[RED("useRandomSpaceBetweenSpawns")] 		public CBool UseRandomSpaceBetweenSpawns { get; set;}

		[RED("spawnRadiusMin")] 		public CFloat SpawnRadiusMin { get; set;}

		[RED("spawnRadiusMax")] 		public CFloat SpawnRadiusMax { get; set;}

		[RED("spawnEntityRadius")] 		public CFloat SpawnEntityRadius { get; set;}

		[RED("spawnRotation")] 		public CEnum<ESpawnRotation> SpawnRotation { get; set;}

		[RED("leaveOpenSpaceForDodge")] 		public CBool LeaveOpenSpaceForDodge { get; set;}

		[RED("delayBetweenSpawn")] 		public CFloat DelayBetweenSpawn { get; set;}

		[RED("spawnInRandomOrder")] 		public CBool SpawnInRandomOrder { get; set;}

		[RED("spawnOnGround")] 		public CBool SpawnOnGround { get; set;}

		public CBTTaskSpawnMultipleEntitiesAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnMultipleEntitiesAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
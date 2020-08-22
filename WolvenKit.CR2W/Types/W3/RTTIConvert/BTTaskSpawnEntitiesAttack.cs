using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSpawnEntitiesAttack : IBehTreeTask
	{
		[RED("resourceName")] 		public CName ResourceName { get; set;}

		[RED("eventName")] 		public CName EventName { get; set;}

		[RED("numberOfEntities")] 		public CInt32 NumberOfEntities { get; set;}

		[RED("timeBetweenSpawn")] 		public CFloat TimeBetweenSpawn { get; set;}

		[RED("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[RED("minDistFromEachOther")] 		public CFloat MinDistFromEachOther { get; set;}

		[RED("initialDelay")] 		public CFloat InitialDelay { get; set;}

		[RED("behVariableToSetOnEnd")] 		public CName BehVariableToSetOnEnd { get; set;}

		[RED("shouldStart")] 		public CBool ShouldStart { get; set;}

		[RED("lastSpawnTimestamp")] 		public CFloat LastSpawnTimestamp { get; set;}

		[RED("spawnTimeout")] 		public CFloat SpawnTimeout { get; set;}

		[RED("checkDistanceOfNpcToTarget")] 		public CBool CheckDistanceOfNpcToTarget { get; set;}

		[RED("spawnEntitiesAroundOwner")] 		public CBool SpawnEntitiesAroundOwner { get; set;}

		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("usedPos", 2,0)] 		public CArray<Vector> UsedPos { get; set;}

		public BTTaskSpawnEntitiesAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskSpawnEntitiesAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
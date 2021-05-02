using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSpawnEntitiesAttackDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(2)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(3)] [RED("numberOfEntities")] 		public CInt32 NumberOfEntities { get; set;}

		[Ordinal(4)] [RED("timeBetweenSpawn")] 		public CFloat TimeBetweenSpawn { get; set;}

		[Ordinal(5)] [RED("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[Ordinal(6)] [RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[Ordinal(7)] [RED("minDistFromEachOther")] 		public CFloat MinDistFromEachOther { get; set;}

		[Ordinal(8)] [RED("initialDelay")] 		public CFloat InitialDelay { get; set;}

		[Ordinal(9)] [RED("behVariableToSetOnEnd")] 		public CName BehVariableToSetOnEnd { get; set;}

		[Ordinal(10)] [RED("checkDistanceOfNpcToTarget")] 		public CBool CheckDistanceOfNpcToTarget { get; set;}

		[Ordinal(11)] [RED("spawnEntitiesAroundOwner")] 		public CBool SpawnEntitiesAroundOwner { get; set;}

		public BTTaskSpawnEntitiesAttackDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
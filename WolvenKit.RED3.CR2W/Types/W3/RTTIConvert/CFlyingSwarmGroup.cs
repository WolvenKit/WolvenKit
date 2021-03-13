using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFlyingSwarmGroup : CVariable
	{
		[Ordinal(1)] [RED("groupId")] 		public CFlyingGroupId GroupId { get; set;}

		[Ordinal(2)] [RED("groupCenter")] 		public Vector GroupCenter { get; set;}

		[Ordinal(3)] [RED("targetPosition")] 		public Vector TargetPosition { get; set;}

		[Ordinal(4)] [RED("currentGroupState")] 		public CName CurrentGroupState { get; set;}

		[Ordinal(5)] [RED("boidCount")] 		public CInt32 BoidCount { get; set;}

		[Ordinal(6)] [RED("toSpawnCount")] 		public CInt32 ToSpawnCount { get; set;}

		[Ordinal(7)] [RED("spawnPoiType")] 		public CName SpawnPoiType { get; set;}

		[Ordinal(8)] [RED("toDespawnCount")] 		public CInt32 ToDespawnCount { get; set;}

		[Ordinal(9)] [RED("despawnPoiType")] 		public CName DespawnPoiType { get; set;}

		[Ordinal(10)] [RED("changeGroupState")] 		public CName ChangeGroupState { get; set;}

		public CFlyingSwarmGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFlyingSwarmGroup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
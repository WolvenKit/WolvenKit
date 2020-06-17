using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFlyingSwarmGroup : CVariable
	{
		[RED("groupId")] 		public CFlyingGroupId GroupId { get; set;}

		[RED("groupCenter")] 		public Vector GroupCenter { get; set;}

		[RED("targetPosition")] 		public Vector TargetPosition { get; set;}

		[RED("currentGroupState")] 		public CName CurrentGroupState { get; set;}

		[RED("boidCount")] 		public CInt32 BoidCount { get; set;}

		[RED("toSpawnCount")] 		public CInt32 ToSpawnCount { get; set;}

		[RED("spawnPoiType")] 		public CName SpawnPoiType { get; set;}

		[RED("toDespawnCount")] 		public CInt32 ToDespawnCount { get; set;}

		[RED("despawnPoiType")] 		public CName DespawnPoiType { get; set;}

		[RED("changeGroupState")] 		public CName ChangeGroupState { get; set;}

		public CFlyingSwarmGroup(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CFlyingSwarmGroup(cr2w);

	}
}
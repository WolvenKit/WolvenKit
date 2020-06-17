using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnObjectDef : IBehTreeTaskDefinition
	{
		[RED("useThisTask")] 		public CBool UseThisTask { get; set;}

		[RED("objectTemplate")] 		public CHandle<CEntityTemplate> ObjectTemplate { get; set;}

		[RED("useAnimEvent")] 		public CBool UseAnimEvent { get; set;}

		[RED("spawnAnimEventName")] 		public CName SpawnAnimEventName { get; set;}

		[RED("spawnAtBonePosition")] 		public CBool SpawnAtBonePosition { get; set;}

		[RED("boneName")] 		public CName BoneName { get; set;}

		[RED("spawnOnGround")] 		public CBool SpawnOnGround { get; set;}

		[RED("groundZCheck")] 		public CFloat GroundZCheck { get; set;}

		[RED("spawnPositionOffset")] 		public Vector SpawnPositionOffset { get; set;}

		[RED("offsetInLocalSpace")] 		public CBool OffsetInLocalSpace { get; set;}

		[RED("randomizeOffset")] 		public CBool RandomizeOffset { get; set;}

		public CBTTaskSpawnObjectDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSpawnObjectDef(cr2w);

	}
}
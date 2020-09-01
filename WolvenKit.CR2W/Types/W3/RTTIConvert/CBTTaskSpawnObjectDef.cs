using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnObjectDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("useThisTask")] 		public CBool UseThisTask { get; set;}

		[Ordinal(2)] [RED("objectTemplate")] 		public CHandle<CEntityTemplate> ObjectTemplate { get; set;}

		[Ordinal(3)] [RED("useAnimEvent")] 		public CBool UseAnimEvent { get; set;}

		[Ordinal(4)] [RED("spawnAnimEventName")] 		public CName SpawnAnimEventName { get; set;}

		[Ordinal(5)] [RED("spawnAtBonePosition")] 		public CBool SpawnAtBonePosition { get; set;}

		[Ordinal(6)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(7)] [RED("spawnOnGround")] 		public CBool SpawnOnGround { get; set;}

		[Ordinal(8)] [RED("groundZCheck")] 		public CFloat GroundZCheck { get; set;}

		[Ordinal(9)] [RED("spawnPositionOffset")] 		public Vector SpawnPositionOffset { get; set;}

		[Ordinal(10)] [RED("offsetInLocalSpace")] 		public CBool OffsetInLocalSpace { get; set;}

		[Ordinal(11)] [RED("randomizeOffset")] 		public CBool RandomizeOffset { get; set;}

		public CBTTaskSpawnObjectDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnObjectDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
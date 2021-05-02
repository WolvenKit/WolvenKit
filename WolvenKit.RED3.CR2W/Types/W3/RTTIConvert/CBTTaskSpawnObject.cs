using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnObject : IBehTreeTask
	{
		[Ordinal(1)] [RED("useThisTask")] 		public CBool UseThisTask { get; set;}

		[Ordinal(2)] [RED("objectTemplate")] 		public CHandle<CEntityTemplate> ObjectTemplate { get; set;}

		[Ordinal(3)] [RED("useAnimEvent")] 		public CBool UseAnimEvent { get; set;}

		[Ordinal(4)] [RED("spawnAnimEventName")] 		public CName SpawnAnimEventName { get; set;}

		[Ordinal(5)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(6)] [RED("spawnNodeTag")] 		public CName SpawnNodeTag { get; set;}

		[Ordinal(7)] [RED("spawnAtBonePosition")] 		public CBool SpawnAtBonePosition { get; set;}

		[Ordinal(8)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(9)] [RED("spawnOnGround")] 		public CBool SpawnOnGround { get; set;}

		[Ordinal(10)] [RED("groundZCheck")] 		public CFloat GroundZCheck { get; set;}

		[Ordinal(11)] [RED("spawnPositionOffset")] 		public Vector SpawnPositionOffset { get; set;}

		[Ordinal(12)] [RED("offsetInLocalSpace")] 		public CBool OffsetInLocalSpace { get; set;}

		[Ordinal(13)] [RED("randomizeOffset")] 		public CBool RandomizeOffset { get; set;}

		[Ordinal(14)] [RED("spawnNodes", 2,0)] 		public CArray<CHandle<CNode>> SpawnNodes { get; set;}

		[Ordinal(15)] [RED("i")] 		public CInt32 I { get; set;}

		[Ordinal(16)] [RED("size")] 		public CInt32 Size { get; set;}

		[Ordinal(17)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		public CBTTaskSpawnObject(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
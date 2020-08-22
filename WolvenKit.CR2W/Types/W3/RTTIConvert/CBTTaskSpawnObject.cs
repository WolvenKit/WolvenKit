using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnObject : IBehTreeTask
	{
		[RED("useThisTask")] 		public CBool UseThisTask { get; set;}

		[RED("objectTemplate")] 		public CHandle<CEntityTemplate> ObjectTemplate { get; set;}

		[RED("useAnimEvent")] 		public CBool UseAnimEvent { get; set;}

		[RED("spawnAnimEventName")] 		public CName SpawnAnimEventName { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("spawnNodeTag")] 		public CName SpawnNodeTag { get; set;}

		[RED("spawnAtBonePosition")] 		public CBool SpawnAtBonePosition { get; set;}

		[RED("boneName")] 		public CName BoneName { get; set;}

		[RED("spawnOnGround")] 		public CBool SpawnOnGround { get; set;}

		[RED("groundZCheck")] 		public CFloat GroundZCheck { get; set;}

		[RED("spawnPositionOffset")] 		public Vector SpawnPositionOffset { get; set;}

		[RED("offsetInLocalSpace")] 		public CBool OffsetInLocalSpace { get; set;}

		[RED("randomizeOffset")] 		public CBool RandomizeOffset { get; set;}

		[RED("spawnNodes", 2,0)] 		public CArray<CHandle<CNode>> SpawnNodes { get; set;}

		[RED("i")] 		public CInt32 I { get; set;}

		[RED("size")] 		public CInt32 Size { get; set;}

		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		public CBTTaskSpawnObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnObject(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
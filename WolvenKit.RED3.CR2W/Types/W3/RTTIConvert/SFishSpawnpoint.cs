using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFishSpawnpoint : CVariable
	{
		[Ordinal(1)] [RED("shouldBeErased")] 		public CBool ShouldBeErased { get; set;}

		[Ordinal(2)] [RED("isFishSpawned")] 		public CBool IsFishSpawned { get; set;}

		[Ordinal(3)] [RED("position")] 		public Vector Position { get; set;}

		[Ordinal(4)] [RED("rotation")] 		public EulerAngles Rotation { get; set;}

		[Ordinal(5)] [RED("spawnHandler")] 		public CHandle<CCreateEntityHelper> SpawnHandler { get; set;}

		public SFishSpawnpoint(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
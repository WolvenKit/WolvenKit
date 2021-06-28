using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeWaypointSpawner : CVariable
	{
		[Ordinal(1)] [RED("visibility")] 		public CEnum<ESpawnTreeSpawnVisibility> Visibility { get; set;}

		[Ordinal(2)] [RED("spawnpointDelay")] 		public CFloat SpawnpointDelay { get; set;}

		[Ordinal(3)] [RED("tags")] 		public TagList Tags { get; set;}

		[Ordinal(4)] [RED("useLocationTest")] 		public CBool UseLocationTest { get; set;}

		public CSpawnTreeWaypointSpawner(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
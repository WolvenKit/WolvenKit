using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCommunityAreaTypeDefault : CCommunityAreaType
	{
		[Ordinal(1)] [RED("areaSpawnRadius")] 		public CFloat AreaSpawnRadius { get; set;}

		[Ordinal(2)] [RED("areaDespawnRadius")] 		public CFloat AreaDespawnRadius { get; set;}

		[Ordinal(3)] [RED("spawnRadius")] 		public CFloat SpawnRadius { get; set;}

		[Ordinal(4)] [RED("despawnRadius")] 		public CFloat DespawnRadius { get; set;}

		[Ordinal(5)] [RED("dontRestore")] 		public CBool DontRestore { get; set;}

		public CCommunityAreaTypeDefault(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
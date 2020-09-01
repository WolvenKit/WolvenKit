using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCommunityAreaTypeDefault : CCommunityAreaType
	{
		[Ordinal(0)] [RED("areaSpawnRadius")] 		public CFloat AreaSpawnRadius { get; set;}

		[Ordinal(0)] [RED("areaDespawnRadius")] 		public CFloat AreaDespawnRadius { get; set;}

		[Ordinal(0)] [RED("spawnRadius")] 		public CFloat SpawnRadius { get; set;}

		[Ordinal(0)] [RED("despawnRadius")] 		public CFloat DespawnRadius { get; set;}

		[Ordinal(0)] [RED("dontRestore")] 		public CBool DontRestore { get; set;}

		public CCommunityAreaTypeDefault(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCommunityAreaTypeDefault(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeActionPointSpawner : CVariable
	{
		[Ordinal(0)] [RED("visibility")] 		public CEnum<ESpawnTreeSpawnVisibility> Visibility { get; set;}

		[Ordinal(0)] [RED("spawnpointDelay")] 		public CFloat SpawnpointDelay { get; set;}

		[Ordinal(0)] [RED("tags")] 		public TagList Tags { get; set;}

		[Ordinal(0)] [RED("categories", 2,0)] 		public CArray<CName> Categories { get; set;}

		public CSpawnTreeActionPointSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnTreeActionPointSpawner(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
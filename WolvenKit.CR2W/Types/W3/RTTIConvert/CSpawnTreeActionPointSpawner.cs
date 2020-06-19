using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeActionPointSpawner : CVariable
	{
		[RED("visibility")] 		public CEnum<ESpawnTreeSpawnVisibility> Visibility { get; set;}

		[RED("spawnpointDelay")] 		public CFloat SpawnpointDelay { get; set;}

		[RED("tags")] 		public TagList Tags { get; set;}

		[RED("categories", 2,0)] 		public CArray<CName> Categories { get; set;}

		public CSpawnTreeActionPointSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnTreeActionPointSpawner(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
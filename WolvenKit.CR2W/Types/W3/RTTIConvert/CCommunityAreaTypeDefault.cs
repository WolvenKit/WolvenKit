using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCommunityAreaTypeDefault : CCommunityAreaType
	{
		[RED("areaSpawnRadius")] 		public CFloat AreaSpawnRadius { get; set;}

		[RED("areaDespawnRadius")] 		public CFloat AreaDespawnRadius { get; set;}

		[RED("spawnRadius")] 		public CFloat SpawnRadius { get; set;}

		[RED("despawnRadius")] 		public CFloat DespawnRadius { get; set;}

		[RED("dontRestore")] 		public CBool DontRestore { get; set;}

		public CCommunityAreaTypeDefault(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCommunityAreaTypeDefault(cr2w);

	}
}
using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3EntitySpawner : W3UsableEntity
	{
		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("appearanceAfterSpawn")] 		public CName AppearanceAfterSpawn { get; set;}

		[RED("autoSpawn")] 		public CBool AutoSpawn { get; set;}

		[RED("spawnDelay")] 		public CFloat SpawnDelay { get; set;}

		[RED("numberOfUses")] 		public CInt32 NumberOfUses { get; set;}

		[RED("spawnNearPlayer")] 		public CBool SpawnNearPlayer { get; set;}

		[RED("avoidNodeWithTag")] 		public CName AvoidNodeWithTag { get; set;}

		public W3EntitySpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3EntitySpawner(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
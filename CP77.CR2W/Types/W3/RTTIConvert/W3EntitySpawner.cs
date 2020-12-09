using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3EntitySpawner : W3UsableEntity
	{
		[Ordinal(1)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(2)] [RED("appearanceAfterSpawn")] 		public CName AppearanceAfterSpawn { get; set;}

		[Ordinal(3)] [RED("autoSpawn")] 		public CBool AutoSpawn { get; set;}

		[Ordinal(4)] [RED("spawnDelay")] 		public CFloat SpawnDelay { get; set;}

		[Ordinal(5)] [RED("numberOfUses")] 		public CInt32 NumberOfUses { get; set;}

		[Ordinal(6)] [RED("spawnNearPlayer")] 		public CBool SpawnNearPlayer { get; set;}

		[Ordinal(7)] [RED("avoidNodeWithTag")] 		public CName AvoidNodeWithTag { get; set;}

		public W3EntitySpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3EntitySpawner(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapSpawnEntity : W3Trap
	{
		[Ordinal(0)] [RED("("spawnOnlyOnAreaEnter")] 		public CBool SpawnOnlyOnAreaEnter { get; set;}

		[Ordinal(0)] [RED("("maxSpawns")] 		public CFloat MaxSpawns { get; set;}

		[Ordinal(0)] [RED("("entityToSpawn")] 		public CHandle<CEntityTemplate> EntityToSpawn { get; set;}

		[Ordinal(0)] [RED("("offsetVector")] 		public Vector OffsetVector { get; set;}

		[Ordinal(0)] [RED("("excludedActorsTags", 2,0)] 		public CArray<CName> ExcludedActorsTags { get; set;}

		[Ordinal(0)] [RED("("appearanceAfterFirstSpawn")] 		public CString AppearanceAfterFirstSpawn { get; set;}

		[Ordinal(0)] [RED("("m_Spawns")] 		public CInt32 M_Spawns { get; set;}

		public W3TrapSpawnEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TrapSpawnEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
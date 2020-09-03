using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FoodDispenser : CGameplayEntity
	{
		[Ordinal(1)] [RED("foodEntity")] 		public CHandle<CEntityTemplate> FoodEntity { get; set;}

		[Ordinal(2)] [RED("maxSpawnedFood")] 		public CInt32 MaxSpawnedFood { get; set;}

		[Ordinal(3)] [RED("spawnedFood", 2,0)] 		public CArray<CHandle<CEntity>> SpawnedFood { get; set;}

		public W3FoodDispenser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3FoodDispenser(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
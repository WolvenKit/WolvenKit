using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ISpawnTreeSetLootInitializer : ISpawnTreeScriptedInitializer
	{
		[Ordinal(0)] [RED("lootDefinitions", 2,0)] 		public CArray<SR4LootNameProperty> LootDefinitions { get; set;}

		[Ordinal(0)] [RED("overrideLoot")] 		public CBool OverrideLoot { get; set;}

		[Ordinal(0)] [RED("randomize")] 		public CBool Randomize { get; set;}

		[Ordinal(0)] [RED("inventory")] 		public CHandle<CInventoryComponent> Inventory { get; set;}

		[Ordinal(0)] [RED("i")] 		public CInt32 I { get; set;}

		[Ordinal(0)] [RED("rand")] 		public CInt32 Rand { get; set;}

		[Ordinal(0)] [RED("randRange")] 		public CInt32 RandRange { get; set;}

		public ISpawnTreeSetLootInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ISpawnTreeSetLootInitializer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
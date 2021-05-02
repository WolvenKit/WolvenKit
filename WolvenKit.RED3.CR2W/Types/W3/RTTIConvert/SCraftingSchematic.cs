using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCraftingSchematic : CVariable
	{
		[Ordinal(1)] [RED("craftedItemName")] 		public CName CraftedItemName { get; set;}

		[Ordinal(2)] [RED("craftedItemCount")] 		public CInt32 CraftedItemCount { get; set;}

		[Ordinal(3)] [RED("requiredCraftsmanType")] 		public CEnum<ECraftsmanType> RequiredCraftsmanType { get; set;}

		[Ordinal(4)] [RED("requiredCraftsmanLevel")] 		public CEnum<ECraftsmanLevel> RequiredCraftsmanLevel { get; set;}

		[Ordinal(5)] [RED("baseCraftingPrice")] 		public CInt32 BaseCraftingPrice { get; set;}

		[Ordinal(6)] [RED("ingredients", 2,0)] 		public CArray<SItemParts> Ingredients { get; set;}

		[Ordinal(7)] [RED("schemName")] 		public CName SchemName { get; set;}

		public SCraftingSchematic(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
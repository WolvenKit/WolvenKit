using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCraftingSchematic : CVariable
	{
		[Ordinal(0)] [RED("("craftedItemName")] 		public CName CraftedItemName { get; set;}

		[Ordinal(0)] [RED("("craftedItemCount")] 		public CInt32 CraftedItemCount { get; set;}

		[Ordinal(0)] [RED("("requiredCraftsmanType")] 		public CEnum<ECraftsmanType> RequiredCraftsmanType { get; set;}

		[Ordinal(0)] [RED("("requiredCraftsmanLevel")] 		public CEnum<ECraftsmanLevel> RequiredCraftsmanLevel { get; set;}

		[Ordinal(0)] [RED("("baseCraftingPrice")] 		public CInt32 BaseCraftingPrice { get; set;}

		[Ordinal(0)] [RED("("ingredients", 2,0)] 		public CArray<SItemParts> Ingredients { get; set;}

		[Ordinal(0)] [RED("("schemName")] 		public CName SchemName { get; set;}

		public SCraftingSchematic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCraftingSchematic(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
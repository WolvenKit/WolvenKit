using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCraftingSchematic : CVariable
	{
		[RED("craftedItemName")] 		public CName CraftedItemName { get; set;}

		[RED("craftedItemCount")] 		public CInt32 CraftedItemCount { get; set;}

		[RED("requiredCraftsmanType")] 		public CEnum<ECraftsmanType> RequiredCraftsmanType { get; set;}

		[RED("requiredCraftsmanLevel")] 		public CEnum<ECraftsmanLevel> RequiredCraftsmanLevel { get; set;}

		[RED("baseCraftingPrice")] 		public CInt32 BaseCraftingPrice { get; set;}

		[RED("ingredients", 2,0)] 		public CArray<SItemParts> Ingredients { get; set;}

		[RED("schemName")] 		public CName SchemName { get; set;}

		public SCraftingSchematic(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SCraftingSchematic(cr2w);

	}
}
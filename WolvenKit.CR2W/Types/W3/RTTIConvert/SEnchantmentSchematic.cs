using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEnchantmentSchematic : CVariable
	{
		[RED("schemName")] 		public CName SchemName { get; set;}

		[RED("baseCraftingPrice")] 		public CInt32 BaseCraftingPrice { get; set;}

		[RED("level")] 		public CInt32 Level { get; set;}

		[RED("ingredients", 2,0)] 		public CArray<SItemParts> Ingredients { get; set;}

		[RED("localizedName")] 		public CName LocalizedName { get; set;}

		[RED("localizedDescriptionName")] 		public CString LocalizedDescriptionName { get; set;}

		public SEnchantmentSchematic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEnchantmentSchematic(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
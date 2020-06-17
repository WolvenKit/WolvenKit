using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCookingSchematic : CVariable
	{
		[RED("cookedItemName")] 		public CName CookedItemName { get; set;}

		[RED("cookedItemQuantity")] 		public CInt32 CookedItemQuantity { get; set;}

		[RED("ingredients", 2,0)] 		public CArray<SItemParts> Ingredients { get; set;}

		[RED("schemName")] 		public CName SchemName { get; set;}

		public SCookingSchematic(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SCookingSchematic(cr2w);

	}
}
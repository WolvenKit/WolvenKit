using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCookingSchematic : CVariable
	{
		[Ordinal(1)] [RED("cookedItemName")] 		public CName CookedItemName { get; set;}

		[Ordinal(2)] [RED("cookedItemQuantity")] 		public CInt32 CookedItemQuantity { get; set;}

		[Ordinal(3)] [RED("ingredients", 2,0)] 		public CArray<SItemParts> Ingredients { get; set;}

		[Ordinal(4)] [RED("schemName")] 		public CName SchemName { get; set;}

		public SCookingSchematic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCookingSchematic(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
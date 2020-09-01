using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAlchemyRecipe : CVariable
	{
		[Ordinal(0)] [RED("cookedItemName")] 		public CName CookedItemName { get; set;}

		[Ordinal(0)] [RED("cookedItemType")] 		public CEnum<EAlchemyCookedItemType> CookedItemType { get; set;}

		[Ordinal(0)] [RED("cookedItemIconPath")] 		public CString CookedItemIconPath { get; set;}

		[Ordinal(0)] [RED("cookedItemQuantity")] 		public CInt32 CookedItemQuantity { get; set;}

		[Ordinal(0)] [RED("recipeName")] 		public CName RecipeName { get; set;}

		[Ordinal(0)] [RED("recipeIconPath")] 		public CString RecipeIconPath { get; set;}

		[Ordinal(0)] [RED("typeName")] 		public CName TypeName { get; set;}

		[Ordinal(0)] [RED("level")] 		public CInt32 Level { get; set;}

		[Ordinal(0)] [RED("requiredIngredients", 2,0)] 		public CArray<SItemParts> RequiredIngredients { get; set;}

		public SAlchemyRecipe(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAlchemyRecipe(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
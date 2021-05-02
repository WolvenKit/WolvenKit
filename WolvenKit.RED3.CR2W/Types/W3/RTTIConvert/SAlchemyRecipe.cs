using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAlchemyRecipe : CVariable
	{
		[Ordinal(1)] [RED("cookedItemName")] 		public CName CookedItemName { get; set;}

		[Ordinal(2)] [RED("cookedItemType")] 		public CEnum<EAlchemyCookedItemType> CookedItemType { get; set;}

		[Ordinal(3)] [RED("cookedItemIconPath")] 		public CString CookedItemIconPath { get; set;}

		[Ordinal(4)] [RED("cookedItemQuantity")] 		public CInt32 CookedItemQuantity { get; set;}

		[Ordinal(5)] [RED("recipeName")] 		public CName RecipeName { get; set;}

		[Ordinal(6)] [RED("recipeIconPath")] 		public CString RecipeIconPath { get; set;}

		[Ordinal(7)] [RED("typeName")] 		public CName TypeName { get; set;}

		[Ordinal(8)] [RED("level")] 		public CInt32 Level { get; set;}

		[Ordinal(9)] [RED("requiredIngredients", 2,0)] 		public CArray<SItemParts> RequiredIngredients { get; set;}

		public SAlchemyRecipe(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
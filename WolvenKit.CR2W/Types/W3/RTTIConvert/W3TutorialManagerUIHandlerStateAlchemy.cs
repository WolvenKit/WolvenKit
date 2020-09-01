using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateAlchemy : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(0)] [RED("("INGREDIENTS")] 		public CName INGREDIENTS { get; set;}

		[Ordinal(0)] [RED("("COOKED_ITEM_DESC")] 		public CName COOKED_ITEM_DESC { get; set;}

		[Ordinal(0)] [RED("("CATEGORIES")] 		public CName CATEGORIES { get; set;}

		[Ordinal(0)] [RED("("SELECT_SOMETHING")] 		public CName SELECT_SOMETHING { get; set;}

		[Ordinal(0)] [RED("("SELECT_THUNDERBOLT")] 		public CName SELECT_THUNDERBOLT { get; set;}

		[Ordinal(0)] [RED("("COOK")] 		public CName COOK { get; set;}

		[Ordinal(0)] [RED("("POTIONS")] 		public CName POTIONS { get; set;}

		[Ordinal(0)] [RED("("PREPARATION_GO_TO")] 		public CName PREPARATION_GO_TO { get; set;}

		[Ordinal(0)] [RED("("RECIPE_THUNDERBOLT")] 		public CName RECIPE_THUNDERBOLT { get; set;}

		[Ordinal(0)] [RED("("POTIONS_JOURNAL")] 		public CName POTIONS_JOURNAL { get; set;}

		[Ordinal(0)] [RED("("isClosing")] 		public CBool IsClosing { get; set;}

		[Ordinal(0)] [RED("("isForcedTunderbolt")] 		public CBool IsForcedTunderbolt { get; set;}

		[Ordinal(0)] [RED("("currentlySelectedRecipe")] 		public CName CurrentlySelectedRecipe { get; set;}

		[Ordinal(0)] [RED("("requiredRecipeName")] 		public CName RequiredRecipeName { get; set;}

		[Ordinal(0)] [RED("("selectRecipe")] 		public CName SelectRecipe { get; set;}

		public W3TutorialManagerUIHandlerStateAlchemy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateAlchemy(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
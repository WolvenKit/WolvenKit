using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateAlchemyMutagens : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("MUTAGENS")] 		public CName MUTAGENS { get; set;}

		[RED("currentlySelectedRecipe")] 		public CName CurrentlySelectedRecipe { get; set;}

		[RED("requiredRecipeName")] 		public CName RequiredRecipeName { get; set;}

		[RED("selectRecipe")] 		public CName SelectRecipe { get; set;}

		public W3TutorialManagerUIHandlerStateAlchemyMutagens(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateAlchemyMutagens(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
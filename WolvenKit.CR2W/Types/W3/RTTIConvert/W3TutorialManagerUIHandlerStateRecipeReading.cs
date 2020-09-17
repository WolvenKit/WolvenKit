using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateRecipeReading : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("OPEN_INVENTORY")] 		public CName OPEN_INVENTORY { get; set;}

		[Ordinal(2)] [RED("SELECT_TAB")] 		public CName SELECT_TAB { get; set;}

		[Ordinal(3)] [RED("SELECT_BOOK")] 		public CName SELECT_BOOK { get; set;}

		[Ordinal(4)] [RED("USE")] 		public CName USE { get; set;}

		[Ordinal(5)] [RED("READ")] 		public CName READ { get; set;}

		[Ordinal(6)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateRecipeReading(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateRecipeReading(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
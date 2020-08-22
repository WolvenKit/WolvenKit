using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateCrafting : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("SCHEMATICS")] 		public CName SCHEMATICS { get; set;}

		[RED("ITEM_DESCRIPTION")] 		public CName ITEM_DESCRIPTION { get; set;}

		[RED("COMPONENTS")] 		public CName COMPONENTS { get; set;}

		[RED("PRICE")] 		public CName PRICE { get; set;}

		[RED("CRAFTSMEN")] 		public CName CRAFTSMEN { get; set;}

		[RED("DISMANTLING")] 		public CName DISMANTLING { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateCrafting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateCrafting(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateCrafting : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("SCHEMATICS")] 		public CName SCHEMATICS { get; set;}

		[Ordinal(2)] [RED("ITEM_DESCRIPTION")] 		public CName ITEM_DESCRIPTION { get; set;}

		[Ordinal(3)] [RED("COMPONENTS")] 		public CName COMPONENTS { get; set;}

		[Ordinal(4)] [RED("PRICE")] 		public CName PRICE { get; set;}

		[Ordinal(5)] [RED("CRAFTSMEN")] 		public CName CRAFTSMEN { get; set;}

		[Ordinal(6)] [RED("DISMANTLING")] 		public CName DISMANTLING { get; set;}

		[Ordinal(7)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateCrafting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateCrafting(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
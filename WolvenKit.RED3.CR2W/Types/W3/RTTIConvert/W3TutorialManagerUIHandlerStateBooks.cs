using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateBooks : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("SELECT_TAB")] 		public CName SELECT_TAB { get; set;}

		[Ordinal(2)] [RED("SELECT_BOOK")] 		public CName SELECT_BOOK { get; set;}

		[Ordinal(3)] [RED("USE")] 		public CName USE { get; set;}

		[Ordinal(4)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateBooks(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
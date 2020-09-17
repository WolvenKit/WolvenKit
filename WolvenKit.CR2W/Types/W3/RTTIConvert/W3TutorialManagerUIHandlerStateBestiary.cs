using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateBestiary : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("BESTIARY_DESCRIPTION")] 		public CName BESTIARY_DESCRIPTION { get; set;}

		[Ordinal(2)] [RED("BESTIARY_CLOSE")] 		public CName BESTIARY_CLOSE { get; set;}

		[Ordinal(3)] [RED("OPEN_BESTIARY")] 		public CName OPEN_BESTIARY { get; set;}

		[Ordinal(4)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateBestiary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateBestiary(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateMutagenDismantlingTable : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("DESCRIPTION")] 		public CName DESCRIPTION { get; set;}

		[Ordinal(2)] [RED("WHY_DO_IT")] 		public CName WHY_DO_IT { get; set;}

		[Ordinal(3)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateMutagenDismantlingTable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateMutagenDismantlingTable(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
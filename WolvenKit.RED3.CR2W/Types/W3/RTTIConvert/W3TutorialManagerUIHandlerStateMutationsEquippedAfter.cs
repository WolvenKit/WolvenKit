using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateMutationsEquippedAfter : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("EQUIPPING_ONLY_ONE")] 		public CName EQUIPPING_ONLY_ONE { get; set;}

		[Ordinal(2)] [RED("MASTER")] 		public CName MASTER { get; set;}

		[Ordinal(3)] [RED("CHAR_PANEL")] 		public CName CHAR_PANEL { get; set;}

		[Ordinal(4)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		[Ordinal(5)] [RED("activated")] 		public CBool Activated { get; set;}

		public W3TutorialManagerUIHandlerStateMutationsEquippedAfter(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateMutationsEquippedAfter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
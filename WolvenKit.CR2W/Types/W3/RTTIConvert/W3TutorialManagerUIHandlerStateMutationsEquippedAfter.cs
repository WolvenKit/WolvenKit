using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateMutationsEquippedAfter : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("EQUIPPING_ONLY_ONE")] 		public CName EQUIPPING_ONLY_ONE { get; set;}

		[RED("MASTER")] 		public CName MASTER { get; set;}

		[RED("CHAR_PANEL")] 		public CName CHAR_PANEL { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		[RED("activated")] 		public CBool Activated { get; set;}

		public W3TutorialManagerUIHandlerStateMutationsEquippedAfter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateMutationsEquippedAfter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
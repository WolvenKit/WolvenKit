using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateOils : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(0)] [RED("("CAN_EQUIP")] 		public CName CAN_EQUIP { get; set;}

		[Ordinal(0)] [RED("("SELECT_TAB")] 		public CName SELECT_TAB { get; set;}

		[Ordinal(0)] [RED("("EQUIP_OIL")] 		public CName EQUIP_OIL { get; set;}

		[Ordinal(0)] [RED("("ON_EQUIPPED")] 		public CName ON_EQUIPPED { get; set;}

		[Ordinal(0)] [RED("("OILS_JOURNAL_ENTRY")] 		public CName OILS_JOURNAL_ENTRY { get; set;}

		[Ordinal(0)] [RED("("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateOils(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateOils(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateOils : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("CAN_EQUIP")] 		public CName CAN_EQUIP { get; set;}

		[Ordinal(2)] [RED("SELECT_TAB")] 		public CName SELECT_TAB { get; set;}

		[Ordinal(3)] [RED("EQUIP_OIL")] 		public CName EQUIP_OIL { get; set;}

		[Ordinal(4)] [RED("ON_EQUIPPED")] 		public CName ON_EQUIPPED { get; set;}

		[Ordinal(5)] [RED("OILS_JOURNAL_ENTRY")] 		public CName OILS_JOURNAL_ENTRY { get; set;}

		[Ordinal(6)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateOils(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateOils(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
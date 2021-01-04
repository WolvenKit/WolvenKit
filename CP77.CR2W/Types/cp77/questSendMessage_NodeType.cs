using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSendMessage_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)]  [RED("msg")] public CHandle<gameJournalPath> Msg { get; set; }
		[Ordinal(1)]  [RED("sendNotification")] public CBool SendNotification { get; set; }

		public questSendMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

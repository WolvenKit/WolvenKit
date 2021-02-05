using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questChangeContactList_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("contact")] public CHandle<gameJournalPath> Contact { get; set; }
		[Ordinal(1)]  [RED("addContact")] public CBool AddContact { get; set; }
		[Ordinal(2)]  [RED("sendNotification")] public CBool SendNotification { get; set; }

		public questChangeContactList_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

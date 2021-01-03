using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questChangeContactList_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("addContact")] public CBool AddContact { get; set; }
		[Ordinal(1)]  [RED("contact")] public CHandle<gameJournalPath> Contact { get; set; }
		[Ordinal(2)]  [RED("sendNotification")] public CBool SendNotification { get; set; }

		public questChangeContactList_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

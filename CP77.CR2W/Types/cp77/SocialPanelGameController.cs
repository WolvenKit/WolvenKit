using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SocialPanelGameController : gameuiMenuGameController
	{
		[Ordinal(1)]  [RED("SocialPanelContactsListRef")] public inkWidgetReference SocialPanelContactsListRef { get; set; }
		[Ordinal(2)]  [RED("SocialPanelContactsDetailsRef")] public inkWidgetReference SocialPanelContactsDetailsRef { get; set; }
		[Ordinal(3)]  [RED("ContactsList")] public wCHandle<SocialPanelContactsList> ContactsList { get; set; }
		[Ordinal(4)]  [RED("ContactDetails")] public wCHandle<SocialPanelContactsDetails> ContactDetails { get; set; }
		[Ordinal(5)]  [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(6)]  [RED("JournalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }

		public SocialPanelGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

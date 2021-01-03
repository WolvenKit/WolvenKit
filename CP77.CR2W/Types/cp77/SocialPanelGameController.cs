using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SocialPanelGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("ContactDetails")] public wCHandle<SocialPanelContactsDetails> ContactDetails { get; set; }
		[Ordinal(1)]  [RED("ContactsList")] public wCHandle<SocialPanelContactsList> ContactsList { get; set; }
		[Ordinal(2)]  [RED("JournalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(3)]  [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(4)]  [RED("SocialPanelContactsDetailsRef")] public inkWidgetReference SocialPanelContactsDetailsRef { get; set; }
		[Ordinal(5)]  [RED("SocialPanelContactsListRef")] public inkWidgetReference SocialPanelContactsListRef { get; set; }

		public SocialPanelGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

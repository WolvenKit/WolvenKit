using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactsList : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("ListItemName")] public CName ListItemName { get; set; }
		[Ordinal(2)] [RED("ItemsRoot")] public inkBasePanelWidgetReference ItemsRoot { get; set; }
		[Ordinal(3)] [RED("ItemsList")] public CArray<wCHandle<SocialPanelContactsListItem>> ItemsList { get; set; }
		[Ordinal(4)] [RED("CurrentContactHash")] public CInt32 CurrentContactHash { get; set; }
		[Ordinal(5)] [RED("LastClickedContact")] public wCHandle<gameJournalContact> LastClickedContact { get; set; }

		public SocialPanelContactsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

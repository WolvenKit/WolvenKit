using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactsList : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("CurrentContactHash")] public CInt32 CurrentContactHash { get; set; }
		[Ordinal(1)]  [RED("ItemsList")] public CArray<wCHandle<SocialPanelContactsListItem>> ItemsList { get; set; }
		[Ordinal(2)]  [RED("ItemsRoot")] public inkBasePanelWidgetReference ItemsRoot { get; set; }
		[Ordinal(3)]  [RED("LastClickedContact")] public wCHandle<gameJournalContact> LastClickedContact { get; set; }
		[Ordinal(4)]  [RED("ListItemName")] public CName ListItemName { get; set; }

		public SocialPanelContactsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

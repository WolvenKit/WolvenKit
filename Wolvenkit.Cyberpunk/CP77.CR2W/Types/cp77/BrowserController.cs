using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BrowserController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("addressText")] public inkTextWidgetReference AddressText { get; set; }
		[Ordinal(1)]  [RED("currentPage")] public wCHandle<inkCompoundWidget> CurrentPage { get; set; }
		[Ordinal(2)]  [RED("currentRequestedPage")] public CString CurrentRequestedPage { get; set; }
		[Ordinal(3)]  [RED("defaultDevicePage")] public CString DefaultDevicePage { get; set; }
		[Ordinal(4)]  [RED("gameController")] public CHandle<BrowserGameController> GameController { get; set; }
		[Ordinal(5)]  [RED("homeButton")] public inkWidgetReference HomeButton { get; set; }
		[Ordinal(6)]  [RED("homeButtonCoontroller")] public CHandle<LinkController> HomeButtonCoontroller { get; set; }
		[Ordinal(7)]  [RED("pageContentRoot")] public inkWidgetReference PageContentRoot { get; set; }
		[Ordinal(8)]  [RED("spinner")] public wCHandle<inkWidget> Spinner { get; set; }
		[Ordinal(9)]  [RED("spinnerPath")] public redResourceReferenceScriptToken SpinnerPath { get; set; }
		[Ordinal(10)]  [RED("webPageLibraryID")] public CName WebPageLibraryID { get; set; }
		[Ordinal(11)]  [RED("websiteData")] public CArray<wCHandle<gameJournalInternetPage>> WebsiteData { get; set; }

		public BrowserController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

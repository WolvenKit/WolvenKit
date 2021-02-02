using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkListController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("ItemSelected")] public inkListControllerCallback ItemSelected { get; set; }
		[Ordinal(1)]  [RED("ItemActivated")] public inkListControllerCallback ItemActivated { get; set; }
		[Ordinal(2)]  [RED("itemLibraryID")] public CName ItemLibraryID { get; set; }
		[Ordinal(3)]  [RED("cycledNavigation")] public CBool CycledNavigation { get; set; }
		[Ordinal(4)]  [RED("beginToggled")] public CBool BeginToggled { get; set; }

		public inkListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

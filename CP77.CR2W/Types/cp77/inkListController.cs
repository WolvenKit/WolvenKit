using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkListController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("ItemActivated")] public inkListControllerCallback ItemActivated { get; set; }
		[Ordinal(1)]  [RED("ItemSelected")] public inkListControllerCallback ItemSelected { get; set; }
		[Ordinal(2)]  [RED("beginToggled")] public CBool BeginToggled { get; set; }
		[Ordinal(3)]  [RED("cycledNavigation")] public CBool CycledNavigation { get; set; }
		[Ordinal(4)]  [RED("itemLibraryID")] public CName ItemLibraryID { get; set; }

		public inkListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

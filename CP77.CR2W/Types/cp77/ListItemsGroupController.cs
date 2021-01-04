using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ListItemsGroupController : CodexListItemController
	{
		[Ordinal(0)]  [RED("data")] public CArray<CHandle<IScriptable>> Data { get; set; }
		[Ordinal(1)]  [RED("foldArrowRef")] public inkWidgetReference FoldArrowRef { get; set; }
		[Ordinal(2)]  [RED("foldoutButton")] public inkWidgetReference FoldoutButton { get; set; }
		[Ordinal(3)]  [RED("foldoutButtonController")] public wCHandle<inkButtonController> FoldoutButtonController { get; set; }
		[Ordinal(4)]  [RED("foldoutIndipendently")] public CBool FoldoutIndipendently { get; set; }
		[Ordinal(5)]  [RED("isOpen")] public CBool IsOpen { get; set; }
		[Ordinal(6)]  [RED("lastClickedData")] public wCHandle<IScriptable> LastClickedData { get; set; }
		[Ordinal(7)]  [RED("menuList")] public inkCompoundWidgetReference MenuList { get; set; }
		[Ordinal(8)]  [RED("menuListController")] public wCHandle<inkListController> MenuListController { get; set; }

		public ListItemsGroupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

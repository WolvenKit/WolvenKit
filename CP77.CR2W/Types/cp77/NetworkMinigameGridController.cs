using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameGridController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("animHighlightProxy")] public CHandle<inkanimProxy> AnimHighlightProxy { get; set; }
		[Ordinal(1)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(2)]  [RED("currentActivePosition")] public Vector2 CurrentActivePosition { get; set; }
		[Ordinal(3)]  [RED("firstBoot")] public CBool FirstBoot { get; set; }
		[Ordinal(4)]  [RED("gridCellLibraryName")] public CName GridCellLibraryName { get; set; }
		[Ordinal(5)]  [RED("gridContainer")] public inkWidgetReference GridContainer { get; set; }
		[Ordinal(6)]  [RED("gridData")] public CArray<CellData> GridData { get; set; }
		[Ordinal(7)]  [RED("gridVisualOffset")] public Vector2 GridVisualOffset { get; set; }
		[Ordinal(8)]  [RED("horizontalCurrentHighlight")] public inkWidgetReference HorizontalCurrentHighlight { get; set; }
		[Ordinal(9)]  [RED("horizontalHoverHighlight")] public inkWidgetReference HorizontalHoverHighlight { get; set; }
		[Ordinal(10)]  [RED("isHorizontal")] public CBool IsHorizontal { get; set; }
		[Ordinal(11)]  [RED("isHorizontalHighlight")] public CBool IsHorizontalHighlight { get; set; }
		[Ordinal(12)]  [RED("lastHighlighted")] public CellData LastHighlighted { get; set; }
		[Ordinal(13)]  [RED("lastSelected")] public CellData LastSelected { get; set; }
		[Ordinal(14)]  [RED("verticalCurrentHighlight")] public inkWidgetReference VerticalCurrentHighlight { get; set; }
		[Ordinal(15)]  [RED("verticalHoverHighlight")] public inkWidgetReference VerticalHoverHighlight { get; set; }

		public NetworkMinigameGridController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

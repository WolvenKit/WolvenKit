using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemPreviewGameController : gameuiItemPreviewGameController
	{
		[Ordinal(0)]  [RED("data")] public CHandle<InventoryItemPreviewData> Data { get; set; }
		[Ordinal(1)]  [RED("isMouseDown")] public CBool IsMouseDown { get; set; }
		[Ordinal(2)]  [RED("itemLevelText")] public inkTextWidgetReference ItemLevelText { get; set; }
		[Ordinal(3)]  [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(4)]  [RED("itemRarityWidget")] public inkWidgetReference ItemRarityWidget { get; set; }

		public ItemPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

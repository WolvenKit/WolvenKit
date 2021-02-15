using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemPreviewGameController : gameuiItemPreviewGameController
	{
		[Ordinal(8)] [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(9)] [RED("itemLevelText")] public inkTextWidgetReference ItemLevelText { get; set; }
		[Ordinal(10)] [RED("itemRarityWidget")] public inkWidgetReference ItemRarityWidget { get; set; }
		[Ordinal(11)] [RED("data")] public CHandle<InventoryItemPreviewData> Data { get; set; }
		[Ordinal(12)] [RED("isMouseDown")] public CBool IsMouseDown { get; set; }

		public ItemPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

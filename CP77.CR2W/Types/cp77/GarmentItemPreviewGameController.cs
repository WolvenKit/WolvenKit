using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GarmentItemPreviewGameController : gameuiInventoryPuppetPreviewGameController
	{
		[Ordinal(0)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("isRotatable")] public CBool IsRotatable { get; set; }
		[Ordinal(2)]  [RED("data")] public CHandle<InventoryItemPreviewData> Data { get; set; }
		[Ordinal(3)]  [RED("placementSlot")] public TweakDBID PlacementSlot { get; set; }
		[Ordinal(4)]  [RED("initialItem")] public gameItemID InitialItem { get; set; }
		[Ordinal(5)]  [RED("givenItem")] public gameItemID GivenItem { get; set; }

		public GarmentItemPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

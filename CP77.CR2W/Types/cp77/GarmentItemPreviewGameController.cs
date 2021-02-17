using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GarmentItemPreviewGameController : gameuiInventoryPuppetPreviewGameController
	{
		[Ordinal(9)] [RED("data")] public CHandle<InventoryItemPreviewData> Data { get; set; }
		[Ordinal(10)] [RED("placementSlot")] public TweakDBID PlacementSlot { get; set; }
		[Ordinal(11)] [RED("initialItem")] public gameItemID InitialItem { get; set; }
		[Ordinal(12)] [RED("givenItem")] public gameItemID GivenItem { get; set; }

		public GarmentItemPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

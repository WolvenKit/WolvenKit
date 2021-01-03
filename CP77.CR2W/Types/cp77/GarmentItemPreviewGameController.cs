using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GarmentItemPreviewGameController : gameuiInventoryPuppetPreviewGameController
	{
		[Ordinal(0)]  [RED("data")] public CHandle<InventoryItemPreviewData> Data { get; set; }
		[Ordinal(1)]  [RED("givenItem")] public gameItemID GivenItem { get; set; }
		[Ordinal(2)]  [RED("initialItem")] public gameItemID InitialItem { get; set; }
		[Ordinal(3)]  [RED("placementSlot")] public TweakDBID PlacementSlot { get; set; }

		public GarmentItemPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

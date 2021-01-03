using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioPopupGameController : BaseModalListPopupGameController
	{
		[Ordinal(0)]  [RED("dataSource")] public CHandle<inkScriptableDataSourceWrapper> DataSource { get; set; }
		[Ordinal(1)]  [RED("dataView")] public CHandle<RadioStationsDataView> DataView { get; set; }
		[Ordinal(2)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)]  [RED("playerVehicle")] public wCHandle<vehicleBaseObject> PlayerVehicle { get; set; }
		[Ordinal(4)]  [RED("quickSlotsManager")] public wCHandle<QuickSlotsManager> QuickSlotsManager { get; set; }
		[Ordinal(5)]  [RED("scrollArea")] public inkScrollAreaWidgetReference ScrollArea { get; set; }
		[Ordinal(6)]  [RED("scrollController")] public wCHandle<inkScrollController> ScrollController { get; set; }
		[Ordinal(7)]  [RED("scrollControllerWidget")] public inkWidgetReference ScrollControllerWidget { get; set; }
		[Ordinal(8)]  [RED("selectedItem")] public wCHandle<RadioStationListItemController> SelectedItem { get; set; }
		[Ordinal(9)]  [RED("startupIndex")] public CUInt32 StartupIndex { get; set; }

		public VehicleRadioPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

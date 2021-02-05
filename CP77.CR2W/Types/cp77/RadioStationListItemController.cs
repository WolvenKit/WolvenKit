using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RadioStationListItemController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(1)]  [RED("typeIcon")] public inkImageWidgetReference TypeIcon { get; set; }
		[Ordinal(2)]  [RED("stationData")] public CHandle<RadioListItemData> StationData { get; set; }

		public RadioStationListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

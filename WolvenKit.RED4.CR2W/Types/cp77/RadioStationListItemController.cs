using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioStationListItemController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(16)] [RED("typeIcon")] public inkImageWidgetReference TypeIcon { get; set; }
		[Ordinal(17)] [RED("stationData")] public CHandle<RadioListItemData> StationData { get; set; }

		public RadioStationListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

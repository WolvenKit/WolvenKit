using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMetroSignLogicController : inkIStreetNameSignLogicController
	{
		[Ordinal(1)] [RED("stationName")] public inkTextWidgetReference StationName { get; set; }
		[Ordinal(2)] [RED("subDistrictName")] public inkTextWidgetReference SubDistrictName { get; set; }
		[Ordinal(3)] [RED("metroStationsContainer")] public inkCompoundWidgetReference MetroStationsContainer { get; set; }
		[Ordinal(4)] [RED("metroStationLibraryName")] public CName MetroStationLibraryName { get; set; }
		[Ordinal(5)] [RED("metroStationTextWidgetName")] public CName MetroStationTextWidgetName { get; set; }

		public inkMetroSignLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

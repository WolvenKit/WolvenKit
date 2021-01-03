using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkHighwaySignLogicController : inkIStreetNameSignLogicController
	{
		[Ordinal(0)]  [RED("districtName")] public inkTextWidgetReference DistrictName { get; set; }
		[Ordinal(1)]  [RED("metroStationIconLeft")] public inkImageWidgetReference MetroStationIconLeft { get; set; }
		[Ordinal(2)]  [RED("metroStationIconRight")] public inkImageWidgetReference MetroStationIconRight { get; set; }
		[Ordinal(3)]  [RED("subDistrictName")] public inkTextWidgetReference SubDistrictName { get; set; }

		public inkHighwaySignLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

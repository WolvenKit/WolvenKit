using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkStreetNameSignLogicController : inkIStreetNameSignLogicController
	{
		[Ordinal(0)]  [RED("districtName")] public inkTextWidgetReference DistrictName { get; set; }
		[Ordinal(1)]  [RED("streetName")] public inkTextWidgetReference StreetName { get; set; }
		[Ordinal(2)]  [RED("subdistrictName")] public inkTextWidgetReference SubdistrictName { get; set; }

		public inkStreetNameSignLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

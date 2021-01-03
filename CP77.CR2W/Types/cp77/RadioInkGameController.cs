using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RadioInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("stationLogoWidget")] public inkImageWidgetReference StationLogoWidget { get; set; }
		[Ordinal(1)]  [RED("stationNameWidget")] public inkTextWidgetReference StationNameWidget { get; set; }

		public RadioInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SmartHouseDeviceWidgetController : DeviceWidgetControllerBase
	{
		[Ordinal(10)] [RED("interiorManagerSlot")] public wCHandle<inkWidget> InteriorManagerSlot { get; set; }

		public SmartHouseDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

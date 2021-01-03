using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SystemDeviceWidgetController : DeviceWidgetControllerBase
	{
		[Ordinal(0)]  [RED("slavesConnectedCount")] public inkTextWidgetReference SlavesConnectedCount { get; set; }

		public SystemDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

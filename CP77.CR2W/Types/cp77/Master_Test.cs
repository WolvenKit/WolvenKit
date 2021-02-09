using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Master_Test : gameObject
	{
		[Ordinal(31)]  [RED("deviceComponent")] public CHandle<gameMasterDeviceComponent> DeviceComponent { get; set; }

		public Master_Test(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Master_Test : gameObject
	{
		[Ordinal(0)]  [RED("deviceComponent")] public CHandle<gameMasterDeviceComponent> DeviceComponent { get; set; }

		public Master_Test(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

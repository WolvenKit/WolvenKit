using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TeleportDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("teleport")] public STeleportOperationData Teleport { get; set; }

		public TeleportDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

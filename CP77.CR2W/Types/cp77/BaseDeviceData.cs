using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BaseDeviceData : CVariable
	{
		[Ordinal(0)]  [RED("debugName")] public CName DebugName { get; set; }
		[Ordinal(1)]  [RED("deviceName")] public CString DeviceName { get; set; }
		[Ordinal(2)]  [RED("deviceState")] public CEnum<EDeviceStatus> DeviceState { get; set; }
		[Ordinal(3)]  [RED("durabilityType")] public CEnum<EDeviceDurabilityType> DurabilityType { get; set; }
		[Ordinal(4)]  [RED("hackOwner")] public wCHandle<gameObject> HackOwner { get; set; }

		public BaseDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseDeviceData : CVariable
	{
		[Ordinal(0)] [RED("deviceState")] public CEnum<EDeviceStatus> DeviceState { get; set; }
		[Ordinal(1)] [RED("durabilityType")] public CEnum<EDeviceDurabilityType> DurabilityType { get; set; }
		[Ordinal(2)] [RED("deviceName")] public CString DeviceName { get; set; }
		[Ordinal(3)] [RED("debugName")] public CName DebugName { get; set; }
		[Ordinal(4)] [RED("hackOwner")] public wCHandle<gameObject> HackOwner { get; set; }

		public BaseDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerDeviceStatus : ScannerChunk
	{
		[Ordinal(0)] [RED("deviceStatus")] public CString DeviceStatus { get; set; }
		[Ordinal(1)] [RED("deviceStatusFriendlyName")] public CString DeviceStatusFriendlyName { get; set; }

		public ScannerDeviceStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

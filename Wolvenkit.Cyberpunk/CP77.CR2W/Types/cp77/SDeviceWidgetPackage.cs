using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SDeviceWidgetPackage : SWidgetPackage
	{
		[Ordinal(0)]  [RED("actionWidgets")] public CArray<SActionWidgetPackage> ActionWidgets { get; set; }
		[Ordinal(1)]  [RED("deviceState")] public CEnum<EDeviceStatus> DeviceState { get; set; }
		[Ordinal(2)]  [RED("deviceStatus")] public CString DeviceStatus { get; set; }

		public SDeviceWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

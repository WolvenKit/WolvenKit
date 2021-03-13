using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDeviceWidgetPackage : SWidgetPackage
	{
		[Ordinal(17)] [RED("deviceStatus")] public CString DeviceStatus { get; set; }
		[Ordinal(18)] [RED("deviceState")] public CEnum<EDeviceStatus> DeviceState { get; set; }
		[Ordinal(19)] [RED("actionWidgets")] public CArray<SActionWidgetPackage> ActionWidgets { get; set; }

		public SDeviceWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerDeviceBodyGameController : BaseChunkGameController
	{
		[Ordinal(0)]  [RED("deviceAuthorizationCallbackID")] public CUInt32 DeviceAuthorizationCallbackID { get; set; }
		[Ordinal(1)]  [RED("deviceAuthorizationRow")] public inkCompoundWidgetReference DeviceAuthorizationRow { get; set; }
		[Ordinal(2)]  [RED("deviceAuthorizationText")] public inkTextWidgetReference DeviceAuthorizationText { get; set; }
		[Ordinal(3)]  [RED("isValidDeviceAuthorization")] public CBool IsValidDeviceAuthorization { get; set; }
		[Ordinal(4)]  [RED("isValidnetworkStatus")] public CBool IsValidnetworkStatus { get; set; }
		[Ordinal(5)]  [RED("networkStatusCallbackID")] public CUInt32 NetworkStatusCallbackID { get; set; }
		[Ordinal(6)]  [RED("networkStatusRow")] public inkCompoundWidgetReference NetworkStatusRow { get; set; }
		[Ordinal(7)]  [RED("networkStatusText")] public inkTextWidgetReference NetworkStatusText { get; set; }

		public ScannerDeviceBodyGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

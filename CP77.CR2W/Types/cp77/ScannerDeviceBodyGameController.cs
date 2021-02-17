using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerDeviceBodyGameController : BaseChunkGameController
	{
		[Ordinal(5)] [RED("networkStatusText")] public inkTextWidgetReference NetworkStatusText { get; set; }
		[Ordinal(6)] [RED("deviceAuthorizationText")] public inkTextWidgetReference DeviceAuthorizationText { get; set; }
		[Ordinal(7)] [RED("deviceAuthorizationRow")] public inkCompoundWidgetReference DeviceAuthorizationRow { get; set; }
		[Ordinal(8)] [RED("networkStatusRow")] public inkCompoundWidgetReference NetworkStatusRow { get; set; }
		[Ordinal(9)] [RED("networkStatusCallbackID")] public CUInt32 NetworkStatusCallbackID { get; set; }
		[Ordinal(10)] [RED("deviceAuthorizationCallbackID")] public CUInt32 DeviceAuthorizationCallbackID { get; set; }
		[Ordinal(11)] [RED("isValidnetworkStatus")] public CBool IsValidnetworkStatus { get; set; }
		[Ordinal(12)] [RED("isValidDeviceAuthorization")] public CBool IsValidDeviceAuthorization { get; set; }

		public ScannerDeviceBodyGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

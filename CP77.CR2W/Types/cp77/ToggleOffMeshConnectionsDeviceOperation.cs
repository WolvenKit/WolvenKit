using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleOffMeshConnectionsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("operationName")] public CName OperationName { get; set; }
		[Ordinal(1)]  [RED("executeOnce")] public CBool ExecuteOnce { get; set; }
		[Ordinal(2)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)]  [RED("toggleOperations")] public CArray<SToggleDeviceOperationData> ToggleOperations { get; set; }
		[Ordinal(4)]  [RED("disableDevice")] public CBool DisableDevice { get; set; }
		[Ordinal(5)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(6)]  [RED("affectsPlayer")] public CBool AffectsPlayer { get; set; }
		[Ordinal(7)]  [RED("affectsNPCs")] public CBool AffectsNPCs { get; set; }

		public ToggleOffMeshConnectionsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleOffMeshConnectionsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("affectsNPCs")] public CBool AffectsNPCs { get; set; }
		[Ordinal(1)]  [RED("affectsPlayer")] public CBool AffectsPlayer { get; set; }
		[Ordinal(2)]  [RED("enable")] public CBool Enable { get; set; }

		public ToggleOffMeshConnectionsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

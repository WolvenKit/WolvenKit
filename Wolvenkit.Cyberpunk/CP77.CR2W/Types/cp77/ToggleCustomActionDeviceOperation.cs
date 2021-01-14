using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleCustomActionDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("customActionID")] public CName CustomActionID { get; set; }
		[Ordinal(1)]  [RED("enabled")] public CBool Enabled { get; set; }

		public ToggleCustomActionDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

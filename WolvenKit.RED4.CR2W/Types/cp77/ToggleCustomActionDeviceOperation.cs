using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleCustomActionDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("customActionID")] public CName CustomActionID { get; set; }
		[Ordinal(6)] [RED("enabled")] public CBool Enabled { get; set; }

		public ToggleCustomActionDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

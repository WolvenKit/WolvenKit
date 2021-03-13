using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleOffMeshConnectionsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(6)] [RED("affectsPlayer")] public CBool AffectsPlayer { get; set; }
		[Ordinal(7)] [RED("affectsNPCs")] public CBool AffectsNPCs { get; set; }

		public ToggleOffMeshConnectionsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

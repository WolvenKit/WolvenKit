using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceScanningDescription : ObjectScanningDescription
	{
		[Ordinal(0)] [RED("DeviceGameplayDescription")] public TweakDBID DeviceGameplayDescription { get; set; }
		[Ordinal(1)] [RED("DeviceCustomDescriptions")] public CArray<TweakDBID> DeviceCustomDescriptions { get; set; }
		[Ordinal(2)] [RED("DeviceGameplayRole")] public TweakDBID DeviceGameplayRole { get; set; }
		[Ordinal(3)] [RED("DeviceRoleActionsDescriptions")] public CArray<TweakDBID> DeviceRoleActionsDescriptions { get; set; }

		public DeviceScanningDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

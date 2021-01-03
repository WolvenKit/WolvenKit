using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DeviceScanningDescription : ObjectScanningDescription
	{
		[Ordinal(0)]  [RED("DeviceCustomDescriptions")] public CArray<TweakDBID> DeviceCustomDescriptions { get; set; }
		[Ordinal(1)]  [RED("DeviceGameplayDescription")] public TweakDBID DeviceGameplayDescription { get; set; }
		[Ordinal(2)]  [RED("DeviceGameplayRole")] public TweakDBID DeviceGameplayRole { get; set; }
		[Ordinal(3)]  [RED("DeviceRoleActionsDescriptions")] public CArray<TweakDBID> DeviceRoleActionsDescriptions { get; set; }

		public DeviceScanningDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDeviceSettings : audioEntitySettings
	{
		[Ordinal(6)] [RED("deviceSettings")] public audioDeviceStateSettings DeviceSettings { get; set; }

		public audioDeviceSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

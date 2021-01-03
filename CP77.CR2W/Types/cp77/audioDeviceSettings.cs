using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioDeviceSettings : audioEntitySettings
	{
		[Ordinal(0)]  [RED("deviceSettings")] public audioDeviceStateSettings DeviceSettings { get; set; }

		public audioDeviceSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

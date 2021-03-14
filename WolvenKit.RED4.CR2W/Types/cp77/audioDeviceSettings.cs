using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDeviceSettings : audioEntitySettings
	{
		private audioDeviceStateSettings _deviceSettings;

		[Ordinal(6)] 
		[RED("deviceSettings")] 
		public audioDeviceStateSettings DeviceSettings
		{
			get
			{
				if (_deviceSettings == null)
				{
					_deviceSettings = (audioDeviceStateSettings) CR2WTypeManager.Create("audioDeviceStateSettings", "deviceSettings", cr2w, this);
				}
				return _deviceSettings;
			}
			set
			{
				if (_deviceSettings == value)
				{
					return;
				}
				_deviceSettings = value;
				PropertySet(this);
			}
		}

		public audioDeviceSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

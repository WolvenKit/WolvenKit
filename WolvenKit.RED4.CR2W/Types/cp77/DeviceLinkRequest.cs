using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceLinkRequest : redEvent
	{
		private DeviceLink _deviceLink;

		[Ordinal(0)] 
		[RED("deviceLink")] 
		public DeviceLink DeviceLink
		{
			get
			{
				if (_deviceLink == null)
				{
					_deviceLink = (DeviceLink) CR2WTypeManager.Create("DeviceLink", "deviceLink", cr2w, this);
				}
				return _deviceLink;
			}
			set
			{
				if (_deviceLink == value)
				{
					return;
				}
				_deviceLink = value;
				PropertySet(this);
			}
		}

		public DeviceLinkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

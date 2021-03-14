using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceLinkEstablished : redEvent
	{
		private wCHandle<DeviceLinkComponentPS> _deviceLinkPS;

		[Ordinal(0)] 
		[RED("deviceLinkPS")] 
		public wCHandle<DeviceLinkComponentPS> DeviceLinkPS
		{
			get
			{
				if (_deviceLinkPS == null)
				{
					_deviceLinkPS = (wCHandle<DeviceLinkComponentPS>) CR2WTypeManager.Create("whandle:DeviceLinkComponentPS", "deviceLinkPS", cr2w, this);
				}
				return _deviceLinkPS;
			}
			set
			{
				if (_deviceLinkPS == value)
				{
					return;
				}
				_deviceLinkPS = value;
				PropertySet(this);
			}
		}

		public DeviceLinkEstablished(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

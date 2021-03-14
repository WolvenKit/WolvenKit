using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhysicalHackingEvent : redEvent
	{
		private CString _deviceName;

		[Ordinal(0)] 
		[RED("deviceName")] 
		public CString DeviceName
		{
			get
			{
				if (_deviceName == null)
				{
					_deviceName = (CString) CR2WTypeManager.Create("String", "deviceName", cr2w, this);
				}
				return _deviceName;
			}
			set
			{
				if (_deviceName == value)
				{
					return;
				}
				_deviceName = value;
				PropertySet(this);
			}
		}

		public PhysicalHackingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

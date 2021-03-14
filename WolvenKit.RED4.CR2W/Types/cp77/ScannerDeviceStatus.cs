using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerDeviceStatus : ScannerChunk
	{
		private CString _deviceStatus;
		private CString _deviceStatusFriendlyName;

		[Ordinal(0)] 
		[RED("deviceStatus")] 
		public CString DeviceStatus
		{
			get
			{
				if (_deviceStatus == null)
				{
					_deviceStatus = (CString) CR2WTypeManager.Create("String", "deviceStatus", cr2w, this);
				}
				return _deviceStatus;
			}
			set
			{
				if (_deviceStatus == value)
				{
					return;
				}
				_deviceStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("deviceStatusFriendlyName")] 
		public CString DeviceStatusFriendlyName
		{
			get
			{
				if (_deviceStatusFriendlyName == null)
				{
					_deviceStatusFriendlyName = (CString) CR2WTypeManager.Create("String", "deviceStatusFriendlyName", cr2w, this);
				}
				return _deviceStatusFriendlyName;
			}
			set
			{
				if (_deviceStatusFriendlyName == value)
				{
					return;
				}
				_deviceStatusFriendlyName = value;
				PropertySet(this);
			}
		}

		public ScannerDeviceStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

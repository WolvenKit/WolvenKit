using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDeviceWidgetPackage : SWidgetPackage
	{
		private CString _deviceStatus;
		private CEnum<EDeviceStatus> _deviceState;
		private CArray<SActionWidgetPackage> _actionWidgets;

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get
			{
				if (_deviceState == null)
				{
					_deviceState = (CEnum<EDeviceStatus>) CR2WTypeManager.Create("EDeviceStatus", "deviceState", cr2w, this);
				}
				return _deviceState;
			}
			set
			{
				if (_deviceState == value)
				{
					return;
				}
				_deviceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("actionWidgets")] 
		public CArray<SActionWidgetPackage> ActionWidgets
		{
			get
			{
				if (_actionWidgets == null)
				{
					_actionWidgets = (CArray<SActionWidgetPackage>) CR2WTypeManager.Create("array:SActionWidgetPackage", "actionWidgets", cr2w, this);
				}
				return _actionWidgets;
			}
			set
			{
				if (_actionWidgets == value)
				{
					return;
				}
				_actionWidgets = value;
				PropertySet(this);
			}
		}

		public SDeviceWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

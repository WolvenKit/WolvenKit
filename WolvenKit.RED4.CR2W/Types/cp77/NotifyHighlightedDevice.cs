using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NotifyHighlightedDevice : redEvent
	{
		private CBool _isDeviceHighlighted;
		private CBool _isNotifiedByMasterDevice;

		[Ordinal(0)] 
		[RED("IsDeviceHighlighted")] 
		public CBool IsDeviceHighlighted
		{
			get
			{
				if (_isDeviceHighlighted == null)
				{
					_isDeviceHighlighted = (CBool) CR2WTypeManager.Create("Bool", "IsDeviceHighlighted", cr2w, this);
				}
				return _isDeviceHighlighted;
			}
			set
			{
				if (_isDeviceHighlighted == value)
				{
					return;
				}
				_isDeviceHighlighted = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("IsNotifiedByMasterDevice")] 
		public CBool IsNotifiedByMasterDevice
		{
			get
			{
				if (_isNotifiedByMasterDevice == null)
				{
					_isNotifiedByMasterDevice = (CBool) CR2WTypeManager.Create("Bool", "IsNotifiedByMasterDevice", cr2w, this);
				}
				return _isNotifiedByMasterDevice;
			}
			set
			{
				if (_isNotifiedByMasterDevice == value)
				{
					return;
				}
				_isNotifiedByMasterDevice = value;
				PropertySet(this);
			}
		}

		public NotifyHighlightedDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

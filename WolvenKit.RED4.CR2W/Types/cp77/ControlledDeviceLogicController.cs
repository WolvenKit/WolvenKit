using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ControlledDeviceLogicController : inkWidgetLogicController
	{
		private wCHandle<inkImageWidget> _deviceIcon;
		private wCHandle<inkRectangleWidget> _activeBg;

		[Ordinal(1)] 
		[RED("deviceIcon")] 
		public wCHandle<inkImageWidget> DeviceIcon
		{
			get
			{
				if (_deviceIcon == null)
				{
					_deviceIcon = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "deviceIcon", cr2w, this);
				}
				return _deviceIcon;
			}
			set
			{
				if (_deviceIcon == value)
				{
					return;
				}
				_deviceIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activeBg")] 
		public wCHandle<inkRectangleWidget> ActiveBg
		{
			get
			{
				if (_activeBg == null)
				{
					_activeBg = (wCHandle<inkRectangleWidget>) CR2WTypeManager.Create("whandle:inkRectangleWidget", "activeBg", cr2w, this);
				}
				return _activeBg;
			}
			set
			{
				if (_activeBg == value)
				{
					return;
				}
				_activeBg = value;
				PropertySet(this);
			}
		}

		public ControlledDeviceLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

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
			get => GetProperty(ref _deviceIcon);
			set => SetProperty(ref _deviceIcon, value);
		}

		[Ordinal(2)] 
		[RED("activeBg")] 
		public wCHandle<inkRectangleWidget> ActiveBg
		{
			get => GetProperty(ref _activeBg);
			set => SetProperty(ref _activeBg, value);
		}

		public ControlledDeviceLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ControlledDeviceLogicController : inkWidgetLogicController
	{
		private CWeakHandle<inkImageWidget> _deviceIcon;
		private CWeakHandle<inkRectangleWidget> _activeBg;

		[Ordinal(1)] 
		[RED("deviceIcon")] 
		public CWeakHandle<inkImageWidget> DeviceIcon
		{
			get => GetProperty(ref _deviceIcon);
			set => SetProperty(ref _deviceIcon, value);
		}

		[Ordinal(2)] 
		[RED("activeBg")] 
		public CWeakHandle<inkRectangleWidget> ActiveBg
		{
			get => GetProperty(ref _activeBg);
			set => SetProperty(ref _activeBg, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SDeviceWidgetPackage : SWidgetPackage
	{
		private CString _deviceStatus;
		private CEnum<EDeviceStatus> _deviceState;
		private CArray<SActionWidgetPackage> _actionWidgets;

		[Ordinal(17)] 
		[RED("deviceStatus")] 
		public CString DeviceStatus
		{
			get => GetProperty(ref _deviceStatus);
			set => SetProperty(ref _deviceStatus, value);
		}

		[Ordinal(18)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get => GetProperty(ref _deviceState);
			set => SetProperty(ref _deviceState, value);
		}

		[Ordinal(19)] 
		[RED("actionWidgets")] 
		public CArray<SActionWidgetPackage> ActionWidgets
		{
			get => GetProperty(ref _actionWidgets);
			set => SetProperty(ref _actionWidgets, value);
		}
	}
}

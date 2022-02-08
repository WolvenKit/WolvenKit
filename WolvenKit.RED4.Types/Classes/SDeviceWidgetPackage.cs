using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SDeviceWidgetPackage : SWidgetPackage
	{
		[Ordinal(17)] 
		[RED("deviceStatus")] 
		public CString DeviceStatus
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(18)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		[Ordinal(19)] 
		[RED("actionWidgets")] 
		public CArray<SActionWidgetPackage> ActionWidgets
		{
			get => GetPropertyValue<CArray<SActionWidgetPackage>>();
			set => SetPropertyValue<CArray<SActionWidgetPackage>>(value);
		}

		public SDeviceWidgetPackage()
		{
			ActionWidgets = new();
		}
	}
}

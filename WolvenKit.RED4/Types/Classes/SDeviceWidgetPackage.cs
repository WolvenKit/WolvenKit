using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDeviceWidgetPackage : SWidgetPackage
	{
		[Ordinal(18)] 
		[RED("deviceStatus")] 
		public CString DeviceStatus
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(19)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		[Ordinal(20)] 
		[RED("actionWidgets")] 
		public CArray<SActionWidgetPackage> ActionWidgets
		{
			get => GetPropertyValue<CArray<SActionWidgetPackage>>();
			set => SetPropertyValue<CArray<SActionWidgetPackage>>(value);
		}

		public SDeviceWidgetPackage()
		{
			ActionWidgets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

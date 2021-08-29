using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SystemDeviceWidgetController : DeviceWidgetControllerBase
	{
		private inkTextWidgetReference _slavesConnectedCount;
		private inkWidgetReference _connectedDevicesHolder;

		[Ordinal(10)] 
		[RED("slavesConnectedCount")] 
		public inkTextWidgetReference SlavesConnectedCount
		{
			get => GetProperty(ref _slavesConnectedCount);
			set => SetProperty(ref _slavesConnectedCount, value);
		}

		[Ordinal(11)] 
		[RED("connectedDevicesHolder")] 
		public inkWidgetReference ConnectedDevicesHolder
		{
			get => GetProperty(ref _connectedDevicesHolder);
			set => SetProperty(ref _connectedDevicesHolder, value);
		}
	}
}

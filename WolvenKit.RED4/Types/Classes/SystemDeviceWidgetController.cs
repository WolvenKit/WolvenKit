using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SystemDeviceWidgetController : DeviceWidgetControllerBase
	{
		[Ordinal(10)] 
		[RED("slavesConnectedCount")] 
		public inkTextWidgetReference SlavesConnectedCount
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("connectedDevicesHolder")] 
		public inkWidgetReference ConnectedDevicesHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public SystemDeviceWidgetController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

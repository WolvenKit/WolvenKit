using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SystemDeviceWidgetController : DeviceWidgetControllerBase
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

		public SystemDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

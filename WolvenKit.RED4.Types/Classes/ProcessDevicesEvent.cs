using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProcessDevicesEvent : redEvent
	{
		private CArray<CHandle<gameDeviceComponentPS>> _devices;

		[Ordinal(0)] 
		[RED("devices")] 
		public CArray<CHandle<gameDeviceComponentPS>> Devices
		{
			get => GetProperty(ref _devices);
			set => SetProperty(ref _devices, value);
		}
	}
}

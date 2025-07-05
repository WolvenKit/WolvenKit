using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProcessDevicesEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("devices")] 
		public CArray<CHandle<gameDeviceComponentPS>> Devices
		{
			get => GetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>();
			set => SetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>(value);
		}

		public ProcessDevicesEvent()
		{
			Devices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

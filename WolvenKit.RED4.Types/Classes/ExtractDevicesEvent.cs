using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExtractDevicesEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("lazyDevices")] 
		public CArray<CHandle<gameLazyDevice>> LazyDevices
		{
			get => GetPropertyValue<CArray<CHandle<gameLazyDevice>>>();
			set => SetPropertyValue<CArray<CHandle<gameLazyDevice>>>(value);
		}

		[Ordinal(1)] 
		[RED("devices")] 
		public CArray<CHandle<gameDeviceComponentPS>> Devices
		{
			get => GetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>();
			set => SetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>(value);
		}

		[Ordinal(2)] 
		[RED("eventToSendOnCompleted")] 
		public CHandle<ProcessDevicesEvent> EventToSendOnCompleted
		{
			get => GetPropertyValue<CHandle<ProcessDevicesEvent>>();
			set => SetPropertyValue<CHandle<ProcessDevicesEvent>>(value);
		}

		[Ordinal(3)] 
		[RED("lastExtractedIndex")] 
		public CInt32 LastExtractedIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ExtractDevicesEvent()
		{
			LazyDevices = new();
			Devices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

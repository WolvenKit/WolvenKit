using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceCounter : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("devices")] 
		public CArray<CHandle<gameDeviceComponentPS>> Devices
		{
			get => GetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>();
			set => SetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>(value);
		}

		[Ordinal(1)] 
		[RED("systemType")] 
		public CEnum<EVirtualSystem> SystemType
		{
			get => GetPropertyValue<CEnum<EVirtualSystem>>();
			set => SetPropertyValue<CEnum<EVirtualSystem>>(value);
		}

		public DeviceCounter()
		{
			Devices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

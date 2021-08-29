using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceCounter : RedBaseClass
	{
		private CArray<CHandle<gameDeviceComponentPS>> _devices;
		private CEnum<EVirtualSystem> _systemType;

		[Ordinal(0)] 
		[RED("devices")] 
		public CArray<CHandle<gameDeviceComponentPS>> Devices
		{
			get => GetProperty(ref _devices);
			set => SetProperty(ref _devices, value);
		}

		[Ordinal(1)] 
		[RED("systemType")] 
		public CEnum<EVirtualSystem> SystemType
		{
			get => GetProperty(ref _systemType);
			set => SetProperty(ref _systemType, value);
		}
	}
}

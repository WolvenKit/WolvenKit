using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInputDevicesMappingsJSON : RedBaseClass
	{
		private CArray<CName> _devices;
		private CArray<inkInputIconMappingJSON> _mappings;

		[Ordinal(0)] 
		[RED("devices")] 
		public CArray<CName> Devices
		{
			get => GetProperty(ref _devices);
			set => SetProperty(ref _devices, value);
		}

		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<inkInputIconMappingJSON> Mappings
		{
			get => GetProperty(ref _mappings);
			set => SetProperty(ref _mappings, value);
		}
	}
}

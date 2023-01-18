using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkInputDevicesMappingsJSON : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("devices")] 
		public CArray<CName> Devices
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<inkInputIconMappingJSON> Mappings
		{
			get => GetPropertyValue<CArray<inkInputIconMappingJSON>>();
			set => SetPropertyValue<CArray<inkInputIconMappingJSON>>(value);
		}

		public inkInputDevicesMappingsJSON()
		{
			Devices = new();
			Mappings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

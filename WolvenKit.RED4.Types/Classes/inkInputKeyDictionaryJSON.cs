using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkInputKeyDictionaryJSON : ISerializable
	{
		[Ordinal(0)] 
		[RED("devicesMappings")] 
		public CArray<inkInputDevicesMappingsJSON> DevicesMappings
		{
			get => GetPropertyValue<CArray<inkInputDevicesMappingsJSON>>();
			set => SetPropertyValue<CArray<inkInputDevicesMappingsJSON>>(value);
		}

		public inkInputKeyDictionaryJSON()
		{
			DevicesMappings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

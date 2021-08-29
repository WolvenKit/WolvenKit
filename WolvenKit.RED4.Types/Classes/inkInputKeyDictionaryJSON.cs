using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInputKeyDictionaryJSON : ISerializable
	{
		private CArray<inkInputDevicesMappingsJSON> _devicesMappings;

		[Ordinal(0)] 
		[RED("devicesMappings")] 
		public CArray<inkInputDevicesMappingsJSON> DevicesMappings
		{
			get => GetProperty(ref _devicesMappings);
			set => SetProperty(ref _devicesMappings, value);
		}
	}
}

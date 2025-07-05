using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDeviceResource : CResource
	{
		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<gameDeviceResourceData> Data
		{
			get => GetPropertyValue<CHandle<gameDeviceResourceData>>();
			set => SetPropertyValue<CHandle<gameDeviceResourceData>>(value);
		}

		public gameDeviceResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Master_Test : gameObject
	{
		[Ordinal(35)] 
		[RED("deviceComponent")] 
		public CHandle<gameMasterDeviceComponent> DeviceComponent
		{
			get => GetPropertyValue<CHandle<gameMasterDeviceComponent>>();
			set => SetPropertyValue<CHandle<gameMasterDeviceComponent>>(value);
		}

		public Master_Test()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

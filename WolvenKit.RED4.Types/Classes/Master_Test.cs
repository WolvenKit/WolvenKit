using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Master_Test : gameObject
	{
		private CHandle<gameMasterDeviceComponent> _deviceComponent;

		[Ordinal(40)] 
		[RED("deviceComponent")] 
		public CHandle<gameMasterDeviceComponent> DeviceComponent
		{
			get => GetProperty(ref _deviceComponent);
			set => SetProperty(ref _deviceComponent, value);
		}
	}
}

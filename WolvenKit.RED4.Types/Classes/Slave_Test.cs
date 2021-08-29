using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Slave_Test : gameObject
	{
		private CHandle<PSD_Detector> _deviceComponent;

		[Ordinal(40)] 
		[RED("deviceComponent")] 
		public CHandle<PSD_Detector> DeviceComponent
		{
			get => GetProperty(ref _deviceComponent);
			set => SetProperty(ref _deviceComponent, value);
		}
	}
}

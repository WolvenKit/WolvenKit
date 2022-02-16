using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Slave_Test : gameObject
	{
		[Ordinal(35)] 
		[RED("deviceComponent")] 
		public CHandle<PSD_Detector> DeviceComponent
		{
			get => GetPropertyValue<CHandle<PSD_Detector>>();
			set => SetPropertyValue<CHandle<PSD_Detector>>(value);
		}
	}
}

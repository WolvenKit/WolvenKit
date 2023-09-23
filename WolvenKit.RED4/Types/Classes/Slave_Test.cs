using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Slave_Test : gameObject
	{
		[Ordinal(36)] 
		[RED("deviceComponent")] 
		public CHandle<PSD_Detector> DeviceComponent
		{
			get => GetPropertyValue<CHandle<PSD_Detector>>();
			set => SetPropertyValue<CHandle<PSD_Detector>>(value);
		}

		public Slave_Test()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

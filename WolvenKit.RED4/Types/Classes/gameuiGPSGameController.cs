using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGPSGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("gpsSettings")] 
		public gamegpsSettings GpsSettings
		{
			get => GetPropertyValue<gamegpsSettings>();
			set => SetPropertyValue<gamegpsSettings>(value);
		}

		public gameuiGPSGameController()
		{
			GpsSettings = new gamegpsSettings();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

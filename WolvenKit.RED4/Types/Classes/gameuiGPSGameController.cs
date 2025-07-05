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
			GpsSettings = new gamegpsSettings { FixedPathOffset = new Vector3 { Z = 0.500000F }, FixedPortalMappinOffset = new Vector3 { Z = 1.250000F }, PathRefreshTimeInterval = 1.000000F, LastPlayerNavmeshPositionRefreshTimeIntervalSecs = 0.330000F, MaxPathDisplayLength = 400.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

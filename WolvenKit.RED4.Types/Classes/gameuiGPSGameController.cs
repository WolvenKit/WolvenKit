using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiGPSGameController : gameuiHUDGameController
	{
		private gamegpsSettings _gpsSettings;

		[Ordinal(9)] 
		[RED("gpsSettings")] 
		public gamegpsSettings GpsSettings
		{
			get => GetProperty(ref _gpsSettings);
			set => SetProperty(ref _gpsSettings, value);
		}
	}
}

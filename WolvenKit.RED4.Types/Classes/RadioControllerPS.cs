using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadioControllerPS : MediaDeviceControllerPS
	{
		private RadioSetup _radioSetup;
		private CArray<RadioStationsMap> _stations;
		private CBool _stationsInitialized;

		[Ordinal(109)] 
		[RED("radioSetup")] 
		public RadioSetup RadioSetup
		{
			get => GetProperty(ref _radioSetup);
			set => SetProperty(ref _radioSetup, value);
		}

		[Ordinal(110)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetProperty(ref _stations);
			set => SetProperty(ref _stations, value);
		}

		[Ordinal(111)] 
		[RED("stationsInitialized")] 
		public CBool StationsInitialized
		{
			get => GetProperty(ref _stationsInitialized);
			set => SetProperty(ref _stationsInitialized, value);
		}
	}
}

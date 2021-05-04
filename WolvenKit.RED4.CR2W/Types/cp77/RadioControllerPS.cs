using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioControllerPS : MediaDeviceControllerPS
	{
		private RadioSetup _radioSetup;
		private CArray<RadioStationsMap> _stations;
		private CBool _stationsInitialized;

		[Ordinal(108)] 
		[RED("radioSetup")] 
		public RadioSetup RadioSetup
		{
			get => GetProperty(ref _radioSetup);
			set => SetProperty(ref _radioSetup, value);
		}

		[Ordinal(109)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetProperty(ref _stations);
			set => SetProperty(ref _stations, value);
		}

		[Ordinal(110)] 
		[RED("stationsInitialized")] 
		public CBool StationsInitialized
		{
			get => GetProperty(ref _stationsInitialized);
			set => SetProperty(ref _stationsInitialized, value);
		}

		public RadioControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

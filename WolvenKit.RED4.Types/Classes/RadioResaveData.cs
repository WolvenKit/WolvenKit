using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadioResaveData : RedBaseClass
	{
		private MediaResaveData _mediaResaveData;
		private CArray<RadioStationsMap> _stations;

		[Ordinal(0)] 
		[RED("mediaResaveData")] 
		public MediaResaveData MediaResaveData
		{
			get => GetProperty(ref _mediaResaveData);
			set => SetProperty(ref _mediaResaveData, value);
		}

		[Ordinal(1)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetProperty(ref _stations);
			set => SetProperty(ref _stations, value);
		}
	}
}

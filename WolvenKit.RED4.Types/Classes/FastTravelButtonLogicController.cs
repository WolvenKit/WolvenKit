using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastTravelButtonLogicController : inkButtonController
	{
		private inkTextWidgetReference _districtName;
		private inkTextWidgetReference _locationName;
		private SSoundData _soundData;
		private CBool _isInitialized;
		private CWeakHandle<gameFastTravelPointData> _fastTravelPointData;

		[Ordinal(10)] 
		[RED("districtName")] 
		public inkTextWidgetReference DistrictName
		{
			get => GetProperty(ref _districtName);
			set => SetProperty(ref _districtName, value);
		}

		[Ordinal(11)] 
		[RED("locationName")] 
		public inkTextWidgetReference LocationName
		{
			get => GetProperty(ref _locationName);
			set => SetProperty(ref _locationName, value);
		}

		[Ordinal(12)] 
		[RED("soundData")] 
		public SSoundData SoundData
		{
			get => GetProperty(ref _soundData);
			set => SetProperty(ref _soundData, value);
		}

		[Ordinal(13)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(14)] 
		[RED("fastTravelPointData")] 
		public CWeakHandle<gameFastTravelPointData> FastTravelPointData
		{
			get => GetProperty(ref _fastTravelPointData);
			set => SetProperty(ref _fastTravelPointData, value);
		}
	}
}

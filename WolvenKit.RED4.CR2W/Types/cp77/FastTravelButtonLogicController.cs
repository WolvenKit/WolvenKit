using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelButtonLogicController : inkButtonController
	{
		private inkTextWidgetReference _districtName;
		private inkTextWidgetReference _locationName;
		private SSoundData _soundData;
		private CBool _isInitialized;
		private wCHandle<gameFastTravelPointData> _fastTravelPointData;

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
		public wCHandle<gameFastTravelPointData> FastTravelPointData
		{
			get => GetProperty(ref _fastTravelPointData);
			set => SetProperty(ref _fastTravelPointData, value);
		}

		public FastTravelButtonLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

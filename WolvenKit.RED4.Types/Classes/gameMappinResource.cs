using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMappinResource : CResource
	{
		private CArray<gameCookedMappinData> _cookedData;
		private CArray<gameCookedMultiMappinData> _cookedMultiData;
		private CArray<gameCookedGpsMappinData> _cookedGpsData;

		[Ordinal(1)] 
		[RED("cookedData")] 
		public CArray<gameCookedMappinData> CookedData
		{
			get => GetProperty(ref _cookedData);
			set => SetProperty(ref _cookedData, value);
		}

		[Ordinal(2)] 
		[RED("cookedMultiData")] 
		public CArray<gameCookedMultiMappinData> CookedMultiData
		{
			get => GetProperty(ref _cookedMultiData);
			set => SetProperty(ref _cookedMultiData, value);
		}

		[Ordinal(3)] 
		[RED("cookedGpsData")] 
		public CArray<gameCookedGpsMappinData> CookedGpsData
		{
			get => GetProperty(ref _cookedGpsData);
			set => SetProperty(ref _cookedGpsData, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMappinResource : CResource
	{
		[Ordinal(1)] 
		[RED("cookedData")] 
		public CArray<gameCookedMappinData> CookedData
		{
			get => GetPropertyValue<CArray<gameCookedMappinData>>();
			set => SetPropertyValue<CArray<gameCookedMappinData>>(value);
		}

		[Ordinal(2)] 
		[RED("cookedMultiData")] 
		public CArray<gameCookedMultiMappinData> CookedMultiData
		{
			get => GetPropertyValue<CArray<gameCookedMultiMappinData>>();
			set => SetPropertyValue<CArray<gameCookedMultiMappinData>>(value);
		}

		[Ordinal(3)] 
		[RED("cookedGpsData")] 
		public CArray<gameCookedGpsMappinData> CookedGpsData
		{
			get => GetPropertyValue<CArray<gameCookedGpsMappinData>>();
			set => SetPropertyValue<CArray<gameCookedGpsMappinData>>(value);
		}

		public gameMappinResource()
		{
			CookedData = new();
			CookedMultiData = new();
			CookedGpsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

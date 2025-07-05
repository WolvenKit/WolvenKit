using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePointOfInterestMappinResource : CResource
	{
		[Ordinal(1)] 
		[RED("cookedData")] 
		public CArray<gameCookedPointOfInterestMappinData> CookedData
		{
			get => GetPropertyValue<CArray<gameCookedPointOfInterestMappinData>>();
			set => SetPropertyValue<CArray<gameCookedPointOfInterestMappinData>>(value);
		}

		public gamePointOfInterestMappinResource()
		{
			CookedData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

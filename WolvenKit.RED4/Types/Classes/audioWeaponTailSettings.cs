using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioWeaponTailSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("interiorDefault")] 
		public CName InteriorDefault
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("interiorWide")] 
		public CName InteriorWide
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("interiorCar")] 
		public CName InteriorCar
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("exteriorWide")] 
		public CName ExteriorWide
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("exteriorUrbanNarrow")] 
		public CName ExteriorUrbanNarrow
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("exteriorUrbanStreet")] 
		public CName ExteriorUrbanStreet
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("exteriorUrbanStreetWide")] 
		public CName ExteriorUrbanStreetWide
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("exteriorUrbanOpen")] 
		public CName ExteriorUrbanOpen
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("exteriorUrbanEnclosed")] 
		public CName ExteriorUrbanEnclosed
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("exteriorBadlandsOpen")] 
		public CName ExteriorBadlandsOpen
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("exteriorBadlandsCanyon")] 
		public CName ExteriorBadlandsCanyon
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioWeaponTailSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

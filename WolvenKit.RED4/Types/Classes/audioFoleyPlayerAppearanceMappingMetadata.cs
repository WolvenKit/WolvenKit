using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioFoleyPlayerAppearanceMappingMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("fallbackMetadata")] 
		public CName FallbackMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("jacketSettings")] 
		public CArray<audioAppearanceToPlayerMetadata> JacketSettings
		{
			get => GetPropertyValue<CArray<audioAppearanceToPlayerMetadata>>();
			set => SetPropertyValue<CArray<audioAppearanceToPlayerMetadata>>(value);
		}

		[Ordinal(3)] 
		[RED("topSettings")] 
		public CArray<audioAppearanceToPlayerMetadata> TopSettings
		{
			get => GetPropertyValue<CArray<audioAppearanceToPlayerMetadata>>();
			set => SetPropertyValue<CArray<audioAppearanceToPlayerMetadata>>(value);
		}

		[Ordinal(4)] 
		[RED("bottomSettings")] 
		public CArray<audioAppearanceToPlayerMetadata> BottomSettings
		{
			get => GetPropertyValue<CArray<audioAppearanceToPlayerMetadata>>();
			set => SetPropertyValue<CArray<audioAppearanceToPlayerMetadata>>(value);
		}

		[Ordinal(5)] 
		[RED("jewelrySettings")] 
		public CArray<audioAppearanceToPlayerMetadata> JewelrySettings
		{
			get => GetPropertyValue<CArray<audioAppearanceToPlayerMetadata>>();
			set => SetPropertyValue<CArray<audioAppearanceToPlayerMetadata>>(value);
		}

		public audioFoleyPlayerAppearanceMappingMetadata()
		{
			JacketSettings = new();
			TopSettings = new();
			BottomSettings = new();
			JewelrySettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

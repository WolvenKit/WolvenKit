using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkGameSettingsResource : CResource
	{
		[Ordinal(1)] 
		[RED("compositionResource")] 
		public CResourceReference<inkFullscreenCompositionResource> CompositionResource
		{
			get => GetPropertyValue<CResourceReference<inkFullscreenCompositionResource>>();
			set => SetPropertyValue<CResourceReference<inkFullscreenCompositionResource>>(value);
		}

		[Ordinal(2)] 
		[RED("permanentTextureAtlases")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlases
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>(value);
		}

		[Ordinal(3)] 
		[RED("permanentTextureAtlasesPC")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlasesPC
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>(value);
		}

		[Ordinal(4)] 
		[RED("permanentTextureAtlasesDurango")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlasesDurango
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>(value);
		}

		[Ordinal(5)] 
		[RED("permanentTextureAtlasesOrbis")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlasesOrbis
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>(value);
		}

		[Ordinal(6)] 
		[RED("permanentTextureAtlasesProspero")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlasesProspero
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>(value);
		}

		[Ordinal(7)] 
		[RED("permanentTextureAtlasesStadiaSwitch")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlasesStadiaSwitch
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>(value);
		}

		[Ordinal(8)] 
		[RED("permanentTextureAtlasesStadia")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlasesStadia
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>(value);
		}

		[Ordinal(9)] 
		[RED("permanentTextureAtlasesStadiaDurango")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlasesStadiaDurango
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>(value);
		}

		[Ordinal(10)] 
		[RED("permanentTextureAtlasesStadiaOrbis")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlasesStadiaOrbis
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<inkTextureAtlas>>>(value);
		}

		[Ordinal(11)] 
		[RED("themes")] 
		public CArray<inkStyleThemeDescriptor> Themes
		{
			get => GetPropertyValue<CArray<inkStyleThemeDescriptor>>();
			set => SetPropertyValue<CArray<inkStyleThemeDescriptor>>(value);
		}

		[Ordinal(12)] 
		[RED("layersResource")] 
		public CResourceReference<inkLayersResource> LayersResource
		{
			get => GetPropertyValue<CResourceReference<inkLayersResource>>();
			set => SetPropertyValue<CResourceReference<inkLayersResource>>(value);
		}

		[Ordinal(13)] 
		[RED("iconReferenceFallbackTextureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> IconReferenceFallbackTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(14)] 
		[RED("initLoadingScreenLogoLoopVideo")] 
		public CResourceAsyncReference<Bink> InitLoadingScreenLogoLoopVideo
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(15)] 
		[RED("npcNameplateResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> NpcNameplateResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(16)] 
		[RED("defaultShapeCollectionResource")] 
		public CResourceReference<inkShapeCollectionResource> DefaultShapeCollectionResource
		{
			get => GetPropertyValue<CResourceReference<inkShapeCollectionResource>>();
			set => SetPropertyValue<CResourceReference<inkShapeCollectionResource>>(value);
		}

		[Ordinal(17)] 
		[RED("globalTVBinkLengthDataResource")] 
		public CResourceAsyncReference<JsonResource> GlobalTVBinkLengthDataResource
		{
			get => GetPropertyValue<CResourceAsyncReference<JsonResource>>();
			set => SetPropertyValue<CResourceAsyncReference<JsonResource>>(value);
		}

		[Ordinal(18)] 
		[RED("worldMapFloorplanWidgetResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> WorldMapFloorplanWidgetResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(19)] 
		[RED("gpsAugmentedRealitySignEntity")] 
		public CResourceAsyncReference<entEntityTemplate> GpsAugmentedRealitySignEntity
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		[Ordinal(20)] 
		[RED("gpsAugmentedRealityWidgetTurnLeft")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> GpsAugmentedRealityWidgetTurnLeft
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(21)] 
		[RED("gpsAugmentedRealityWidgetTurnRight")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> GpsAugmentedRealityWidgetTurnRight
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(22)] 
		[RED("gpsAugmentedRealityWidgetTurnBack")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> GpsAugmentedRealityWidgetTurnBack
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(23)] 
		[RED("malePresetResource")] 
		public CResourceAsyncReference<CResource> MalePresetResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(24)] 
		[RED("femalePresetResource")] 
		public CResourceAsyncReference<CResource> FemalePresetResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(25)] 
		[RED("fallbackHeadCustomizationFpp")] 
		public CResourceAsyncReference<CResource> FallbackHeadCustomizationFpp
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(26)] 
		[RED("fallbackHeadCustomizationTpp")] 
		public CResourceAsyncReference<CResource> FallbackHeadCustomizationTpp
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(27)] 
		[RED("fallbackHeadCustomizationTppFaceRig")] 
		public CResourceAsyncReference<CResource> FallbackHeadCustomizationTppFaceRig
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(28)] 
		[RED("fallbackBodyCustomization")] 
		public CResourceAsyncReference<CResource> FallbackBodyCustomization
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(29)] 
		[RED("fallbackArmsCustomization")] 
		public CResourceAsyncReference<CResource> FallbackArmsCustomization
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(30)] 
		[RED("vsetSceneResource")] 
		public CResourceAsyncReference<CResource> VsetSceneResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(31)] 
		[RED("keyboardIconsAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> KeyboardIconsAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(32)] 
		[RED("steamIconsAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> SteamIconsAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(33)] 
		[RED("durangoIconsAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> DurangoIconsAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(34)] 
		[RED("orbisIconsAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> OrbisIconsAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(35)] 
		[RED("prosperoIconsAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> ProsperoIconsAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(36)] 
		[RED("nintendoSwitchIconsAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> NintendoSwitchIconsAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(37)] 
		[RED("stadiaIconsAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> StadiaIconsAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(38)] 
		[RED("stadiaDurangoIconsAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> StadiaDurangoIconsAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(39)] 
		[RED("stadiaOrbisIconsAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> StadiaOrbisIconsAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		public inkGameSettingsResource()
		{
			PermanentTextureAtlases = new();
			PermanentTextureAtlasesPC = new();
			PermanentTextureAtlasesDurango = new();
			PermanentTextureAtlasesOrbis = new();
			PermanentTextureAtlasesProspero = new();
			PermanentTextureAtlasesStadiaSwitch = new();
			PermanentTextureAtlasesStadia = new();
			PermanentTextureAtlasesStadiaDurango = new();
			PermanentTextureAtlasesStadiaOrbis = new();
			Themes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

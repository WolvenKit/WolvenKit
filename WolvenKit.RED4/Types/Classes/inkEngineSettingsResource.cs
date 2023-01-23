using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkEngineSettingsResource : CResource
	{
		[Ordinal(1)] 
		[RED("fallbackCompositionResource")] 
		public CResourceReference<inkFullscreenCompositionResource> FallbackCompositionResource
		{
			get => GetPropertyValue<CResourceReference<inkFullscreenCompositionResource>>();
			set => SetPropertyValue<CResourceReference<inkFullscreenCompositionResource>>(value);
		}

		[Ordinal(2)] 
		[RED("fallbackShapeCollectionResource")] 
		public CResourceReference<inkShapeCollectionResource> FallbackShapeCollectionResource
		{
			get => GetPropertyValue<CResourceReference<inkShapeCollectionResource>>();
			set => SetPropertyValue<CResourceReference<inkShapeCollectionResource>>(value);
		}

		[Ordinal(3)] 
		[RED("fallbackIconAtlasResource")] 
		public CResourceReference<inkTextureAtlas> FallbackIconAtlasResource
		{
			get => GetPropertyValue<CResourceReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceReference<inkTextureAtlas>>(value);
		}

		[Ordinal(4)] 
		[RED("inputKeyIconsDefinitionResource")] 
		public CResourceAsyncReference<JsonResource> InputKeyIconsDefinitionResource
		{
			get => GetPropertyValue<CResourceAsyncReference<JsonResource>>();
			set => SetPropertyValue<CResourceAsyncReference<JsonResource>>(value);
		}

		[Ordinal(5)] 
		[RED("fallbackFontFamilyPath")] 
		public CResourceReference<inkFontFamilyResource> FallbackFontFamilyPath
		{
			get => GetPropertyValue<CResourceReference<inkFontFamilyResource>>();
			set => SetPropertyValue<CResourceReference<inkFontFamilyResource>>(value);
		}

		[Ordinal(6)] 
		[RED("blackTexture")] 
		public CResourceReference<CBitmapTexture> BlackTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(7)] 
		[RED("advertMissingFormatTexture")] 
		public CResourceReference<CBitmapTexture> AdvertMissingFormatTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(8)] 
		[RED("advertWrongResourceTexture")] 
		public CResourceReference<CBitmapTexture> AdvertWrongResourceTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(9)] 
		[RED("fallbackTextureAtlas")] 
		public CResourceReference<inkTextureAtlas> FallbackTextureAtlas
		{
			get => GetPropertyValue<CResourceReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceReference<inkTextureAtlas>>(value);
		}

		[Ordinal(10)] 
		[RED("imageTilingMaterial")] 
		public CResourceReference<IMaterial> ImageTilingMaterial
		{
			get => GetPropertyValue<CResourceReference<IMaterial>>();
			set => SetPropertyValue<CResourceReference<IMaterial>>(value);
		}

		[Ordinal(11)] 
		[RED("imageNineSliceMaterial")] 
		public CResourceReference<IMaterial> ImageNineSliceMaterial
		{
			get => GetPropertyValue<CResourceReference<IMaterial>>();
			set => SetPropertyValue<CResourceReference<IMaterial>>(value);
		}

		[Ordinal(12)] 
		[RED("depthMaterial")] 
		public CResourceReference<IMaterial> DepthMaterial
		{
			get => GetPropertyValue<CResourceReference<IMaterial>>();
			set => SetPropertyValue<CResourceReference<IMaterial>>(value);
		}

		[Ordinal(13)] 
		[RED("whiteMaskAtlas")] 
		public CResourceReference<inkTextureAtlas> WhiteMaskAtlas
		{
			get => GetPropertyValue<CResourceReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceReference<inkTextureAtlas>>(value);
		}

		[Ordinal(14)] 
		[RED("defaultBinkMaterial")] 
		public CResourceReference<CMaterialTemplate> DefaultBinkMaterial
		{
			get => GetPropertyValue<CResourceReference<CMaterialTemplate>>();
			set => SetPropertyValue<CResourceReference<CMaterialTemplate>>(value);
		}

		[Ordinal(15)] 
		[RED("tooManyBinksTexture")] 
		public CResourceReference<CBitmapTexture> TooManyBinksTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(16)] 
		[RED("componentMissingTexture")] 
		public CResourceReference<CBitmapTexture> ComponentMissingTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		public inkEngineSettingsResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

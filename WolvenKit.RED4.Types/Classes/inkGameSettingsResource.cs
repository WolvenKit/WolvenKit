using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("themes")] 
		public CArray<inkStyleThemeDescriptor> Themes
		{
			get => GetPropertyValue<CArray<inkStyleThemeDescriptor>>();
			set => SetPropertyValue<CArray<inkStyleThemeDescriptor>>(value);
		}

		public inkGameSettingsResource()
		{
			PermanentTextureAtlases = new();
			PermanentTextureAtlasesPC = new();
			PermanentTextureAtlasesDurango = new();
			PermanentTextureAtlasesOrbis = new();
			Themes = new();
		}
	}
}

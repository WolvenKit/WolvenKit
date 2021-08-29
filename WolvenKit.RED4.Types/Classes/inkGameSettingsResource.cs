using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkGameSettingsResource : CResource
	{
		private CResourceReference<inkFullscreenCompositionResource> _compositionResource;
		private CArray<CResourceAsyncReference<inkTextureAtlas>> _permanentTextureAtlases;
		private CArray<CResourceAsyncReference<inkTextureAtlas>> _permanentTextureAtlasesPC;
		private CArray<CResourceAsyncReference<inkTextureAtlas>> _permanentTextureAtlasesDurango;
		private CArray<CResourceAsyncReference<inkTextureAtlas>> _permanentTextureAtlasesOrbis;
		private CArray<inkStyleThemeDescriptor> _themes;

		[Ordinal(1)] 
		[RED("compositionResource")] 
		public CResourceReference<inkFullscreenCompositionResource> CompositionResource
		{
			get => GetProperty(ref _compositionResource);
			set => SetProperty(ref _compositionResource, value);
		}

		[Ordinal(2)] 
		[RED("permanentTextureAtlases")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlases
		{
			get => GetProperty(ref _permanentTextureAtlases);
			set => SetProperty(ref _permanentTextureAtlases, value);
		}

		[Ordinal(3)] 
		[RED("permanentTextureAtlasesPC")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlasesPC
		{
			get => GetProperty(ref _permanentTextureAtlasesPC);
			set => SetProperty(ref _permanentTextureAtlasesPC, value);
		}

		[Ordinal(4)] 
		[RED("permanentTextureAtlasesDurango")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlasesDurango
		{
			get => GetProperty(ref _permanentTextureAtlasesDurango);
			set => SetProperty(ref _permanentTextureAtlasesDurango, value);
		}

		[Ordinal(5)] 
		[RED("permanentTextureAtlasesOrbis")] 
		public CArray<CResourceAsyncReference<inkTextureAtlas>> PermanentTextureAtlasesOrbis
		{
			get => GetProperty(ref _permanentTextureAtlasesOrbis);
			set => SetProperty(ref _permanentTextureAtlasesOrbis, value);
		}

		[Ordinal(6)] 
		[RED("themes")] 
		public CArray<inkStyleThemeDescriptor> Themes
		{
			get => GetProperty(ref _themes);
			set => SetProperty(ref _themes, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkFullscreenCompositionResource : CResource
	{
		[Ordinal(1)] 
		[RED("compositionPresets")] 
		public CArray<inkCompositionPreset> CompositionPresets
		{
			get => GetPropertyValue<CArray<inkCompositionPreset>>();
			set => SetPropertyValue<CArray<inkCompositionPreset>>(value);
		}

		[Ordinal(2)] 
		[RED("backgroundMenuTextureUHDRes")] 
		public CResourceAsyncReference<CBitmapTexture> BackgroundMenuTextureUHDRes
		{
			get => GetPropertyValue<CResourceAsyncReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<CBitmapTexture>>(value);
		}

		[Ordinal(3)] 
		[RED("backgroundMenuTextureFHDRes")] 
		public CResourceAsyncReference<CBitmapTexture> BackgroundMenuTextureFHDRes
		{
			get => GetPropertyValue<CResourceAsyncReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<CBitmapTexture>>(value);
		}

		[Ordinal(4)] 
		[RED("previewSettings")] 
		public CHandle<inkCompositionPreviewSettings> PreviewSettings
		{
			get => GetPropertyValue<CHandle<inkCompositionPreviewSettings>>();
			set => SetPropertyValue<CHandle<inkCompositionPreviewSettings>>(value);
		}

		public inkFullscreenCompositionResource()
		{
			CompositionPresets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

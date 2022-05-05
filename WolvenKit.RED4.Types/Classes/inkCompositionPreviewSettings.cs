using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCompositionPreviewSettings : ISerializable
	{
		[Ordinal(0)] 
		[RED("sourceState")] 
		public CName SourceState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("targetState")] 
		public CName TargetState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("previewResolution")] 
		public CEnum<inkETextureResolution> PreviewResolution
		{
			get => GetPropertyValue<CEnum<inkETextureResolution>>();
			set => SetPropertyValue<CEnum<inkETextureResolution>>(value);
		}

		[Ordinal(3)] 
		[RED("gameFrameTexture")] 
		public CResourceAsyncReference<CBitmapTexture> GameFrameTexture
		{
			get => GetPropertyValue<CResourceAsyncReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<CBitmapTexture>>(value);
		}

		[Ordinal(4)] 
		[RED("textureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(5)] 
		[RED("texturePart")] 
		public CName TexturePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkCompositionPreviewSettings()
		{
			PreviewResolution = Enums.inkETextureResolution.HD_1280_720;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

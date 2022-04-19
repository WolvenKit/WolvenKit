using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkMaskWidget : inkLeafWidget
	{
		[Ordinal(20)] 
		[RED("textureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(21)] 
		[RED("texturePart")] 
		public CName TexturePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("dynamicTextureMask")] 
		public CName DynamicTextureMask
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("dataSource")] 
		public CEnum<inkMaskDataSource> DataSource
		{
			get => GetPropertyValue<CEnum<inkMaskDataSource>>();
			set => SetPropertyValue<CEnum<inkMaskDataSource>>(value);
		}

		[Ordinal(24)] 
		[RED("invertMask")] 
		public CBool InvertMask
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("maskTransparency")] 
		public CFloat MaskTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkMaskWidget()
		{
			Opacity = 0.010000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

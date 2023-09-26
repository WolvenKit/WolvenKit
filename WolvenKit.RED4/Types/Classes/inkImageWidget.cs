using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkImageWidget : inkLeafWidget
	{
		[Ordinal(20)] 
		[RED("useExternalDynamicTexture")] 
		public CBool UseExternalDynamicTexture
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("externalDynamicTexture")] 
		public CName ExternalDynamicTexture
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("useNineSliceScale")] 
		public CBool UseNineSliceScale
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("nineSliceScale")] 
		public inkMargin NineSliceScale
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(24)] 
		[RED("mirrorType")] 
		public CEnum<inkBrushMirrorType> MirrorType
		{
			get => GetPropertyValue<CEnum<inkBrushMirrorType>>();
			set => SetPropertyValue<CEnum<inkBrushMirrorType>>(value);
		}

		[Ordinal(25)] 
		[RED("tileType")] 
		public CEnum<inkBrushTileType> TileType
		{
			get => GetPropertyValue<CEnum<inkBrushTileType>>();
			set => SetPropertyValue<CEnum<inkBrushTileType>>(value);
		}

		[Ordinal(26)] 
		[RED("horizontalTileCrop")] 
		public CFloat HorizontalTileCrop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("verticalTileCrop")] 
		public CFloat VerticalTileCrop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("textureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(29)] 
		[RED("texturePart")] 
		public CName TexturePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("contentHAlign")] 
		public CEnum<inkEHorizontalAlign> ContentHAlign
		{
			get => GetPropertyValue<CEnum<inkEHorizontalAlign>>();
			set => SetPropertyValue<CEnum<inkEHorizontalAlign>>(value);
		}

		[Ordinal(31)] 
		[RED("contentVAlign")] 
		public CEnum<inkEVerticalAlign> ContentVAlign
		{
			get => GetPropertyValue<CEnum<inkEVerticalAlign>>();
			set => SetPropertyValue<CEnum<inkEVerticalAlign>>(value);
		}

		[Ordinal(32)] 
		[RED("tileHAlign")] 
		public CEnum<inkEHorizontalAlign> TileHAlign
		{
			get => GetPropertyValue<CEnum<inkEHorizontalAlign>>();
			set => SetPropertyValue<CEnum<inkEHorizontalAlign>>(value);
		}

		[Ordinal(33)] 
		[RED("tileVAlign")] 
		public CEnum<inkEVerticalAlign> TileVAlign
		{
			get => GetPropertyValue<CEnum<inkEVerticalAlign>>();
			set => SetPropertyValue<CEnum<inkEVerticalAlign>>(value);
		}

		public inkImageWidget()
		{
			NineSliceScale = new inkMargin();
			TileHAlign = Enums.inkEHorizontalAlign.Left;
			TileVAlign = Enums.inkEVerticalAlign.Top;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

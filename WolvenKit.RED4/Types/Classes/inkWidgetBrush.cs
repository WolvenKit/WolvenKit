using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetBrush : IScriptable
	{
		[Ordinal(0)] 
		[RED("textureAtlas")] 
		public CResourceReference<inkTextureAtlas> TextureAtlas
		{
			get => GetPropertyValue<CResourceReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceReference<inkTextureAtlas>>(value);
		}

		[Ordinal(1)] 
		[RED("texturePartId")] 
		public CName TexturePartId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("tileType")] 
		public CEnum<inkBrushTileType> TileType
		{
			get => GetPropertyValue<CEnum<inkBrushTileType>>();
			set => SetPropertyValue<CEnum<inkBrushTileType>>(value);
		}

		[Ordinal(3)] 
		[RED("mirrorType")] 
		public CEnum<inkBrushMirrorType> MirrorType
		{
			get => GetPropertyValue<CEnum<inkBrushMirrorType>>();
			set => SetPropertyValue<CEnum<inkBrushMirrorType>>(value);
		}

		public inkWidgetBrush()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

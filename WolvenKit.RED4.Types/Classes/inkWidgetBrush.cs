using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetBrush : IScriptable
	{
		private CResourceReference<inkTextureAtlas> _textureAtlas;
		private CName _texturePartId;
		private CEnum<inkBrushTileType> _tileType;
		private CEnum<inkBrushMirrorType> _mirrorType;

		[Ordinal(0)] 
		[RED("textureAtlas")] 
		public CResourceReference<inkTextureAtlas> TextureAtlas
		{
			get => GetProperty(ref _textureAtlas);
			set => SetProperty(ref _textureAtlas, value);
		}

		[Ordinal(1)] 
		[RED("texturePartId")] 
		public CName TexturePartId
		{
			get => GetProperty(ref _texturePartId);
			set => SetProperty(ref _texturePartId, value);
		}

		[Ordinal(2)] 
		[RED("tileType")] 
		public CEnum<inkBrushTileType> TileType
		{
			get => GetProperty(ref _tileType);
			set => SetProperty(ref _tileType, value);
		}

		[Ordinal(3)] 
		[RED("mirrorType")] 
		public CEnum<inkBrushMirrorType> MirrorType
		{
			get => GetProperty(ref _mirrorType);
			set => SetProperty(ref _mirrorType, value);
		}
	}
}

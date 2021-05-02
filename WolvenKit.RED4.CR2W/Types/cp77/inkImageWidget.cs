using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkImageWidget : inkLeafWidget
	{
		private CBool _useNineSliceScale;
		private inkMargin _nineSliceScale;
		private CEnum<inkBrushMirrorType> _mirrorType;
		private CEnum<inkBrushTileType> _tileType;
		private raRef<inkTextureAtlas> _textureAtlas;
		private CName _texturePart;
		private CEnum<inkEHorizontalAlign> _contentHAlign;
		private CEnum<inkEVerticalAlign> _contentVAlign;
		private CEnum<inkEHorizontalAlign> _tileHAlign;
		private CEnum<inkEVerticalAlign> _tileVAlign;

		[Ordinal(20)] 
		[RED("useNineSliceScale")] 
		public CBool UseNineSliceScale
		{
			get => GetProperty(ref _useNineSliceScale);
			set => SetProperty(ref _useNineSliceScale, value);
		}

		[Ordinal(21)] 
		[RED("nineSliceScale")] 
		public inkMargin NineSliceScale
		{
			get => GetProperty(ref _nineSliceScale);
			set => SetProperty(ref _nineSliceScale, value);
		}

		[Ordinal(22)] 
		[RED("mirrorType")] 
		public CEnum<inkBrushMirrorType> MirrorType
		{
			get => GetProperty(ref _mirrorType);
			set => SetProperty(ref _mirrorType, value);
		}

		[Ordinal(23)] 
		[RED("tileType")] 
		public CEnum<inkBrushTileType> TileType
		{
			get => GetProperty(ref _tileType);
			set => SetProperty(ref _tileType, value);
		}

		[Ordinal(24)] 
		[RED("textureAtlas")] 
		public raRef<inkTextureAtlas> TextureAtlas
		{
			get => GetProperty(ref _textureAtlas);
			set => SetProperty(ref _textureAtlas, value);
		}

		[Ordinal(25)] 
		[RED("texturePart")] 
		public CName TexturePart
		{
			get => GetProperty(ref _texturePart);
			set => SetProperty(ref _texturePart, value);
		}

		[Ordinal(26)] 
		[RED("contentHAlign")] 
		public CEnum<inkEHorizontalAlign> ContentHAlign
		{
			get => GetProperty(ref _contentHAlign);
			set => SetProperty(ref _contentHAlign, value);
		}

		[Ordinal(27)] 
		[RED("contentVAlign")] 
		public CEnum<inkEVerticalAlign> ContentVAlign
		{
			get => GetProperty(ref _contentVAlign);
			set => SetProperty(ref _contentVAlign, value);
		}

		[Ordinal(28)] 
		[RED("tileHAlign")] 
		public CEnum<inkEHorizontalAlign> TileHAlign
		{
			get => GetProperty(ref _tileHAlign);
			set => SetProperty(ref _tileHAlign, value);
		}

		[Ordinal(29)] 
		[RED("tileVAlign")] 
		public CEnum<inkEVerticalAlign> TileVAlign
		{
			get => GetProperty(ref _tileVAlign);
			set => SetProperty(ref _tileVAlign, value);
		}

		public inkImageWidget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

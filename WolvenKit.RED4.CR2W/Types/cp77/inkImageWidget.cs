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
			get
			{
				if (_useNineSliceScale == null)
				{
					_useNineSliceScale = (CBool) CR2WTypeManager.Create("Bool", "useNineSliceScale", cr2w, this);
				}
				return _useNineSliceScale;
			}
			set
			{
				if (_useNineSliceScale == value)
				{
					return;
				}
				_useNineSliceScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("nineSliceScale")] 
		public inkMargin NineSliceScale
		{
			get
			{
				if (_nineSliceScale == null)
				{
					_nineSliceScale = (inkMargin) CR2WTypeManager.Create("inkMargin", "nineSliceScale", cr2w, this);
				}
				return _nineSliceScale;
			}
			set
			{
				if (_nineSliceScale == value)
				{
					return;
				}
				_nineSliceScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("mirrorType")] 
		public CEnum<inkBrushMirrorType> MirrorType
		{
			get
			{
				if (_mirrorType == null)
				{
					_mirrorType = (CEnum<inkBrushMirrorType>) CR2WTypeManager.Create("inkBrushMirrorType", "mirrorType", cr2w, this);
				}
				return _mirrorType;
			}
			set
			{
				if (_mirrorType == value)
				{
					return;
				}
				_mirrorType = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("tileType")] 
		public CEnum<inkBrushTileType> TileType
		{
			get
			{
				if (_tileType == null)
				{
					_tileType = (CEnum<inkBrushTileType>) CR2WTypeManager.Create("inkBrushTileType", "tileType", cr2w, this);
				}
				return _tileType;
			}
			set
			{
				if (_tileType == value)
				{
					return;
				}
				_tileType = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("textureAtlas")] 
		public raRef<inkTextureAtlas> TextureAtlas
		{
			get
			{
				if (_textureAtlas == null)
				{
					_textureAtlas = (raRef<inkTextureAtlas>) CR2WTypeManager.Create("raRef:inkTextureAtlas", "textureAtlas", cr2w, this);
				}
				return _textureAtlas;
			}
			set
			{
				if (_textureAtlas == value)
				{
					return;
				}
				_textureAtlas = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("texturePart")] 
		public CName TexturePart
		{
			get
			{
				if (_texturePart == null)
				{
					_texturePart = (CName) CR2WTypeManager.Create("CName", "texturePart", cr2w, this);
				}
				return _texturePart;
			}
			set
			{
				if (_texturePart == value)
				{
					return;
				}
				_texturePart = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("contentHAlign")] 
		public CEnum<inkEHorizontalAlign> ContentHAlign
		{
			get
			{
				if (_contentHAlign == null)
				{
					_contentHAlign = (CEnum<inkEHorizontalAlign>) CR2WTypeManager.Create("inkEHorizontalAlign", "contentHAlign", cr2w, this);
				}
				return _contentHAlign;
			}
			set
			{
				if (_contentHAlign == value)
				{
					return;
				}
				_contentHAlign = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("contentVAlign")] 
		public CEnum<inkEVerticalAlign> ContentVAlign
		{
			get
			{
				if (_contentVAlign == null)
				{
					_contentVAlign = (CEnum<inkEVerticalAlign>) CR2WTypeManager.Create("inkEVerticalAlign", "contentVAlign", cr2w, this);
				}
				return _contentVAlign;
			}
			set
			{
				if (_contentVAlign == value)
				{
					return;
				}
				_contentVAlign = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("tileHAlign")] 
		public CEnum<inkEHorizontalAlign> TileHAlign
		{
			get
			{
				if (_tileHAlign == null)
				{
					_tileHAlign = (CEnum<inkEHorizontalAlign>) CR2WTypeManager.Create("inkEHorizontalAlign", "tileHAlign", cr2w, this);
				}
				return _tileHAlign;
			}
			set
			{
				if (_tileHAlign == value)
				{
					return;
				}
				_tileHAlign = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("tileVAlign")] 
		public CEnum<inkEVerticalAlign> TileVAlign
		{
			get
			{
				if (_tileVAlign == null)
				{
					_tileVAlign = (CEnum<inkEVerticalAlign>) CR2WTypeManager.Create("inkEVerticalAlign", "tileVAlign", cr2w, this);
				}
				return _tileVAlign;
			}
			set
			{
				if (_tileVAlign == value)
				{
					return;
				}
				_tileVAlign = value;
				PropertySet(this);
			}
		}

		public inkImageWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

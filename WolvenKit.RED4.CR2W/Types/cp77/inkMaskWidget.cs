using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMaskWidget : inkLeafWidget
	{
		private raRef<inkTextureAtlas> _textureAtlas;
		private CName _texturePart;
		private CName _dynamicTextureMask;
		private CEnum<inkMaskDataSource> _dataSource;
		private CBool _invertMask;
		private CFloat _maskTransparency;

		[Ordinal(20)] 
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

		[Ordinal(21)] 
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

		[Ordinal(22)] 
		[RED("dynamicTextureMask")] 
		public CName DynamicTextureMask
		{
			get
			{
				if (_dynamicTextureMask == null)
				{
					_dynamicTextureMask = (CName) CR2WTypeManager.Create("CName", "dynamicTextureMask", cr2w, this);
				}
				return _dynamicTextureMask;
			}
			set
			{
				if (_dynamicTextureMask == value)
				{
					return;
				}
				_dynamicTextureMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("dataSource")] 
		public CEnum<inkMaskDataSource> DataSource
		{
			get
			{
				if (_dataSource == null)
				{
					_dataSource = (CEnum<inkMaskDataSource>) CR2WTypeManager.Create("inkMaskDataSource", "dataSource", cr2w, this);
				}
				return _dataSource;
			}
			set
			{
				if (_dataSource == value)
				{
					return;
				}
				_dataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("invertMask")] 
		public CBool InvertMask
		{
			get
			{
				if (_invertMask == null)
				{
					_invertMask = (CBool) CR2WTypeManager.Create("Bool", "invertMask", cr2w, this);
				}
				return _invertMask;
			}
			set
			{
				if (_invertMask == value)
				{
					return;
				}
				_invertMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("maskTransparency")] 
		public CFloat MaskTransparency
		{
			get
			{
				if (_maskTransparency == null)
				{
					_maskTransparency = (CFloat) CR2WTypeManager.Create("Float", "maskTransparency", cr2w, this);
				}
				return _maskTransparency;
			}
			set
			{
				if (_maskTransparency == value)
				{
					return;
				}
				_maskTransparency = value;
				PropertySet(this);
			}
		}

		public inkMaskWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

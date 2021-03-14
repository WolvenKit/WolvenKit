using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkQuadShapeWidget : inkBaseShapeWidget
	{
		private raRef<inkTextureAtlas> _textureAtlas;
		private CName _texturePart;
		private CArray<Vector2> _vertexList;

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
		[RED("vertexList")] 
		public CArray<Vector2> VertexList
		{
			get
			{
				if (_vertexList == null)
				{
					_vertexList = (CArray<Vector2>) CR2WTypeManager.Create("array:Vector2", "vertexList", cr2w, this);
				}
				return _vertexList;
			}
			set
			{
				if (_vertexList == value)
				{
					return;
				}
				_vertexList = value;
				PropertySet(this);
			}
		}

		public inkQuadShapeWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

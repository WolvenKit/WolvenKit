using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPlatformSpecificImageController : inkWidgetLogicController
	{
		private raRef<inkTextureAtlas> _textureAtlas;
		private raRef<inkTextureAtlas> _textureAtlas_PS4;
		private raRef<inkTextureAtlas> _textureAtlas_XB1;
		private CName _partName;
		private CName _partName_PS4;
		private CName _partName_XB1;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("textureAtlas_PS4")] 
		public raRef<inkTextureAtlas> TextureAtlas_PS4
		{
			get
			{
				if (_textureAtlas_PS4 == null)
				{
					_textureAtlas_PS4 = (raRef<inkTextureAtlas>) CR2WTypeManager.Create("raRef:inkTextureAtlas", "textureAtlas_PS4", cr2w, this);
				}
				return _textureAtlas_PS4;
			}
			set
			{
				if (_textureAtlas_PS4 == value)
				{
					return;
				}
				_textureAtlas_PS4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("textureAtlas_XB1")] 
		public raRef<inkTextureAtlas> TextureAtlas_XB1
		{
			get
			{
				if (_textureAtlas_XB1 == null)
				{
					_textureAtlas_XB1 = (raRef<inkTextureAtlas>) CR2WTypeManager.Create("raRef:inkTextureAtlas", "textureAtlas_XB1", cr2w, this);
				}
				return _textureAtlas_XB1;
			}
			set
			{
				if (_textureAtlas_XB1 == value)
				{
					return;
				}
				_textureAtlas_XB1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("partName")] 
		public CName PartName
		{
			get
			{
				if (_partName == null)
				{
					_partName = (CName) CR2WTypeManager.Create("CName", "partName", cr2w, this);
				}
				return _partName;
			}
			set
			{
				if (_partName == value)
				{
					return;
				}
				_partName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("partName_PS4")] 
		public CName PartName_PS4
		{
			get
			{
				if (_partName_PS4 == null)
				{
					_partName_PS4 = (CName) CR2WTypeManager.Create("CName", "partName_PS4", cr2w, this);
				}
				return _partName_PS4;
			}
			set
			{
				if (_partName_PS4 == value)
				{
					return;
				}
				_partName_PS4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("partName_XB1")] 
		public CName PartName_XB1
		{
			get
			{
				if (_partName_XB1 == null)
				{
					_partName_XB1 = (CName) CR2WTypeManager.Create("CName", "partName_XB1", cr2w, this);
				}
				return _partName_XB1;
			}
			set
			{
				if (_partName_XB1 == value)
				{
					return;
				}
				_partName_XB1 = value;
				PropertySet(this);
			}
		}

		public inkPlatformSpecificImageController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

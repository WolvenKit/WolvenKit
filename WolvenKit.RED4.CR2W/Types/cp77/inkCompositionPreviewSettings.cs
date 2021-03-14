using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCompositionPreviewSettings : ISerializable
	{
		private CName _sourceState;
		private CName _targetState;
		private CEnum<inkETextureResolution> _previewResolution;
		private raRef<CBitmapTexture> _gameFrameTexture;
		private raRef<inkTextureAtlas> _textureAtlas;
		private CName _texturePart;

		[Ordinal(0)] 
		[RED("sourceState")] 
		public CName SourceState
		{
			get
			{
				if (_sourceState == null)
				{
					_sourceState = (CName) CR2WTypeManager.Create("CName", "sourceState", cr2w, this);
				}
				return _sourceState;
			}
			set
			{
				if (_sourceState == value)
				{
					return;
				}
				_sourceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetState")] 
		public CName TargetState
		{
			get
			{
				if (_targetState == null)
				{
					_targetState = (CName) CR2WTypeManager.Create("CName", "targetState", cr2w, this);
				}
				return _targetState;
			}
			set
			{
				if (_targetState == value)
				{
					return;
				}
				_targetState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("previewResolution")] 
		public CEnum<inkETextureResolution> PreviewResolution
		{
			get
			{
				if (_previewResolution == null)
				{
					_previewResolution = (CEnum<inkETextureResolution>) CR2WTypeManager.Create("inkETextureResolution", "previewResolution", cr2w, this);
				}
				return _previewResolution;
			}
			set
			{
				if (_previewResolution == value)
				{
					return;
				}
				_previewResolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gameFrameTexture")] 
		public raRef<CBitmapTexture> GameFrameTexture
		{
			get
			{
				if (_gameFrameTexture == null)
				{
					_gameFrameTexture = (raRef<CBitmapTexture>) CR2WTypeManager.Create("raRef:CBitmapTexture", "gameFrameTexture", cr2w, this);
				}
				return _gameFrameTexture;
			}
			set
			{
				if (_gameFrameTexture == value)
				{
					return;
				}
				_gameFrameTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		public inkCompositionPreviewSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticStickerNode : worldNode
	{
		private CArray<CString> _labels;
		private CBool _showBackground;
		private CColor _textColor;
		private CColor _backgroundColor;
		private CArray<raRef<CBitmapTexture>> _sprites;
		private CInt32 _spriteSize;
		private CBool _alignSpritesHorizontally;
		private CFloat _scale;
		private CFloat _visibilityDistance;

		[Ordinal(4)] 
		[RED("labels")] 
		public CArray<CString> Labels
		{
			get
			{
				if (_labels == null)
				{
					_labels = (CArray<CString>) CR2WTypeManager.Create("array:String", "labels", cr2w, this);
				}
				return _labels;
			}
			set
			{
				if (_labels == value)
				{
					return;
				}
				_labels = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("showBackground")] 
		public CBool ShowBackground
		{
			get
			{
				if (_showBackground == null)
				{
					_showBackground = (CBool) CR2WTypeManager.Create("Bool", "showBackground", cr2w, this);
				}
				return _showBackground;
			}
			set
			{
				if (_showBackground == value)
				{
					return;
				}
				_showBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("textColor")] 
		public CColor TextColor
		{
			get
			{
				if (_textColor == null)
				{
					_textColor = (CColor) CR2WTypeManager.Create("Color", "textColor", cr2w, this);
				}
				return _textColor;
			}
			set
			{
				if (_textColor == value)
				{
					return;
				}
				_textColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get
			{
				if (_backgroundColor == null)
				{
					_backgroundColor = (CColor) CR2WTypeManager.Create("Color", "backgroundColor", cr2w, this);
				}
				return _backgroundColor;
			}
			set
			{
				if (_backgroundColor == value)
				{
					return;
				}
				_backgroundColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("sprites")] 
		public CArray<raRef<CBitmapTexture>> Sprites
		{
			get
			{
				if (_sprites == null)
				{
					_sprites = (CArray<raRef<CBitmapTexture>>) CR2WTypeManager.Create("array:raRef:CBitmapTexture", "sprites", cr2w, this);
				}
				return _sprites;
			}
			set
			{
				if (_sprites == value)
				{
					return;
				}
				_sprites = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("spriteSize")] 
		public CInt32 SpriteSize
		{
			get
			{
				if (_spriteSize == null)
				{
					_spriteSize = (CInt32) CR2WTypeManager.Create("Int32", "spriteSize", cr2w, this);
				}
				return _spriteSize;
			}
			set
			{
				if (_spriteSize == value)
				{
					return;
				}
				_spriteSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("alignSpritesHorizontally")] 
		public CBool AlignSpritesHorizontally
		{
			get
			{
				if (_alignSpritesHorizontally == null)
				{
					_alignSpritesHorizontally = (CBool) CR2WTypeManager.Create("Bool", "alignSpritesHorizontally", cr2w, this);
				}
				return _alignSpritesHorizontally;
			}
			set
			{
				if (_alignSpritesHorizontally == value)
				{
					return;
				}
				_alignSpritesHorizontally = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CFloat) CR2WTypeManager.Create("Float", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("visibilityDistance")] 
		public CFloat VisibilityDistance
		{
			get
			{
				if (_visibilityDistance == null)
				{
					_visibilityDistance = (CFloat) CR2WTypeManager.Create("Float", "visibilityDistance", cr2w, this);
				}
				return _visibilityDistance;
			}
			set
			{
				if (_visibilityDistance == value)
				{
					return;
				}
				_visibilityDistance = value;
				PropertySet(this);
			}
		}

		public worldStaticStickerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

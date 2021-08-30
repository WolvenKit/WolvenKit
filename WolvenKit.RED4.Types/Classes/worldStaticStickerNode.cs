using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticStickerNode : worldNode
	{
		private CArray<CString> _labels;
		private CBool _showBackground;
		private CColor _textColor;
		private CColor _backgroundColor;
		private CArray<CResourceAsyncReference<CBitmapTexture>> _sprites;
		private CInt32 _spriteSize;
		private CBool _alignSpritesHorizontally;
		private CFloat _scale;
		private CFloat _visibilityDistance;

		[Ordinal(4)] 
		[RED("labels")] 
		public CArray<CString> Labels
		{
			get => GetProperty(ref _labels);
			set => SetProperty(ref _labels, value);
		}

		[Ordinal(5)] 
		[RED("showBackground")] 
		public CBool ShowBackground
		{
			get => GetProperty(ref _showBackground);
			set => SetProperty(ref _showBackground, value);
		}

		[Ordinal(6)] 
		[RED("textColor")] 
		public CColor TextColor
		{
			get => GetProperty(ref _textColor);
			set => SetProperty(ref _textColor, value);
		}

		[Ordinal(7)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get => GetProperty(ref _backgroundColor);
			set => SetProperty(ref _backgroundColor, value);
		}

		[Ordinal(8)] 
		[RED("sprites")] 
		public CArray<CResourceAsyncReference<CBitmapTexture>> Sprites
		{
			get => GetProperty(ref _sprites);
			set => SetProperty(ref _sprites, value);
		}

		[Ordinal(9)] 
		[RED("spriteSize")] 
		public CInt32 SpriteSize
		{
			get => GetProperty(ref _spriteSize);
			set => SetProperty(ref _spriteSize, value);
		}

		[Ordinal(10)] 
		[RED("alignSpritesHorizontally")] 
		public CBool AlignSpritesHorizontally
		{
			get => GetProperty(ref _alignSpritesHorizontally);
			set => SetProperty(ref _alignSpritesHorizontally, value);
		}

		[Ordinal(11)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(12)] 
		[RED("visibilityDistance")] 
		public CFloat VisibilityDistance
		{
			get => GetProperty(ref _visibilityDistance);
			set => SetProperty(ref _visibilityDistance, value);
		}

		public worldStaticStickerNode()
		{
			_showBackground = true;
			_spriteSize = 40;
			_alignSpritesHorizontally = true;
			_scale = 1.000000F;
			_visibilityDistance = 25.000000F;
		}
	}
}

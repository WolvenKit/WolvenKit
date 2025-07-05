using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticStickerNode : worldNode
	{
		[Ordinal(4)] 
		[RED("labels")] 
		public CArray<CString> Labels
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(5)] 
		[RED("showBackground")] 
		public CBool ShowBackground
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("textColor")] 
		public CColor TextColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(7)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(8)] 
		[RED("sprites")] 
		public CArray<CResourceAsyncReference<CBitmapTexture>> Sprites
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CBitmapTexture>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CBitmapTexture>>>(value);
		}

		[Ordinal(9)] 
		[RED("spriteSize")] 
		public CInt32 SpriteSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("alignSpritesHorizontally")] 
		public CBool AlignSpritesHorizontally
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("visibilityDistance")] 
		public CFloat VisibilityDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldStaticStickerNode()
		{
			Labels = new();
			ShowBackground = true;
			TextColor = new CColor();
			BackgroundColor = new CColor();
			Sprites = new();
			SpriteSize = 40;
			AlignSpritesHorizontally = true;
			Scale = 1.000000F;
			VisibilityDistance = 25.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

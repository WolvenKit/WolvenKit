using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticStickerNode : worldNode
	{
		[Ordinal(2)] 
		[RED("labels")] 
		public CArray<CString> Labels
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(3)] 
		[RED("showBackground")] 
		public CBool ShowBackground
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("textColor")] 
		public CColor TextColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(5)] 
		[RED("backgroundColor")] 
		public CColor BackgroundColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(6)] 
		[RED("sprites")] 
		public CArray<CResourceAsyncReference<CBitmapTexture>> Sprites
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CBitmapTexture>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CBitmapTexture>>>(value);
		}

		[Ordinal(7)] 
		[RED("spriteSize")] 
		public CInt32 SpriteSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("alignSpritesHorizontally")] 
		public CBool AlignSpritesHorizontally
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
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
			TextColor = new CColor { Red = 255, Green = 255, Blue = 255, Alpha = 255 };
			BackgroundColor = new CColor { Alpha = 100 };
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

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class textTextBlockStyle : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tintColor")] 
		public HDRColor TintColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(1)] 
		[RED("shadowOffset")] 
		public Vector2 ShadowOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(2)] 
		[RED("shadowColor")] 
		public HDRColor ShadowColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(3)] 
		[RED("fontStyle")] 
		public textTextBlockFontStyle FontStyle
		{
			get => GetPropertyValue<textTextBlockFontStyle>();
			set => SetPropertyValue<textTextBlockFontStyle>(value);
		}

		[Ordinal(4)] 
		[RED("fontSize")] 
		public CUInt16 FontSize
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public textTextBlockStyle()
		{
			TintColor = new() { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Alpha = 1.000000F };
			ShadowOffset = new();
			ShadowColor = new() { Alpha = 1.000000F };
			FontStyle = new() { OutlineColor = new() { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Alpha = 1.000000F } };
			FontSize = 22;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

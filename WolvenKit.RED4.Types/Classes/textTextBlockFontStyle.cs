using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class textTextBlockFontStyle : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("fontStyle")] 
		public CName FontStyle
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("outlineSize")] 
		public CInt32 OutlineSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("outlineColor")] 
		public HDRColor OutlineColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		public textTextBlockFontStyle()
		{
			OutlineColor = new() { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Alpha = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

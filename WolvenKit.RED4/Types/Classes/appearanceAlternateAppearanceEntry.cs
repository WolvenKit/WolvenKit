using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class appearanceAlternateAppearanceEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Original")] 
		public CName Original
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("Alternate")] 
		public CName Alternate
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("AlternateAppearanceIndex")] 
		public CUInt8 AlternateAppearanceIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public appearanceAlternateAppearanceEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
